#region Apache License 2.0

// <copyright file="FormattedPrintBuffer.cs" company="Edgerunner.org">
// Copyright 2016 Thaddeus Ryker
// </copyright>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

namespace Org.Edgerunner.Buffers.Output
{
    using System;
    using System.IO;
    using System.Text;

    /// <summary>
   ///    Class that defines a formatted buffer for writing out text.
   /// </summary>
   public abstract class FormattedPrintBuffer : IDisposable, IFormatted, IPrintBuffer
   {
      #region IDisposable Pattern

      /// <summary>
      ///    Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
      /// </summary>
      public abstract void Dispose();

      #endregion

      #region IFormatted Members

      /// <summary>
      ///    Gets the System.Text.Encoding used for the output buffer.
      /// </summary>
      /// <value>The encoding.</value>
      public abstract Encoding Encoding { get; }

      /// <summary>
      ///    Gets the format provider.
      /// </summary>
      /// <value>The format provider.</value>
      public abstract IFormatProvider FormatProvider { get; }

      #endregion

      #region IPrintBuffer Members

      /// <summary>
      ///    Gets or sets the absolute character position within the buffer.
      /// </summary>
      public abstract long AbsolutePosition { get; protected set; }

      /// <summary>
      ///    Gets the number of the current line.
      /// </summary>
      public abstract int LineNumber { get; }

      /// <summary>
      ///    Gets the current character position on the current line.
      /// </summary>
      public abstract int CharacterPosition { get; }

      /// <summary>
      ///    Closes the output buffer.
      /// </summary>
      public abstract void Close();

      /// <summary>
      ///    Escapes the specified text segment.
      /// </summary>
      /// <param name="text">The text to escape.</param>
      /// <returns>The escaped text.</returns>
      public abstract string Escape(string text);

      /// <summary>
      ///    Escapes special characters in the supplied text.
      /// </summary>
      /// <param name="text">The text containing characters to escape.</param>
      /// <returns>The text with any special characters escaped.</returns>
      public abstract string EscapeCharacters(string text);

      /// <summary>
      ///    Flushes the output buffer.
      /// </summary>
      public abstract void Flush();

      /// <summary>
      ///    Gets a padding string of spaces with a width of "position".
      /// </summary>
      /// <param name="position">The position.</param>
      /// <returns>The resulting pad string.</returns>
      public abstract string GetPadString(int position);

      /// <summary>
      ///    Gets a padding string of spaces with a width of the current buffer position.
      /// </summary>
      /// <returns>The resulting pad string.</returns>
      public abstract string GetPadString();

      /// <summary>
      ///    Increases the buffer indent level by 1.
      /// </summary>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Indent();

      /// <summary>
      ///    Increases the buffer indent level by the specified level.
      /// </summary>
      /// <param name="level">The number of indent levels to increase the current level by.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Indent(int level);

      /// <summary>
      ///    Gets or sets the indent spacing width for each indent level.
      /// </summary>
      /// <value>The indent spacing width.</value>
      public abstract int IndentSpacing { get; set; }

      /// <summary>
      ///    Gets or sets the line terminator.
      /// </summary>
      /// <value>The new line terminator.</value>
      public abstract string NewLine { get; set; }

      /// <summary>
      ///    Pads the output buffer to the specified position with whitespace.
      /// </summary>
      /// <param name="position">The position to pad to.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Pad(int position);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(decimal value);

      /// <summary>
      ///    Writes out a formatted string, using the same semantics as System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(string format, object arg0);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(string value);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(object value);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(bool value);

      /// <summary>
      ///    Writes text to the output buffer containing <c>count</c> characters <c>buffer</c> starting at <c>index</c>.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <param name="index">Starting index.</param>
      /// <param name="count">Number of characters to write.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(char[] buffer, int index, int count);

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <param name="arg2">The arg2.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(string format, object arg0, object arg1, object arg2);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(char value);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(float value);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(uint value);

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg">The arg.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(string format, params object[] arg);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(ulong value);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(double value);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(int value);

      /// <summary>
      ///    Writes the specified buffer to the output buffer.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(char[] buffer);

      /// <summary>
      ///    Writes out a formatted string to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(string format, object arg0, object arg1);

      /// <summary>
      ///    Writes the specified value to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void Write(long value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(uint value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(int value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(ulong value);

      /// <summary>
      ///    Writes a line to the output buffer containing <c>count</c> characters <c>buffer</c> starting at <c>index</c>.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <param name="index">Starting index.</param>
      /// <param name="count">Number of characters to write.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(char[] buffer, int index, int count);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(double value);

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg">The arg.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(string format, params object[] arg);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(string value);

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(string format, object arg0, object arg1);

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <param name="arg2">The arg2.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(string format, object arg0, object arg1, object arg2);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(char value);

      /// <summary>
      ///    Writes out a formatted string as a line to the output buffer, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(string format, object arg0);

      /// <summary>
      ///    Writes the specified buffer as a line to the output buffer.
      /// </summary>
      /// <param name="buffer">The buffer.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(char[] buffer);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(bool value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(float value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(decimal value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine();

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(long value);

      /// <summary>
      ///    Writes the specified value as a line to the output buffer.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      public abstract void WriteLine(object value);

      #endregion

      /// <summary>
      ///    Updates the buffer positioning based on the specified text.
      /// </summary>
      /// <param name="value">The text to use.</param>
      protected abstract void UpdateBufferPositioning(string value);
   }
}