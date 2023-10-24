#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParser.Code.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Expressions;
using Org.Edgerunner.BC.AL.Language.Parsers.Expressions.Code;
using Org.Edgerunner.BC.AL.Language.Parsers.Expressions.Common;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.BC.AL.Objects.Code;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      /// <summary>
      /// Parses an AL length declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <returns>A new <see cref="AlParserExpression"/>.</returns>
      public AlParserExpression? ParseLengthDeclaration(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         if (!TokenValidates(token, TokenType.Symbol, "[", $"Expected '[', instead encountered: {token.Value}"))
            return null;

         token = tokens.NextToken();
         var start = tokens.Position;
         if (!TokenValidates(token, LiteralType.Integer, $"Expected valid integer, instead encountered: {token.Value}"))
            return null;

         token = tokens.NextToken();
         if (!TokenValidates(token, TokenType.Symbol, "]", $"Expected ']', but instead encountered: {token.Value}"))
            return null;

         return new IntegerExpression(tokens, start);
      }

      public AlParserExpression? ParseVariableType(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;

         if (token.TokenType != (int)TokenType.Identifier || Enum.TryParse(typeof(VariableType), token.Value, true, out var varType))
         {
            GenerateParserError(token, token, $"Expected a valid AL data type, but instead encountered: {token.Value}");
            return null;
         }

         var start = tokens.Position;
         VariableTypeExpression result;
         
         switch (varType)
         {
            case VariableType.Code:
            case VariableType.Text:
            {
               var length = ParseLengthDeclaration(tokens);
               result = new VariableTypeExpression(tokens, start, tokens.Position);
               result.Children.Add(length);
               break;
            }
            default:
               return null;
         }

         return result;
      }
   }
}