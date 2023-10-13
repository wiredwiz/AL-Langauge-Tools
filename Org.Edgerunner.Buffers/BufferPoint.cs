#region MIT License

// <copyright company="Edgerunner.org" file="BufferPoint.cs">
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
   ///    Represents the current character position and line number within a LineBuffer.
   /// </summary>
   [Serializable]
   public struct BufferPoint
   {
      #region Constructors And Finalizers

      /// <summary>
      /// Initializes a new instance of the <see cref="BufferPoint"/> struct. 
      /// </summary>
      /// <param name="line" type="int">
      ///    <para>
      ///       Integer specifying the line number.
      ///    </para>
      /// </param>
      /// <param name="position" type="int">
      ///    <para>
      ///       Integer specifying the character position.
      ///    </para>
      /// </param>
      public BufferPoint(int line, int position)
      {
         LineNumber = line;
         CharacterPosition = position;
      }

      #endregion

      /// <summary>
      /// Gets the character position.
      /// </summary>
      /// <value>The character position.</value>
      public int CharacterPosition { get; }

      /// <summary>
      /// Gets the line number.
      /// </summary>
      /// <value>The line number.</value>
      public int LineNumber { get; }

      #region Static

      /// <summary>
      /// Implements the &gt; operator.
      /// </summary>
      /// <param name="point1">The first point object.</param>
      /// <param name="point2">The second point object.</param>
      /// <returns>The result of the operator.</returns>
      public static bool operator >(BufferPoint point1, BufferPoint point2)
      {
         if (point1.LineNumber > point2.LineNumber)
            return true;
         if (point1.LineNumber == point2.LineNumber)
            return point1.CharacterPosition > point2.CharacterPosition;
         return false;
      }

      /// <summary>
      /// Implements the &lt; operator.
      /// </summary>
      /// <param name="point1">The first point object.</param>
      /// <param name="point2">The second point object.</param>
      /// <returns>The result of the operator.</returns>
      public static bool operator <(BufferPoint point1, BufferPoint point2)
      {
         if (point1.LineNumber < point2.LineNumber)
            return true;
         if (point1.LineNumber == point2.LineNumber)
            return point1.CharacterPosition < point2.CharacterPosition;
         return false;
      }

      #endregion
   }
}