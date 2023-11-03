#region MIT License
// <copyright company = "Edgerunner.org" file = "DimensionsDeclarationRule.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Variables
{
   public class DimensionsDeclarationRule : AlParserRule
   {
      public DimensionsDeclarationRule() : base(AlSyntaxNodeType.DimensionsDeclaration, "Dimensions Declaration Rule") {}
      public override bool Parse(TokenStream<AlToken> tokens, IParser<AlToken, AlSyntaxNodeType> context, ParserRule<AlToken, AlSyntaxNodeType> parentRule)
      {
         Enter(context);
         var token = tokens.Current;
         var parsed = true;
         parentRule.AddChildNode(this);

         if (new SymbolRule(token).Parse(tokens, context, this))
         {
            if (!tokens.TryMoveNext(ref token))
               return Exit(context, false);
         }
         else
            parsed = false;

         if (new IntegerLiteralRule(token!).Parse(tokens, context, this))
         {
            if (!tokens.TryMoveNext(ref token))
               return Exit(context, false);
            
            if (!ParseRepeatingDelimitedExpression(tokens, context, this, ",", "]", typeof(IntegerLiteralRule)))
               parsed = false;
         }
         else
            parsed = false;

         token = tokens.Current;
         if (!new SymbolRule(token).Parse(tokens, context, this))
            parsed = false;

         return Exit(context, parsed);
      }
   }
}