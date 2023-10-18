﻿#region MIT License

//  <copyright company = "Edgerunner.org" file = "IPointAccessible.cs">
//  Copyright(c) Thaddeus Ryker 2023
//  </copyright>
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.

#endregion

namespace Org.Edgerunner.Buffers
{
   /// <summary>
   ///    Interface that defines a buffer that supports buffer points.
   /// </summary>
   public interface IPointAccessible
   {
      /// <summary>
      /// Gets a new BufferPoint instance that defines the current buffer position.
      /// </summary>
      /// <param name="offset">The offset position to fetch the buffer point for.</param>
      /// <returns>A <see cref="BufferPoint" /> that defines the current buffer position.</returns>
      BufferPoint GetBufferPoint(int offset = 0);

      /// <summary>
      ///    Sets the buffer to a new position defined by point.
      /// </summary>
      /// <param name="point" type="Org.Edgerunner.Dynamics.NavTools.Parser.Common.BufferPoint">
      ///    A <see cref="BufferPoint" /> that defines the new buffer position.
      /// </param>
      void SetBufferPoint(BufferPoint point);
   }
}