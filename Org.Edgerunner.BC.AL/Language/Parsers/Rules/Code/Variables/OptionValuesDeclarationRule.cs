#region MIT License
// <copyright company = "Edgerunner.org" file = "OptionValuesDeclarationRule.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Generators;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Variables
{
   public class OptionValuesDeclarationRule : AlParserRule
   {
      public OptionValuesDeclarationRule() : base(AlSyntaxNodeType.OptionValuesDeclaration,
                                                  "Option Values Declaration Rule") {}

      /// <summary>
      /// Parses this rule from the token stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent rule to link to.</param>
      /// <returns><c>true</c> if parsing was successful, <c>false</c> otherwise.</returns>
      public virtual bool Parse(TokenStream<AlToken> tokens, AlParser context, AlParserRule parentRule)
      {
         try
         {
            Enter(context);
            var token = tokens.Current;
            var parsed = true;
            parentRule.AddChildNode(this);

            if (Validator.ValidateToken(
                                        token, 
                                        context, 
                                        parentRule, 
                                        TokenType.Identifier, 
                                        string.Format(Resources.ExpectedOptionValue, token.Value)))
            {
               new IdentifierRule(token).Parse(tokens, context, this);
               Match(context);
               if (!tokens.TryMoveNext(ref token))
                  return false;

               if (!ParseRepeatingDelimitedExpression(tokens, context, this, ",", ";", new OptionValueGenerator()))
                  parsed = false;
            }
            else
               parsed = false;

            if (!new SymbolRule(token!).Parse(tokens, context, this, ";"))
               parsed = false;

            return parsed;
         }
         finally
         {
            Exit(context);
         }
      }
   }
}