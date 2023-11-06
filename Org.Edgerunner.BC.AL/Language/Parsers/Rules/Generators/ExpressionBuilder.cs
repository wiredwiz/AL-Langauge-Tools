#region MIT License
// <copyright company = "Edgerunner.org" file = "ExpressionBuilder.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Source.Expressions;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Generators
{
   public class ExpressionBuilder
   {
      /// <summary>
      /// Attempts to build a new expression rule and return it.
      /// </summary>
      /// <param name="tokens">The tokens.</param>
      /// <param name="context">The context.</param>
      /// <returns>A new <seealso cref="AlParserRule"/> instance if successful; otherwise null.</returns>
      public static AlParserRule? BuildRule(TokenStream<AlToken> tokens, AlParser context)
      {
         var token = tokens.Current;
         string errorMessage;

         switch ((TokenType)token.TokenType)
         {
            case TokenType.Identifier: 
            case TokenType.Literal:
               if (token is IdentifierToken { ReservedWord: true })
               {
                  errorMessage = $"Encountered unexpected reserved word: \"{token.Value}\"";
                  context.GenerateParserError(token, token, errorMessage);
                  return new ErrorNode(errorMessage, token);
               }

               AlParserRule expression = new SimpleExpressionRule();
               if (!((SimpleExpressionRule)expression).Parse(tokens, context))
                  return null;

               if (!tokens.TryMoveNext(ref token))
                  return null;

               while (!tokens.EndOfStream())
               {
                  token = tokens.Current;

                  // now that we parsed a basic expression, we see if it is more complex
                  if (token.TokenType == (int)TokenType.Symbol)
                  {
                     if (token.Value == "[")
                     {
                        // we seem to have a bracketed expression
                     }
                     else if (token.Value == ".")
                     {
                        // we seem to have a member access expression
                     }
                     else if (token.Value == "(")
                     {
                        // we seem to have a method invocation expression
                     }
                     else if (token.Value == "::")
                     {
                        // we seem to have a scope expression
                     }
                     else if (token.IsAssignmentOperator)
                     {
                        // we seem to be in an assignment statement, bail out with the expression we have built
                        return expression;
                     }
                     else if (token.IsBinaryOperator)
                     {
                        // we seem to have a binary expression
                     }
                     else if (token.IsComparisonOperator)
                     {
                        // we seem to have a comparison expression
                     }
                  }
               }

               break;
            case TokenType.Symbol:
               {
                  if (token.Value != "[")
                  {
                     errorMessage = "Invalid expression, unexpected symbol";
                     context.GenerateParserError(token, token, errorMessage);
                     return new ErrorNode(errorMessage, token);
                  }

                  // parse a set expression

                  break;
               }
            case TokenType.XmlComment:
               errorMessage = "Encountered XmlComment inside code";
               context.GenerateParserError(token, token, errorMessage);
               var result = new ErrorNode(errorMessage, token);
               if (!tokens.TryMoveNext(ref token))
                  return null;
               return result;
            case TokenType.Comment:
            case TokenType.Whitespace:
               if (!tokens.TryMoveNext(ref token))
                  return null;
               break;
            case TokenType.Error:
               errorMessage = "Encountered unexpected mangled token";
               context.GenerateParserError(token, token, errorMessage);
               result = new ErrorNode(errorMessage, token);
               if (!tokens.TryMoveNext(ref token))
                  return null;
               return result;
         }

         return null;
      }
   }
}