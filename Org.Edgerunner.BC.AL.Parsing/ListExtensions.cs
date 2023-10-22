#region MIT License
// <copyright company = "Edgerunner.org" file = "ListExtensions.cs">
// Copyright(c)  2023
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

namespace Org.Edgerunner.BC.AL.Parsing
{
   /// <summary>
   /// Class containing list extension methods.
   /// </summary>
   public static class ListExtensions
   {
      /// <summary>
      /// Converts this list to a stack.
      /// </summary>
      /// <typeparam name="T">Type of object in the stack and list.</typeparam>
      /// <param name="list">The list to convert.</param>
      /// <returns>A new <see cref="Stack{T}"/>.</returns>
      /// <remarks>Pushes the list onto the stack in reverse so that the first item in the list will be the first item popped as well.</remarks>
      public static Stack<T> ToStack<T>(this List<T> list)
      {
         var stack = new Stack<T>(list.Count);
         for (var i = list.Count - 1; i > -1; i--) stack.Push(list[i]);
         return stack;
      }
   }
}