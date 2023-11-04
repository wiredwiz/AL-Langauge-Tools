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

using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.Language.Parsers;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public class AlParser : IParser<AlToken, AlSyntaxNodeType>
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="AlParser"/> class.
      /// </summary>
      public AlParser()
      {
         HasErrors = false;
         _State = 0;
      }

      protected internal readonly List<IErrorListener<AlToken>> ErrorListeners = new List<IErrorListener<AlToken>>();

      protected internal readonly List<ITraceListener> TraceListeners = new List<ITraceListener>();
      private int _State;

      /// <inheritdoc />
      public bool HasErrors { get; private set; }

      /// <inheritdoc />
      public virtual int State
      {
         get => _State;

         set
         {
            if (value == 1)
               HasErrors = true;

            _State = value;
         }
      }

      /// <inheritdoc />
      public bool EnableTracing { get; set; } = false;

      /// <inheritdoc />
      public void AddErrorListener(IErrorListener<AlToken> listener)
      {
         ErrorListeners.Add(listener);
      }

      /// <inheritdoc />
      public void ClearErrorListeners()
      {
         ErrorListeners.Clear();
      }

      /// <inheritdoc />
      public void RemoveErrorListener(IErrorListener<AlToken> listener)
      {
         ErrorListeners.Remove(listener);
      }

      /// <inheritdoc />
      public void AddTraceListener(ITraceListener listener)
      {
         TraceListeners.Add(listener);
      }

      /// <inheritdoc />
      public void ClearTraceListeners()
      {
         TraceListeners.Clear();
      }

      /// <inheritdoc />
      public void RemoveTraceListener(ITraceListener listener)
      {
         TraceListeners.Remove(listener);
      }

      /// <summary>
      /// Parses AL code from tokens in the stream and generates a parser rule tree.
      /// </summary>
      /// <param name="tokens">The tokens.</param>
      /// <returns><c>true</c> if parsing succeeded, <c>false</c> otherwise.</returns>
      public bool ParseSource(TokenStream<AlToken> tokens)
      {
         HasErrors = false;
         return false;
      }

      
      /// <inheritdoc />
      public virtual void GenerateParserError(AlToken startToken, AlToken endToken, string message)
      {
         HasErrors = true;
         var error = new ParserError(startToken, endToken, message);
         foreach (var listener in ErrorListeners) listener.AnnounceError(error);
      }

      /// <inheritdoc />
      public virtual void GenerateTraceEvent(ParserRule<AlToken, AlSyntaxNodeType> rule, TraceEvent traceEvent)
      {
         foreach (var listener in TraceListeners) listener.AnnounceTraceMessage(rule, traceEvent);
      }

      /// <inheritdoc />
      public void GenerateTraceEvent(AlToken token, TraceEvent traceEvent)
      {
         foreach (var listener in TraceListeners) listener.AnnounceTraceMessage(token, traceEvent);
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