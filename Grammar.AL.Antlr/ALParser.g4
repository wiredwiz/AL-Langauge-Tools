parser grammar ALParser;

options { tokenVocab=ALLexer; }

@parser::members 
{  // define our member text lists
   List<string> Builtins = new List<string>() 
      {
         "action", "array", "automation", "biginteger", "bigtext", "blob", "boolean", "byte", 
         "char", "clienttype", "code", "codeunit", "completiontriggererrorlevel", "connectiontype", 
         "database", "dataclassification", "datascope", "date", "dateformula", "datetime", "decimal", 
         "defaultlayout", "dialog", "dictionary", "dotnet", "dotnetassembly", "dotnettypedeclaration", 
         "duration", "enum", "errorinfo", "errortype", "executioncontext", "executionmode", "fieldclass", 
         "fieldref", "fieldtype", "file", "filterpagebuilder", "guid", "instream", "integer", "joker", 
         "keyref", "list", "moduledependencyinfo", "moduleinfo", "none", "notification", 
         "notificationscope", "objecttype", "option", "outstream", "page", "pageresult", "query", 
         "record", "recordid", "recordref", "report", "reportformat", "securityfilter", "securityfiltering", 
         "table", "tableconnectiontype", "tablefilter", "testaction", "testfield", "testfilterfield", 
         "testpage", "testpermissions", "testrequestpage", "text", "textbuilder", "textconst", "textencoding", 
         "time", "transactionmodel", "transactiontype", "variant", "verbosity", "version", "xmlport", 
         "httpcontent", "httpheaders", "httpclient", "httprequestmessage", "httpresponsemessage", 
         "jsontoken", "jsonvalue", "jsonarray", "jsonobject", "view", "views", "xmlattribute", 
         "xmlattributecollection", "xmlcomment", "xmlcdata", "xmldeclaration", "xmldocument", 
         "xmldocumenttype", "xmlelement", "xmlnamespacemanager", "xmlnametable", "xmlnode", 
         "xmlnodelist", "xmlprocessinginstruction", "xmlreadoptions", "xmltext", "xmlwriteoptions", 
         "webserviceactioncontext", "webserviceactionresultcode", "sessionsettings;"
      };

      List<string> VariableTypes = new List<string>() 
      {
         "any", "biginteger", "bigtext", "blob", "boolean", "byte", "char", "code", 
         "codeunit", "companyproperty", "database", "datatransfer", "date", "dateformula", 
         "datetime", "debugger", "decimal", "dialog", "dictionary", "dotnet", "duration", 
         "enum", "errorinfo", "fieldref", "file", "filterpagebuilder", "guid", "httpclient", 
         "httpcontent", "httpheaders", "httprequestmessage", "httpresponsemessage", 
         "instream", "integer", "isolatedstorage", "jsonarray", "jsonobject", "jsontoken", "jsonvalue", 
         "keyref", "label", "list", "media", "mediaset", "moduledependencyinfo", "moduleinfo", 
         "navapp", "none", "notification", "numbersequence", "option", "outstream", "page", "productname", "query", 
         "record", "recordid", "recordref", "report", "requestpage", "session", "sessioninformation", 
         "sessionsettings", "system", "taskscheduler", "testaction", "testfield", 
         "testfilter", "testfilterfield", "testpage", "testpart", "testrequestpage", "text", 
         "textbuilder", "textconst", "time", "variant", "version", "webserviceactioncontext", 
         "xmlattribute", "xmlattributecollection", "xmlcdata", "xmlcomment", "xmldeclaration", 
         "xmldocument", "xmldocumenttype", "xmlelement", "xmlnamespacemanager", "xmlnametable", 
         "xmlnode", "xmlnodelist", "xmlport", "xmlprocessinginstruction", "xmlreadoptions", "xmltext", 
         "xmlwriteoptions", "action", "auditcategory", "clienttype", "commitbehavior", "dataclassification", 
         "datascope", "defaultlayout", "errorbehavior", "errortype", "executioncontext", "executionmode", 
         "fieldclass", "fieldtype", "inherentpermissionsscope", "isolationlevel", "notificationscope", 
         "objecttype", "pagebackgroundtaskerrorlevel", "permissionobjecttype", "reportformat", "reportlayouttype", 
         "securityfilter", "securityoperationresult", "tableconnectiontype", "telemetryscope", "testpermissions", 
         "textencoding", "transactionmodel", "transactiontype", "verbosity", "webserviceactionresultcode"
      };
}

compileUnit
	: EOF
   | statement EOF
	;

comment
   : IDENTIFIER
   ;

maxLength
   : IDENTIFIER
   ;

locked
   : IDENTIFIER
   ;

any
   : {_input.Lt(1).Text.ToLowerInvariant() == "any"}? IDENTIFIER
   ;

