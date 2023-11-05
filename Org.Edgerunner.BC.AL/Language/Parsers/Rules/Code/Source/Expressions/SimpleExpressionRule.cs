#region MIT License
// <copyright company = "Edgerunner.org" file = "SimpleExpressionRule.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;
using System.Linq.Expressions;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Source.Expressions
{
   public class SimpleExpressionRule : ExpressionRule, IParsable
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="SimpleExpressionRule"/> class.
      /// </summary>
      public SimpleExpressionRule() : base(AlSyntaxNodeType.SimpleExpression, "Simple Expression Rule") {}
      public override bool Parse(TokenStream<AlToken> tokens, AlParser context)
      {
         Enter(context);
         var token = tokens.Current;

         switch ((TokenType)token.TokenType)
         {
            case TokenType.Identifier:
               return new IdentifierRule(token).Parse(tokens, context, this);
            case TokenType.Literal:
            {
               var literal = token as LiteralToken;
               switch (literal!.LiteralType)
               {
                  case LiteralType.Boolean:
                     return new BooleanLiteralRule(token).Parse(tokens, context, this);
                  case LiteralType.DateTime:
                     return new DatetimeLiteralRule(token).Parse(tokens, context, this);
                  case LiteralType.Date:
                     return new DateLiteralRule(token).Parse(tokens, context, this);
                  case LiteralType.Time:
                     return new TimeLiteralRule(token).Parse(tokens, context, this);
                  case LiteralType.Decimal:
                     return new DecimalLiteralRule(token).Parse(tokens, context, this);
                  case LiteralType.Integer:
                     return new IntegerLiteralRule(token).Parse(tokens, context, this);
                  case LiteralType.String:
                     return new StringLiteralRule(token).Parse(tokens, context, this);
                  default:
                     var errorMessage = $"Invalid expression, encountered unexpected symbol: \"{token.Value}\"";
                     context.GenerateParserError(token, token, errorMessage);
                     AddChildNode(new ErrorNode(errorMessage, token));
                     return false;
               }
            }
            default:
               return false;
         }
      }
   }
}