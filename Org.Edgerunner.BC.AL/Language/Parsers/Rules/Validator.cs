#region MIT License
// <copyright company = "Edgerunner.org" file = "Validator.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Parsers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules
{
   /// <summary>
   /// Class containing various AL code validators.
   /// </summary>
   public static class Validator
   {
      /// <summary>
      /// Validates that the <see cref="AlToken" /> matches the expected type and value.
      /// </summary>
      /// <param name="token">The token.</param>
      /// <param name="context">The current AL parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="type">The type to match.</param>
      /// <param name="value">The value to match.</param>
      /// <param name="errorMessage">The error message to generate if validation fails.</param>
      /// <returns><c>true</c> if the token passes validation, <c>false</c> otherwise.</returns>
      /// <seealso cref="AlToken" />
      // ReSharper disable once FlagArgument
      // ReSharper disable once TooManyArguments
      public static bool ValidateToken(AlToken? token, IParser<AlToken, AlSyntaxNodeType> context, ParserRule<AlToken, AlSyntaxNodeType> parentRule, TokenType type, string value, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type || token.Value != value)
         {
            if (context.State == 0)
            {
               context.GenerateParserError(token, token, errorMessage);
               parentRule.AddChildNode(new ErrorNode(errorMessage, token));
            }
            context.State = 1;
            return false;
         }

         context.State = 0;
         return true;
      }

      /// <summary>
      /// Validates that the <see cref="AlToken" /> matches the expected type and one of the allowed values.
      /// </summary>
      /// <param name="token">The token.</param>
      /// <param name="context">The current AL parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="type">The type to match.</param>
      /// <param name="allowedValues">The allowable values.</param>
      /// <param name="errorMessage">The error message to generate if validation fails.</param>
      /// <returns><c>true</c> if the token passes validation, <c>false</c> otherwise.</returns>
      /// <seealso cref="AlToken" />
      // ReSharper disable once FlagArgument
      // ReSharper disable once TooManyArguments
      public static bool ValidateToken(AlToken? token, IParser<AlToken, AlSyntaxNodeType> context, ParserRule<AlToken, AlSyntaxNodeType> parentRule, TokenType type, IEnumerable<string> allowedValues, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type || allowedValues.Contains(token.Value))
         {
            if (context.State == 0)
            {
               context.GenerateParserError(token, token, errorMessage);
               parentRule.AddChildNode(new ErrorNode(errorMessage, token));
            }
            context.State = 1;
            return false;
         }

         context.State = 0;
         return true;
      }

      /// <summary>
      /// Validates that the <see cref="AlToken"/> matches the expected type.
      /// </summary>
      /// <param name="token">The token.</param>
      /// <param name="context">The current AL parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="type">The type to match.</param>
      /// <param name="errorMessage">The error message to use if validation fails.</param>
      /// <returns><c>true</c> if the token passes validation, <c>false</c> otherwise.</returns>
      /// <seealso cref="AlToken"/>
      // ReSharper disable once FlagArgument
      public static bool ValidateToken(AlToken? token, IParser<AlToken, AlSyntaxNodeType> context, ParserRule<AlToken, AlSyntaxNodeType> parentRule, TokenType type, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type)
         {
            if (context.State == 0)
            {
               context.GenerateParserError(token, token, errorMessage);
               parentRule.AddChildNode(new ErrorNode(errorMessage, token));
            }
            context.State = 1;
            return false;
         }

         context.State = 0;
         return true;
      }

      /// <summary>
      /// Validates that the <see cref="AlToken"/> is a literal token of the expected literal type.
      /// </summary>
      /// <param name="token">The token.</param>
      /// <param name="context">The current AL parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <param name="type">The token literal type to match.</param>
      /// <param name="errorMessage">The error message to use if validation fails.</param>
      /// <returns><c>true</c> if the token passes validation, <c>false</c> otherwise.</returns>
      /// <remarks>Assumes a token type of Literal in this case</remarks>
      /// <seealso cref="AlToken"/>
      // ReSharper disable once FlagArgument
      public static bool ValidateToken(AlToken? token, IParser<AlToken, AlSyntaxNodeType> context, ParserRule<AlToken, AlSyntaxNodeType> parentRule, LiteralType type, string errorMessage)
      {
         if (token == null)
            return false;

         if (token is not LiteralToken literal)
         {
            if (context.State == 0)
            {
               context.GenerateParserError(token, token, errorMessage);
               parentRule.AddChildNode(new ErrorNode(errorMessage, token));
            }
            context.State = 1;
            return false;
         }

         // ReSharper disable once ComplexConditionExpression
         if (literal.TokenType != (int)TokenType.Literal || literal.LiteralType != type)
         {
            if (context.State == 0)
            {
               context.GenerateParserError(token, token, errorMessage);
               parentRule.AddChildNode(new ErrorNode(errorMessage, token));
            }
            context.State = 1;
            return false;
         }

         context.State = 0;
         return true;
      }
   }
}