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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      /// <summary>
      /// Parses an integer literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseIntegerLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid integer, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.Integer, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Integer, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a decimal literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseDecimalLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid decimal, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.Decimal, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Decimal, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a datetime literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseDatetimeLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid datetime, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.DateTime, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.DateTime, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a date literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseDateLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid date, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.Date, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Date, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a time literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseTimeLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid time, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.Time, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Time, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a boolean literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseBooleanLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected true or false, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.Boolean, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Boolean, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a string literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseStringLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid string, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, LiteralType.String, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.String, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses an identifier literal expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="value">The expected value of the token.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseIdentifierLiteral(TokenStream<AlToken> tokens, string value, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected identifier with value '{value}', instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, TokenType.Identifier, value, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Identifier, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses an identifier expression from the stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseIdentifierLiteral(TokenStream<AlToken> tokens, AlParserContext context)
      {
         var token = tokens.Current;
         var message = $"Expected valid identifier, instead encountered: {token.Value}";
         var tokenValidates = ValidateToken(token, context, TokenType.Identifier, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Identifier, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a symbol from the stream that matches a specified value.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="value">The expected symbol value.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseSymbol(TokenStream<AlToken> tokens, string value, AlParserContext context)
      {
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedSymbol, $"'{value}'", token.Value);
         var tokenValidates = ValidateToken(token, context, TokenType.Symbol, value, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Symbol, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }

      /// <summary>
      /// Parses a symbol from the stream that matches one of the specified values.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="values">The enumeration of allowed values.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseSymbol(TokenStream<AlToken> tokens, IEnumerable<string> values, AlParserContext context)
      {
         var token = tokens.Current;
         var enumerable = values as string[] ?? values.ToArray();
         // ReSharper disable once ExceptionNotDocumented
         string setText = string.Join(", ", enumerable.Select(i => $"'{i}'"));
         var message = string.Format(Resources.ExpectedSymbol, setText, token.Value);
         var tokenValidates = ValidateToken(token, context, TokenType.Symbol, enumerable, message);
         if (tokenValidates)
         {
            var expression = new TerminalNode(AlSyntaxNodeType.Symbol, token);
            if (context.CurrentRule != null)
               context.CurrentRule.AddChildNode(expression);
            else
               context.CurrentRule = expression;
         }

         return tokenValidates;
      }
   }
}