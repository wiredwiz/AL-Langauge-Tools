#region MIT License
// <copyright company = "Edgerunner.org" file = "IParserContext.cs">
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

using System.Text;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Pooling;

namespace Org.Edgerunner.Language.Parsers
{
   /// <summary>
   /// Class that represents a parser expression.
   /// Implements the <see cref="Org.Edgerunner.Language.Parsers.ITree" />.
   /// Implements the <see cref="Org.Edgerunner.Language.Parsers.ISyntaxNode" />.
   /// </summary>
   /// <typeparam name="T">A type of <see cref="IToken"/></typeparam>
   /// <seealso cref="Org.Edgerunner.Language.Parsers.ITree" />
   /// <seealso cref="Org.Edgerunner.Language.Parsers.ISyntaxNode" />
   /// <seealso cref="IToken"/>
   public class ParserExpression<T> : ITree, ISyntaxNode
   where T : IToken
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="ParserExpression{T}" /> class.
      /// </summary>
      /// <param name="tokenStream">The token stream.</param>
      /// <param name="start">The start token position.</param>
      /// <param name="end">The end token position.</param>
      public ParserExpression(TokenStream<T> tokenStream, int start, int end)
      {
         TokenStream = tokenStream;
         Start = start;
         End = end;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="ParserExpression{T}" /> class.
      /// </summary>
      /// <param name="tokenStream">The token stream.</param>
      /// <param name="start">The start token position.</param>
      /// <remarks>This overload assumes that the end position is the same as the start.</remarks>
      public ParserExpression(TokenStream<T> tokenStream, int start)
      {
         TokenStream = tokenStream;
         Start = start;
         End = start;
      }

      protected TokenStream<T> TokenStream;

      /// <inheritdoc />
      public ITree? Parent { get; set; }

      /// <inheritdoc />
      public IList<ITree> Children { get; } = new List<ITree>();

      /// <inheritdoc />
      public int Start { get; set; }

      /// <inheritdoc />
      public int End { get; set; }

      /// <inheritdoc />
      public string GetText()
      {
         var text = StringBuilderPool.Current.Get();
         if (!Children.Any())
         {
            for (int i = Start; i <= End; i++) text.Append(TokenStream.GetTokenAt(i).Value);
            return text.ToString();
         }

         foreach (var child in Children) text.Append(((ISyntaxNode)child).GetText());
         return text.ToString();
      }
   }
}