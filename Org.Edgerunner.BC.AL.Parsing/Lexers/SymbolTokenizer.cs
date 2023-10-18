#region MIT License

// <copyright company = "Edgerunner.org" file = "SymbolTokenizer.cs">
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

using Org.Edgerunner.BC.AL.Parsing.Tokens;
using Org.Edgerunner.Buffers;

// ReSharper disable FlagArgument

namespace Org.Edgerunner.BC.AL.Parsing.Lexers
{
   public static class SymbolTokenizer
   {
      /// <summary>
      /// Builds a symbol token from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read.</param>
      /// <param name="text">The current token text.</param>
      /// <param name="start">The starting <see cref="BufferPoint"/>.</param>
      /// <param name="includeNextChar">if set to <c>true</c> advance and include the next character in the buffer.</param>
      /// <returns>A new <see cref="SymbolToken"/> instance.</returns>
      /// <remarks>Advances the buffer to the next character after the token.</remarks>
      private static SymbolToken BuildSymbolTokenFromBuffer(ITextBuffer buffer,
                                                            string text,
                                                            BufferPoint start,
                                                            bool includeNextChar)
      {
         if (includeNextChar) text += buffer.GetNextChar();
         buffer.GetNextChar();
         return new SymbolToken(text, start, buffer.GetBufferPoint(-1));
      }

      /// <summary>
      /// Reads a SymbolToken from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="SymbolToken"/>.</returns>
      public static AlToken? ReadSymbolTokenFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var start = buffer.GetBufferPoint();
         var text = buffer.Current.ToString();
         switch (buffer.Current)
         {
            case '+':
            case '-':
            case '*':
            case '\\':
            case '>':
            case ':':
               return BuildSymbolTokenFromBuffer(buffer, text, start, buffer.PeekChar() == '=');
            case '<':
               return BuildSymbolTokenFromBuffer(buffer, text, start, buffer.PeekChar() is '>' or '=');
            default:
               buffer.GetNextChar();
               return new SymbolToken(text, start, buffer.GetBufferPoint(-1));
         }
      }
   }
}