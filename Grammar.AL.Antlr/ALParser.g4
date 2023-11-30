parser grammar ALParser;

options { tokenVocab=ALLexer; }

compileUnit
	: EOF
   | statement EOF
	;

action
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "action"}?
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
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "any"}?
   ;

bigInteger
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "biginteger"}?
   ;

bigText
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "bigtext"}?
   ;

blob
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "blob"}?
   ;

boolean
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "boolean"}?
   ;

byte
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "byte"}?
   ;

char
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "char"}?
   ;

code
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "code"}?
   ;

codeunit
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "codeunit"}?
   ;

companyProperty
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "companyproperty"}?
   ;

database
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "database"}?
   ;

dataTransfer
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "datatransfer"}?
   ;

date
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "date"}?
   ;

dateformula
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "dateformula"}?
   ;

datetime
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "datetime"}?
   ;

debugger
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "debugger"}?
   ;

decimal
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "decimal"}?
   ;

dialog
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "dialog"}?
   ;

dictionary
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "dictionary"}?
   ;

dotnet
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "dotnet"}?
   ;

duration
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "duration"}?
   ;

enum
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "enum"}?
   ;

errorInfo
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "errorinfo"}?
   ;

fieldRef
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "fieldref"}?
   ;

file
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "file"}?
   ;

filterPageBuilder
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "filterpagebuilder"}?
   ;

guid
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "guid"}?
   ;

httpClient
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "httpclient"}?
   ;

httpContent
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "httpcontent"}?
   ;

httpHeaders
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "httpheaders"}?
   ;

httpRequestMessage
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "httprequestmessage"}?
   ;

httpresponsemessage
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "httpresponsemessage"}?
   ;

inStream
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "instream"}?
   ;

integer
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "integer"}?
   ;

isolatedStorage
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "isolatedstorage"}?
   ;

jsonArray
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "jsonarray"}?
   ;

jsonObject
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "jsonobject"}?
   ;

jsonToken
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "jsontoken"}?
   ;

jsonValue
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "jsonvalue"}?
   ;

keyRef
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "keyref"}?
   ;

label
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "label"}?
   ;

list
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "list"}?
   ;

media
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "media"}?
   ;

mediaSet
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "mediaset"}?
   ;

moduleDependencyInfo
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "moduledependencyinfo"}?
   ;

moduleInfo
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "moduleinfo"}?
   ;

navApp
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "navapp"}?
   ;

none
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "none"}?
   ;

notification
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "notification"}?
   ;

numberSequence
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "numbersequence"}?
   ;

option
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "option"}?
   ;

outStream
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "outstream"}?
   ;

page
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "page"}?
   ;

productName
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "productname"}?
   ;

query
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "query"}?
   ;

record
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "record"}?
   ;

recordId
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "recordid"}?
   ;

recordRef
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "recordref"}?
   ;

report
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "report"}?
   ;

requestPage
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "requestpage"}?
   ;

session
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "session"}?
   ;

sessionInformation
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "sessioninformation"}?
   ;

sessionSettings
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "sessionsettings"}?
   ;

system
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "system"}?
   ;

taskScheduler
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "taskscheduler"}?
   ;

testAction
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testaction"}?
   ;

testField
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testfield"}?
   ;

testFilter
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testfilter"}?
   ;

testFilterField
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testfilterfield"}?
   ;

testPage
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testpage"}?
   ;

testPart
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testpart"}?
   ;

testrequestpage
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testrequestpage"}?
   ;

temporary
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "temporary"}?
   ;

text
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "text"}?
   ;

textBuilder
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "textbuilder"}?
   ;

textConst
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "textconst"}?
   ;

time
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "time"}?
   ;

variant
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "variant"}?
   ;

version
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "version"}?
   ;

webServiceActionContext
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "webserviceactioncontext"}?
   ;

xmlAttribute
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlattribute"}?
   ;

xmlAttributeCollection
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlattributecollection"}?
   ;

xmlCdata
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlcdata"}?
   ;

xmlComment
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlcomment"}?
   ;

xmlDeclaration
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmldeclaration"}?
   ;

xmlDocument
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmldocument"}?
   ;

xmlDocumentType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmldocumenttype"}?
   ;

xmlElement
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlelement"}?
   ;

xmlNamespaceManager
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlnamespacemanager"}?
   ;

xmlNameTable
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlnametable"}?
   ;

xmlNode
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlnode"}?
   ;

xmlNodeList
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlnodelist"}?
   ;

xmlport
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlport"}?
   ;

xmlProcessingInstruction
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlprocessinginstruction"}?
   ;

xmlReadOptions
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlreadoptions"}?
   ;

xmlText
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmltext"}?
   ;

xmlWriteOptions
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "xmlwriteoptions"}?
   ;

auditCategory
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "auditcategory"}?
   ;

clientType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "clienttype"}?
   ;

commitBehavior
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "commitbehavior"}?
   ;

dataClassification
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "dataclassification"}?
   ;

dataScope
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "datascope"}?
   ;

defaultLayout
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "defaultlayout"}?
   ;

errorBehavior
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "errorbehavior"}?
   ;

errorType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "errortype"}?
   ;

executionContext
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "executioncontext"}?
   ;

executionMode
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "executionmode"}?
   ;

fieldClass
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "fieldclass"}?
   ;

fieldType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "fieldtype"}?
   ;

inherentPermissionsScope
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "inherentpermissionsscope"}?
   ;

isolationLevel
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "isolationlevel"}?
   ;

notificationScope
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "notificationscope"}?
   ;

objectType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "objecttype"}?
   ;

pageBackgroundTaskErrorLevel
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "pagebackgroundtaskerrorlevel"}?
   ;

permissionObjectType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "permissionobjecttype"}?
   ;

reportFormat
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "reportformat"}?
   ;

reportLayoutType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "reportlayouttype"}?
   ;

securityFilter
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "securityfilter"}?
   ;

securityOperationResult
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "securityoperationresult"}?
   ;

tableConnectionType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "tableconnectiontype"}?
   ;

telemetryScope
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "telemetryscope"}?
   ;

testPermissions
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "testpermissions"}?
   ;

textEncoding
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "textencoding"}?
   ;

transactionModel
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "transactionmodel"}?
   ;

transactionType
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "transactiontype"}?
   ;

verbosity
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "verbosity"}?
   ;

webServiceActionResultCode
   : IDENTIFIER {$IDENTIFIER.text.ToLowerInvariant() == "webserviceactionresultcode"}?
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
   | dateformula
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
   | httpresponsemessage
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
   | testrequestpage
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