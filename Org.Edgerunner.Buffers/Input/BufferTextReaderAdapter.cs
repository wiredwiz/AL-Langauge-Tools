#region MIT License

// <copyright company="Edgerunner.org" file="BufferTextReaderAdapter.cs">
// Copyright (c) Thaddeus Ryker 2016
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

namespace Org.Edgerunner.Buffers.Input
{
    using System.IO;

    /// <summary>
   ///    TODO: Describe this class here.
   /// </summary>
   public class BufferTextReaderAdapter : TextReader
   {
      private readonly TextBuffer _Buffer;

      #region Constructors And Finalizers

      /// <summary>
      /// Initializes a new instance of the <see cref="BufferTextReaderAdapter" /> class.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      public BufferTextReaderAdapter(TextBuffer buffer)
      {
         _Buffer = buffer;
      }

      #endregion

      /// <summary>
      /// Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      /// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the reader does not support seeking.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public override int Peek()
      {
         var value = -1;
         if (!_Buffer.AtEndOfBuffer())
         {
            value = _Buffer.GetNextChar();
            _Buffer.GetPreviousChar();
         }

         return value;
      }

      /// <summary>
      /// Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      /// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
      /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
      /// <param name="count">The maximum number of characters to read. If the end of the reader is reached before the specified number of characters is read into the buffer, the method returns.</param>
      /// <returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether the data is available within the reader. This method returns 0 (zero) if it is called when no more characters are left to read.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public override int Read(char[] buffer, int index, int count)
      {
         var value = 0;
         for (var i = 0; i < count; i++)
         {
            if (_Buffer.AtEndOfBuffer())
               break;
            buffer[index + i] = _Buffer.GetNextChar();
            value++;
         }

         return value;
      }

      /// <summary>
      /// Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      /// <returns>The next character from the text reader, or -1 if no more characters are available. The default implementation returns -1.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public override int Read()
      {
         var value = -1;
         if (!_Buffer.AtEndOfBuffer())
            value = _Buffer.GetNextChar();
         return value;
      }

      /// <summary>
      /// Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      /// <param name="buffer">When this method returns, this parameter contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> -1) replaced by the characters read from the current source.</param>
      /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
      /// <param name="count">The maximum number of characters to read.</param>
      /// <returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether all input characters have been read.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public override int ReadBlock(char[] buffer, int index, int count)
      {
         var value = 0;
         for (var i = 0; i < count; i++)
         {
            if (_Buffer.AtEndOfBuffer())
               break;
            buffer[index + i] = _Buffer.GetNextChar();
            value++;
         }

         return value;
      }

      /// <summary>
      /// Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      /// <returns>The next line from the reader, or <see langword="null" /> if all characters have been read.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public override string ReadLine()
      {
         var value = new StringBuilder();
         var currentLine = _Buffer.LineNumber;
         while (_Buffer.LineNumber == currentLine)
            value.Append(_Buffer.GetNextChar());

         return value.ToString();
      }

      /// <summary>
      /// Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      /// <returns>A string that contains all characters from the current position to the end of the text reader.</returns>
      /// <exception cref="BufferException">Unable to access current line number in buffer for some reason or buffer is missing end of file marker.</exception>
      public override string ReadToEnd()
      {
         var value = new StringBuilder();
         while (!_Buffer.AtEndOfBuffer())
            value.Append(_Buffer.GetNextChar());

         return value.ToString();
      }
   }
}