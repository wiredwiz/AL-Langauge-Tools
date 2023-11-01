#region MIT License
// <copyright company = "Edgerunner.org" file = "Key.cs">
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

namespace Org.Edgerunner.BC.AL.Objects.Tables
{
   public class Key
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="Key"/> class.
      /// </summary>
      /// <param name="name">The key name.</param>
      /// <param name="fields">The key fields.</param>
      public Key(string name, IEnumerable<string> fields)
      {
         Name = name;
         Fields = fields.ToList();
      }

      public string Name { get; set; }

      public List<string> Fields { get; set; }

      public bool Clustered { get; set; }

      public bool Enabled { get; set; }

      public bool Unique { get; set; }
      public override string ToString()
      {
         var result = $"key({Name}; {string.Join(", ", Fields)})\r\n{{";
         if (Clustered || Enabled || Unique)
         {
            if (Enabled) result +=   $"    Enabled=true";
            if (Clustered) result += $"    Clustered=true";
            if (Unique) result +=    $"    Unique=true";
         }
         return result + "}";
      }

   }
}