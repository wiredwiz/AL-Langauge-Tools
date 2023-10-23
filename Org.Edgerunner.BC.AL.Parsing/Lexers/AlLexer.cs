#region MIT License

// <copyright company = "Edgerunner.org" file = "AlLexer.cs">
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

using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Buffers;
using Org.Edgerunner.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Lexers
{
   public class AlLexer : ILexer
   {
      private readonly int[] _FileObjectMap = TokenMapping.GetFileObjectMap();

      public int[] GetTokenMap()
      {
         return _FileObjectMap;
      }

      /// <inheritdoc />
      // ReSharper disable once MethodTooLong
      public IToken? ReadTokenFromBuffer(ITextBuffer buffer)
      {
         SkipWhitespace(buffer);
         if (buffer.AtEndOfBuffer()) return null;

         var start = buffer.GetBufferPoint();
         var indicator = (CharacterIndicator)_FileObjectMap[buffer.Current];
         IToken? result = null;
         switch (indicator)
         {
            case CharacterIndicator.Comment:
            {
               if (buffer.PeekChar() == '*')
                  result = CommentTokenizer.ReadMultiLineCommentTokenFromBuffer(buffer);
               if (buffer.PeekChar() == '/')
                  result = buffer.PeekChar(2) == '/'
                     ? CommentTokenizer.ReadXmlCommentTokenFromBuffer(buffer)
                     : CommentTokenizer.ReadSingleLineCommentTokenFromBuffer(buffer);

               buffer.GetNextChar();
               return result;
            }
            case CharacterIndicator.Number:
            {
               return LiteralTokenizer.ReadNumericBasedLiteralFromBuffer(buffer);
            }
            case CharacterIndicator.Symbol:
               return SymbolTokenizer.ReadSymbolTokenFromBuffer(buffer);
            case CharacterIndicator.String:
               return LiteralTokenizer.ReadStringLiteralTokenFromBuffer(buffer);
            case CharacterIndicator.Identifier:
            {
               if (buffer.Current is 'T' or 't' or 'F' or 'f')
                  result = LiteralTokenizer.ReadBooleanLiteralFromBuffer(buffer);

               return result ?? IdentifierTokenizer.ReadIdentifierTokenFromBuffer(buffer);
            }
         }

         return new ErrorToken(buffer.Current.ToString(), start, buffer.GetBufferPoint(), "Invalid token character");
      }

      /// <inheritdoc />
      public List<IToken> ReadTokensFromBuffer(ITextBuffer buffer)
      {
         var tokens = new List<IToken>();
         // loop and add tokens until we reach null/end of buffer
         while (ReadTokenFromBuffer(buffer) is {} token) tokens.Add(token);
         return tokens;
      }

      /// <summary>
      /// Skips the whitespace between the current position in the buffer and the next possible token.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      private void SkipWhitespace(ITextBuffer buffer)
      {
         if (_FileObjectMap[buffer.Current] == (int)CharacterIndicator.Whitespace)
#pragma warning disable S108
            while (_FileObjectMap[buffer.GetNextChar()] == (int)CharacterIndicator.Whitespace) {}
#pragma warning restore S108
      }
   }
}