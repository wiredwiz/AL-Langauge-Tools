﻿#region MIT License
// <copyright company = "Edgerunner.org" file = "VariableDeclarationRule.cs">
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

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Variables
{
   public class VariableDeclarationRule : AlParserRule
   {
      public VariableDeclarationRule() : base(AlSyntaxNodeType.VariableDeclaration, "Variable Declaration Rule") {}

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
            parentRule.AddChildNode(this);

            // read the variable name
            new IdentifierRule(token).Parse(tokens, context, this);
            Match(context);
            if (!tokens.TryMoveNext(ref token))
               return false;

            // check for colon separator
            if (new SymbolRule(token!).Parse(tokens, context, this, ":"))
            {
               if (!tokens.TryMoveNext(ref token))
                  return false;
            }

            // read data type
            var parsed = new VariableTypeDeclarationRule().Parse(tokens, context, this);
            if (parsed && !tokens.TryMoveNext(ref token)) return false;

            // now look for the statement terminator
            if (new SymbolRule(token!).Parse(tokens, context, this, ";"))
            {
               if (!tokens.TryMoveNext(ref token))
                  return false;
            }
            
            return parsed;
         }
         finally
         {
            Exit(context);
         }
      }
   }
}