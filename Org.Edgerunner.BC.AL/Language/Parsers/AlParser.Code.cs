#region MIT License
// <copyright company = "Edgerunner.org" file = "AlParser.Code.cs">
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

using System.Security.Authentication.ExtendedProtection;
using Org.Edgerunner.BC.AL.Language.Aspects;
using Org.Edgerunner.BC.AL.Objects.Code;
using Org.Edgerunner.Language.Lexers;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules;
using Org.Edgerunner.BC.AL.Language.Parsers.Rules.Terminals;
using Org.Edgerunner.BC.AL.Language.Tokens;

namespace Org.Edgerunner.BC.AL.Language.Parsers
{
   public partial class AlParser
   {
      /// <summary>
      /// Parses an AL length declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [ParserRule(AlSyntaxNodeType.LengthDeclaration)]
      public AlParserRule ParseLengthDeclaration(TokenStream<AlToken> tokens)
      {
         var token = tokens.Current;
         var parsed = true;
         var newRule = new AlParserRule(AlSyntaxNodeType.LengthDeclaration);
         parentRule.AddChildNode(newRule);

         var message = string.Format(Resources.ExpectedSymbol, "'['", token.Value);
         if (ValidateToken(token, context, newRule, TokenType.Symbol, "[", message))
         {
            if (!tokens.TryMoveNext(ref token))
               return false;
         }
         else
            parsed = false;

         if (ParseIntegerLiteral(tokens, context, newRule))
         {
            if (!tokens.TryMoveNext(ref token))
               return false;
         }
         else
            parsed = false;

         token = tokens.Current;
         var last = token;
         message = string.Format(Resources.ExpectedSymbol, "']'", token.Value);
         if (!ValidateToken(token, context, newRule, TokenType.Symbol, "]", message))
            parsed = false;

         return parsed;
      }

      /// <summary>
      /// Parses an AL array dimensions declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [ParserRule(AlSyntaxNodeType.DimensionsDeclaration)]
      public bool ParseDimensionsDeclaration(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var parsed = true;
         var newRule = new AlParserRule(AlSyntaxNodeType.DimensionsDeclaration);
         parentRule.AddChildNode(newRule);

         var message = string.Format(Resources.ExpectedSymbol, "'['", token.Value);
         if (ValidateToken(token, context, newRule, TokenType.Symbol, "[", message))
         {
            if (!tokens.TryMoveNext(ref token))
               return false;
         }
         else
            parsed = false;

         if (ParseIntegerLiteral(tokens, context, newRule))
         {
            if (!tokens.TryMoveNext(ref token))
               return false;
            
            if (!ParseRepeatingDelimitedExpression(tokens, context, newRule, ",", "]", ParseIntegerLiteral))
               parsed = false;
         }
         else
            parsed = false;

         token = tokens.Current;
         message = string.Format(Resources.ExpectedSymbol, "']'", token.Value);
         if (!ValidateToken(token, context, newRule, TokenType.Symbol, "]", message))
            parsed = false;

         return parsed;
      }

      /// <summary>
      /// Parses an AL object declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [ParserRule(AlSyntaxNodeType.ObjectReferenceDeclaration)]
      public bool ParseVariableObjectDeclaration(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var newRule = new AlParserRule(AlSyntaxNodeType.ObjectReferenceDeclaration);
         parentRule.AddChildNode(newRule);

         var errorMessage = $"Expected an object number or name identifier, instead encountered ${token.Value}";

         // Look for an object integer number
         var parsed = token.TokenType == (int)TokenType.Literal && token is LiteralToken { LiteralType: LiteralType.Integer };
         if (parsed)
            parsed = ParseIntegerLiteral(tokens, context, newRule);
         else if (token.TokenType == (int)TokenType.Identifier)
            // if we didn't have a number, but instead an identifier, then we are still good
            parsed = ParseIdentifierLiteral(tokens, context, newRule);
         else
         {
            GenerateParserError(token, token, errorMessage);
            newRule.AddChildNode(new ErrorNode(errorMessage, token));
            parsed = false;
         }

         return parsed;
      }

      /// <summary>
      /// Parses an AL array variable declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [ParserRule(AlSyntaxNodeType.ArrayDeclaration)]
      public bool ParseArrayDeclaration(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var newRule = new AlParserRule(AlSyntaxNodeType.ArrayDeclaration);
         parentRule.AddChildNode(newRule);

         ParseIdentifierLiteral(tokens, context, newRule);
         if (!tokens.TryMoveNext(ref token))
            return false;
         
         // look for length declaration
         var parsed = ParseDimensionsDeclaration(tokens, context, newRule);
         if (parsed && !tokens.TryMoveNext(ref token)) return false;

         // Look for identifier
         parsed = ParseIdentifierLiteral(tokens, context, newRule, "of");
         if (parsed && !tokens.TryMoveNext(ref token)) return false;

         // Now parse our array sub type declaration
         parsed = ParseVariableTypeDeclaration(tokens, context, newRule);

         return parsed;
      }

