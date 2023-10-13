﻿#region MIT License

//  <copyright company = "Edgerunner.org" file = "IPositionable.cs">
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
   ///    Interface that defines a character buffer with position.
   /// </summary>
   public interface IPositionable
   {
      /// <summary>
      ///    Gets or sets the absolute character position within the buffer.
      /// </summary>
      long AbsolutePosition { get; set; }

      /// <summary>
      ///    Gets or sets the number of the current line.
      /// </summary>
      int LineNumber { get; set; }

      /// <summary>
      ///    Gets or sets the current character position on the current line.
      /// </summary>
      int CharacterPosition { get; set; }
   }
}