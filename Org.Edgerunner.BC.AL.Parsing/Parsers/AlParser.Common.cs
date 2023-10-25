#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParser.Common.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Expressions;
using Org.Edgerunner.BC.AL.Language.Parsers.Expressions.Common;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      /// <summary>
      /// Parses an integer expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseIntegerExpression(TokenStream<AlToken> tokens, ref AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid integer, instead encountered: {token.Value}";
         var tokenValidates = TokenValidates(token, context, LiteralType.Integer, message);
         if (!tokenValidates)
         {
            context.Expression = context.State == 0
               ? new ErrorExpression(tokens, message, token)
               : null;
         }
         else
            context.Expression = new IntegerExpression(tokens, token);

         return tokenValidates;
      }

      /// <summary>
      /// Parses a string expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseStringExpression(TokenStream<AlToken> tokens, ref AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid string, instead encountered: {token.Value}";
         var tokenValidates = TokenValidates(token, context, LiteralType.String, message);
         tokens.NextToken();

         context.Expression = tokenValidates ? new StringExpression(tokens, token) : new ErrorExpression(tokens, message, token);
         return tokenValidates;
      }

      /// <summary>
      /// Parses a string expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="value">The expected value of the token.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseIdentifierExpression(TokenStream<AlToken> tokens, string value, ref AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected identifier with value '{value}', instead encountered: {token.Value}";
         var tokenValidates = TokenValidates(token, context, TokenType.Identifier, value, message);
         tokens.NextToken();

         context.Expression = tokenValidates ? new IdentifierExpression(tokens, token) : new ErrorExpression(tokens, message, token);
         return tokenValidates;
      }

      /// <summary>
      /// Parses a string expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseIdentifierExpression(TokenStream<AlToken> tokens, ref AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid identifier, instead encountered: {token.Value}";
         var tokenValidates = TokenValidates(token, context, TokenType.Identifier, message);
         tokens.NextToken();

         context.Expression = tokenValidates ? new IdentifierExpression(tokens, token) : new ErrorExpression(tokens, message, token);
         return tokenValidates;
      }
   }
}