#region MIT License
// <copyright company = "Edgerunner.org" file = "LiteralTokenizer.cs">
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
using Org.Edgerunner.BC.AL.Parsing.Pooling;

namespace Org.Edgerunner.BC.AL.Parsing.Lexers
{
   public static class LiteralTokenizer
   {
            /// <summary>
      /// Reads a StringToken from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="LiteralToken"/> or <see cref="ErrorToken"/>.</returns>
      public static AlToken? ReadStringLiteralTokenFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();
         BufferPoint end;

         text.Append(buffer.Current);
         while (true)
         {
            // fetch the next character and then make sure we aren't at the end of buffer.
            var tk = buffer.GetNextChar();
            if (buffer.AtEndOfBuffer())
            {
               // we have reached end of buffer, thus our string is invalid, we return an error token instead
               return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(-1), "String reached end of file without termination");
            }

            // check for invalid line breaks in the string
            if (tk == '\n' || tk == '\r')
            {
               return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(-1), "Strings cannot contain line breaks or carriage returns");
            }

            // append the currently read token and check for string termination character
            text.Append(tk);
            if (tk == '\'')
            {
               // check to make sure if the termination character is actually being escaped and if not, break out of our loop since we have reached the end of the string
               if (buffer.PeekChar() != '\'')
               {
                  end = buffer.GetBufferPoint();
                  break;
               }

               text.Append(buffer.GetNextChar());
            }
         }

         buffer.GetNextChar();
         return new LiteralToken(text.ToString(), start, end, LiteralType.String);
      }

      /// <summary>
      /// Reads a SymbolToken from a buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="SymbolToken"/>.</returns>
      public static AlToken? ReadNumberLiteralTokenFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var hasDecimal = false;
         var start = buffer.GetBufferPoint();

         // read the integral portion
         text.Append(ReadIntegerFromBuffer(buffer));

         // check for decimal
         if (buffer.Current == '.')
         {
            text.Append(buffer.Current);
            hasDecimal = true;
            // read the fractional number if it exists
            if (buffer.GetNextChar().IsNumber())
               text.Append(ReadIntegerFromBuffer(buffer));
            else
               return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(-1), "Decimal fraction is missing");
         }
         
         return new LiteralToken(text.ToString(), start, buffer.GetBufferPoint(-1), hasDecimal ? LiteralType.Decimal : LiteralType.Integer);
      }

      /// <summary>
      /// Reads an integer from buffer.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <returns>a <see cref="string"/> containing an integer number.</returns>
      private static string ReadIntegerFromBuffer(ITextBuffer buffer)
      {
         var text = StringBuilderPool.Current.Get();
         text.Append(buffer.Current);
         while (buffer.GetNextChar().IsNumber()) text.Append(buffer.Current);

         return text.ToString();
      }

      /// <summary>
      /// Reads the date literal from buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="LiteralToken"/> or <see cref="ErrorToken"/>.</returns>
      public static AlToken? ReadDateLiteralFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();

         // read the integral portion of the date
         text.Append(ReadIntegerFromBuffer(buffer));

         // check for date qualifier
         if (!(buffer.PeekChar() is 'D' or 'd'))
            return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(), "Invalid date literal");

         text.Append(buffer.GetNextChar());
         var result = new LiteralToken(text.ToString(), start, buffer.GetBufferPoint(), LiteralType.Date);
         buffer.GetNextChar();
         return result;
      }

      /// <summary>
      /// Reads the date time literal from buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="LiteralToken"/> or <see cref="ErrorToken"/>.</returns>
      public static AlToken? ReadTimeLiteralFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();

         // read the integral portion of the date
         text.Append(ReadIntegerFromBuffer(buffer));

         // check for date qualifier
         if (!(buffer.PeekChar() is 'T' or 't'))
            return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(), "Invalid time literal");
         text.Append(buffer.GetNextChar());

         var result = new LiteralToken(text.ToString(), start, buffer.GetBufferPoint(), LiteralType.Time);
         buffer.GetNextChar();
         return result;
      }

      /// <summary>
      /// Reads the datetime literal from buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="LiteralToken"/> or <see cref="ErrorToken"/>.</returns>
      public static AlToken? ReadDateTimeLiteralFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();

         // read the integral portion of the date
         text.Append(ReadIntegerFromBuffer(buffer));

         // check for datetime qualifier
         if (!(buffer.PeekChar() is 'D' or 'd'))
            return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(), "Invalid datetime literal");
         text.Append(buffer.GetNextChar());
         if (!(buffer.PeekChar() is 'T' or 't'))
            return new ErrorToken(text.ToString(), start, buffer.GetBufferPoint(), "Invalid datetime literal");
         text.Append(buffer.GetNextChar());

         var result = new LiteralToken(text.ToString(), start, buffer.GetBufferPoint(), LiteralType.DateTime);
         buffer.GetNextChar();
         return result;
      }

      /// <summary>
      /// Reads the boolean literal from buffer.
      /// </summary>
      /// <param name="buffer">The buffer to read from.</param>
      /// <returns>A new <see cref="LiteralToken"/> or <see cref="ErrorToken"/>.</returns>
      public static AlToken? ReadBooleanLiteralFromBuffer(ITextBuffer buffer)
      {
         // no valid token so we return a null
         if (buffer.AtEndOfBuffer()) return null;

         // begin our token reading process
         var text = StringBuilderPool.Current.Get();
         var start = buffer.GetBufferPoint();
         string booleanLiteral;

         if (buffer.Current.ToUpper() is 'T')
            booleanLiteral = "TRUE";
         else if (buffer.Current.ToUpper() is 'F')
            booleanLiteral = "FALSE";
         else
            return null;

         foreach (var letter in booleanLiteral)
         {
            if (letter != buffer.Current.ToUpper())
               return null;

            text.Append(buffer.Current);
            buffer.GetNextChar();
         }

         return new LiteralToken(text.ToString(), start, buffer.GetBufferPoint(-1), LiteralType.Boolean);
      }
   }
}