#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParser.Code.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Expressions;
using Org.Edgerunner.BC.AL.Language.Parsers.Expressions.Code;
using Org.Edgerunner.BC.AL.Language.Parsers.Expressions.Common;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.BC.AL.Objects.Code;
using Org.Edgerunner.Language.Lexers;
using System.Drawing;
using System.Security.Authentication.ExtendedProtection;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      /// <summary>
      /// Parses an AL length declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      public bool ParseLengthDeclaration(TokenStream<AlToken> tokens, ref AlParserContext context)
      {
         var token = tokens.Current;
         var currentExpression = context.Expression;
         var expression = new LengthExpression(tokens, token);
         var message = string.Format(Resources.ExpectedOpenSqBracket, token.Value);
         if (!TokenValidates(token, context, TokenType.Symbol, "[", message))
            context.State = 1;
         else
            tokens.NextToken();

         if (!ParseIntegerExpression(tokens, ref context))
            context.State = 1;
         else
            tokens.NextToken();

         message = string.Format(Resources.ExpectedCloseSqBracket, token.Value);
         if (!TokenValidates(token, context, TokenType.Symbol, "]", message))
            context.State = 1;
         else
            tokens.NextToken();

         if (context.State == 1)
         {
            if (context.Expression != null)
            {
               context.Expression.Parent = currentExpression;
               currentExpression!.Children.Add(context.Expression);
            }
            else
            {
               var error = new ErrorExpression()
            }
         }

         var parsed = context.State != 1;
         context.State = 0;
         if (!parsed && context.Expression != null)
         {

         }

         return parsed;
      }

      public AlParserExpression? ParseVariableType(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;

         if (token.TokenType != (int)TokenType.Identifier || Enum.TryParse(typeof(VariableType), token.Value, true, out var varType))
         {
            GenerateParserError(token, token, $"Expected a valid AL data type, but instead encountered: {token.Value}");
            return null;
         }

         var start = tokens.Current;
         VariableTypeExpression result = null;
         
         switch (varType)
         {
            case VariableType.Code:
            case VariableType.Text:
            {
               // TODO: Fix the logic for refactored code
               //var length = ParseLengthDeclaration(tokens);
               //result = new VariableTypeExpression(tokens, start, tokens.Current);
               //result.Children.Add(length);
               break;
            }
            default:
               return null;
         }

         return result;
      }
   }
}