bigInteger
   : {_input.Lt(1).Text.ToLowerInvariant() == "biginteger"}? IDENTIFIER
   ;

bigText
   : {_input.Lt(1).Text.ToLowerInvariant() == "bigtext"}? IDENTIFIER
   ;

blob
   : {_input.Lt(1).Text.ToLowerInvariant() == "blob"}? IDENTIFIER
   ;

boolean
   : {_input.Lt(1).Text.ToLowerInvariant() == "boolean"}? IDENTIFIER
   ;

byte
   : {_input.Lt(1).Text.ToLowerInvariant() == "byte"}? IDENTIFIER
   ;

char
   : {_input.Lt(1).Text.ToLowerInvariant() == "char"}? IDENTIFIER
   ;

code
   : {_input.Lt(1).Text.ToLowerInvariant() == "code"}? IDENTIFIER
   ;

codeunit
   : {_input.Lt(1).Text.ToLowerInvariant() == "codeunit"}? IDENTIFIER
   ;

companyProperty
   : {_input.Lt(1).Text.ToLowerInvariant() == "companyproperty"}? IDENTIFIER
   ;

database
   : {_input.Lt(1).Text.ToLowerInvariant() == "database"}? IDENTIFIER
   ;

dataTransfer
   : {_input.Lt(1).Text.ToLowerInvariant() == "datatransfer"}? IDENTIFIER
   ;

date
   : {_input.Lt(1).Text.ToLowerInvariant() == "date"}? IDENTIFIER
   ;

dateFormula
   : {_input.Lt(1).Text.ToLowerInvariant() == "dateformula"}? IDENTIFIER
   ;

datetime
   : {_input.Lt(1).Text.ToLowerInvariant() == "datetime"}? IDENTIFIER
   ;

debugger
   : {_input.Lt(1).Text.ToLowerInvariant() == "debugger"}? IDENTIFIER
   ;

decimal
   : {_input.Lt(1).Text.ToLowerInvariant() == "decimal"}? IDENTIFIER
   ;

dialog
   : {_input.Lt(1).Text.ToLowerInvariant() == "dialog"}? IDENTIFIER
   ;

dictionary
   : {_input.Lt(1).Text.ToLowerInvariant() == "dictionary"}? IDENTIFIER
   ;

dotnet
   : {_input.Lt(1).Text.ToLowerInvariant() == "dotnet"}? IDENTIFIER
   ;

duration
   : {_input.Lt(1).Text.ToLowerInvariant() == "duration"}? IDENTIFIER
   ;

enum
   : {_input.Lt(1).Text.ToLowerInvariant() == "enum"}? IDENTIFIER
   ;

errorInfo
   : {_input.Lt(1).Text.ToLowerInvariant() == "errorinfo"}? IDENTIFIER
   ;

fieldRef
   : {_input.Lt(1).Text.ToLowerInvariant() == "fieldref"}? IDENTIFIER
   ;

file
   : {_input.Lt(1).Text.ToLowerInvariant() == "file"}? IDENTIFIER
   ;

filterPageBuilder
   : {_input.Lt(1).Text.ToLowerInvariant() == "filterpagebuilder"}? IDENTIFIER
   ;

guid
   : {_input.Lt(1).Text.ToLowerInvariant() == "guid"}? IDENTIFIER
   ;

httpClient
   : {_input.Lt(1).Text.ToLowerInvariant() == "httpclient"}? IDENTIFIER
   ;

httpContent
   : {_input.Lt(1).Text.ToLowerInvariant() == "httpcontent"}? IDENTIFIER
   ;

httpHeaders
   : {_input.Lt(1).Text.ToLowerInvariant() == "httpheaders"}? IDENTIFIER
   ;

httpRequestMessage
   : {_input.Lt(1).Text.ToLowerInvariant() == "httprequestmessage"}? IDENTIFIER
   ;

httpResponseMessage
   : {_input.Lt(1).Text.ToLowerInvariant() == "httpresponsemessage"}? IDENTIFIER
   ;

inStream
   : {_input.Lt(1).Text.ToLowerInvariant() == "instream"}? IDENTIFIER
   ;

integer
   : {_input.Lt(1).Text.ToLowerInvariant() == "integer"}? IDENTIFIER
   ;

isolatedStorage
   : {_input.Lt(1).Text.ToLowerInvariant() == "isolatedstorage"}? IDENTIFIER
   ;

jsonArray
   : {_input.Lt(1).Text.ToLowerInvariant() == "jsonarray"}? IDENTIFIER
   ;

jsonObject
   : {_input.Lt(1).Text.ToLowerInvariant() == "jsonobject"}? IDENTIFIER
   ;

jsonToken
   : {_input.Lt(1).Text.ToLowerInvariant() == "jsontoken"}? IDENTIFIER
   ;

