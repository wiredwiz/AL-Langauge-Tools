#region MIT License
// <copyright company = "Edgerunner.org" file = "DictionaryVariableTypeDeclaration.cs">
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

namespace Org.Edgerunner.BC.Objects.Code.TypeDeclarations
{
   /// <summary>
   /// Class that defines a variable declaration of the dictionary type.
   /// Implements the <see cref="Org.Edgerunner.BC.Objects.Code.TypeDeclarations.BasicVariableTypeDeclaration" />
   /// </summary>
   /// <seealso cref="Org.Edgerunner.BC.Objects.Code.TypeDeclarations.BasicVariableTypeDeclaration" />
   public class DictionaryVariableTypeDeclaration : BasicVariableTypeDeclaration
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="DictionaryVariableTypeDeclaration"/> class.
      /// </summary>
      /// <param name="keyType">Type of the key.</param>
      /// <param name="valueType">Type of the value.</param>
      public DictionaryVariableTypeDeclaration(BasicVariableTypeDeclaration keyType, BasicVariableTypeDeclaration valueType) : base(VariableType.Dictionary)
      {
         KeyType = keyType;
         ValueType = valueType;
      }

      /// <summary>
      /// Gets or sets the key declaration type.
      /// </summary>
      /// <value>The key declaration.</value>
      public BasicVariableTypeDeclaration KeyType { get; set; }

      /// <summary>
      /// Gets or sets the value declaration type.
      /// </summary>
      /// <value>The value declaration.</value>
      public BasicVariableTypeDeclaration ValueType { get; set; }

      /// <summary>
      /// Returns a <see cref="System.String" /> that represents this instance.
      /// </summary>
      /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
      public override string ToString()
      {
         return $"Dictionary of [{KeyType}, {ValueType}]";
      }
   }
}