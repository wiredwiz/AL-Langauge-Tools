#region MIT License
// <copyright company = "Edgerunner.org" file = "CharacterExtensions.cs">
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

namespace Org.Edgerunner.BC.AL.Parsing
{
   /// <summary>
   /// Class containing extension methods for the character type.
   /// </summary>
   public static class CharacterExtensions
   {
      /// <summary>
      /// Determines whether the specified character is a number.
      /// </summary>
      /// <param name="character">The character.</param>
      /// <returns><c>true</c> if the specified character is a number; otherwise, <c>false</c>.</returns>
      public static bool IsNumber(this char character)
      {
         return character is >= '0' and <= '9';
      }

      /// <summary>
      /// Determines whether the specified character is a letter.
      /// </summary>
      /// <param name="character">The character.</param>
      /// <returns><c>true</c> if the specified character is a letter; otherwise, <c>false</c>.</returns>
      public static bool IsLetter(this char character)
      {
         return character is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
      }

      /// <summary>
      /// Converts the specified character to uppercase.
      /// </summary>
      /// <param name="character">The character to uppercase.</param>
      /// <returns>A <see cref="char"/>.</returns>
      /// <remarks>Non-letter characters are returned as they are.</remarks>
      public static char ToUpper(this char character)
      {
         if (character is >= 'a' and <= 'z')
            return (char)(character - 32);

         return character;
      }

      /// <summary>
      /// Converts the specified character to lowercase.
      /// </summary>
      /// <param name="character">The character to lowercase.</param>
      /// <returns>A <see cref="char"/>.</returns>
      /// <remarks>Non-letter characters are returned as they are.</remarks>
      public static char ToLower(this char character)
      {
         if (character is >= 'A' and <= 'Z')
            return (char)(character + 32);

         return character;
      }
   }
}