jsonValue
   : {_input.Lt(1).Text.ToLowerInvariant() == "jsonvalue"}? IDENTIFIER
   ;

keyRef
   : {_input.Lt(1).Text.ToLowerInvariant() == "keyref"}? IDENTIFIER
   ;

label
   : {_input.Lt(1).Text.ToLowerInvariant() == "label"}? IDENTIFIER
   ;

list
   : {_input.Lt(1).Text.ToLowerInvariant() == "list"}? IDENTIFIER
   ;

media
   : {_input.Lt(1).Text.ToLowerInvariant() == "media"}? IDENTIFIER
   ;

mediaSet
   : {_input.Lt(1).Text.ToLowerInvariant() == "mediaset"}? IDENTIFIER
   ;

moduleDependencyInfo
   : {_input.Lt(1).Text.ToLowerInvariant() == "moduledependencyinfo"}? IDENTIFIER
   ;

moduleInfo
   : {_input.Lt(1).Text.ToLowerInvariant() == "moduleinfo"}? IDENTIFIER
   ;

navApp
   : {_input.Lt(1).Text.ToLowerInvariant() == "navapp"}? IDENTIFIER
   ;

none
   : {_input.Lt(1).Text.ToLowerInvariant() == "none"}? IDENTIFIER
   ;

notification
   : {_input.Lt(1).Text.ToLowerInvariant() == "notification"}? IDENTIFIER
   ;

numberSequence
   : {_input.Lt(1).Text.ToLowerInvariant() == "numbersequence"}? IDENTIFIER
   ;

option
   : {_input.Lt(1).Text.ToLowerInvariant() == "option"}? IDENTIFIER
   ;

outStream
   : {_input.Lt(1).Text.ToLowerInvariant() == "outstream"}? IDENTIFIER
   ;

page
   : {_input.Lt(1).Text.ToLowerInvariant() == "page"}? IDENTIFIER
   ;

productName
   : {_input.Lt(1).Text.ToLowerInvariant() == "productname"}? IDENTIFIER
   ;

query
   : {_input.Lt(1).Text.ToLowerInvariant() == "query"}? IDENTIFIER
   ;

record
   : {_input.Lt(1).Text.ToLowerInvariant() == "record"}? IDENTIFIER
   ;

recordId
   : {_input.Lt(1).Text.ToLowerInvariant() == "recordid"}? IDENTIFIER
   ;

recordRef
   : {_input.Lt(1).Text.ToLowerInvariant() == "recordref"}? IDENTIFIER
   ;

report
   : {_input.Lt(1).Text.ToLowerInvariant() == "report"}? IDENTIFIER
   ;

requestPage
   : {_input.Lt(1).Text.ToLowerInvariant() == "requestpage"}? IDENTIFIER
   ;

session
   : {_input.Lt(1).Text.ToLowerInvariant() == "session"}? IDENTIFIER
   ;

sessionInformation
   : {_input.Lt(1).Text.ToLowerInvariant() == "sessioninformation"}? IDENTIFIER
   ;

sessionSettings
   : {_input.Lt(1).Text.ToLowerInvariant() == "sessionsettings"}? IDENTIFIER
   ;

system
   : {_input.Lt(1).Text.ToLowerInvariant() == "system"}? IDENTIFIER
   ;

taskScheduler
   : {_input.Lt(1).Text.ToLowerInvariant() == "taskscheduler"}? IDENTIFIER
   ;

temporary
   : {_input.Lt(1).Text.ToLowerInvariant() == "temporary"}? IDENTIFIER
   ;

testAction
   : {_input.Lt(1).Text.ToLowerInvariant() == "testaction"}? IDENTIFIER
   ;

testField
   : {_input.Lt(1).Text.ToLowerInvariant() == "testfield"}? IDENTIFIER
   ;

testFilter
   : {_input.Lt(1).Text.ToLowerInvariant() == "testfilter"}? IDENTIFIER
   ;

testFilterField
   : {_input.Lt(1).Text.ToLowerInvariant() == "testfilterfield"}? IDENTIFIER
   ;

testPage
   : {_input.Lt(1).Text.ToLowerInvariant() == "testpage"}? IDENTIFIER
   ;

testPart
   : {_input.Lt(1).Text.ToLowerInvariant() == "testpart"}? IDENTIFIER
   ;

testRequestPage
   : {_input.Lt(1).Text.ToLowerInvariant() == "testrequestpage"}? IDENTIFIER
   ;

text
   : {_input.Lt(1).Text.ToLowerInvariant() == "text"}? IDENTIFIER
   ;

textBuilder
   : {_input.Lt(1).Text.ToLowerInvariant() == "textbuilder"}? IDENTIFIER
   ;

textConst
   : {_input.Lt(1).Text.ToLowerInvariant() == "textconst"}? IDENTIFIER
   ;

