#region Apapche License 2.0

// <copyright file="SourceCodePrintBuffer.cs" company="Edgerunner.org">
// Copyright 2016 Thaddeus Ryker
// </copyright>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//     http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

namespace Org.Edgerunner.Buffers.Output
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security;
    using System.Text;

    /// <summary>
   ///    Class that represents an output buffer for source code.
   /// </summary>
   public class SourceCodePrintBuffer : FormattedPrintBuffer
   {
      private readonly TextWriter _Writer;
      private Dictionary<int, string> _Indents;

      private int _IndentSpacing = 2;
      private int _LineNumber = 1;
      private string _NewLine;
      private int _Position = 1;

      #region Constructors And Finalizers

      /// <summary>
      ///    Initializes a new instance of the <see cref="SourceCodePrintBuffer" /> class.
      /// </summary>
      /// <param name="writer">The <see cref="System.IO.TextWriter" /> to write the output to.</param>
      /// <exception cref="ArgumentNullException"><paramref name="writer" /> is <see langword="null" />.</exception>
      public SourceCodePrintBuffer(TextWriter writer)
      {
         if (writer == null)
            throw new ArgumentNullException(nameof(writer), "writer is null.");
         this._Writer = writer;
         this.Initialize();
      }

      /// <summary>
      ///    Initializes a new instance of the <see cref="SourceCodePrintBuffer" /> class.
      /// </summary>
      /// <param name="path">The file path to write the output to.</param>
      /// <exception cref="UnauthorizedAccessException">Access is denied. </exception>
      /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="IOException">
      ///    <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory
      ///    name, or volume label syntax.
      /// </exception>
      /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
      /// <exception cref="ArgumentException">path is null or empty.</exception>
      public SourceCodePrintBuffer(string path)
      {
         if (string.IsNullOrEmpty(path))
            throw new ArgumentException("path is null or empty.", nameof(path));

         this._Writer = new StreamWriter(path, false, Encoding.GetEncoding(850));
         this.Initialize();
      }

      /// <summary>
      ///    Finalizes an instance of the <see cref="SourceCodePrintBuffer" /> class.
      /// </summary>
      ~SourceCodePrintBuffer()
      {
         this.Dispose(false);
      }

      #endregion

      /// <summary>
      ///    Gets the System.Text.Encoding used for the output buffer.
      /// </summary>
      /// <value>The encoding.</value>
      public override Encoding Encoding => this._Writer.Encoding;

      /// <summary>
      ///    Gets the format provider.
      /// </summary>
      /// <value>The format provider.</value>
      public override IFormatProvider FormatProvider => this._Writer.FormatProvider;

      /// <summary>
      ///    Gets or sets the indent spacing width for each indent level.
      /// </summary>
      /// <value>The indent spacing width.</value>
      public override int IndentSpacing
      {
         get { return this._IndentSpacing; }
         set { this._IndentSpacing = value; }
      }

      /// <summary>
      ///    Gets or sets the absolute character position within the buffer.
      /// </summary>
      public override long AbsolutePosition { get; protected set; }

      /// <summary>
      /// Gets the number of the current line.
      /// </summary>
      public override int LineNumber => this._LineNumber;

      /// <summary>
      ///    Gets or sets the line terminator.
      /// </summary>
      /// <value>The new line terminator.</value>
      public override string NewLine
      {
         get { return this._Writer.NewLine; }
         set
         {
            this._NewLine = value;
            this._Writer.NewLine = value;
         }
      }

      /// <summary>
      /// Gets the current character position on the current line.
      /// </summary>
      public override int ColumnPosition => this._Position;

      #region IDisposable Pattern

      /// <summary>
      ///    Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
      /// </summary>
      public override void Dispose()
      {
         this.Dispose(true);
         GC.SuppressFinalize(this);
      }

      /// <summary>
      ///    Releases unmanaged and - optionally - managed resources.
      /// </summary>
      /// <param name="disposing">
      ///    <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
      ///    unmanaged resources.
      /// </param>
      protected virtual void Dispose(bool disposing)
      {
         if (disposing)
            this._Writer?.Dispose();
      }

      #endregion

      /// <summary>
      ///    Closes the output buffer.
      /// </summary>
      public override void Close()
      {
         this._Writer.Close();
      }

      /// <summary>
      ///    Escapes the specified text segment.
      /// </summary>
      /// <param name="text">The text to escape.</param>
      /// <returns>The escaped text.</returns>
      public override string Escape(string text)
      {
         return text;
      }

      /// <summary>
      ///    Escapes special characters in the supplied text.
      /// </summary>
      /// <param name="text">The text containing characters to escape.</param>
      /// <returns>The text with any special characters escaped.</returns>
      public override string EscapeCharacters(string text)
      {
         return text;
      }

      /// <summary>
      ///    Flushes the output buffer.
      /// </summary>
      public override void Flush()
      {
         this._Writer.Flush();
      }

      /// <summary>
      ///    Gets a padding string of spaces with a width of "position".
      /// </summary>
      /// <param name="position">The position.</param>
      /// <returns>The resulting pad string.</returns>
      public override string GetPadString(int position)
      {
         if (position > 1)
            return new string(' ', position - 1);
         return string.Empty;
      }

      /// <summary>
      ///    Gets a padding string of spaces with a width of the current buffer position.
      /// </summary>
      /// <returns>The resulting pad string.</returns>
      public override string GetPadString()
      {
         return this.GetPadString(this._Position);
      }

      /// <summary>
      ///    Increases the buffer indent level by 1.
      /// </summary>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Indent()
      {
         this.Indent(1);
      }

      /// <summary>
      ///    Increases the buffer indent level by the specified level.
      /// </summary>
      /// <param name="level">The number of indent levels to increase the current level by.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Indent(int level)
      {
         if (!this._Indents.ContainsKey(level)) this._Indents[level] = new string(' ', this._IndentSpacing * level);
         this._Position += this._IndentSpacing * level;
         this._Writer.Write(this._Indents[level]);
      }

      /// <summary>
      ///    Pads the output buffer to the specified position with whitespace.
      /// </summary>
      /// <param name="position">The position to pad to.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Pad(int position)
      {
         if (this._Position < position)
            this.Write(new string(' ', position - this._Position));
      }

      /// <summary>
      ///    Updates the buffer positioning based on the specified text.
      /// </summary>
      /// <param name="value">The text to use.</param>
      [SuppressMessage("ReSharper", "ExceptionNotDocumented")]
      protected override void UpdateBufferPositioning(string value)
      {
         if (!string.IsNullOrEmpty(value))
         {
            var lines = value.Split(new[] { this._NewLine }, StringSplitOptions.None);
            this.AbsolutePosition += value.Length;
            if (lines.Length > 1)
            {
               this._LineNumber += lines.Length - 1;
               this._Position = lines[lines.Length - 1].Length;
            }
            else
               this._Position += lines[0].Length;
         }
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(decimal value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes out a formatted string, using the same semantics as System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(string format, object arg0)
      {
         var valueText = string.Format(this.FormatProvider, format, arg0);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(format, arg0);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(string value)
      {
         this.UpdateBufferPositioning(value);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(object value)
      {
         var valueText = value.ToString();
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(bool value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes text to the output buffer containing <c>count</c> characters <c>buffer</c> starting at <c>index</c>.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <param name="index">Starting index.</param>
      /// <param name="count">Number of characters to write.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(char[] buffer, int index, int count)
      {
         var valueText = buffer.ToString().Substring(index, count);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(buffer, index, count);
      }

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <param name="arg2">The arg2.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(string format, object arg0, object arg1, object arg2)
      {
         var valueText = string.Format(this.FormatProvider, format, arg0, arg1, arg2);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(format, arg0, arg1, arg2);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(char value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(float value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(uint value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg">The arg.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(string format, params object[] arg)
      {
         var valueText = string.Format(format, arg);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(format, arg);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(ulong value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(double value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(int value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified buffer to the output buffer.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(char[] buffer)
      {
         var valueText = buffer.ToString();
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(buffer);
      }

      /// <summary>
      ///    Writes out a formatted string to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(string format, object arg0, object arg1)
      {
         var valueText = string.Format(this.FormatProvider, format, arg0, arg1);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(format, arg0, arg1);
      }

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void Write(long value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._Writer.Write(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(uint value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(int value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(ulong value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes a line to the output buffer containing <c>count</c> characters <c>buffer</c> starting at <c>index</c>.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <param name="index">Starting index.</param>
      /// <param name="count">Number of characters to write.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(char[] buffer, int index, int count)
      {
         var valueText = buffer.ToString().Substring(index, count);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(buffer, index, count);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(double value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg">The arg.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(string format, params object[] arg)
      {
         var valueText = string.Format(format, arg);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(format, arg);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(string value)
      {
         this.UpdateBufferPositioning(value);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(string format, object arg0, object arg1)
      {
         var valueText = string.Format(this.FormatProvider, format, arg0, arg1);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(format, arg0, arg1);
      }

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <param name="arg2">The arg2.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(string format, object arg0, object arg1, object arg2)
      {
         var valueText = string.Format(this.FormatProvider, format, arg0, arg1, arg2);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(format, arg0, arg1, arg2);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(char value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(string format, object arg0)
      {
         var valueText = string.Format(this.FormatProvider, format, arg0);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(format, arg0);
      }

      /// <summary>
      ///    Writes the specified buffer as a line to the output buffer.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(char[] buffer)
      {
         var valueText = buffer.ToString();
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(buffer);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(bool value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(float value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(decimal value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine()
      {
         this.UpdateBufferPositioning(this._NewLine);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine();
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(long value)
      {
         var valueText = value.ToString(this.FormatProvider);
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public override void WriteLine(object value)
      {
         if (value == null)
            return;
         var formattable = value as IFormattable;
         var valueText = formattable?.ToString(null, this.FormatProvider) ?? value.ToString();
         this.UpdateBufferPositioning(valueText);
         this._LineNumber += 1;
         this._Position = 1;
         this._Writer.WriteLine(value);
      }

      private void Initialize()
      {
         this._NewLine = this.NewLine;
         this._Indents = new Dictionary<int, string>(10);
      }
   }
}