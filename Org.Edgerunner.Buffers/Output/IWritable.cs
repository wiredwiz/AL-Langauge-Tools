#region Apache License 2.0

// <copyright file="IWritable.cs" company="Edgerunner.org">
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
    using System.IO;

    /// <summary>
   ///    Interface That defines a writable buffer.
   /// </summary>
   public interface IWritable
   {
      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(decimal value);

      /// <summary>
      ///    Writes out a formatted string, using the same semantics as System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(string format, object arg0);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(string value);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(object value);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(bool value);

      /// <summary>
      ///    Writes text containing <c>count</c> characters from the array starting at <c>index</c>.
      /// </summary>
      /// <param name="buffer">The character array.</param>
      /// <param name="index">Starting index.</param>
      /// <param name="count">Number of characters to write.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(char[] buffer, int index, int count);

      /// <summary>
      ///    Writes out a formatted string as a line, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <param name="arg2">The arg2.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(string format, object arg0, object arg1, object arg2);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(char value);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(float value);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(uint value);

      /// <summary>
      ///    Writes out a formatted string as a line, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg">The arg.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(string format, params object[] arg);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(ulong value);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(double value);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(int value);

      /// <summary>
      ///    Writes the specified character array.
      /// </summary>
      /// <param name="buffer">The character array.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(char[] buffer);

      /// <summary>
      ///    Writes out a formatted string, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(string format, object arg0, object arg1);

      /// <summary>
      ///    Writes the specified value.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Write(long value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(uint value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(int value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(ulong value);

      /// <summary>
      ///    Writes a line containing <c>count</c> characters from the character array starting at <c>index</c>.
      /// </summary>
      /// <param name="buffer">The character array.</param>
      /// <param name="index">Starting index.</param>
      /// <param name="count">Number of characters to write.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(char[] buffer, int index, int count);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(double value);

      /// <summary>
      ///    Writes out a formatted string as a line, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg">The arg.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(string format, params object[] arg);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(string value);

      /// <summary>
      ///    Writes out a formatted string as a line, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(string format, object arg0, object arg1);

      /// <summary>
      ///    Writes out a formatted string as a line, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <param name="arg1">The arg1.</param>
      /// <param name="arg2">The arg2.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(string format, object arg0, object arg1, object arg2);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(char value);

      /// <summary>
      ///    Writes out a formatted string as a line, using the same semantics as
      ///    System.String.Format(System.String,System.Object).
      /// </summary>
      /// <param name="format">The format.</param>
      /// <param name="arg0">The arg0.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(string format, object arg0);

      /// <summary>
      ///    Writes the specified character array as a line.
      /// </summary>
      /// <param name="buffer">The character array.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(char[] buffer);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(bool value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(float value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(decimal value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine();

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(long value);

      /// <summary>
      ///    Writes the specified value as a line.
      /// </summary>
      /// <param name="value">The value.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void WriteLine(object value);
   }
}