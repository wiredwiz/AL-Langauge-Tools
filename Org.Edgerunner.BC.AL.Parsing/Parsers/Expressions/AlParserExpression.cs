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
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Expressions
{
   /// <summary>
   /// Class that represents an AL parser expression.
   /// Implements the <see cref="Org.Edgerunner.Language.Parsers.ParserExpression{AlToken}" />
   /// </summary>
   /// <seealso cref="Org.Edgerunner.Language.Parsers.ParserExpression{AlToken}" />
   public class AlParserExpression : ParserExpression<AlToken>
   {
      public AlParserExpression(TokenStream<AlToken> tokenStream, int start, int end) : base(tokenStream, start, end) {}
      public AlParserExpression(TokenStream<AlToken> tokenStream, int start) : base(tokenStream, start) {}
   }
}