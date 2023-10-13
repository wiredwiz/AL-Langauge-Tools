#region MIT License

// <copyright company = "Edgerunner.org" file = "TextBuffer.cs">
// Copyright(c) Thaddeus Ryker 2023
// </copyright>
// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#endregion

using System.Text;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace Org.Edgerunner.Buffers.Input
{
   /// <summary>
   /// Class representing a text buffer.
   /// </summary>
   /// <seealso cref="Org.Edgerunner.Buffers.ITextBuffer" />
   /// <seealso cref="Org.Edgerunner.Buffers.IPositionable" />
   /// <seealso cref="Org.Edgerunner.Buffers.IPointAccessible" />
   public class TextBuffer : ITextBuffer, IPositionable, IPointAccessible
   {
      private Dictionary<int, string> _Lines;
      private Dictionary<int, int> _AbsoluteIndexCounter;
      private int _LineNumber;
      private int _MaxLineNo;
      private int _CharacterPosition;
      private long _AbsolutePosition;

      /// <summary>
      ///    Constant character value that defines the end of file for the buffer.
      /// </summary>
      public const char EndOfFile = '\0';

      /// <summary>
      ///    Constant defining the message for "Buffer Is Empty" errors.
      /// </summary>
      protected const string BufferIsEmptyError = "Buffer is empty";

      /// <summary>
      ///    Constant defining the message for "Buffer Underflow" errors.
      /// </summary>
      protected const string BufferUnderflowError = "Buffer underflow";

      #region Constructors And Finalizers

      /// <summary>
      /// Initializes a new instance of the <see cref="TextBuffer"/> class.
      /// </summary>
      /// <param name="text">A string of text to read into the buffer.</param>
      /// <exception cref="ArgumentNullException">The <paramref name="text" /> parameter is <see langword="null" />.</exception>
      /// <exception cref="IOException">An I/O error has occurred while reading from the string.</exception>
      public TextBuffer(string text)
      {
         var source = new StringReader(text);
         Initialize(source);
         source.Dispose();
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="TextBuffer"/> class.
      /// </summary>
      /// <param name="filePath">string containing the path to the file used to read the text into the buffer.</param>
      /// <param name="codePage">The encoding codepage to use.</param>
      /// <exception cref="FileNotFoundException">The file cannot be found.</exception>
      /// <exception cref="DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
      /// <exception cref="ArgumentException"><paramref name="filePath" /> is an empty string ("").</exception>
      /// <exception cref="NotSupportedException"><paramref name="filePath" /> includes an incorrect or invalid syntax for file name, directory name, or volume label.</exception>
      /// <exception cref="ArgumentNullException"><paramref name="filePath" /> is <see langword="null" /> or <paramref name="codePage" /> is invalid.</exception>
      /// <exception cref="IOException">An I/O error has occurred while reading from the file specified by <paramref name="filePath"/>.</exception>
      public TextBuffer(string filePath, int codePage)
      {
         var source = new StreamReader(filePath, Encoding.GetEncoding(codePage));
         Initialize(source);
         source.Close();
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="TextBuffer" /> class.
      ///    Initializes new instance of TextBuffer class with a buffer source of 'source'.
      /// </summary>
      /// <param name="source">
      ///    <para>
      ///       TextReader instance used to read the text into the buffer.
      ///    </para>
      /// </param>
      /// <exception cref="IOException">An I/O error has occurred while reading from the <see cref="TextReader"/> instance.</exception>
      /// <exception cref="ObjectDisposedException">The <see cref="TextReader"/> instance has been disposed of.</exception>
      public TextBuffer(TextReader source)
      {
         Initialize(source);
      }

      #endregion

      /// <summary>
      /// Gets the character at the current position in the buffer.
      /// </summary>
      /// <value>The current.</value>
      public char Current
      {
         get => _Lines[_LineNumber][_CharacterPosition - 1];
      }

      /// <summary>
      /// Gets a value indicating whether this <see cref="ITextBuffer" /> is empty.
      /// </summary>
      /// <value><c>true</c> if empty; otherwise, <c>false</c>.</value>
      public bool IsEmpty => _MaxLineNo == 1 && _Lines[1].Length == 1;

      /// <summary>
      /// Determines whether the current position is at the beginning of the buffer.
      /// </summary>
      /// <returns><c>true</c> if the current position is at the beginning of the buffer; <c>false</c> otherwise.</returns>
      public bool AtBeginningOfBuffer()
      {
         return _LineNumber == 1 && _CharacterPosition == 1;
      }

      /// <summary>
      /// Determines whether the current position is at the end of the buffer.
      /// </summary>
      /// <returns><c>true</c> if the current position is at the end of the buffer; <c>false</c> otherwise.</returns>
      public bool AtEndOfBuffer()
      {
         return _LineNumber == _MaxLineNo && _CharacterPosition == _Lines[_MaxLineNo].Length;
      }

      /// <summary>
      /// Advances the buffer position ahead by one and returns the character at that position.
      /// </summary>
      /// <returns>Character at the next buffer position.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public char GetNextChar()
      {
         if (!_Lines.TryGetValue(_LineNumber, out var currentLine))
            throw new BufferException("Unable to access current line number in buffer for some reason");

         if (_CharacterPosition == currentLine.Length && currentLine[_CharacterPosition - 1] == EndOfFile)
            return EndOfFile;

         if (_CharacterPosition == currentLine.Length && _LineNumber == _MaxLineNo)
            throw new BufferException("Buffer missing end of file marker");

         if (_CharacterPosition == currentLine.Length)
         {
            _LineNumber++;
            _CharacterPosition = 1;
            _AbsolutePosition++;
            return _Lines[_LineNumber][0];
         }

         _CharacterPosition++;
         _AbsolutePosition++;
         return currentLine[_CharacterPosition - 1];
      }

      /// <summary>
      /// Advances the buffer position behind by one and returns the character at that position.
      /// </summary>
      /// <returns>Character at the previous buffer position.</returns>
      /// <exception cref="KeyNotFoundException">Text line is missing from the internal buffer.</exception>
      /// <exception cref="IndexOutOfRangeException">Unable to access a character position in the buffer.</exception>
      public char GetPreviousChar()
      {
         var currentLine = _Lines[_LineNumber];

         if (_LineNumber == 1 && _CharacterPosition == 1)
            return currentLine[1];

         if (_CharacterPosition == 1)
         {
            _LineNumber--;
            _AbsolutePosition--;
            var previousLine = _Lines[_LineNumber];
            _CharacterPosition = previousLine.Length;
            return previousLine[^1];
         }

         _CharacterPosition--;
         _AbsolutePosition--;
         return currentLine[_CharacterPosition - 1];
      }

      /// <summary>
      /// Advances the buffer position to the beginning of the buffer and returns the character at that position.
      /// </summary>
      /// <returns>Character at the first position in the buffer.</returns>
      /// <exception cref="KeyNotFoundException">A line within the buffer cannot be accessed.</exception>
      public char MoveToBeginning()
      {
         _AbsolutePosition = 1;
         _LineNumber = 1;
         _CharacterPosition = 1;
         return _Lines[1][0];
      }

      /// <summary>
      /// Advances the buffer position to the end of the buffer and returns the character at that position.
      /// </summary>
      /// <returns>Character at the last position in the buffer.</returns>
      /// <exception cref="KeyNotFoundException">A line within the buffer cannot be accessed.</exception>
      public char MoveToEnd()
      {
         var lastLine = _Lines[_MaxLineNo];
         _AbsolutePosition = _AbsoluteIndexCounter[_MaxLineNo];
         _LineNumber = _MaxLineNo;
         _CharacterPosition = lastLine.Length;
         return lastLine[^1];
      }

      /// <summary>
      /// Moves the character position to the first position for the current line.
      /// </summary>
      public void MoveToBeginningOfLine()
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// Moves the character position to the last position for the current line.
      /// </summary>
      public void MoveToEndOfLine()
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// Gets or sets the absolute character position within the buffer.
      /// </summary>
      /// <value>The absolute position.</value>
      /// <exception cref="ArgumentOutOfRangeException" accessor="set">The value is outside the valid range for the buffer.</exception>
      /// <exception cref="BufferException" accessor="set">Buffer is empty.</exception>
      public long AbsolutePosition
      {
         get => _AbsolutePosition;
         set
         {
            if (_MaxLineNo == 0)
               throw new BufferException("Buffer is empty");

            var line = 0;
            int length;
            do
            {
               line++;

               if (!_AbsoluteIndexCounter.TryGetValue(line, out length))
                  throw new ArgumentOutOfRangeException(nameof(value), "Absolute position is outside the valid range for the buffer");
            }
            while (value < length);

            if (value != length)
               line--;

            var offset = line > 1 ? _AbsoluteIndexCounter[line - 1] : 0;
            _LineNumber = line;
            _CharacterPosition = (int)(value - offset);

            _AbsolutePosition = value;
         }
      }

      /// <summary>
      /// Gets or sets the number of the current line.
      /// </summary>
      /// <value>The line number.</value>
      /// <exception cref="ArgumentOutOfRangeException" accessor="set">Line number is outside of the buffer line number range.</exception>
      public int LineNumber
      {
         get => _LineNumber;
         set
         {
            if (value < 1)
               throw new ArgumentOutOfRangeException(nameof(value), "Non-positive line numbers are invalid");
            if (value > _Lines.Count)
               throw new ArgumentOutOfRangeException(nameof(value), "Line number exceeds the range within the buffer");

            var offset = value > 1 ? _AbsoluteIndexCounter[value - 1] : 0;
            _AbsolutePosition = offset + _CharacterPosition;
            _LineNumber = value;
         }
      }

      /// <summary>
      /// Gets or sets the current character position on the current line.
      /// </summary>
      /// <value>The position.</value>
      /// <exception cref="ArgumentOutOfRangeException" accessor="set">Character position is outside the valid range.</exception>
      public int CharacterPosition
      {
         get => _CharacterPosition;
         set
         {
            if (value < 1)
               throw new ArgumentOutOfRangeException(nameof(value), "Non-positive character positions are invalid");
            if (value > _Lines[_LineNumber].Length)
               throw new ArgumentOutOfRangeException(nameof(value), "Character position exceeds the length of the current line");

            var offset = _LineNumber > 1 ? _AbsoluteIndexCounter[_LineNumber - 1] : 0;
            _AbsolutePosition = offset + value;
            _CharacterPosition = value;
         }
      }

      /// <summary>
      /// Gets a new BufferPoint instance that defines the current buffer position.
      /// </summary>
      /// <returns>A <see cref="BufferPoint" /> that defines the current buffer position.</returns>
      public BufferPoint GetBufferPoint()
      {
         return new BufferPoint(_LineNumber, _CharacterPosition);
      }

      /// <summary>
      /// Sets the buffer to a new position defined by point.
      /// </summary>
      /// <param name="point">A <see cref="BufferPoint" /> that defines the new buffer position.</param>
      public void SetBufferPoint(BufferPoint point)
      {
         _LineNumber = point.LineNumber;
         CharacterPosition = point.CharacterPosition;
      }

      /// <summary>
      /// Initializes this instance.
      /// </summary>
      /// <exception cref="ObjectDisposedException">The <see cref="TextReader"/> instance has been disposed of.</exception>
      /// <exception cref="IOException">An I/O error has occurred while reading from the <see cref="TextReader"/> instance.</exception>
      private void Initialize(TextReader source)
      {
         _Lines = new Dictionary<int, string>();
         _AbsoluteIndexCounter = new Dictionary<int, int>();
         LoadFromReader(source);
      }

      /// <summary>
      /// Loads from reader.
      /// </summary>
      /// <param name="source">The source.</param>
      /// <exception cref="ObjectDisposedException">The <see cref="TextReader"/> instance has been disposed of.</exception>
      /// <exception cref="IOException">An I/O error has occurred while reading from the <see cref="TextReader"/> instance.</exception>
      private void LoadFromReader(TextReader source)
      {
         int character;
         var line = 0;
         var text = new StringBuilder();
         var absolute = 0;

         while ((character = source.Read()) != -1)
         {
            text.Append(character);
            if (character != '\n')
               continue;

            _Lines.Add(++line, text.ToString());
            absolute += text.Length;
            _AbsoluteIndexCounter.Add(line, absolute);
            text.Clear();
         }

         text.Append(EndOfFile);
         _Lines.Add(++line, text.ToString());
         absolute += text.Length;
         _AbsoluteIndexCounter.Add(line, absolute);

         _MaxLineNo = line;
         _AbsolutePosition = 1;
         _LineNumber = 1;
         _CharacterPosition = 1;
      }
   }
}