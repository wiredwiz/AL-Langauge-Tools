#region MIT License

// <copyright company = "Edgerunner.org" file = "VariableTypeDeclarationRule.cs">
// Copyright(c) Thaddeus Ryker 2023
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

using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.BC.AL.Objects.Code;
using Org.Edgerunner.Language.Lexers;

namespace Org.Edgerunner.BC.AL.Language.Parsers.Rules.Code.Variables
{
   public class VariableTypeDeclarationRule : AlParserRule, IParsable
   {
      public VariableTypeDeclarationRule() : base(AlSyntaxNodeType.VariableTypeDeclaration,
                                                  "Variable Type Declaration Rule") {}

      /// <summary>
      /// Parses this rule from the token stream.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent rule to link to.</param>
      /// <returns><c>true</c> if parsing was successful, <c>false</c> otherwise.</returns>
      // ReSharper disable once MethodTooLong
      public virtual bool Parse(TokenStream<AlToken> tokens, AlParser context, AlParserRule parentRule)
      {
         try
         {
            Enter(context);
            var token = tokens.Current;
            parentRule.AddChildNode(this);
            var parsed = true;
            var isArray = false;
            object? varType = null;

            if (token.TokenType == (int)TokenType.Identifier && token.Value == "array")
               isArray = true;
            else if (token.TokenType != (int)TokenType.Identifier ||
                     !Enum.TryParse(typeof(VariableType), token.Value, true, out varType))
            {
               var errorMessage = $"Expected a valid AL data type, but instead encountered: {token.Value}";
               context.GenerateParserError(token, token, errorMessage);
               AddChildNode(new ErrorNode(errorMessage, token));

               return false;
            }

            if (isArray)
            {
               // Parse an array declaration e.g. array[5] of text[20]
               if (!new ArrayDeclarationRule().Parse(tokens, context, this))
                  parsed = false;
            }
            else
               switch (varType)
               {
                  case VariableType.BigInteger:
                  case VariableType.BigText:
                  case VariableType.Blob:
                  case VariableType.Boolean:
                  case VariableType.Byte:
                  case VariableType.Char:
                  case VariableType.CompanyProperty:
                  case VariableType.Database:
                  case VariableType.DataTransfer:
                  case VariableType.Date:
                  case VariableType.DateFormula:
                  case VariableType.DateTime:
                  case VariableType.Debugger:
                  case VariableType.Decimal:
                  case VariableType.Dialog:
                  case VariableType.Duration:
                  case VariableType.ErrorInfo:
                  case VariableType.FieldRef:
                  case VariableType.File:
                  case VariableType.FilterPageBuilder:
                  case VariableType.Guid:
                  case VariableType.HttpClient:
                  case VariableType.HttpHeaders:
                  case VariableType.HttpRequestMessage:
                  case VariableType.HttpResponseMessage:
                  case VariableType.InStream:
                  case VariableType.Integer:
                  case VariableType.IsolatedStorage:
                  case VariableType.JsonArray:
                  case VariableType.JsonObject:
                  case VariableType.JsonToken:
                  case VariableType.JsonValue:
                  case VariableType.KeyRef:
                  case VariableType.Media:
                  case VariableType.MediaSet:
                  case VariableType.ModuleDependencyInfo:
                  case VariableType.ModuleInfo:
                  case VariableType.NavApp:
                  case VariableType.None:
                  case VariableType.Notification:
                  case VariableType.NumberSequence:
                  case VariableType.OutStream:
                  case VariableType.ProductName:
                  case VariableType.RecordId:
                  case VariableType.RecordRef:
                  case VariableType.RequestPage:
                  case VariableType.SecretText:
                  case VariableType.Session:
                  case VariableType.SessionInformation:
                  case VariableType.SessionSettings:
                  case VariableType.System:
                  case VariableType.TaskScheduler:
                  case VariableType.TestAction:
                  case VariableType.TestField:
                  case VariableType.TestFilterField:
                  case VariableType.TestPage:
                  case VariableType.TestPart:
                  case VariableType.TestPageRequest:
                  case VariableType.TextBuilder:
                  case VariableType.TextConst:
                  case VariableType.Time:
                  case VariableType.Variant:
                  case VariableType.Version:
                  case VariableType.WebServiceActionContext:
                  case VariableType.XmlAttribute:
                  case VariableType.XmlAttributeCollection:
                  case VariableType.XmlCData:
                  case VariableType.XmlDeclaration:
                  case VariableType.XmlDocument:
                  case VariableType.XmlDocumentType:
                  case VariableType.XmlElement:
                  case VariableType.XmlNamespaceManager:
                  case VariableType.XmlNameTable:
                  case VariableType.XmlNode:
                  case VariableType.XmlNodeList:
                  case VariableType.Xmlport:
                  case VariableType.XmlProcessingInstruction:
                  case VariableType.XmlReadOptions:
                  case VariableType.XmlText:
                  case VariableType.XmlWriteOptions:
                  case VariableType.Action:
                  case VariableType.AuditCategory:
                  case VariableType.ClientType:
                  case VariableType.CommitBehavior:
                  case VariableType.DataClassification:
                  case VariableType.DataScope:
                  case VariableType.DefaultLayout:
                  case VariableType.ErrorBehavior:
                  case VariableType.ErrorType:
                  case VariableType.ExecutionContext:
                  case VariableType.ExecutionMode:
                  case VariableType.FieldClass:
                  case VariableType.FieldType:
                  case VariableType.InherentPermissionsScope:
                  case VariableType.IsolationLevel:
                  case VariableType.NotificationScope:
                  case VariableType.ObjectType:
                  case VariableType.PageBackgroundTaskErrorLevel:
                  case VariableType.PermissionObjectType:
                  case VariableType.ReportFormat:
                  case VariableType.ReportLayoutType:
                  case VariableType.SecurityFilter:
                  case VariableType.SecurityOperationResult:
                  case VariableType.TableConnectionType:
                  case VariableType.TelemetryScope:
                  case VariableType.TestPermissions:
                  case VariableType.TextEncoding:
                  case VariableType.TransactionModel:
                  case VariableType.TransactionType:
                  case VariableType.Verbosity:
                  case VariableType.WebServiceActionResultCode:
                  {
                     // we have nothing extra to do, these variable types have no extra declaration
                     new IdentifierRule(token).Parse(tokens, context, this);
                     break;
                  }
                  case VariableType.Text:
                  {
                     return ParseTextVariable(tokens, context, token);
                  }
                  case VariableType.Code:
                  {
                     return ParseCodeVariable(tokens, context, token);
                  }
                  case VariableType.Record:
                  case VariableType.Codeunit:
                  case VariableType.Enum:
                  case VariableType.Page:
                  case VariableType.Query:
                  case VariableType.Report:
                  {
                     return ParseObjectVariable(tokens, context, token);
                  }
                  case VariableType.Option:
                  {
                     return ParseOptionVariable(tokens, context, token);
                  }
                  case VariableType.Dictionary:
                  {
                     parsed = new DictionaryDeclarationRule().Parse(tokens, context, this);
                     break;
                  }
                  case VariableType.List:
                  {
                     parsed = new ListDeclarationRule().Parse(tokens, context, this);
                     break;
                  }
                  case VariableType.DotNet:
                  {
                     break;
                  }
                  case VariableType.Label:
                  {
                     break;
                  }
                  default:
                     return false;
               }

            return parsed;
         }
         finally
         {
            Exit(context);
         }
      }

