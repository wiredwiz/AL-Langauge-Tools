#region MIT License
// <copyright company = "Edgerunner.org" file = "ExpressionGenerator.cs">
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

using Org.Edgerunner.BC.AL.Language.Extensions;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Source.Expressions;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Generators
{
   public class ExpressionGenerator : IRuleGenerator
   {
      public bool Parses(TokenStream<AlToken> tokens, AlParser context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var parsed = true;
         string errorMessage;

         while (!tokens.EndOfStream() && token.TokenType != (int)TokenType.Symbol && token.Value != ";")
         {
            switch ((TokenType)token.TokenType)
            {
               case TokenType.Identifier:
               case TokenType.Literal:
                  var newRule = new SimpleExpressionRule();
                  parsed = newRule.Parse(tokens, context, parentRule);
                  if (!parsed || !tokens.TryMoveNext(ref token))
                     return false;

                  // now that we parsed a basic expression, we see if it is more complex
                  if (token.TokenType == (int)TokenType.Symbol)
                  {
                     if (token.Value == "[") {
                        // we seem to have a bracketed expression
                     }
                     else if (token.Value == ".")
                     {
                        // we seem to have a member access expression
                     }
                  }
                  break;
               case TokenType.Symbol:
               {
                  errorMessage = "Invalid expression, unexpected symbol";
                  context.GenerateParserError(token, token, errorMessage);
                  parentRule.AddChildNode(new ErrorNode(errorMessage, token));
                  break;
               }
               case TokenType.XmlComment:
                  errorMessage = "Encountered XmlComment inside code";
                  context.GenerateParserError(token, token, errorMessage);
                  parentRule.AddChildNode(new ErrorNode(errorMessage, token));
                  break;
               case TokenType.Comment:
               case TokenType.Whitespace:
                  tokens.TryMoveNext(ref token);
                  break;
               case TokenType.Error:
                  errorMessage = "Encountered unexpected mangled token";
                  context.GenerateParserError(token, token, errorMessage);
                  parentRule.AddChildNode(new ErrorNode(errorMessage, token));
                  break;
            }
         }
      }
   }
}