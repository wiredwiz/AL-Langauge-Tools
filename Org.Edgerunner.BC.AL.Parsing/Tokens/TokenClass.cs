#region MIT License
// <copyright company = "Edgerunner.org" file = "TokenClass.cs">
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

// ReSharper disable InconsistentNaming

namespace Org.Edgerunner.BC.AL.Parsing.Tokens
{
   /// <summary>
   /// Enumeration representing AL token classes for identifier tokens.
   /// </summary>
   public enum TokenClass
   {
      None = 0,
      TABLE,
      TABLEEXT,
      PAGE,
      PAGEEXT,
      REPORT,
      QUERY,
      CODEUNIT,
      XMLPORT,
      ENUM,
      ENUMEXT,
      CONTROLADDIN,
      DOTNET,
      INTERFACE,
      PERMISSIONSET,
      PERMISSIONSETEXT,
      BEGIN,
      END,
      TRIGGER,
      PROCEDURE,
      EVENT,
      IF,
      ELSE,
      CASE,
      WHILE,
      REPEAT,
      UNTIL,
      FOR,
      EXIT,
      VAR,
      COLUMN,
      DATAITEM,
      KEYS,
      KEY,
      FIELD,
      FIELDGROUP,
      SORTING,
      REQUESTPAGE,
      LAYOUT,
      AREA,
      GROUP,
      LABELS,
      ACTIONS,
      LABEL,
      TEXT,
      CODE,
      DECIMAL,
      INTEGER,
      DURATION,
      DICTIONARY,
      LIST,
      ARRAY,
      OPTION,
      DATE,
      TIME,
      DATETIME,
      GUID,
      MEDIA,
      BIGINTEGER,
      BIGTEXT,
      BLOB,
      BYTE,
      CHAR,
      DATEFORMULA,
      DIALOG,
      TABLEREF,
      FIELDREF,
      TABLEFILTER,
      KEYREF,
      FILE,
      INSTREAM,
      OUTSTREAM,
      TRANSACTIONMODEL,
      TRANSACTIONTYPE,
      DATABASE,
      VARIANT,
      BOOLEAN,
      TRUE,
      FALSE,
      REC,
      XREC
   }
}