      private bool ParseOptionVariable(TokenStream<AlToken> tokens, AlParser context, AlToken token)
      {
         new IdentifierRule(token).Parse(tokens, context, this);
         if (!tokens.TryMoveNext(ref token!))
            return false;

         // parse an option value declaration e.g. foo,bar,bah
         var result = new OptionValuesDeclarationRule().Parse(tokens, context, this);
         if (!result)
            return false;

         return true;
      }

      private bool ParseObjectVariable(TokenStream<AlToken> tokens, AlParser context, AlToken token)
      {
         new IdentifierRule(token).Parse(tokens, context, this);
         if (!tokens.TryMoveNext(ref token!))
            return false;

         // Parse an object declaration e.g. 20 or "Customer"
         var result = new ObjectReferenceDeclarationRule().Parse(tokens, context, this);
         if (!result)
            return false;

         return true;
      }

      private bool ParseTextVariable(TokenStream<AlToken> tokens, AlParser context, AlToken token)
      {
         // Parse a text declaration e.g. text[20]
         new IdentifierRule(token).Parse(tokens, context, this);

         // parse the length declaration portion if it exists e.g. [20]
         // text variables do not require a length declaration
         if (tokens.Next()?.Value == "[")
         {
            if (!tokens.TryMoveNext(ref token!))
               return false;

            if (!new LengthDeclarationRule().Parse(tokens, context, this))
               return false;
         }

         return true;
      }

      private bool ParseCodeVariable(TokenStream<AlToken> tokens, AlParser context, AlToken token)
      {
         // Parse a code declaration e.g. code[20]
         new IdentifierRule(token).Parse(tokens, context, this);
         if (!tokens.TryMoveNext(ref token!))
            return false;

         // parse the length declaration portion e.g. [20]
         if (!new LengthDeclarationRule().Parse(tokens, context, this))
            return false;

         return true;
      }
   }
}