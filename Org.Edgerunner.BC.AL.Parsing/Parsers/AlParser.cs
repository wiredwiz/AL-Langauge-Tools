#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParser.cs">
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
using Org.Edgerunner.BC.AL.Objects.Tables;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser : IParser<AlToken, AlObjectBase>
   {

      protected internal readonly List<IErrorListener<AlToken>> Listeners = new List<IErrorListener<AlToken>>();

      /// <inheritdoc />
      public void AddErrorListener(IErrorListener<AlToken> listener)
      {
         Listeners.Add(listener);
      }

      /// <inheritdoc />
      public void ClearErrorListeners()
      {
         Listeners.Clear();
      }

      /// <inheritdoc />
      public void RemoveErrorListener(IErrorListener<AlToken> listener)
      {
         Listeners.Remove(listener);
      }

      /// <summary>
      /// Parses tokens from the stream into a type of <seealso cref="AlObjectBase"/>.
      /// </summary>
      /// <param name="tokens">The tokens.</param>
      /// <returns>A new <seealso cref="AlObjectBase"/>.</returns>
      public AlObjectBase? ParseSource(TokenStream<AlToken> tokens)
      {
         var token = tokens.NextToken();
         if (token == null)
            return null;

         switch (token.TokenType)
         {
            case (int)TokenType.Identifier when token.Value.ToLowerInvariant() == "table":
               return new Table("test", 1);
            case (int)TokenType.Identifier when token.Value.ToLowerInvariant() == "codeunit":
               return new Codeunit("test", 1);
            default:
               return null;
         }
      }

      /// <summary>
      /// Tokens the validates.
      /// </summary>
      /// <param name="token">The token.</param>
      /// <param name="type">The type.</param>
      /// <param name="value">The value.</param>
      /// <param name="errorMessage">The error message to generate if validation fails.</param>
      /// <returns><c>true</c> if the token passes validation, <c>false</c> otherwise.</returns>
      // ReSharper disable once FlagArgument
      protected virtual bool TokenValidates(AlToken? token, TokenType type, string value, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type || token.Value != value)
         {
            GenerateParserError(token, token, errorMessage);
            return false;
         }

         return true;
      }

      /// <summary>
      /// Tokens the validates.
      /// </summary>
      /// <param name="token">The token.</param>
      /// <param name="type">The literal value type.</param>
      /// <param name="errorMessage">The error message to generate if validation fails.</param>
      /// <returns><c>true</c> if the token passes validation, <c>false</c> otherwise.</returns>
      /// <remarks>Assumes a token type of Literal in this case</remarks>
      // ReSharper disable once FlagArgument
      protected virtual bool TokenValidates(AlToken? token, LiteralType type, string errorMessage)
      {
         if (token == null)
            return false;

         if (token is not LiteralToken literal)
         {
            GenerateParserError(token, token, errorMessage);
            return false;
         }

         // ReSharper disable once ComplexConditionExpression
         if (literal.TokenType != (int)TokenType.Literal || literal.LiteralType != type)
         {
            GenerateParserError(token, token, errorMessage);
            return false;
         }

         return true;
      }

      /// <summary>
      /// Generates a parser error and announces it.
      /// </summary>
      /// <param name="startToken">The start token.</param>
      /// <param name="endToken">The end token.</param>
      /// <param name="message">The message to display in the error.</param>
      protected virtual void GenerateParserError(AlToken startToken, AlToken endToken, string message)
      {
         var error = new ParserError(startToken, startToken, message);
         foreach (var listener in Listeners) listener.AnnounceError(error);
      }
   }
}