#region MIT License
// <copyright company = "Edgerunner.org" file = "VariableType.cs">
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

namespace Org.Edgerunner.BC.AL.Objects.Code
{
   /// <summary>
   /// Enum that defines AL variable types.
   /// </summary>
   public enum VariableType
   {
      Any,
      BigInteger,
      BigText,
      Blob,
      Boolean,
      Byte,
      Char,
      Code,
      Codeunit,
      CompanyProperty,
      Database,
      DataTransfer,
      Date,
      DateFormula,
      DateTime,
      Debugger,
      Decimal,
      Dialog,
      Dictionary,
      DotNet,
      Duration,
      Enum,
      ErrorInfo,
      FieldRef,
      File,
      FilterPageBuilder,
      Guid,
      HttpClient,
      HttpHeaders,
      HttpRequestMessage,
      HttpResponseMessage,
      InStream,
      Integer,
      IsolatedStorage,
      JsonArray,
      JsonObject,
      JsonToken,
      JsonValue,
      KeyRef,
      Label,
      List,
      Media,
      MediaSet,
      ModuleDependencyInfo,
      ModuleInfo,
      NavApp,
      None,
      Notification,
      NumberSequence,
      Option,
      OutStream,
      Page,
      ProductName,
      Query,
      Record,
      RecordId,
      RecordRef,
      Report,
      RequestPage,
      SecretText,
      Session,
      SessionInformation,
      SessionSettings,
      System,
      TaskScheduler,
      TestAction,
      TestField,
      TestFilterField,
      TestPage,
      TestPart,
      TestPageRequest,
      Text,
      TextBuilder,
      TextConst,
      Time,
      Variant,
      Version,
      WebServiceActionContext,
      XmlAttribute,
      XmlAttributeCollection,
      XmlCData,
      XmlDeclaration,
      XmlDocument,
      XmlDocumentType,
      XmlElement,
      XmlNamespaceManager,
      XmlNameTable,
      XmlNode,
      XmlNodeList,
      Xmlport,
      XmlProcessingInstruction,
      XmlReadOptions,
      XmlText,
      XmlWriteOptions,
      Action,
      AuditCategory,
      ClientType,
      CommitBehavior,
      DataClassification,
      DataScope,
      DefaultLayout,
      ErrorBehavior,
      ErrorType,
      ExecutionContext,
      ExecutionMode,
      FieldClass,
      FieldType,
      InherentPermissionsScope,
      IsolationLevel,
      NotificationScope,
      ObjectType,
      PageBackgroundTaskErrorLevel,
      PermissionObjectType,
      ReportFormat,
      ReportLayoutType,
      SecurityFilter,
      SecurityOperationResult,
      TableConnectionType,
      TelemetryScope,
      TestPermissions,
      TextEncoding,
      TransactionModel,
      TransactionType,
      Verbosity,
      WebServiceActionResultCode
   }
}