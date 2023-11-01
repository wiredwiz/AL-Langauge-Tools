#region MIT License
// <copyright company = "Edgerunner.org" file = "AlObjectBase.cs">
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

namespace Org.Edgerunner.BC.AL.Objects
{
   public abstract class AlObjectBase
   {
      string _Name;
      int _Id;
      string _Namespace;

      /// <summary>
      /// Initializes a new instance of the <see cref="AlObjectBase" /> class.
      /// </summary>
      /// <param name="name">The name.</param>
      /// <param name="id">The identifier.</param>
      /// <param name="namespace">The namespace.</param>
      /// <exception cref="System.ArgumentException">Value cannot be null or empty. - name</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">id - Value must be a positive number</exception>
      protected AlObjectBase(string name, int id, string @namespace = "")
      {
         if (string.IsNullOrEmpty(name.Trim()))
            throw new ArgumentException("Value cannot be null or empty.", nameof(name));
         if (id <= 0)
         {
            throw new ArgumentOutOfRangeException(nameof(id), "Value must be a positive number");
         }


         _Name = name;
         _Id = id;
         _Namespace = @namespace;
      }

      /// <summary>
      /// Gets or sets the name.
      /// </summary>
      /// <value>The name.</value>
      public virtual string Name
      {
         get => _Name;
         set => _Name = value;
      }

      /// <summary>
      /// Gets or sets the namespace.
      /// </summary>
      /// <value>The namespace.</value>
      public virtual string Namespace
      {
         get => _Namespace;
         set => _Namespace = value;
      }

      /// <summary>
      /// Gets or sets the unique object identifier.
      /// </summary>
      /// <value>The identifier.</value>
      public virtual int Id
      {
         get => _Id;
         set => _Id = value;
      }
   }
}