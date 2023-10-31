#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParserExpression.cs">
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
using Org.Edgerunner.Language.Parsers;
using Org.Edgerunner.Pooling;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules
{
   /// <summary>
   /// Class that represents an AL parser rule.
   /// Implements the <see cref="ParserRule{TToken,TType}" />
   /// </summary>
   /// <seealso cref="ParserRule{TToken,TType}" />
   public class AlParserRule : ParserRule<AlToken, AlSyntaxNodeType>
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="AlParserRule" /> class.
      /// </summary>
      /// <param name="type">The expression node type.</param>
      /// <remarks>This overload assumes that the start and end positions are both the same symbol token.</remarks>
      public AlParserRule(AlSyntaxNodeType type) : base(type) {}

      public override string GetText()
      {
         switch (Children.Count)
         {
            case 0:
               return string.Empty;
            case 1:
               return ((ISyntaxNode<AlToken, AlSyntaxNodeType>)Children[0]).GetText();
            default:
            {
               var text = StringBuilderPool.Current.Get();
               text.Append(((ISyntaxNode<AlToken, AlSyntaxNodeType>)Children[0]).GetText());
               for (int i = 1; i < Children.Count; i++)
               {
                  var child = Children[i] as ISyntaxNode<AlToken, AlSyntaxNodeType>;
                  var fragment = child!.GetText();

                  if (fragment.First() is not ':' and not '.' and not ';')
                     text.Append(" ");
                  
                  text.Append(fragment);
               }
               return text.ToString();
            }
         }
      }
   }
}