time
   : {_input.Lt(1).Text.ToLowerInvariant() == "time"}? IDENTIFIER
   ;

variant
   : {_input.Lt(1).Text.ToLowerInvariant() == "variant"}? IDENTIFIER
   ;

version
   : {_input.Lt(1).Text.ToLowerInvariant() == "version"}? IDENTIFIER
   ;

webServiceActionContext
   : {_input.Lt(1).Text.ToLowerInvariant() == "webserviceactioncontext"}? IDENTIFIER
   ;

xmlAttribute
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlattribute"}? IDENTIFIER
   ;

xmlAttributeCollection
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlattributecollection"}? IDENTIFIER
   ;

xmlCdata
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlcdata"}? IDENTIFIER
   ;

xmlComment
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlcomment"}? IDENTIFIER
   ;

xmlDeclaration
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmldeclaration"}? IDENTIFIER
   ;

xmlDocument
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmldocument"}? IDENTIFIER
   ;

xmlDocumentType
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmldocumenttype"}? IDENTIFIER
   ;

xmlElement
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlelement"}? IDENTIFIER
   ;

xmlNamespaceManager
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlnamespacemanager"}? IDENTIFIER
   ;

xmlNameTable
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlnametable"}? IDENTIFIER
   ;

xmlNode
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlnode"}? IDENTIFIER
   ;

xmlNodeList
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlnodelist"}? IDENTIFIER
   ;

xmlport
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlport"}? IDENTIFIER
   ;

xmlProcessingInstruction
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlprocessinginstruction"}? IDENTIFIER
   ;

xmlReadOptions
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlreadoptions"}? IDENTIFIER
   ;

xmlText
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmltext"}? IDENTIFIER
   ;

xmlWriteOptions
   : {_input.Lt(1).Text.ToLowerInvariant() == "xmlwriteoptions"}? IDENTIFIER
   ;

action
   : {_input.Lt(1).Text.ToLowerInvariant() == "action"}? IDENTIFIER
   ;

auditCategory
   : {_input.Lt(1).Text.ToLowerInvariant() == "auditcategory"}? IDENTIFIER
   ;

clientType
   : {_input.Lt(1).Text.ToLowerInvariant() == "clienttype"}? IDENTIFIER
   ;

commitBehavior
   : {_input.Lt(1).Text.ToLowerInvariant() == "commitbehavior"}? IDENTIFIER
   ;

dataClassification
   : {_input.Lt(1).Text.ToLowerInvariant() == "dataclassification"}? IDENTIFIER
   ;

dataScope
   : {_input.Lt(1).Text.ToLowerInvariant() == "datascope"}? IDENTIFIER
   ;

defaultLayout
   : {_input.Lt(1).Text.ToLowerInvariant() == "defaultlayout"}? IDENTIFIER
   ;

errorBehavior
   : {_input.Lt(1).Text.ToLowerInvariant() == "errorbehavior"}? IDENTIFIER
   ;

errorType
   : {_input.Lt(1).Text.ToLowerInvariant() == "errortype"}? IDENTIFIER
   ;

executionContext
   : {_input.Lt(1).Text.ToLowerInvariant() == "executioncontext"}? IDENTIFIER
   ;

executionMode
   : {_input.Lt(1).Text.ToLowerInvariant() == "executionmode"}? IDENTIFIER
   ;

fieldClass
   : {_input.Lt(1).Text.ToLowerInvariant() == "fieldclass"}? IDENTIFIER
   ;

fieldType
   : {_input.Lt(1).Text.ToLowerInvariant() == "fieldtype"}? IDENTIFIER
   ;

inherentPermissionsScope
   : {_input.Lt(1).Text.ToLowerInvariant() == "inherentpermissionsscope"}? IDENTIFIER
   ;

isolationLevel
   : {_input.Lt(1).Text.ToLowerInvariant() == "isolationlevel"}? IDENTIFIER
   ;

notificationScope
   : {_input.Lt(1).Text.ToLowerInvariant() == "notificationscope"}? IDENTIFIER
   ;

objectType
   : {_input.Lt(1).Text.ToLowerInvariant() == "objecttype"}? IDENTIFIER
   ;

pageBackgroundTaskErrorLevel
   : {_input.Lt(1).Text.ToLowerInvariant() == "pagebackgroundtaskerrorlevel"}? IDENTIFIER
   ;

permissionObjectType
   : {_input.Lt(1).Text.ToLowerInvariant() == "permissionobjecttype"}? IDENTIFIER
   ;

reportFormat
   : {_input.Lt(1).Text.ToLowerInvariant() == "reportformat"}? IDENTIFIER
   ;

reportLayoutType
   : {_input.Lt(1).Text.ToLowerInvariant() == "reportlayouttype"}? IDENTIFIER
   ;

