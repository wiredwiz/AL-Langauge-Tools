#region MIT License

// <copyright company = "Edgerunner.org" file = "ICharacterBuffer.cs">
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

namespace Org.Edgerunner.Buffers
{
   /// <summary>
   ///    Interface that defines a character buffer.
   /// </summary>
   public interface ICharacterBuffer
   {
      /// <summary>
      ///    Gets the character at the current position in the buffer.
      /// </summary>
      char Current { get; }

      /// <summary>
      /// Gets a value indicating whether this <see cref="ICharacterBuffer"/> is empty.
      /// </summary>
      /// <value><c>true</c> if empty; otherwise, <c>false</c>.</value>
      bool IsEmpty { get; }

      /// <summary>
      ///    Determines whether the current position is at the beginning of the buffer.
      /// </summary>
      /// <returns>
      ///    <c>true</c> if the current position is at the beginning of the buffer; <c>false</c> otherwise.
      /// </returns>
      bool AtBeginningOfBuffer();

      /// <summary>
      ///    Determines whether the current position is at the end of the buffer.
      /// </summary>
      /// <returns>
      ///    <c>true</c> if the current position is at the end of the buffer; <c>false</c> otherwise.
      /// </returns>
      bool AtEndOfBuffer();

      /// <summary>
      ///    Advances the buffer position ahead by one and returns the character at that position.
      /// </summary>
      /// <returns>
      ///    Character at the next buffer position.
      /// </returns>
      char GetNextChar();

      /// <summary>
      ///    Advances the buffer position behind by one and returns the character at that position.
      /// </summary>
      /// <returns>
      ///    Character at the previous buffer position.
      /// </returns>
      /// <exception cref="BufferException">Buffer underflow.</exception>
      char GetPreviousChar();

      /// <summary>
      ///    Advances the buffer position to the beginning of the buffer and returns the character at that position.
      /// </summary>
      /// <returns>
      ///    Character at the first position in the buffer.
      /// </returns>
      /// <exception cref="BufferException">Buffer is empty.</exception>
      char MoveToBeginningOfBuffer();

      /// <summary>
      ///    Advances the buffer position to the end of the buffer and returns the character at that position.
      /// </summary>
      /// <returns>
      ///    Character at the last position in the buffer.
      /// </returns>
      /// <exception cref="BufferException">Buffer is empty.</exception>
      char MoveToEndOfBuffer();
   }
}