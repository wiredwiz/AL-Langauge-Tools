#region MIT License

// <copyright company="Edgerunner.org" file="BufferException.cs">
// Copyright (c) Thaddeus Ryker 2016
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

namespace Org.Edgerunner.Buffers
{
    using System;

   /// <summary>
   /// Represents errors that occur during buffer operations.
   /// </summary>
   public class BufferException : Exception
   {
      #region Constructors And Finalizers

      /// <summary>
      ///    Initializes a new instance of the <see cref="BufferException" /> class.
      ///    Parameterless (default) constructor
      /// </summary>
      public BufferException()
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="BufferException" /> class.
      /// Constructor for an exception with text message
      /// </summary>
      /// <param name="message">The message that describes the error.</param>
      public BufferException(string message)
         : base(message)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="BufferException" /> class.
      /// Constructor for an exception with text message and inner exception
      /// </summary>
      /// <param name="message">The message.</param>
      /// <param name="e">The e.</param>
      public BufferException(string message, Exception e)
         : base(message, e)
      {
      }

      #endregion
   }
}