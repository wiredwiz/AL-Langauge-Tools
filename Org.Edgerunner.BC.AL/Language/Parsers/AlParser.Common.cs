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

using Org.Edgerunner.BC.AL.Language.Aspects;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      public delegate bool ParserHandler(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule rule);

      /// <summary>
      /// Parses an integer literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseIntegerLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedInteger, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.Integer, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Integer, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a decimal literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseDecimalLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDecimal, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.Decimal, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Decimal, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a datetime literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseDatetimeLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDatetime, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.DateTime, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.DateTime, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a date literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseDateLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDate, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.Date, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Date, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a time literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseTimeLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedTime, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.Time, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Time, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a boolean literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseBooleanLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedBoolean, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.Boolean, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Boolean, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a string literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseStringLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedString, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, LiteralType.String, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.String, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses an identifier expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseIdentifierLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedIdentifier, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, TokenType.Identifier, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Identifier, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses an identifier expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="expectedValue">The expected identifier value.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseIdentifierLiteral(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule, string expectedValue)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedSpecificIdentifier, expectedValue, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, TokenType.Identifier, expectedValue, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Identifier, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a symbol from the stream that matches a specified value.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="value">The expected symbol value.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseSymbol(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule, string value)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedSymbol, value, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, TokenType.Symbol, value, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Symbol, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a symbol from the stream that matches one of the specified values.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="values">The enumeration of allowed values.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [Trace]
      public bool ParseSymbol(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule, IEnumerable<string> values)
      {
         var token = tokens.Current;
         var enumerable = values as string[] ?? values.ToArray();
         // ReSharper disable once ExceptionNotDocumented
         string setText = string.Join(", ", enumerable.Select(i => $"{i}"));
         var message = string.Format(Resources.ExpectedSymbolFromSet, setText, token.Value);
         var tokenValidates = ValidateToken(token, context, parentRule, TokenType.Symbol, enumerable, message);
         if (tokenValidates) parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Symbol, token));

         return tokenValidates;
      }

      /// <summary>
      /// Parses a repeating expression with a symbol delimiter.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="delimiter">The delimiter symbol.</param>
      /// <param name="terminators">The possible terminator symbols.</param>
      /// <param name="handler">The parser handler delegate.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      // ReSharper disable once TooManyArguments
      public bool ParseRepeatingDelimitedExpression(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule, string delimiter, string[] terminators, ParserHandler handler)
      {
         var token = tokens.Current;
         bool success = true;

         if (token.TokenType == (int)TokenType.Symbol && terminators.Contains(token.Value))
            return true;

         while (token.TokenType != (int)TokenType.Symbol || !terminators.Contains(token.Value))
         {
            // Look for delimiter token
            var message = string.Format(Resources.ExpectedSymbol, delimiter, token.Value);
            var parses = ValidateToken(token, context, parentRule, TokenType.Symbol, delimiter, message);
            success = success && parses;
            if (parses)
            {
               parentRule.AddChildNode(new AlTerminalNode(AlSyntaxNodeType.Symbol, token));
               token = tokens.MoveNext();
            }

            // Now parse the expression
            parses = handler(tokens, context, parentRule);
            success = success && parses;
            if (parses) token = tokens.MoveNext();

            // If both parsing attempts failed, we move ahead one to prevent infinite looping
            if (!success) token = tokens.MoveNext();
         }

         return success;
      }
   }
}