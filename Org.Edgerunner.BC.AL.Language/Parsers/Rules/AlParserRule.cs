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
      /// <param name="start">The start token.</param>
      /// <param name="end">The end token.</param>
      public AlParserRule(AlSyntaxNodeType type, AlToken start, AlToken end) : base(type, start, end) {}

      /// <summary>
      /// Initializes a new instance of the <see cref="AlParserRule" /> class.
      /// </summary>
      /// <param name="type">The expression node type.</param>
      /// <param name="symbol">The start/end symbol token.</param>
      /// <remarks>This overload assumes that the start and end positions are both the same symbol token.</remarks>
      public AlParserRule(AlSyntaxNodeType type, AlToken symbol) : base(type, symbol) {}
   }
}