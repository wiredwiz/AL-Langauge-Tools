#region Apache License 2.0

// <copyright file="IPrintBuffer.cs" company="Edgerunner.org">
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
   ///    Interface that defines a print buffer.
   /// </summary>
   public interface IPrintBuffer : IPositionable, IWritable
   {
      /// <summary>
      ///    Gets or sets the indent spacing width for each indent level.
      /// </summary>
      /// <value>The indent spacing width.</value>
      int IndentSpacing { get; set; }

      /// <summary>
      ///    Gets or sets the line terminator.
      /// </summary>
      /// <value>The new line terminator.</value>
      string NewLine { get; set; }

      /// <summary>
      ///    Closes the output buffer.
      /// </summary>
      void Close();

      /// <summary>
      ///    Escapes the specified text segment.
      /// </summary>
      /// <param name="text">The text to escape.</param>
      /// <returns>The escaped text.</returns>
      string Escape(string text);

      /// <summary>
      ///    Escapes special characters in the supplied text.
      /// </summary>
      /// <param name="text">The text containing characters to escape.</param>
      /// <returns>The text with any special characters escaped.</returns>
      string EscapeCharacters(string text);

      /// <summary>
      ///    Flushes the output buffer.
      /// </summary>
      void Flush();

      /// <summary>
      ///    Gets a padding string of spaces with a width of "position".
      /// </summary>
      /// <param name="position">The position.</param>
      /// <returns>The resulting pad string.</returns>
      string GetPadString(int position);

      /// <summary>
      ///    Gets a padding string of spaces with a width of the current buffer position.
      /// </summary>
      /// <returns>The resulting pad string.</returns>
      string GetPadString();

      /// <summary>
      ///    Increases the buffer indent level by 1.
      /// </summary>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Indent();

      /// <summary>
      ///    Increases the buffer indent level by the specified level.
      /// </summary>
      /// <param name="level">The number of indent levels to increase the current level by.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Indent(int level);

      /// <summary>
      ///    Pads the output buffer to the specified position with whitespace.
      /// </summary>
      /// <param name="position">The position to pad to.</param>
      /// <exception cref="IOException">An I/O error occurs. </exception>
      void Pad(int position);
   }
}