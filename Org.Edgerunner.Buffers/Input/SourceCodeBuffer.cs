#region MIT License

// <copyright company="Edgerunner.org" file="SourceCodeBuffer.cs">
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

namespace Org.Edgerunner.Buffers.Input
{
    using System.IO;

    /// <summary>
   ///    Class that represents a source code buffer to read from.
   /// </summary>
   public class SourceCodeBuffer : TextBuffer
   {
      #region Constructors And Finalizers

      /// <summary>
      ///    Initializes a new instance of the <see cref="SourceCodeBuffer" /> class.
      /// </summary>
      /// <param name="source">String containing the path to the file used to read the text into the buffer.</param>
      public SourceCodeBuffer(string source)
         : base(source)
      {
         this.Initialize();
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="SourceCodeBuffer" /> class.
      /// </summary>
      /// <param name="source">The <see cref="System.IO.StringReader"/> instance used to read the text into the buffer.</param>
      public SourceCodeBuffer(TextReader source)
         : base(source)
      {
         this.Initialize();
      }

      #endregion

      /// <summary>
      ///    Reads 'token' ParseToken from the current buffer instance.
      /// </summary>
      /// <param name="token" type="Org.Edgerunner.Dynamics.NavTools.Parser.Common.ParseToken">
      ///    <para>
      ///       ParseToken to be read from the buffer.
      ///    </para>
      /// </param>
      public void PopToken(IParserToken token)
      {
         token.Get(this);
      }

      /// <summary>
      ///    Sets the buffer position back to the start of where 'token' was read from, so that it may be read again.
      /// </summary>
      /// <param name="token" type="Org.Edgerunner.Dynamics.NavTools.Parser.Common.ParseToken">
      ///    <para>
      ///       ParseToken to be pushed back onto the buffer.
      ///    </para>
      /// </param>
      public void PushToken(IParserToken token)
      {
         this.SetBufferPoint(new BufferPoint(token.LineNumber, token.Position));
      }

      /// <summary>
      ///    Handles any extra initilization code that is common to all constructors
      /// </summary>
      private void Initialize()
      {
      }
   }
}