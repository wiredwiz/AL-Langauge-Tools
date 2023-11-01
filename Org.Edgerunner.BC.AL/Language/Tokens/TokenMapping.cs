#region MIT License
// <copyright company = "Edgerunner.org" file = "TokenMapping.cs">
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

// ReSharper disable MethodTooLong

namespace Org.Edgerunner.BC.AL.Language.Tokens
{
   /// <summary>
   /// Class for generating AL token maps.
   /// </summary>
   public static class TokenMapping
   {
      private static int[]? _fileObjectMap;
      private static int[]? _alMap;

      /// <summary>
      /// Gets a character map for an AL object file.
      /// </summary>
      /// <returns>An array of <see cref="int"/>.</returns>
      public static int[] GetFileObjectMap()
      {
         if (_fileObjectMap != null)
            return _fileObjectMap;

         _fileObjectMap = new int[256];
         for (var i = 0; i < 256; i++) _fileObjectMap[i] = (int)CharacterIndicator.Error;
         for (var i = 9; i < 14; i++) _fileObjectMap[i] = (int)CharacterIndicator.Whitespace;
         for (var i = 65; i < 91; i++) _fileObjectMap[i] = (int)CharacterIndicator.Identifier;
         for (var i = 97; i < 123; i++) _fileObjectMap[i] = (int)CharacterIndicator.Identifier;
         for (var i = 35; i < 47; i++) _fileObjectMap[i] = (int)CharacterIndicator.Symbol;
         for (var i = 48; i < 58; i++) _fileObjectMap[i] = (int)CharacterIndicator.Number;
         for (var i = 58; i < 65; i++) _fileObjectMap[i] = (int)CharacterIndicator.Symbol;
         for (var i = 91; i < 97; i++) _fileObjectMap[i] = (int)CharacterIndicator.Symbol;
         for (var i = 123; i < 126; i++) _fileObjectMap[i] = (int)CharacterIndicator.Symbol;
         _fileObjectMap[32] = (int)CharacterIndicator.Whitespace;
         _fileObjectMap[33] = (int)CharacterIndicator.Symbol;
         _fileObjectMap[34] = (int)CharacterIndicator.Identifier;
         _fileObjectMap[39] = (int)CharacterIndicator.String;
         _fileObjectMap[40] = (int)CharacterIndicator.Symbol;
         _fileObjectMap[41] = (int)CharacterIndicator.Symbol;
         _fileObjectMap[47] = (int)CharacterIndicator.Comment;
         _fileObjectMap[95] = (int)CharacterIndicator.Identifier;
         _fileObjectMap[126] = (int)CharacterIndicator.Symbol;

         return _fileObjectMap;
      }

      /// <summary>
      /// Gets the character map for AL programming code.
      /// </summary>
      /// <returns>An array of <see cref="int"/>.</returns>
      public static int[] GetAlCodeMap()
      {
         if (_alMap != null)
            return _alMap;

         _alMap = new int[256];
         for (var i = 0; i < 256; i++) _alMap[i] = (int)CharacterIndicator.Error;
         for (var i = 9; i < 14; i++) _alMap[i] = (int)CharacterIndicator.Whitespace;
         for (var i = 65; i < 91; i++) _alMap[i] = (int)CharacterIndicator.Identifier;
         for (var i = 97; i < 123; i++) _alMap[i] = (int)CharacterIndicator.Identifier;
         for (var i = 35; i < 47; i++) _alMap[i] = (int)CharacterIndicator.Symbol;
         for (var i = 48; i < 58; i++) _alMap[i] = (int)CharacterIndicator.Number;
         for (var i = 58; i < 65; i++) _alMap[i] = (int)CharacterIndicator.Symbol;
         for (var i = 91; i < 97; i++) _alMap[i] = (int)CharacterIndicator.Symbol;
         for (var i = 123; i < 126; i++) _alMap[i] = (int)CharacterIndicator.Symbol;
         _alMap[32] = (int)CharacterIndicator.Whitespace;
         _alMap[33] = (int)CharacterIndicator.Symbol;
         _alMap[34] = (int)CharacterIndicator.Identifier;
         _alMap[39] = (int)CharacterIndicator.String;
         _alMap[40] = (int)CharacterIndicator.Symbol;
         _alMap[41] = (int)CharacterIndicator.Symbol;
         _alMap[47] = (int)CharacterIndicator.Comment;
         _alMap[126] = (int)CharacterIndicator.Symbol;

         return _alMap;
      }
   }
}