#region MIT License
// <copyright company = "Edgerunner.org" file = "IParser.cs">
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

namespace Org.Edgerunner.Language.Parsers
{
   public interface IParser<T, out TO>
   where T : IToken
   {
      /// <summary>
      /// Gets a value indicating whether this instance has errors after the last parse attempt.
      /// </summary>
      /// <value><c>true</c> if this instance has errors; otherwise, <c>false</c>.</value>
      bool HasErrors { get; }

      /// <summary>
      /// Gets or sets a value indicating whether enable parser tracing.
      /// </summary>
      /// <value><c>true</c> if tracing is enabled; otherwise, <c>false</c>.</value>
      bool EnableTracing { get; set; }

      /// <summary>
      /// Adds a listener to be notified of parser errors.
      /// </summary>
      /// <param name="listener">The listener.</param>
      void AddErrorListener(IErrorListener<T> listener);

      /// <summary>
      /// Removes all error listeners.
      /// </summary>
      void ClearErrorListeners();

      /// <summary>
      /// Removes the error listener.
      /// </summary>
      /// <param name="listener">The listener.</param>
      void RemoveErrorListener(IErrorListener<T> listener);

      /// <summary>
      /// Parses tokens from the stream into an object of some kind.
      /// </summary>
      /// <param name="tokens">The tokens.</param>
      /// <returns>O.</returns>
      TO? ParseSource(TokenStream<T> tokens);
   }
}