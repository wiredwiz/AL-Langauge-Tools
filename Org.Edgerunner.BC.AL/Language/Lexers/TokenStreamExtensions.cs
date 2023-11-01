#region MIT License
// <copyright company = "Edgerunner.org" file = "TokenStreamExtensions.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Lexers
{
   /// <summary>
   /// Class containing TokenStream extensions methods. 
   /// </summary>
   /// <seealso cref="TokenStream{T}"/>
   public static class TokenStreamExtensions
   {
      /// <summary>
      /// Rewinds the stream back a set number of positions and returns null.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="steps">The number of steps to rewind.</param>
      /// <returns>Null.</returns>
      /// <exception cref="ArgumentOutOfRangeException">steps resulted in a negative stream position.</exception>
      public static AlParserRule? Rewind(this TokenStream<AlToken> tokens, int steps = 1)
      {
         if (tokens.Position - steps < 0)
            throw new ArgumentOutOfRangeException(nameof(steps),
                                                  "The number of positions cannot rewind the stream past its starting position");
         tokens.Position -= steps;
         return null;
      }
   }
}