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

using System.Net.Mail;
using System.Runtime.CompilerServices;
using Org.Edgerunner.BC.AL.Parsing.Tokens;

namespace Org.Edgerunner.BC.AL.Parsing
{
   /// <summary>
   /// Class for generating AL token maps.
   /// </summary>
   public static class TokenMapping
   {
      static int[] GetFileObjectMap()
      {
         var map = new int[256];

         for (int i = 0; i < 256; i++) map[i] = (int)TokenTypes.Error;
         for (int i = 65; i < 91; i++) map[i] = (int)TokenTypes.Identifier;
         for (int i = 97; i < 123; i++) map[i] = (int)TokenTypes.Identifier;
         for (int i = 48; i < 58; i++) map[i] = (int)TokenTypes.Number;
         map[34] = (int)TokenTypes.String;
         map[40] = (int)TokenTypes.Special;
         map[41] = (int)TokenTypes.Special;
         map[59] = (int)TokenTypes.Special;
         map[123] = (int)TokenTypes.Special;
         map[125] = (int)TokenTypes.Special;

         return map;
      }

      static int[] GetAlCodeMap()
      {
         var map = new int[256];

         for (int i = 0; i < 256; i++) map[i] = (int)TokenTypes.Error;

         return map;
      }

      static int[] GetXmlMap()
      {
         var map = new int[256];

         for (int i = 0; i < 256; i++) map[i] = (int)TokenTypes.Error;

         return map;
      }
   }
}