securityFilter
   : {_input.Lt(1).Text.ToLowerInvariant() == "securityfilter"}? IDENTIFIER
   ;

securityOperationResult
   : {_input.Lt(1).Text.ToLowerInvariant() == "securityoperationresult"}? IDENTIFIER
   ;

tableConnectionType
   : {_input.Lt(1).Text.ToLowerInvariant() == "tableconnectiontype"}? IDENTIFIER
   ;

telemetryScope
   : {_input.Lt(1).Text.ToLowerInvariant() == "telemetryscope"}? IDENTIFIER
   ;

testPermissions
   : {_input.Lt(1).Text.ToLowerInvariant() == "testpermissions"}? IDENTIFIER
   ;

textEncoding
   : {_input.Lt(1).Text.ToLowerInvariant() == "textencoding"}? IDENTIFIER
   ;

transactionModel
   : {_input.Lt(1).Text.ToLowerInvariant() == "transactionmodel"}? IDENTIFIER
   ;

transactionType
   : {_input.Lt(1).Text.ToLowerInvariant() == "transactiontype"}? IDENTIFIER
   ;

verbosity
   : {_input.Lt(1).Text.ToLowerInvariant() == "verbosity"}? IDENTIFIER
   ;

webServiceActionResultCode
   : {_input.Lt(1).Text.ToLowerInvariant() == "webserviceactionresultcode"}? IDENTIFIER
   ;

/*
 * Type declarations
 */

sizeDeclaration : LEFTBRACKET INTEGER_LITERAL RIGHTBRACKET;

builtinType
   : IDENTIFIER;
   /*
   : ACTION | ARRAY | AUTOMATION | BIGINTEGER | BIGTEXT | BLOB | BOOLEAN | BYTE | CHAR | CLIENTTYPE | CODE 
   | CODEUNIT | COMPLETIONTRIGGERERRORLEVEL | CONNECTIONTYPE | DATABASE | DATACLASSIFICATION | DATASCOPE 
   | DATE | DATEFORMULA | DATETIME | DECIMAL | DEFAULTLAYOUT | DIALOG | DICTIONARY | DOTNET | DOTNETASSEMBLY 
   | DOTNETTYPEDECLARATION | DURATION | ENUM | ERRORINFO | ERRORTYPE | EXECUTIONCONTEXT | EXECUTIONMODE 
   | FIELDCLASS | FIELDREF | FIELDTYPE | FILE | FILTERPAGEBUILDER | GUID | INSTREAM | INTEGER | JOKER 
   | KEYREF | LIST | MODULEDEPENDENCYINFO | MODULEINFO | NONE | NOTIFICATION | NOTIFICATIONSCOPE | OBJECTTYPE 
   | OPTION | OUTSTREAM | PAGE | PAGERESULT | QUERY | RECORD | RECORDID | RECORDREF | REPORT | REPORTFORMAT 
   | SECURITYFILTER | SECURITYFILTERING | TABLE | TABLECONNECTIONTYPE | TABLEFILTER | TESTACTION | TESTFIELD 
   | TESTFILTERFIELD | TESTPAGE | TESTPERMISSIONS | TESTREQUESTPAGE | TEXT | TEXTBUILDER | TEXTCONST 
   | TEXTENCODING | TIME | TRANSACTIONMODEL | TRANSACTIONTYPE | VARIANT | VERBOSITY | VERSION | XMLPORT 
   | HTTPCONTENT | HTTPHEADERS | HTTPCLIENT | HTTPREQUESTMESSAGE | HTTPRESPONSEMESSAGE | JSONTOKEN 
   | JSONVALUE | JSONARRAY | JSONOBJECT | VIEW | VIEWS | XMLATTRIBUTE | XMLATTRIBUTECOLLECTION | XMLCOMMENT 
   | XMLCDATA | XMLDECLARATION | XMLDOCUMENT | XMLDOCUMENTTYPE | XMLELEMENT | XMLNAMESPACEMANAGER 
   | XMLNAMETABLE | XMLNODE | XMLNODELIST | XMLPROCESSINGINSTRUCTION | XMLREADOPTIONS | XMLTEXT 
   | XMLWRITEOPTIONS | WEBSERVICEACTIONCONTEXT | WEBSERVICEACTIONRESULTCODE | SESSIONSETTINGS;
*/

/*

applicationObjectType
   : CODEUNIT | PAGE | PAGEEXTENSION | PAGECUSTOMIZATION | DOTNET | ENUM | ENUMEXTENSION | VALUE | QUERY 
   | REPORT | TABLE | TABLEEXTENSION | XMLPORT | PROFILE | CONTROLADDIN | REPORTEXTENSION | INTERFACE 
   | PERMISSIONSET | PERMISSIONSETEXTENSION | ENTITLEMENT;
 */

/*
 * Field related rules
 */


