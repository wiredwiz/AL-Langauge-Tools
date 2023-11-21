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
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      public delegate bool ParserHandler(TokenStream<AlToken> tokens, AlParserRule rule);

      /// <summary>
      /// Parses an integer literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Integer)]
      public AlParserRule ParseIntegerLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedInteger, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.Integer, message);
         AlParserRule result = tokenValidates ? new IntegerLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Integer);

         return result;
      }

      /// <summary>
      /// Parses a decimal literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Decimal)]
      public AlParserRule ParseDecimalLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDecimal, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.Decimal, message);
         AlParserRule result = tokenValidates ? new DecimalLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Decimal);

         return result;
      }

      /// <summary>
      /// Parses a datetime literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.DateTime)]
      public AlParserRule ParseDatetimeLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDatetime, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.DateTime, message);
         AlParserRule result = tokenValidates ? new DatetimeLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.DateTime);

         return result;
      }

      /// <summary>
      /// Parses a date literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Date)]
      public AlParserRule ParseDateLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDate, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.Date, message);
         AlParserRule result = tokenValidates ? new DateLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Date);

         return result;
      }

      /// <summary>
      /// Parses a time literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Time)]
      public AlParserRule ParseTimeLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedTime, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.Time, message);
         AlParserRule result = tokenValidates ? new TimeLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Time);

         return result;
      }

      /// <summary>
      /// Parses a boolean literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Boolean)]
      public AlParserRule ParseBooleanLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedBoolean, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.Boolean, message);
         AlParserRule result = tokenValidates ? new BooleanLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Boolean);

         return result;
      }

      /// <summary>
      /// Parses a string literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.String)]
      public AlParserRule ParseStringLiteral(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedString, token.Value);
         var tokenValidates = ValidateToken(token, LiteralType.String, message);
         AlParserRule result = tokenValidates ? new StringLiteralRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.String);

         return result;
      }

      /// <summary>
      /// Parses an identifier expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Identifier)]
      public AlParserRule ParseIdentifier(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedIdentifier, token.Value);
         var tokenValidates = ValidateToken(token, TokenType.Identifier, message);
         AlParserRule result = tokenValidates ? new IdentifierRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Identifier);

         return result;
      }

      /// <summary>
      /// Parses an identifier expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="expectedValue">The expected identifier value.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Identifier)]
      public AlParserRule ParseIdentifier(TokenStream<AlToken> tokens, string expectedValue)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedSpecificIdentifier, expectedValue, token.Value);
         var tokenValidates = ValidateToken(token, TokenType.Identifier, expectedValue, message);
         AlParserRule result = tokenValidates ? new IdentifierRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Identifier);

         return result;
      }

      /// <summary>
      /// Parses a symbol from the stream that matches a specified value.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="value">The expected symbol value.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Symbol)]
      public AlParserRule ParseSymbol(TokenStream<AlToken> tokens, string value)
      {
         var token = tokens.Current;
         Enter(token, AlSyntaxNodeType.Symbol);
         var message = string.Format(Resources.ExpectedSymbol, value, token.Value);
         var tokenValidates = ValidateToken(token, TokenType.Symbol, value, message);
         AlParserRule result = tokenValidates ? new SymbolRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Symbol);

         return result;
      }

      /// <summary>
      /// Parses a symbol from the stream that matches one of the specified values.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="values">The enumeration of allowed values.</param>
      /// <returns>A new <see cref="AlParserRule"/> instance.</returns>
      [ParserRule(AlSyntaxNodeType.Symbol)]
      public AlParserRule ParseSymbol(TokenStream<AlToken> tokens, IEnumerable<string> values)
      {
         var token = tokens.Current;
         var enumerable = values as string[] ?? values.ToArray();
         var message = FormatSetError(Resources.ExpectedSymbolFromSet, enumerable, token.Value);
         var tokenValidates = ValidateToken(token, TokenType.Symbol, enumerable, message);
         AlParserRule result = tokenValidates ? new SymbolRule(token) : new ErrorNode(message, token);
         if (tokenValidates) Consume(token, AlSyntaxNodeType.Symbol);

         return result;
      }

      /// <summary>
      /// Parses a repeating expression with a symbol delimiter.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="delimiter">The delimiter symbol.</param>
      /// <param name="terminator">The terminator symbol.</param>
      /// <param name="handler">The parser handler delegate.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      /// <exception cref="Exception">A delegate callback throws an exception.</exception>
      // ReSharper disable once TooManyArguments
      public bool ParseRepeatingDelimitedExpression(TokenStream<AlToken> tokens, AlParserRule parentRule, string delimiter, string terminator, ParserHandler handler)
      {
         var token = tokens.Current;
         bool success = true;

         if (token.TokenType == (int)TokenType.Symbol && terminator == token.Value)
            return true;

         while (token!.TokenType != (int)TokenType.Symbol || terminator != token.Value)
         {
            // Look for delimiter token
            var message = string.Format(Resources.ExpectedSymbol, delimiter, token.Value);
            var parses = ValidateToken(token, TokenType.Symbol, delimiter, message);
            success = success && parses;
            AlParserRule node = parses
               ? new SymbolRule(token)
               : new ErrorNode(message, token);
            parentRule.AddChildNode(node);
            if (parses && !tokens.TryMoveNext(ref token)) return false;

            // Now parse the expression
            parses = handler(tokens, parentRule);
            success = success && parses;
            if (parses && !tokens.TryMoveNext(ref token)) return false;

            // If both parsing attempts failed, we move ahead one to prevent infinite looping
            if (!success && !tokens.TryMoveNext(ref token)) return false;
         }

         return success;
      }
   }
}