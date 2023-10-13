#region MIT License

// <copyright company="Edgerunner.org" file="BufferTextReaderAdapter.cs">
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
   ///    TODO: Describe this class here.
   /// </summary>
   public class BufferTextReaderAdapter : TextReader
   {
      protected TextBuffer _Buffer;

      #region Constructors And Finalizers

      /// <summary>
      ///    Initializes a new instance of the <see cref="BufferTextReaderAdapter" /> class.
      ///    TODO: Describe this constructor here
      /// </summary>
      public BufferTextReaderAdapter(TextBuffer buffer)
      {
         this._Buffer = buffer;
      }

      #endregion

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override void Close()
      {
         // TODO: Add your implementation before or after the following base method call
         base.Close();
      }

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override int Peek()
      {
         var value = -1;
         if (!this._Buffer.EndOfData())
         {
            value = this._Buffer.GetNextChar();
            this._Buffer.GetPreviousChar();
         }

         return value;
      }

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override int Read(char[] buffer, int index, int count)
      {
         var value = 0;
         for (var i = 0; i < count; i++)
         {
            if (this._Buffer.EndOfData())
               break;
            buffer[index + i] = this._Buffer.GetNextChar();
            value++;
         }

         return value;
      }

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override int Read()
      {
         var value = -1;
         if (!this._Buffer.EndOfData())
            value = this._Buffer.GetNextChar();
         return value;
      }

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override int ReadBlock(char[] buffer, int index, int count)
      {
         var value = 0;
         for (var i = 0; i < count; i++)
         {
            if (this._Buffer.EndOfData())
               break;
            buffer[index + i] = this._Buffer.GetNextChar();
            value++;
         }

         return value;
      }

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override string ReadLine()
      {
         var value = string.Empty;
         var currentLine = this._Buffer.LineNumber;
         while (this._Buffer.LineNumber == currentLine)
            value += this._Buffer.GetNextChar();

         return value;
      }

      /// <summary>
      ///    Overrides the corresponding method from the System.IO.TextReader base type.
      /// </summary>
      public override string ReadToEnd()
      {
         var value = string.Empty;
         while (!this._Buffer.EndOfData())
            value += this._Buffer.GetNextChar();

         return value;
      }
   }
}