/******************************************************

fieldValue
   : IDENTIFIER 
   | INTEGER_LITERAL 
   | FLOAT_LITERAL 
   | DATE_LITERAL 
   | TIME_LITERAL 
   | DATETIME_LITERAL 
   | STRING_LITERAL
   ;

comparisonFilter
   : (NOTEQUAL | EQUAL | LESSTHAN | GREATERTHAN | LESSTHANEQUAL | GREATERTHANEQUAL ) fieldValue
   ;

filterRule
   : (fieldValue | comparisonFilter)
   ;

compoundFilterRule
   : filterRule ((PIPE | AMPERSAND) filterRule)*?
   ;

tableReference
   : IDENTIFIER
   ;

fieldReference
   : IDENTIFIER
   ;

qualifiedFieldReference
   : tableReference PERIOD fieldReference
   ;

/*
 * Table relations
 * /

average
   : IDENTIFIER
   ;

const
   : IDENTIFIER
   ;

count
   : IDENTIFIER
   ;

exist
   : IDENTIFIER
   ;

field
   : IDENTIFIER
   ;

filter
   : IDENTIFIER
   ;

lookup
   : IDENTIFIER
   ;

max
   : IDENTIFIER
   ;

min
   : IDENTIFIER
   ;

upperLimit
   : IDENTIFIER
   ;

sum
   : IDENTIFIER
   ;

tableRelationFilter
   : IDENTIFIER EQUAL (field LEFTPAREN IDENTIFIER RIGHTPAREN | const LEFTPAREN (IDENTIFIER | DIGIT+) RIGHTPAREN)
   ;

tableRelationFilters
   : tableRelationFilter (COMMA tableRelationFilter)*?
   ;

where
   : IDENTIFIER
   ;

tableRelationWhereClause
   : where LEFTPAREN tableRelationFilters RIGHTPAREN
   ;

fieldRelationClause
   : (tableReference | qualifiedFieldReference) tableRelationWhereClause?
   ;

tableRelationIfCondition
   : IF LEFTPAREN tableRelationFilters RIGHTPAREN fieldRelationClause tableRelationElseCondition?
   ;

tableRelationElseCondition
   : ELSE tableRelationIfCondition
   ;

tableRelation
   : fieldRelationClause?
   | tableRelationIfCondition
   ;

/*
 * Flow fields
 * /

calcFormulaTableFilterValue
   : const LEFTPAREN fieldValue RIGHTPAREN
   | filter LEFTPAREN compoundFilterRule RIGHTPAREN
   | field LEFTPAREN IDENTIFIER RIGHTPAREN
   | field LEFTPAREN upperLimit LEFTPAREN IDENTIFIER RIGHTPAREN RIGHTPAREN
   | field LEFTPAREN filter LEFTPAREN IDENTIFIER RIGHTPAREN RIGHTPAREN
   | field LEFTPAREN upperLimit LEFTPAREN filter LEFTPAREN IDENTIFIER RIGHTPAREN RIGHTPAREN RIGHTPAREN
   ;

calcFormulaTableFilter
   : fieldReference EQUAL calcFormulaTableFilterValue
   ;

calcFormulaTableFilters
   : calcFormulaTableFilter (COMMA calcFormulaTableFilter)*?
   ;

calcFormulaWhereClause
   : where LEFTPAREN calcFormulaTableFilters RIGHTPAREN
   ;

calcFormulaExist
   : MINUS exist LEFTPAREN tableReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaCount
   : count LEFTPAREN tableReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaSum
   : MINUS sum LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaAverage
   : MINUS average LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;
   
calcFormulaMin
   : min LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaMax
   : max LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaLookup
   : lookup LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcForumla
   : calcFormulaExist
   | calcFormulaCount
   | calcFormulaSum
   | calcFormulaAverage
   | calcFormulaMin
   | calcFormulaMax
   | calcFormulaLookup
   ;

/*
 * Tables
 * /

tableFieldId : INTEGER_LITERAL;

tableFieldName : IDENTIFIER;

tableFieldType
   : INTEGER
   | BIGINTEGER
   | DECIMAL
   | BOOLEAN
   | BINARY
   | BLOB
   | CODE sizeDeclaration
   | TEXT sizeDeclaration
   | DATE
   | TIME
   | DATETIME
   | DATEFORMULA
   | DURATION
   | RECORDID
   | TABLEFILTER
   | OPTION
   | GUID
   ;



tableField
   : field LEFTPAREN tableFieldId SEMICOLON tableFieldName SEMICOLON tableFieldType RIGHTPAREN LEFTCBRACE RIGHTCBRACE;

/*
 * Method
 * /

method
   : methodAttribute*? PROCEDURE IDENTIFIER LEFTPAREN parameterList? RIGHTPAREN returnValue? varBlock? statementBlock;

/*
 * Method attributes
 * /

attributeArgument
   : IDENTIFIER COLON builtinType;

attributeArgumentList
   : attributeArgument (COMMA attributeArgument)*?;

methodAttribute
   : LEFTBRACKET IDENTIFIER (LEFTPAREN attributeArgumentList? RIGHTPAREN)? RIGHTBRACKET;

***************************************/

