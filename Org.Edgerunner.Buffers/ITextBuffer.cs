#region MIT License

// <copyright company = "Edgerunner.org" file = "ITextBuffer.cs">
// Copyright(c)  2023
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
   /// Interface that defines a buffer of text lines.
   /// Extends the <see cref="Org.Edgerunner.Buffers.ICharacterBuffer" />.
   /// Extends the <see cref="Org.Edgerunner.Buffers.IPositionable" />.
   /// Extends the <see cref="Org.Edgerunner.Buffers.IPointAccessible" />.
   /// </summary>
   /// <seealso cref="Org.Edgerunner.Buffers.ICharacterBuffer" />
   /// <seealso cref="Org.Edgerunner.Buffers.IPositionable" />
   /// <seealso cref="Org.Edgerunner.Buffers.IPointAccessible" />
   public interface ITextBuffer : ICharacterBuffer, IPositionable, IPointAccessible
   {
      /// <summary>
      /// Gets the total text line count in the buffer.
      /// </summary>
      /// <value>The total text lines.</value>
      int TotalLines { get; }

      /// <summary>
      /// Gets the line of text for the specified line number.
      /// </summary>
      /// <param name="lineNumber">The line number.</param>
      /// <returns>A <see cref="string"/> containing the text line.</returns>
      string GetLine(int lineNumber);
      
      /// <summary>
      ///    Moves the character position to the first position for the current line.
      /// </summary>
      public void MoveToBeginningOfLine();

      /// <summary>
      ///    Moves the character position to the last position for the current line.
      /// </summary>
      public void MoveToEndOfLine();
   }
}