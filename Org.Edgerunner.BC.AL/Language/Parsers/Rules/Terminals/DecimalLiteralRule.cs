﻿#region MIT License
// <copyright company = "Edgerunner.org" file = "DecimalLiteralRule.cs">
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
   /// <summary>
   /// Class that represents an decimal literal parser rule.
   /// Implements the <see cref="Terminals.AlTerminalNode" />
   /// </summary>
   /// <seealso cref="Terminals.AlTerminalNode" />
   public class DecimalLiteralRule : AlTerminalNode
   {
      public DecimalLiteralRule(AlToken symbol) : base(AlSyntaxNodeType.Decimal, symbol, "Decimal Literal") {}

      public override bool Parse(TokenStream<AlToken> tokens, IParser<AlToken, AlSyntaxNodeType> context, ParserRule<AlToken, AlSyntaxNodeType> parentRule)
      {
         Enter(context);
         var token = tokens.Current;
         var message = string.Format(Resources.ExpectedDecimal, token.Value);
         var tokenValidates = Validator.ValidateToken(token, context, parentRule, LiteralType.Decimal, message);
         if (tokenValidates)
         {
            context.GenerateTraceEvent(token, TraceEvent.Consume);
            parentRule.AddChildNode(this);
            context.GenerateTraceEvent(this, TraceEvent.Match);
         }

         return Exit(context, tokenValidates);
      }
   }
}