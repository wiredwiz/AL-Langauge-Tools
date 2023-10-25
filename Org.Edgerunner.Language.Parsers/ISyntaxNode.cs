#region MIT License
// <copyright company = "Edgerunner.org" file = "ISyntaxNode.cs">
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

using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.Language.Parsers
{
   /// <summary>
   /// Interface that defines a syntax node.
   /// </summary>
   /// <typeparam name="T">A type of <see cref="IToken"/></typeparam>
   public interface ISyntaxNode<T>
   where T : IToken
   {
      /// <summary>
      /// Gets or sets the token at the start of the syntax node.
      /// </summary>
      /// <value>The starting token.</value>
      T Start { get; set; }

      /// <summary>
      /// Gets or sets the token at the end of the syntax node.
      /// </summary>
      /// <value>The ending token.</value>
      T End { get; set; }

      /// <summary>
      /// Gets the text that represents this node.
      /// </summary>
      /// <returns>A <see cref="string"/> containing the text.</returns>
      string GetText();
   }
}