      /// <summary>
      /// Parses an AL option values declaration.
      /// </summary>
      /// <param name="tokens">The tokens to read.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns><c>true</c> if parsing succeeds, <c>false</c> otherwise.</returns>
      [ParserRule(AlSyntaxNodeType.OptionValuesDeclaration)]
      public bool ParseOptionValuesDeclaration(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var parsed = true;
         var token = tokens.Current;
         var newRule = new AlParserRule(AlSyntaxNodeType.OptionValuesDeclaration);
         parentRule.AddChildNode(newRule);

         var allowed = new[] { ",", ";" };
         var message = string.Format(Resources.ExpectedSymbol, "',' or ';'", token.Value);
         while (token!.TokenType != (int)TokenType.Symbol || token.Value != ";")
         {
            // read values
            bool noMatch = false;

            // check if we have a semi-colon
            var tokenValidates = ValidateToken(token, context, newRule, TokenType.Symbol, ",", message);
            if (tokenValidates)
            {
               var node = new AlTerminalNode(AlSyntaxNodeType.Symbol, token);
               newRule.AddChildNode(node);

               if (!tokens.TryMoveNext(ref token))
                  return false;
            }
            else
               noMatch = true;

            // check if we have an identifier
            tokenValidates = ValidateToken(token, context, newRule, TokenType.Identifier, string.Format(Resources.ExpectedOptionValue, token.Value));
            if (tokenValidates)
            {
               var node = new AlTerminalNode(AlSyntaxNodeType.Identifier, token);
               newRule.AddChildNode(node);

               if (!tokens.TryMoveNext(ref token))
                  return false;
               noMatch = false;
            }

            // If we matched neither, move the token stream position forward and keep trying to match
            if (noMatch)
            {
               // We have reached the end of the token stream, so we bail out
               if (tokens.Position == tokens.Size - 1)
                  break;

               // The next token is a semi-colon, so we are done parsing option values
               if (tokens.Next()?.TokenType == (int)TokenType.Symbol && tokens.Next()?.Value == ";")
                  break;

               if (!tokens.TryMoveNext(ref token))
                  return false;
            }
         }

         return parsed;
      }

      /// <summary>
      /// Parses the variable type declaration.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns>bool.</returns>
      [ParserRule(AlSyntaxNodeType.VariableTypeDeclaration)]
      public bool ParseVariableTypeDeclaration(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var token = tokens.Current;
         var newRule = new AlParserRule(AlSyntaxNodeType.VariableTypeDeclaration);
         parentRule.AddChildNode(newRule);
         string errorMessage;
         var parsed = true;
         var isArray = false;
         object? varType = null;

         if (token.TokenType == (int)TokenType.Identifier && token.Value == "array")
            isArray = true;
         else if (token.TokenType != (int)TokenType.Identifier ||
                  !Enum.TryParse(typeof(VariableType), token.Value, true, out varType))
         {
            errorMessage = $"Expected a valid AL data type, but instead encountered: {token.Value}";
            GenerateParserError(token, token, errorMessage);
            newRule.AddChildNode(new ErrorNode(errorMessage, token));

            return false;
         }

         if (isArray)
         {
            // Parse an array declaration e.g. array[5] of text[20]
            if (!ParseArrayDeclaration(tokens, context, newRule))
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
                     ParseIdentifierLiteral(tokens, context, newRule);
                     if (!tokens.TryMoveNext(ref token))
                        return false;
                     break;
                  }
               case VariableType.Code:
               case VariableType.Text:
                  {
                     // Parse a length declaration e.g. [20]
                     ParseIdentifierLiteral(tokens, context, newRule);
                     if (!tokens.TryMoveNext(ref token))
                        return false;
                     var result = ParseLengthDeclaration(tokens, context, newRule);
                     if (result)
                     {
                        if (!tokens.TryMoveNext(ref token))
                           return false;
                     }
                     else
                        parsed = false;
                     break;
                  }
               case VariableType.Record:
               case VariableType.Codeunit:
               case VariableType.Enum:
               case VariableType.Page:
               case VariableType.Query:
               case VariableType.Report:
                  {
                     ParseIdentifierLiteral(tokens, context, newRule);
                     if (!tokens.TryMoveNext(ref token))
                        return false;

                     // Parse an object declaration e.g. 20 or "Customer"
                     var result = ParseVariableObjectDeclaration(tokens, context, newRule);
                     if (!result)
                        parsed = false;
                     break;
                  }
               case VariableType.Option:
                  {
                     ParseIdentifierLiteral(tokens, context, newRule);
                     if (!tokens.TryMoveNext(ref token))
                        return false;

                     // parse an option value declaration e.g. foo,bar,bah
                     var result = ParseOptionValuesDeclaration(tokens, context, newRule);
                     if (!result)
                        parsed = false;
                     break;
                  }
               case VariableType.Dictionary:
                  {
                     break;
                  }
               case VariableType.List:
                  {
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

      /// <summary>
      /// Parses the variable declaration.
      /// </summary>
      /// <param name="tokens">The token stream.</param>
      /// <param name="context">The parser context.</param>
      /// <param name="parentRule">The parent parser rule.</param>
      /// <returns>bool.</returns>
      [ParserRule(AlSyntaxNodeType.VariableDeclaration)]
      public bool ParseVariableDeclaration(TokenStream<AlToken> tokens, AlParserContext context, AlParserRule parentRule)
      {
         var parsed = true;
         AlToken? token = null;
         var newRule = new AlParserRule(AlSyntaxNodeType.VariableDeclaration);
         parentRule.AddChildNode(newRule);

         if (ParseIdentifierLiteral(tokens, context, newRule))
         {
            if (!tokens.TryMoveNext(ref token))
               return false;
         }
         else
            parsed = false;

         if (ParseSymbol(tokens, context, newRule, ":"))
         {
            if (!tokens.TryMoveNext(ref token))
               return false;
         }
         else
            parsed = false;

         if (!ParseVariableTypeDeclaration(tokens, context, newRule))
            parsed = false;

         if (tokens.Current.TokenType != (int)TokenType.Symbol || tokens.Current.Value != ";")
            ScanTillSymbolReached(tokens, new[] { ";", "}" });

         var node = new AlTerminalNode(AlSyntaxNodeType.Symbol, tokens.Current);
         newRule.AddChildNode(node);

         if (!tokens.EndOfStream())
            tokens.MoveNext();

         return parsed;
      }
   }
}