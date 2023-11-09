﻿#region MIT License
// <copyright company = "Edgerunner.org" file = "ITraceListener.cs">
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

using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.Language.Parsers
{
   /// <summary>
   /// Interface that defines a parser trace event listener.
   /// </summary>
   public interface ITraceListener
   {
      /// <summary>
      /// Announces the traced parser event to all listeners.
      /// </summary>
      /// <param name="rule">The parser rule.</param>
      /// <param name="traceEvent">The parser event.</param>
      void AnnounceTraceMessage<TToken, TType>(ParserRule<TToken, TType> rule, TraceEvent traceEvent) where TToken : IToken;

      /// <summary>
      /// Announces the traced parser event to all listeners.
      /// </summary>
      /// <typeparam name="TToken">The type of the token.</typeparam>
      /// <param name="token">The token.</param>
      /// <param name="traceEvent">The parser event.</param>
      void AnnounceTraceMessage<TToken>(TToken token, TraceEvent traceEvent) where TToken : IToken;
   }
}