#region MIT License
// <copyright company = "Edgerunner.org" file = "ILexer.cs">
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

using Org.Edgerunner.Buffers;

namespace Org.Edgerunner.Language.Lexers
{
   /// <summary>
   /// Interface representing a language lexer.
   /// </summary>
   public interface ILexer<T>
   where T : IToken
   {
      /// <summary>
      /// Gets the current token map.
      /// </summary>
      /// <returns>An array of <see cref="int"/>.</returns>
      int[] GetTokenMap();

      /// <summary>
      /// Reads a token from the current position in a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read.</param>
      /// <returns>A new <see cref="T"/> or null if at end of buffer.</returns>
      T? ReadTokenFromBuffer(ITextBuffer buffer);

      /// <summary>
      /// Reads all tokens from the current position in a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read.</param>
      /// <returns>A <see cref="List{T}"/> containing the tokens.</returns>
      List<T> ReadTokensFromBuffer(ITextBuffer buffer);

      /// <summary>
      /// Adds a listener to be notified of lexer errors.
      /// </summary>
      /// <param name="listener">The listener.</param>
      void AddErrorListener(IErrorListener<T> listener);

      /// <summary>
      /// Removes all error listeners.
      /// </summary>
      void ClearErrorListeners();

      /// <summary>
      /// Removes the error listener.
      /// </summary>
      /// <param name="listener">The listener.</param>
      void RemoveErrorListener(IErrorListener<T> listener);
   }
}