#region MIT License
// <copyright company = "Edgerunner.org" file = "ParserRules.cs">
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

using System.Reflection;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules;

namespace ALParser.Demo
{
   public static class ParserRules
   {
      static ParserRules()
      {
         var names = new List<string>();
         Types = new Dictionary<string, Type>();
         var subclassTypes = Assembly
                             .GetAssembly(typeof(AlParserRule))
                             ?.GetTypes()
                             .Where(t => t.IsSubclassOf(typeof(AlParserRule)));
         if (subclassTypes != null)
         {
            foreach (var type in subclassTypes)
            {
               try
               {
                  if (Activator.CreateInstance(type) is AlParserRule rule)
                  {
                     names.Add(rule.Name);
                     Types[rule.Name] = type;
                  }
               }
               catch (Exception)
               {
                  // do nothing, skip this rule
               }
            }
         }
         Names = names;
      }
      
      public static IEnumerable<string> Names { get; private set; }

      private static Dictionary<string, Type> Types { get; set; }

      public static AlParserRule GetInstance(string name)
      {
         var type = Types[name];
         return (Activator.CreateInstance(type) as AlParserRule)!;
      }
   }
}