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

using Org.Edgerunner.BC.AL.Objects;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules;
using Org.Edgerunner.BC.AL.Language.Tokens;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser : IParser<AlToken, AlParserRule>
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="AlParser"/> class.
      /// </summary>
      public AlParser()
      {
         HasErrors = false;
      }

      protected internal readonly List<IErrorListener<AlToken>> Listeners = new List<IErrorListener<AlToken>>();

      /// <inheritdoc />
      public bool HasErrors { get; private set; }

      /// <inheritdoc />
      public bool EnableTracing { get; set; } = false;

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
      /// <returns>A new <seealso cref="AlParserRule"/>.</returns>
      public AlParserRule? ParseSource(TokenStream<AlToken> tokens)
      {
         HasErrors = false;
         return null;
      }

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
      protected virtual bool ValidateToken(AlToken? token, AlParserContext context, AlParserRule parentRule, TokenType type, string value, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type || token.Value != value)
         {
            if (context.State == 0)
            {
               GenerateParserError(token, token, errorMessage);
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
      protected virtual bool ValidateToken(AlToken? token, AlParserContext context, AlParserRule parentRule, TokenType type, IEnumerable<string> allowedValues, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type || allowedValues.Contains(token.Value))
         {
            if (context.State == 0)
            {
               GenerateParserError(token, token, errorMessage);
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
      protected virtual bool ValidateToken(AlToken? token, AlParserContext context, AlParserRule parentRule, TokenType type, string errorMessage)
      {
         if (token == null)
            return false;

         if (token.TokenType != (int)type)
         {
            if (context.State == 0)
            {
               GenerateParserError(token, token, errorMessage);
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
      protected virtual bool ValidateToken(AlToken? token, AlParserContext context, AlParserRule parentRule, LiteralType type, string errorMessage)
      {
         if (token == null)
            return false;

         if (token is not LiteralToken literal)
         {
            if (context.State == 0)
            {
               GenerateParserError(token, token, errorMessage);
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
               GenerateParserError(token, token, errorMessage);
               parentRule.AddChildNode(new ErrorNode(errorMessage, token));
            }
            context.State = 1;
            return false;
         }

         context.State = 0;
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
         HasErrors = true;
         var error = new ParserError(startToken, endToken, message);
         foreach (var listener in Listeners) listener.AnnounceError(error);
      }

      protected virtual void AppendErrorNode(AlParserRule parent, string message, AlToken symbol)
      {
         var node = new ErrorNode(message, symbol)
                    {
                       Parent = parent
                    };
         parent.Children.Add(node);
      }

      protected virtual void ScanTillSymbolReached(TokenStream<AlToken> tokens, IEnumerable<string> terminators)
      {
         var enumerable = terminators as string[] ?? terminators.ToArray();
         while (tokens.Current.TokenType != (int)TokenType.Symbol && !enumerable.Contains(tokens.Current.Value))
         {
            if (tokens.EndOfStream())
               break;

            tokens.MoveNext();
         }
      }
   }
}