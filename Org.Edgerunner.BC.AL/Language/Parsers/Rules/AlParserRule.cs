#region MIT License

// <copyright company = "Edgerunner.org" file = "AlParserExpression.cs">
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Generators;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;
using Org.Edgerunner.Pooling;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules
{
   /// <summary>
   /// Class that represents an AL parser rule.
   /// Implements the <see cref="ParserRule{TToken,TType}" />
   /// </summary>
   /// <seealso cref="ParserRule{TToken,TType}" />
   public abstract class AlParserRule : ParserRule<AlToken, AlSyntaxNodeType>, IParsable
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="AlParserRule" /> class.
      /// </summary>
      /// <param name="type">The rule type.</param>
      /// <param name="name">The rule name.</param>
      /// <remarks>This overload assumes that the start and end positions are both the same symbol token.</remarks>
      protected AlParserRule(AlSyntaxNodeType type, string name) : base(type, name)
      {
         IsError = false;
      }

      protected delegate bool ParserHandler(TokenStream<AlToken> tokens,
                                            IParser<AlToken, AlSyntaxNodeType> context,
                                            ParserRule<AlToken, AlSyntaxNodeType> rule);

      /// <summary>
      /// Gets a value indicating whether this instance is an error.
      /// </summary>
      /// <value><c>true</c> if this instance is an error; otherwise, <c>false</c>.</value>
      public bool IsError { get; protected internal set; }

      public override string GetText()
      {
         switch (Children.Count)
         {
            case 0:
               return string.Empty;
            case 1:
               return ((ISyntaxNode<AlToken, AlSyntaxNodeType>)Children[0]).GetText();
            default:
               {
                  var text = StringBuilderPool.Current.Get();
                  text.Append(((ISyntaxNode<AlToken, AlSyntaxNodeType>)Children[0]).GetText());
                  for (int i = 1; i < Children.Count; i++)
                  {
                     var previous = Children[i - 1] as ISyntaxNode<AlToken, AlSyntaxNodeType>;
                     var child = Children[i] as ISyntaxNode<AlToken, AlSyntaxNodeType>;
                     var fragment = child!.GetText();
                     var previousFragment = previous!.GetText();

                     // We add spacing for readability unless the text starts with a colon, period or semi-colon.
                     // In the case of those tokens we omit the extra space, also for readability.
                     if (fragment.FirstOrDefault() is not ':' and not '.' and not ',' and not ';' and not ')'
                                                      and not ']' and not '[' &&
                         previousFragment.LastOrDefault() is not '(' and not '[')
                        text.Append(" ");

                     text.Append(fragment);
                  }

                  return text.ToString();
               }
         }
      }

      /// <summary>
      /// Parses a repeating expression with a symbol delimiter.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="delimiter">The delimiter symbol.</param>
      /// <param name="terminator">The terminator symbol.</param>
      /// <param name="generator">The parser rule generator.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      // ReSharper disable once TooManyArguments
      protected virtual bool ParseRepeatingDelimitedExpression(
         TokenStream<AlToken> tokens,
         AlParser context,
         string delimiter,
         string terminator,
         IRuleGenerator generator)
      {
         var token = tokens.Current;
         bool success = true;

         if (token.TokenType == (int)TokenType.Symbol && terminator == token.Value)
            return true;

         while (token!.TokenType != (int)TokenType.Symbol || terminator != token.Value)
         {
            // Look for delimiter token
            var parses = ((SymbolRule)AddChildNode(new SymbolRule(token))).Parse(tokens, context, delimiter);
            success = success && parses;
            if (parses && !tokens.TryMoveNext(ref token)) return false;

            // Now parse the expression
            parses = generator.Parses(tokens, context, this);
            success = success && parses;
            if (parses && !tokens.TryMoveNext(ref token)) return false;

            // If both parsing attempts failed, we move ahead one to prevent infinite looping
            if (!success)
               if (tokens.TryMoveNext(ref token))
                  context.GenerateTraceEvent(tokens.Previous()!, TraceEvent.Consume);
               else
                  return false;
         }

         tokens.TryMovePrevious(ref token);

         return success;
      }

      // ReSharper disable once FlagArgument
      protected virtual bool ProcessRuleAndAdvance(bool ruleResult, TokenStream<AlToken> tokens, ref AlToken token, ref bool parsed)
      {
         if (ruleResult)
         {
            if (!tokens.TryMoveNext(ref token!))
               return false;
         }
         else
            parsed = false;

         return true;
      }

      protected void ScanForTokenRegisteringErrors(TokenStream<AlToken> tokens, AlParser context, AlParserRule parentRule, TokenType type, string value)
      {
         if (tokens.EndOfStream())
            return;

         if (tokens.Current.TokenType == (int)type &&
             tokens.Current.Value.ToLowerInvariant() == value.ToLowerInvariant())
            return;

         var start = tokens.Current;

         // ReSharper disable once ComplexConditionExpression
         while (!tokens.EndOfStream() &&
                (tokens.Current.TokenType != (int)type || tokens.Current.Value.ToLowerInvariant() != value.ToLowerInvariant()))
         {
            parentRule.AddChildNode(new ErrorNode("Unexpected token", tokens.Current));
            context.GenerateParserError(start, tokens.Current, "Unexpected token");
            tokens.MoveNext();
         }
      }

      /// <summary>
      /// Parses this rule from the token stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <returns><c>true</c> if parsing was successful, <c>false</c> otherwise.</returns>
      public abstract bool Parse(TokenStream<AlToken> tokens, AlParser context);
   }
}