/*
 * Variables
 */

key
   : IDENTIFIER
   ;

dataType
   : IDENTIFIER
   ;

labelText
   : STRING_LITERAL
   ;

labelMaxLength
   : maxLength EQUAL INTEGER_LITERAL
   ;

labelComment
   : comment EQUAL STRING_LITERAL
   ;

labelLocked
   : locked EQUAL (TRUE | FALSE)
   ;

labelArgument
   : labelMaxLength
   | labelComment
   | labelLocked
   ;

labelArgs
   : labelArgument (COMMA labelArgument)*?
   ;

optionValue
   : IDENTIFIER
   ;

optionValueList
   : optionValue (COMMA optionValue)*?
   ;

variableTypeDeclaration
   : any
   | bigInteger
   | bigText
   | blob
   | boolean
   | byte
   | char
   | code sizeDeclaration
   | codeunit IDENTIFIER
   | companyProperty
   | database
   | dataTransfer
   | date
   | dateFormula
   | datetime
   | debugger
   | decimal
   | dialog
   | dictionary OF LEFTBRACKET key COMMA dataType RIGHTBRACKET
   | dotnet IDENTIFIER
   | duration
   | enum IDENTIFIER
   | errorInfo
   | fieldRef
   | file
   | filterPageBuilder
   | guid
   | httpClient
   | httpContent
   | httpHeaders
   | httpRequestMessage
   | httpResponseMessage
   | inStream
   | integer
   | isolatedStorage
   | jsonArray
   | jsonObject
   | jsonToken
   | jsonValue
   | keyRef
   | label labelText (COMMA labelArgs)?
   | list OF LEFTBRACKET dataType RIGHTBRACKET
   | media
   | mediaSet
   | moduleDependencyInfo
   | moduleInfo
   | navApp
   | none
   | notification
   | numberSequence
   | option optionValueList
   | outStream
   | page IDENTIFIER
   | productName
   | query IDENTIFIER
   | record IDENTIFIER temporary?
   | recordId
   | recordRef
   | report IDENTIFIER
   | requestPage IDENTIFIER
   | session
   | sessionInformation
   | sessionSettings
   | system
   | taskScheduler
   | testAction
   | testField
   | testFilter
   | testFilterField
   | testPage
   | testPart
   | testRequestPage
   | text sizeDeclaration
   | textBuilder
   | textConst IDENTIFIER EQUAL STRING_LITERAL
   | time
   | variant
   | version
   | webServiceActionContext
   | xmlAttribute
   | xmlAttributeCollection
   | xmlCdata
   | xmlComment
   | xmlDeclaration
   | xmlDocument
   | xmlDocumentType
   | xmlElement
   | xmlNamespaceManager
   | xmlNameTable
   | xmlNode
   | xmlNodeList
   | xmlport
   | xmlProcessingInstruction
   | xmlReadOptions
   | xmlText
   | xmlWriteOptions
   | action
   | auditCategory
   | clientType
   | commitBehavior
   | dataClassification
   | dataScope
   | defaultLayout
   | errorBehavior
   | errorType
   | executionContext
   | executionMode
   | fieldClass
   | fieldType
   | inherentPermissionsScope
   | isolationLevel
   | notificationScope
   | objectType
   | pageBackgroundTaskErrorLevel
   | permissionObjectType
   | reportFormat
   | reportLayoutType
   | securityFilter
   | securityOperationResult
   | tableConnectionType
   | telemetryScope
   | testPermissions
   | textEncoding
   | transactionModel
   | transactionType
   | verbosity
   | webServiceActionResultCode
   ;

parameterDeclaration
   : VAR? IDENTIFIER COLON variableTypeDeclaration
   ;

parameterList
   : parameterDeclaration (SEMICOLON parameterDeclaration)*?
   ;
   
variableNameList
	: IDENTIFIER (COMMA IDENTIFIER)*?
   ;

variableDeclaration
   : variableNameList COLON variableTypeDeclaration SEMICOLON
   ;

variableDeclarations
   : variableDeclaration (variableDeclaration)*?
   ;

varBlock
   : VAR variableDeclarations
   ;

protectedVarBlock
   : PROTECTED VAR variableDeclaration
   ;

returnValue
   : COLON IDENTIFIER
   ;

/*
 * Trigger declarations
 */

triggerName : IDENTIFIER;

triggerDeclaration
   : TRIGGER triggerName LEFTPAREN parameterList? RIGHTPAREN returnValue? varBlock? statementBlock SEMICOLON;

