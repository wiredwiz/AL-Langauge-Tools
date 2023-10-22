#region MIT License
// <copyright company = "Edgerunner.org" file = "LabelVariableTypeDeclaration.cs">
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
   /// Class that defines a variable declaration of the label type.
   /// Implements the <see cref="Org.Edgerunner.BC.Objects.Code.TypeDeclarations.BasicVariableTypeDeclaration" />
   /// </summary>
   /// <seealso cref="Org.Edgerunner.BC.Objects.Code.TypeDeclarations.BasicVariableTypeDeclaration" />
   public class LabelVariableTypeDeclaration : BasicVariableTypeDeclaration
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="LabelVariableTypeDeclaration"/> class.
      /// </summary>
      /// <param name="text">The text.</param>
      /// <param name="comment">The comment.</param>
      /// <param name="isLocked">if set to <c>true</c> [is locked]. The default is false.</param>
      /// <param name="maxLength">The maximum length. The default is 0 which specifies no max.</param>
      public LabelVariableTypeDeclaration(string text, string comment = "", bool isLocked = false, int maxLength = 0) : base(VariableType.Label)
      {
         Text = text;
         IsLocked = isLocked;
         Comment = comment;
         MaxLength = maxLength;
      }

      public string Text { get; set; }

      public bool IsLocked { get; set; }

      public string Comment { get; set; }

      public int MaxLength { get; set; }

      /// <summary>
      /// Returns a <see cref="System.String" /> that represents this instance.
      /// </summary>
      /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
      public override string ToString()
      {
         var result = $"{Type} {Text}";
         if (!string.IsNullOrEmpty(Comment)) result += $", Comment={Comment}";
         if (MaxLength > 0) result += $", MaxLength={MaxLength}";
         if (IsLocked) result += $", Locked={IsLocked}";
         return result;
      }
   }
}