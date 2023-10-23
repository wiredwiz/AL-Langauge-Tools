#region MIT License
// <copyright company = "Edgerunner.org" file = "LanguageError.cs">
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

namespace Org.Edgerunner.Language.Lexers
{
   /// <summary>
   /// Class that defines a language error.
   /// </summary>
   /// <typeparam name="T">The type of tokens used in the language</typeparam>
   /// <seealso cref="IToken"/>
   public class LanguageError<T>
   where T : IToken
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="LanguageError{T}" /> class.
      /// </summary>
      /// <param name="startToken">The token that starts the error.</param>
      /// <param name="endToken">The token that ends the error.</param>
      /// <param name="message">The message.</param>
      public LanguageError(T startToken, T endToken, string message)
      {
         StartToken = startToken;
         EndToken = endToken;
         Message = message;
      }

      /// <summary>
      /// Gets the AL token that starts the error.
      /// </summary>
      /// <value>The AL token.</value>
      public T StartToken { get; }

      /// <summary>
      /// Gets the AL token that ends the error.
      /// </summary>
      /// <value>The AL token.</value>
      public T EndToken { get; }

      /// <summary>
      /// Gets or sets the error message.
      /// </summary>
      /// <value>The error message.</value>
      public string Message { get; set; }
   }
}