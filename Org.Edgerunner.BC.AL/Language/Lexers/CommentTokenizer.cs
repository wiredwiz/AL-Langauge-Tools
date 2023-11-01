#region MIT License
// <copyright company = "Edgerunner.org" file = "CommentTokenizer.cs">
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
using Org.Edgerunner.Pooling;

namespace Org.Edgerunner.BC.AL.Language.Lexers
{
   /// <summary>
   /// Class containing methods for tokenizing comments.
   /// </summary>
   public static class CommentTokenizer
   {
      /// <summary>
      /// Reads a single line CommentToken from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <param name="lexer">The AL lexer.</param>
      /// <returns>A new <see cref="CommentToken" />.</returns>
      public static AlToken? ReadSingleLineCommentTokenFromBuffer(ITextBuffer buffer, AlLexer lexer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();

         buffer.GetNextChar();
         text.Append(buffer.Current);
         if (buffer.Current != '/')
            return LexerError.PackageError(lexer, text.ToString(), start, buffer.GetBufferPoint(),
                                           "Invalid single line comment start");

         do
         {
            text.Append(buffer.Current);
         } while (buffer.GetNextChar() is not '\n' and not '\r' and not '\0');

         return new CommentToken(text.ToString(), start, buffer.GetBufferPoint(-1));
      }

      /// <summary>
      /// Reads a multi-line CommentToken from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <param name="lexer">The AL lexer.</param>
      /// <returns>A new <see cref="CommentToken" />.</returns>
      public static AlToken? ReadMultiLineCommentTokenFromBuffer(ITextBuffer buffer, AlLexer lexer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();

         text.Append(buffer.Current);
         if (buffer.GetNextChar() != '*')
            return LexerError.PackageError(lexer, text.ToString(), start, buffer.GetBufferPoint(),
                                           "Invalid multi-line comment start");

         text.Append(buffer.Current);
         while (true)
         {
            if (buffer.GetNextChar() == '*')
            {
               text.Append(buffer.Current);
               if (buffer.GetNextChar() == '/')
               {
                  text.Append(buffer.Current);
                  var result = new CommentToken(text.ToString(), start, buffer.GetBufferPoint());
                  buffer.GetNextChar();

                  return result;
               }

               text.Append(buffer.Current);
            }
            else
               text.Append(buffer.Current);

            if (buffer.Current == '\0')
               break;
         }

         return LexerError.PackageError(lexer, text.ToString(), start, buffer.GetBufferPoint(),
                                        "Multi-line comment not terminated correctly");
      }

      /// <summary>
      /// Reads a XmlCommentToken from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="CommentToken"/>.</returns>
      public static AlToken? ReadXmlCommentTokenFromBuffer(ITextBuffer buffer, AlLexer lexer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();

         text.Append(buffer.Current);
         if (buffer.GetNextChar() != '/' || buffer.PeekChar() != '/')
            return LexerError.PackageError(lexer, text.ToString(), start, buffer.GetBufferPoint(),
                                           "Invalid xml comment start");

         do
         {
            text.Append(buffer.Current);
         } while (buffer.GetNextChar() is not '\n' and not '\r' and not '\0');

         return new XmlCommentToken(text.ToString(), start, buffer.GetBufferPoint(-1));
      }
   }
}