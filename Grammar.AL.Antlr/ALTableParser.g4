parser grammar ALTableParser;

options { tokenVocab=ALLexer; }

import ALCodeParser;

/*
 * Field related rules
 */

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
 */

tableRelationFilter
   : IDENTIFIER EQUAL ({TokenMatches("field")}? IDENTIFIER LEFTPAREN IDENTIFIER RIGHTPAREN 
   | {TokenMatches("const")}? IDENTIFIER LEFTPAREN (IDENTIFIER | INTEGER_LITERAL+) RIGHTPAREN)
   ;

tableRelationFilters
   : tableRelationFilter (COMMA tableRelationFilter)*?
   ;

tableRelationWhereClause
   : {TokenMatches("where")}? IDENTIFIER LEFTPAREN tableRelationFilters RIGHTPAREN
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
 */

calcFormulaTableFilterValue
   : {TokenMatches("const")}? IDENTIFIER LEFTPAREN fieldValue RIGHTPAREN
   | {TokenMatches("filter")}? IDENTIFIER LEFTPAREN compoundFilterRule RIGHTPAREN
   | {TokenMatches("field")}? IDENTIFIER LEFTPAREN IDENTIFIER RIGHTPAREN
   | {TokenMatches("field")}? IDENTIFIER LEFTPAREN {TokenMatches("upperlimit")}? IDENTIFIER LEFTPAREN IDENTIFIER RIGHTPAREN RIGHTPAREN
   | {TokenMatches("field")}? IDENTIFIER LEFTPAREN {TokenMatches("filter")}? IDENTIFIER LEFTPAREN IDENTIFIER RIGHTPAREN RIGHTPAREN
   | {TokenMatches("field")}? IDENTIFIER LEFTPAREN {TokenMatches("upperlimit")}? IDENTIFIER LEFTPAREN {TokenMatches("filter")}? IDENTIFIER LEFTPAREN IDENTIFIER RIGHTPAREN RIGHTPAREN RIGHTPAREN
   ;

calcFormulaTableFilter
   : fieldReference EQUAL calcFormulaTableFilterValue
   ;

calcFormulaTableFilters
   : calcFormulaTableFilter (COMMA calcFormulaTableFilter)*?
   ;

calcFormulaWhereClause
   : {TokenMatches("where")}? IDENTIFIER LEFTPAREN calcFormulaTableFilters RIGHTPAREN
   ;

calcFormulaExist
   : MINUS? {TokenMatches("exist")}? IDENTIFIER LEFTPAREN tableReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaCount
   : {TokenMatches("count")}? IDENTIFIER LEFTPAREN tableReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaSum
   : MINUS? {TokenMatches("sum")}? IDENTIFIER LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaAverage
   : MINUS? {TokenMatches("average")}? IDENTIFIER LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;
   
calcFormulaMin
   : {TokenMatches("min")}? IDENTIFIER LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaMax
   : {TokenMatches("max")}? IDENTIFIER LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
   ;

calcFormulaLookup
   : {TokenMatches("lookup")}? IDENTIFIER LEFTPAREN qualifiedFieldReference calcFormulaWhereClause? RIGHTPAREN
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
 * Table Keys
 */

keyProperties
   : (simpleProperty SEMICOLON)*?
   ;

keyFields
   : IDENTIFIER (SEMICOLON IDENTIFIER)*?
   ;

tableKey
   : {TokenMatches("key")}? IDENTIFIER LEFTPAREN keyFields RIGHTPAREN LEFTCBRACE keyProperties RIGHTCBRACE
   ;

tableKeys
   : {TokenMatches("keys")}? IDENTIFIER LEFTCBRACE tableKey*? RIGHTCBRACE
   ;

/*
 * Tables
 */

tableProperties
   : (simpleProperty SEMICOLON)*?
   ;

tableFieldId : INTEGER_LITERAL;

tableFieldName : IDENTIFIER;

tableFieldType
   : {TokenMatches(SimpleFieldTypes)}? IDENTIFIER
   | {TokenMatches("code")}? IDENTIFIER sizeDeclaration
   | {TokenMatches("text")}? IDENTIFIER sizeDeclaration
   ;

tableFieldProperty
   : {TokenMatches("tablerelation")}? IDENTIFIER EQUAL tableRelation
   | {TokenMatches("calcformula")}? IDENTIFIER EQUAL calcForumla
   | simpleProperty
   ;

tableField
   : {TokenMatches("field")}? IDENTIFIER LEFTPAREN tableFieldId SEMICOLON tableFieldName SEMICOLON tableFieldType RIGHTPAREN LEFTCBRACE (tableFieldProperty SEMICOLON)*? RIGHTCBRACE
   ;

tableFields
   : {TokenMatches("fields")}? IDENTIFIER LEFTCBRACE tableField*? RIGHTCBRACE
   ;

table
   : {TokenMatches("table")}? IDENTIFIER INTEGER_LITERAL IDENTIFIER LEFTCBRACE tableProperties tableFields tableKeys codeDeclarations? RIGHTCBRACE
   ;