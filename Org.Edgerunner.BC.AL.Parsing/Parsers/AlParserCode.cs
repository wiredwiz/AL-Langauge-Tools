#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParserCode.cs">
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

using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.BC.AL.Objects;
using Org.Edgerunner.BC.AL.Objects.Code;
using Org.Edgerunner.BC.AL.Objects.Code.TypeDeclarations;
using Org.Edgerunner.BC.AL.Objects.Tables;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser : IParser<AlToken, AlObjectBase>
   {
      public BasicVariableTypeDeclaration? ParseVariableType(TokenStream<AlToken> tokens)
      {
         var token = tokens.NextToken();
         if (token == null)
            return null;

         if (token.TokenType != (int)TokenType.Identifier || Enum.TryParse(typeof(VariableType), token.Value, true, out var varType))
         {
            GenerateParserError(token, token, $"Expected a valid AL data type but instead encountered: {token.Value}");
            return null;
         }

         switch (varType)
         {
            case VariableType.Code:
            case VariableType.Text:
            {
               var length = ParseVariableLengthDeclaration(tokens);
               return new LengthVariableTypeDeclaration((VariableType)varType, length);
            }
            default:
               return null;
         }

         return null;
      }

      public int ParseVariableLengthDeclaration(TokenStream<AlToken> tokens)
      {
         var token = tokens.NextToken();
         if (!TokenValidates(token, TokenType.Symbol, "[", $"Expected '[', instead encountered: {token.Value}"))
            return 0;

         token = tokens.NextToken();
         if (!TokenValidates(token, LiteralType.Integer, $"Expected valid integer, instead encountered: {token.Value}"))
            return 0;

         var result = int.Parse(token.Value);

         token = tokens.NextToken();
         if (!TokenValidates(token, TokenType.Symbol, "]", $"Expected ']', but instead encountered: {token.Value}"))
            return 0;

         return result;
      }
   }
}