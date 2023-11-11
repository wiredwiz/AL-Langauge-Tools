﻿#region MIT License
// <copyright company = "Edgerunner.org" file = "SymbolRule.cs">
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

using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals
{
   public class SymbolRule : AlTerminalNode, IParsableExpectingValue, IParsableInSet
   {
      public SymbolRule(AlToken symbol) : base(AlSyntaxNodeType.Symbol, symbol, "Symbol Rule") {}

      /// <summary>
      /// Parses a symbol from the token stream and expects to match the specified value.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="expectedValue">The expected identifier value to match against.</param>
      /// <returns><c>true</c> if parsing was successful, <c>false</c> otherwise.</returns>
      public virtual bool Parse(TokenStream<AlToken> tokens, AlParser context, string expectedValue)
      {
         try
         {
            Enter(context);
            var token = tokens.Current;
            var message = string.Format(Resources.ExpectedSpecificSymbol, expectedValue, token.Value);
            var tokenValidates = Validator.ValidateToken(token, context, this, TokenType.Symbol, expectedValue, message);
            if (tokenValidates)
            {
               context.GenerateTraceEvent(token, TraceEvent.Consume);
               context.GenerateTraceEvent(this, TraceEvent.Match);
            }

            return tokenValidates;
         }
         finally
         {
            Exit(context);
         }
      }

      /// <summary>
      /// Parses a symbol from the stream that matches one of the specified values.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="values">The enumeration of allowed values.</param>
      /// <returns><c>true</c> if parsing was successful, <c>false</c> otherwise.</returns>
      /// <exception cref="OutOfMemoryException">The length of the resulting set text string overflows the maximum allowed length (<see cref="System.Int32.MaxValue">Int32.MaxValue</see>).</exception>
      // ReSharper disable once TooManyDeclarations
      public bool Parse(TokenStream<AlToken> tokens, AlParser context, IEnumerable<string> values)
      {
         try
         {
            Enter(context);
            var token = tokens.Current;
            var enumerable = values as string[] ?? values.ToArray();
            // ReSharper disable once ExceptionNotDocumented
            var message = FormatSetError(Resources.ExpectedSymbolFromSet, values, token.Value);
            var tokenValidates = Validator.ValidateToken(token, context, this, TokenType.Symbol, enumerable, message);
            if (tokenValidates)
            {
               context.GenerateTraceEvent(token, TraceEvent.Consume);
               context.GenerateTraceEvent(this, TraceEvent.Match);
            }

            return tokenValidates;
         }
         finally
         {
            Exit(context);
         }
      }

      /// <summary>
      /// Gets a value indicating whether this rule represents an operator.
      /// </summary>
      /// <value><c>true</c> if this instance represents operator; otherwise, <c>false</c>.</value>
      public bool IsOperator
      {
         get => ((SymbolToken)Token).IsOperator;
      }

      /// <summary>
      /// Gets a value indicating whether this instance represents an assignment operator.
      /// </summary>
      /// <value><c>true</c> if this instance represents an assignment operator; otherwise, <c>false</c>.</value>
      public bool IsAssignmentOperator
      {
         get => ((SymbolToken)Token).IsAssignmentOperator;
      }

      public override bool Parse(TokenStream<AlToken> tokens, AlParser context)
      {
         try
         {
            Enter(context);
            var token = tokens.Current;
            var message = string.Format(Resources.ExpectedSymbol, token.Value);
            var tokenValidates = Validator.ValidateToken(token, context, this, TokenType.Symbol, message);
            if (tokenValidates)
            {
               context.GenerateTraceEvent(token, TraceEvent.Consume);
               context.GenerateTraceEvent(this, TraceEvent.Match);
            }

            return tokenValidates;
         }
         finally
         {
            Exit(context);
         }
      }
   }
}