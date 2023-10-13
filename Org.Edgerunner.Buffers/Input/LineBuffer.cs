#region MIT License

//  <copyright company = "Edgerunner.org" file = "LineBuffer.cs">
//  Copyright(c) Thaddeus Ryker 2023
//  </copyright>
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.

#endregion

using System.Text;

namespace Org.Edgerunner.Buffers.Input
{
   /// <summary>
   ///    A character buffer that stores a specific number of lines in a back buffer for backwards reads.
   /// </summary>
   public abstract class LineBuffer : CharacterBuffer
   {
      private readonly int _BackBufferLineLength = 4;
      private Dictionary<int, char[]> _CapBuffer;
      private BufferPoint _CapEnd;
      private BufferPoint _CapStart;
      private bool _Capture;
      private long _DequeuedSize;
      private int _LineIndex;
      private List<char[]> _Lines;
      private int _LinesDeQueued;

            #region Constructors And Finalizers

      /// <summary>
      ///    Initializes a new instance of the <see cref="LineBuffer" /> class.
      ///    Initializes new instance of LineBuffer class with an empty buffer.
      /// </summary>
      public LineBuffer()
      {
         Initialize();
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="LineBuffer" /> class.
      ///    Initializes new instance of LineBuffer class with a buffer containing 'text'.
      /// </summary>
      /// <param name="text">
      ///    <para>
      ///       String to use in the newly initialized buffer.
      ///    </para>
      /// </param>
      public LineBuffer(string text)
      {
         Load(text);
         Initialize();
         QueueLine(text);
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="LineBuffer" /> class.
      ///    Initializes new instance of LineBuffer class with a buffer containing 'text'.
      /// </summary>
      /// <param name="text">
      ///    <para>
      ///       Character array to use in the newly initialized buffer.
      ///    </para>
      /// </param>
      public LineBuffer(char[] text)
      {
         Load(text);
         Initialize();
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="LineBuffer" /> class.
      ///    Initializes new instance of LineBuffer class with a buffer containing 'text'.
      /// </summary>
      /// <param name="text">
      ///    <para>
      ///       Character array to use in the newly initialized buffer.
      ///    </para>
      /// </param>
      /// <param name="backBufferLineLength">
      ///    <para>
      ///       Number of lines to maintain in the back buffer.
      ///    </para>
      /// </param>
      public LineBuffer(char[] text, int backBufferLineLength)
      {
         _BackBufferLineLength = backBufferLineLength;
         Initialize();
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="LineBuffer" /> class.
      ///    Initializes new instance of LineBuffer class with a buffer containing 'text'.
      /// </summary>
      /// <param name="text">
      ///    <para>
      ///       String to use in the newly initialized buffer.
      ///    </para>
      /// </param>
      /// <param name="backBufferLineLength">
      ///    <para>
      ///       Number of lines to maintain in the back buffer.
      ///    </para>
      /// </param>
      public LineBuffer(string text, int backBufferLineLength)
      {
         _BackBufferLineLength = backBufferLineLength;
         Initialize();
      }

      #endregion

      /// <summary>
      ///    TODO: Describe this property here.
      /// </summary>
      public new long AbsolutePosition
      {
         get
         {
            long l_intBackBufferSize = 0;
            if (_LineIndex > 0)
               for (var i = 0; i < _LineIndex; i++)
                  l_intBackBufferSize += _Lines[i].Length;
            return l_intBackBufferSize + _DequeuedSize + base.AbsolutePosition;
         }
      }

      /// <summary>
      ///    Current line number inside the buffer source.
      /// </summary>
      public int LineNumber => _LineIndex + _LinesDeQueued + 1;

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override void BeginCapture()
      {
         _Capture = true;
         _CapBuffer.Add(LineNumber, _Lines[_LineIndex]);
         _CapStart = new BufferPoint(LineNumber, Position);
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override bool BeginningOfBuffer()
      {
         bool value;
         value = base.BeginningOfBuffer();
         return value && _LineIndex + _LinesDeQueued == 0;
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override string EndCapture()
      {
         var captured = new StringBuilder(500000);
         var currentLine = new StringBuilder();
         var start = 0;
         var length = 0;
         _CapEnd = new BufferPoint(LineNumber, Position);
         _Capture = false;
         if (_CapStart.LineNumber == _CapEnd.LineNumber)
         {
            currentLine.Append(_CapBuffer[_CapStart.LineNumber]);
            start = _CapStart.CharacterPosition - 1;
            length = _CapEnd.CharacterPosition - start - 1;
            // currentLine = currentLine.Substring(start, length);
            // captured = currentLine;
            captured.Append(currentLine.ToString(start, length));
         }
         else
         {
            for (var lineCounter = _CapStart.LineNumber; lineCounter <= _CapEnd.LineNumber - 1; lineCounter++)
            {
               currentLine.Remove(0, currentLine.Length);
               currentLine.Append(_CapBuffer[lineCounter]);
               start = lineCounter == _CapStart.LineNumber ? _CapStart.CharacterPosition - 1 : 0;
               length = lineCounter == _CapEnd.LineNumber
                  ? _CapEnd.CharacterPosition - start - 1
                  : currentLine.Length - start;
               currentLine.ToString(start, length);
               // currentLine = currentLine.Substring(start, length);
               captured.AppendLine(currentLine.ToString(start, length));
               // captured += currentLine + "\r\n";
            }

            currentLine.Remove(0, currentLine.Length);
            currentLine.Append(_CapBuffer[_CapEnd.LineNumber]);
            length = _CapEnd.CharacterPosition;
            // currentLine = currentLine.Substring(0, length);
            captured.Append(currentLine.ToString(0, length));
            // captured += currentLine;
         }

         _CapStart = null;
         _CapEnd = null;
         _CapBuffer.Clear();
         return captured.ToString();
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override bool EndOfBuffer()
      {
         bool value;
         value = base.EndOfBuffer();
         return value && _LineIndex >= _Lines.Count - 1;
      }

      /// <summary>
      ///    Determines whether the character position is at the end of the current buffer line.
      /// </summary>
      /// <returns>
      ///    true if the current position is at the end of the current buffer line; false otherwise.
      /// </returns>
      public bool EndOfLine()
      {
         return base.EndOfBuffer();
      }

      /// <summary>
      ///    Throws a new ParseException with a specified error message.
      /// </summary>
      /// <param name="errorMsg">
      ///    <para>
      ///       String containing the error message to display.
      ///    </para>
      /// </param>
      public virtual void Error(string errorMsg)
      {
         // ReSharper disable once ExceptionNotDocumented
         throw new ParserException(errorMsg, LineNumber, Position, AbsolutePosition);
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override BufferPoint GetBufferPoint()
      {
         var point = base.GetBufferPoint();
         point.LineNumber = _LineIndex + _LinesDeQueued + 1;
         return point;
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override char GetNextChar()
      {
         return base.EndOfBuffer() ? GetNextLine() : base.GetNextChar();
      }

      /// <summary>
      ///    Fetches the next available back buffer line into the line buffer and sets the character position to the first
      ///    position in the line.
      /// </summary>
      /// <returns>
      ///    Character in the current character position.
      /// </returns>
      /// <remarks>
      ///    The current line position is advanced by one and the character position is reset to the first position in the new
      ///    line.
      ///    If the current line position is in one of the back buffer lines then the next line is fetched.
      ///    If there are no more lines left to fetch from the back buffer then the character in the current line at the current
      ///    character position is returned.
      /// </remarks>
      public virtual char GetNextLine()
      {
         if (_LineIndex < _Lines.Count - 1)
         {
            _LineIndex++;
            if (_Capture)
               if (!_CapBuffer.ContainsKey(LineNumber))
                  _CapBuffer.Add(LineNumber, _Lines[_LineIndex]);
            LoadBufferLine(_LineIndex);
            return Current;
         }

         return base.GetNextChar();
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override char GetPreviousChar()
      {
         return base.BeginningOfBuffer() ? GetPreviousLine() : base.GetPreviousChar();
      }

      /// <summary>
      ///    Fetches the previous line from the back buffer into the line buffer and sets the character position to the last
      ///    position in that line.
      /// </summary>
      /// <returns>
      ///    Character in the current buffer position.
      /// </returns>
      /// <remarks>
      ///    The current line number is reduced by one and the character position is reset to the last position in the new line.
      /// </remarks>
      /// <exception cref="BufferException">
      ///    Current line number is in the last line in the back buffer lines.
      /// </exception>
      public virtual char GetPreviousLine()
      {
         if (_Lines.Count == 0) throw new BufferException(BufferIsEmptyError);
         if (_LineIndex > 0)
         {
            _LineIndex -= 1;
            LoadBufferLine(_LineIndex);
            return MoveToEnd();
         }

         throw new BufferException(BufferUnderflowError);
      }

      /// <summary>
      ///    Moves the character position to the first position for the current line.
      /// </summary>
      public void MoveToBOL()
      {
         MoveToBeginning();
      }

      /// <summary>
      ///    Moves the character position to the last position for the current line.
      /// </summary>
      public void MoveToEOL()
      {
         MoveToEnd();
      }

      /// <summary>
      ///    Overrides the corresponding method from the CharacterBuffer base type.
      /// </summary>
      public override void SetBufferPoint(BufferPoint point)
      {
         _LineIndex = point.LineNumber - _LinesDeQueued - 1;
         LoadBufferLine(_LineIndex);
         base.SetBufferPoint(point);
      }

      /// <summary>
      ///    Loads the line at the specified index in the back buffer into the line buffer.
      /// </summary>
      /// <param name="index" type="int">
      ///    <para>
      ///       Integer specifying the index line to load from the back buffer lines.
      ///    </para>
      /// </param>
      /// <exception cref="BufferException">
      ///    index is less than zero.
      /// </exception>
      /// <remarks>
      ///    The oldest back buffer line is located at index 0.
      /// </remarks>
      protected void LoadBufferLine(int index)
      {
         if (index < 0)
            throw new BufferException(BufferUnderflowError);
         Load(_Lines[index]);
         if (index > _BackBufferLineLength)
         {
            _DequeuedSize += _Lines[0].Length;
            _Lines.RemoveAt(0);
            _LinesDeQueued += 1;
            _LineIndex -= 1;
         }
      }

      /// <summary>
      ///    Adds a text line to the back buffer lines.
      /// </summary>
      /// <param name="line" type="string">
      ///    <para>
      ///       String of text to add to the buffer.
      ///    </para>
      /// </param>
      protected void QueueLine(string line)
      {
         QueueLine(line.ToCharArray());
      }

      /// <summary>
      ///    Adds a text line to the buffer lines.
      /// </summary>
      /// <param name="line" type="string">
      ///    <para>
      ///       Character array of text to add to the buffer.
      ///    </para>
      /// </param>
      protected void QueueLine(char[] line)
      {
         _Lines.Add(line);
      }

      private void Initialize()
      {
         _Lines = new List<char[]>(_BackBufferLineLength);
         _CapBuffer = new Dictionary<int, char[]>();
      }
   }
}