#region MIT License
// <copyright company = "Edgerunner.org" file = "TokenStream.cs">
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

using System.Collections;

namespace Org.Edgerunner.Language.Lexers
{
   public class TokenStream<T> : IEnumerable<T>
      where T : IToken
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="TokenStream{T}"/> class.
      /// </summary>
      /// <param name="list">The list.</param>
      public TokenStream(List<T> list)
      {
         Stream = list;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="TokenStream{T}"/> class.
      /// </summary>
      public TokenStream()
      {
         Stream = new List<T>();
      }

      protected List<T> Stream;
      protected int _Position;

      /// <summary>
      /// Gets or sets the position in the stream.
      /// </summary>
      /// <value>The position.</value>
      /// <exception cref="System.ArgumentOutOfRangeException">Position - Position must be a non-negative number less than the size</exception>
      public virtual int Position
      {
         get => _Position;
         set
         {
            if (Position < 0 || Position > Stream.Count)
               throw new ArgumentOutOfRangeException(nameof(Position), "Position must be a non-negative number less than or equal to the size");

            _Position = value;
         }
      }

      /// <summary>
      /// Gets the number of tokens in the stream.
      /// </summary>
      /// <value>The size.</value>
      public virtual int Size => Stream.Count;

      /// <summary>
      /// Gets the current token.
      /// </summary>
      /// <value>The current token.</value>
      public virtual T Current => Stream[_Position - 1];

      /// <summary>
      /// Moves the stream position forward by one and returns the token at that position.
      /// </summary>
      /// <returns>A <see cref="T"/> instance.</returns>
      /// <remarks>If the stream position is already at the end, then it returns null.</remarks>
      public virtual T? NextToken()
      {
         if (EndOfStream())
            return default(T);

         return Stream[_Position++];
      }

      /// <summary>
      /// Moves the stream position backward by one and returns the token at that position.
      /// </summary>
      /// <returns>A <see cref="T"/> instance.</returns>
      /// <remarks>If the stream position is already at the beginning, then it returns null.</remarks>
      public virtual T? PreviousToken()
      {
         if (BeginningOfStream())
            return default(T);

         return Stream[--_Position];
      }

      /// <summary>
      /// Determines if the stream position is at the beginning.
      /// </summary>
      /// <returns><c>true</c> if position is at the beginning, <c>false</c> otherwise.</returns>
      public virtual bool BeginningOfStream()
      {
         return _Position == 0;
      }

      /// <summary>
      /// Determines if the stream position is at the end.
      /// </summary>
      /// <returns><c>true</c> if position is at the end, <c>false</c> otherwise.</returns>
      public virtual bool EndOfStream()
      {
         return _Position >= Stream.Count;
      }

      /// <summary>
      /// Returns an enumerator that iterates through the collection.
      /// </summary>
      /// <returns>An enumerator that can be used to iterate through the collection.</returns>
      public IEnumerator<T> GetEnumerator()
      {
         return Stream.GetEnumerator();
      }

      /// <summary>
      /// Returns an enumerator that iterates through a collection.
      /// </summary>
      /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
      IEnumerator IEnumerable.GetEnumerator()
      {
         return ((IEnumerable)Stream).GetEnumerator();
      }
   }
}