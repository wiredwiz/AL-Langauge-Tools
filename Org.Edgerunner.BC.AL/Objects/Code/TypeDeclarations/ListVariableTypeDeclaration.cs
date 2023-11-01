#region MIT License
// <copyright company = "Edgerunner.org" file = "ListVariableTypeDeclaration.cs">
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

namespace Org.Edgerunner.BC.AL.Objects.Code.TypeDeclarations
{
   /// <summary>
   /// Class that defines a variable declaration of the list type.
   /// Implements the <see cref="BasicVariableTypeDeclaration" />
   /// </summary>
   /// <seealso cref="BasicVariableTypeDeclaration" />
   public class ListVariableTypeDeclaration : BasicVariableTypeDeclaration
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="ListVariableTypeDeclaration"/> class.
      /// </summary>
      /// <param name="subDeclaration">The sub declaration.</param>
      public ListVariableTypeDeclaration(BasicVariableTypeDeclaration subDeclaration) : base(VariableType.List)
      {
         SubDeclaration = subDeclaration;
      }

      /// <summary>
      /// Gets or sets the sub declaration.
      /// </summary>
      /// <value>The sub declaration.</value>
      public BasicVariableTypeDeclaration SubDeclaration { get; set; }

      /// <summary>
      /// Returns a <see cref="System.String" /> that represents this instance.
      /// </summary>
      /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
      public override string ToString()
      {
         return $"List of [{SubDeclaration}]";
      }
   }
}