/*
 * AL IF statement logic
 */

ifConditionStatement
   : IF expression THEN;

elseStatement
   : ELSE statement;

ifStatement
   : ifConditionStatement statement (elseStatement)?;

/*
 * AL WHILE statement logic
 */

whileConditionalStatement
   : WHILE expression DO;

whileStatement
   : whileConditionalStatement statement;

/*
 * AL FOR statement logic
 */

forValue
   : DATE_LITERAL
   | TIME_LITERAL
   | booleanLiteral
   | numberLiteral
   ;

forControlStatement
   : FOR IDENTIFIER ASSGN forValue (TO | DOWNTO) forValue DO;

forStatement
   : forControlStatement statement;

/*
 * AL CASE statement logic
 */

caseValue
   : numberLiteral
   | booleanLiteral
   | DATE_LITERAL
   | TIME_LITERAL
   | DATETIME_LITERAL
   | optionLiteral
   | STRING_LITERAL
   ;

caseSet
   : caseValue (COMMA caseValue)*?;

caseRange
   : caseValue RANGE caseValue;

caseValueStatement
   : (caseSet | caseRange) COLON statement;

caseElseStatement
   : ELSE statement;

caseBody
   : (caseValueStatement (SEMICOLON caseValueStatement)*?)? caseElseStatement?;

caseControlStatement
   : CASE expression OF;

caseStatement
   : caseControlStatement caseBody END;

/*
 * AL REPEAT UNTIL statement logic
 */

untilCondition
   : UNTIL expression;

repeatUntilStatement
   : REPEAT statement untilCondition;

/*
 * AL WITH statement logic
 * (DEPRECATED in Dynamics 365 Business Central 2020, release wave 2)
 */

withControlStatement
   : WITH IDENTIFIER DO;

withStatement
   : withControlStatement statement;

/* 
 *AL Exit statement logic
 */

 exitStatement
   : EXIT (expression)?;

/*
 * AL generic statement statement logic
 */

statementLine
   : ifStatement
   | forStatement
   | caseStatement
   | withStatement
   | whileStatement
   | repeatUntilStatement
   | exitStatement
   | expression;
   
statementBlock
   : BEGIN statementList END;

statement
   : (statementLine | statementBlock) SEMICOLON?
   ;

statementList
   : (statementLine (SEMICOLON statementLine)*?)? SEMICOLON?;

/*
 * AL expression logic
 */

indexAccessorValue
   : INTEGER_LITERAL
   | IDENTIFIER
   ;

indexAccessorSet
   : indexAccessorValue (COMMA indexAccessorValue)*?;

valueSet
   : expression (COMMA expression)*?;

expression
   : LEFTPAREN expression RIGHTPAREN #ParenthesisExpression
   | expression (ASTERISK | BACKSLASH | MOD) expression #DivMultExpression
   | expression (PLUS | MINUS) expression #AddSubtractExpression
   | expression (LESSTHAN | GREATERTHAN | LESSTHANEQUAL | GREATERTHANEQUAL | NOTEQUAL | EQUAL) expression #ComparisonExpression
   | NOT expression #negationExpression
   | expression (AND | OR) expression #LogicalComparisonExpression
   | expression (ASSGN | DIV_ASSGN | MULTIPLY_ASSGN | ADD_ASSGN | MINUS_ASSGN) expression #AssignmentExpression
   | expression SCOPE IDENTIFIER #ScopeExpression
   | expression LEFTBRACKET indexAccessorSet RIGHTBRACKET #IndexExpression
   | LEFTBRACKET valueSet? RIGHTBRACKET #SetExpression
   | IDENTIFIER (PERIOD IDENTIFIER)*? LEFTPAREN (expression (COMMA expression)*?)? RIGHTPAREN #MethodCallExpression
   | expression PERIOD IDENTIFIER (PERIOD IDENTIFIER)*? #MemberAccessExpression   
   | IDENTIFIER RIGHTPAREN #FunctionCallExpression
   | expression IN LEFTBRACKET valueSet? RIGHTBRACKET #InSetExpression
   | booleanLiteral #BooleanLiteralExpression
   | DATE_LITERAL #DateLiteralExpression
   | TIME_LITERAL #TimeLiteralExpression
   | DATETIME_LITERAL #DatetimeLiteralExpression
   | IDENTIFIER #IdentifierExpression
   | STRING_LITERAL #StringLiteralExpression
   | numberLiteral #NumberLiteralExpression
   | optionLiteral #OptionLiteralExpression;

optionLiteral
   : IDENTIFIER SCOPE IDENTIFIER;

booleanLiteral
   : TRUE
   | FALSE
   ;

numberLiteral
   : FLOAT_LITERAL
   | INTEGER_LITERAL
   ;