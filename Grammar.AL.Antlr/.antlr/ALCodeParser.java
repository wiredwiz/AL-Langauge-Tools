// Generated from s://AL Language Tools//Grammar.AL.Antlr//ALCodeParser.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue"})
public class ALCodeParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		SINGLE_LINE_COMMENT=1, DELIMITED_COMMENT=2, WS=3, SCOPE=4, RANGE=5, SEMICOLON=6, 
		COLON=7, COMMA=8, PERIOD=9, GREATERTHANEQUAL=10, LESSTHANEQUAL=11, NOTEQUAL=12, 
		EQUAL=13, ASSGN=14, MULTIPLY_ASSGN=15, DIV_ASSGN=16, ADD_ASSGN=17, MINUS_ASSGN=18, 
		ASTERISK=19, BACKSLASH=20, PLUS=21, MINUS=22, LESSTHAN=23, GREATERTHAN=24, 
		LEFTPAREN=25, RIGHTPAREN=26, LEFTBRACKET=27, RIGHTBRACKET=28, LEFTCBRACE=29, 
		RIGHTCBRACE=30, PIPE=31, AMPERSAND=32, AND=33, DIV=34, MOD=35, NOT=36, 
		OR=37, XOR=38, ARRAY=39, ASSERTERROR=40, BEGIN=41, BREAK=42, CASE=43, 
		DO=44, DOWNTO=45, ELSE=46, END=47, EXIT=48, FOR=49, FOREACH=50, FUNCTION=51, 
		GUIALLOWED=52, IF=53, IMPLEMENTS=54, IN=55, INDATASET=56, INTERFACE=57, 
		INTERNAL=58, LOCAL=59, OF=60, PROCEDURE=61, PROGRAM=62, PROTECTED=63, 
		REPEAT=64, RUNONCLIENT=65, SECURITYFILTERING=66, SUPPRESSDISPOSE=67, TEMPORARY=68, 
		THEN=69, TO=70, TRIGGER=71, UNTIL=72, VAR=73, WHILE=74, WITH=75, WITHEVENTS=76, 
		TRUE=77, FALSE=78, DATE_LITERAL=79, TIME_LITERAL=80, DATETIME_LITERAL=81, 
		INTEGER_LITERAL=82, FLOAT_LITERAL=83, STRING_LITERAL=84, IDENTIFIER=85, 
		UNDERSCORE=86, LETTER=87, PREPROCESSOR_DIRECTIVE=88;
	public static final int
		RULE_comment = 0, RULE_maxLength = 1, RULE_locked = 2, RULE_simpleProperty = 3, 
		RULE_sizeDeclaration = 4, RULE_builtinType = 5, RULE_methodDeclaration = 6, 
		RULE_attributeArgument = 7, RULE_attributeArgumentList = 8, RULE_methodAttribute = 9, 
		RULE_dictionaryKey = 10, RULE_dictionaryDataType = 11, RULE_labelText = 12, 
		RULE_labelMaxLength = 13, RULE_labelComment = 14, RULE_labelLocked = 15, 
		RULE_labelArgument = 16, RULE_labelArgs = 17, RULE_optionValue = 18, RULE_optionValueList = 19, 
		RULE_objectId = 20, RULE_dimensions = 21, RULE_variableTypeDeclaration = 22, 
		RULE_parameterName = 23, RULE_parameterDeclaration = 24, RULE_parameterList = 25, 
		RULE_variableNameList = 26, RULE_variableDeclaration = 27, RULE_variableDeclarations = 28, 
		RULE_varBlock = 29, RULE_protectedVarBlock = 30, RULE_returnValue = 31, 
		RULE_triggerName = 32, RULE_triggerDeclaration = 33, RULE_codeEntity = 34, 
		RULE_codeDeclarations = 35, RULE_ifConditionStatement = 36, RULE_elseStatement = 37, 
		RULE_ifStatement = 38, RULE_whileConditionalStatement = 39, RULE_whileStatement = 40, 
		RULE_forValue = 41, RULE_forControlStatement = 42, RULE_forStatement = 43, 
		RULE_caseValue = 44, RULE_caseSet = 45, RULE_caseRange = 46, RULE_caseValueStatement = 47, 
		RULE_caseElseStatement = 48, RULE_caseBody = 49, RULE_caseControlStatement = 50, 
		RULE_caseStatement = 51, RULE_untilCondition = 52, RULE_repeatUntilStatement = 53, 
		RULE_withControlStatement = 54, RULE_withStatement = 55, RULE_exitStatement = 56, 
		RULE_statementLine = 57, RULE_statementBlock = 58, RULE_statement = 59, 
		RULE_statementList = 60, RULE_indexAccessorValue = 61, RULE_indexAccessorSet = 62, 
		RULE_valueSet = 63, RULE_expression = 64, RULE_methodCallArguments = 65, 
		RULE_optionLiteral = 66, RULE_booleanLiteral = 67, RULE_numberLiteral = 68;
	private static String[] makeRuleNames() {
		return new String[] {
			"comment", "maxLength", "locked", "simpleProperty", "sizeDeclaration", 
			"builtinType", "methodDeclaration", "attributeArgument", "attributeArgumentList", 
			"methodAttribute", "dictionaryKey", "dictionaryDataType", "labelText", 
			"labelMaxLength", "labelComment", "labelLocked", "labelArgument", "labelArgs", 
			"optionValue", "optionValueList", "objectId", "dimensions", "variableTypeDeclaration", 
			"parameterName", "parameterDeclaration", "parameterList", "variableNameList", 
			"variableDeclaration", "variableDeclarations", "varBlock", "protectedVarBlock", 
			"returnValue", "triggerName", "triggerDeclaration", "codeEntity", "codeDeclarations", 
			"ifConditionStatement", "elseStatement", "ifStatement", "whileConditionalStatement", 
			"whileStatement", "forValue", "forControlStatement", "forStatement", 
			"caseValue", "caseSet", "caseRange", "caseValueStatement", "caseElseStatement", 
			"caseBody", "caseControlStatement", "caseStatement", "untilCondition", 
			"repeatUntilStatement", "withControlStatement", "withStatement", "exitStatement", 
			"statementLine", "statementBlock", "statement", "statementList", "indexAccessorValue", 
			"indexAccessorSet", "valueSet", "expression", "methodCallArguments", 
			"optionLiteral", "booleanLiteral", "numberLiteral"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, null, null, null, "'::'", "'..'", "';'", "':'", "','", "'.'", "'>='", 
			"'<='", "'<>'", "'='", "':='", "'*='", "'/='", "'+='", "'-='", "'*'", 
			"'/'", "'+'", "'-'", "'<'", "'>'", "'('", "')'", "'['", "']'", "'{'", 
			"'}'", "'|'", "'&'", null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, "'_'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "SINGLE_LINE_COMMENT", "DELIMITED_COMMENT", "WS", "SCOPE", "RANGE", 
			"SEMICOLON", "COLON", "COMMA", "PERIOD", "GREATERTHANEQUAL", "LESSTHANEQUAL", 
			"NOTEQUAL", "EQUAL", "ASSGN", "MULTIPLY_ASSGN", "DIV_ASSGN", "ADD_ASSGN", 
			"MINUS_ASSGN", "ASTERISK", "BACKSLASH", "PLUS", "MINUS", "LESSTHAN", 
			"GREATERTHAN", "LEFTPAREN", "RIGHTPAREN", "LEFTBRACKET", "RIGHTBRACKET", 
			"LEFTCBRACE", "RIGHTCBRACE", "PIPE", "AMPERSAND", "AND", "DIV", "MOD", 
			"NOT", "OR", "XOR", "ARRAY", "ASSERTERROR", "BEGIN", "BREAK", "CASE", 
			"DO", "DOWNTO", "ELSE", "END", "EXIT", "FOR", "FOREACH", "FUNCTION", 
			"GUIALLOWED", "IF", "IMPLEMENTS", "IN", "INDATASET", "INTERFACE", "INTERNAL", 
			"LOCAL", "OF", "PROCEDURE", "PROGRAM", "PROTECTED", "REPEAT", "RUNONCLIENT", 
			"SECURITYFILTERING", "SUPPRESSDISPOSE", "TEMPORARY", "THEN", "TO", "TRIGGER", 
			"UNTIL", "VAR", "WHILE", "WITH", "WITHEVENTS", "TRUE", "FALSE", "DATE_LITERAL", 
			"TIME_LITERAL", "DATETIME_LITERAL", "INTEGER_LITERAL", "FLOAT_LITERAL", 
			"STRING_LITERAL", "IDENTIFIER", "UNDERSCORE", "LETTER", "PREPROCESSOR_DIRECTIVE"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "ALCodeParser.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	  // Define our member text lists
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

	      List<string> VarAppObjects = new List<string>() {"codeunit", "page", "requestpage", "dotnet", "enum", "query", "report", "xmlport"};

	      List<string> SimpleFieldTypes = new List<string>() 
	      {
	         "integer", "biginteger", "decimal", "boolean", "binary", "blob", "date", "time", "datetime", "dateformula", "duration", "recordid", "tablefilter", "option", "guid"
	      };

	      // Positioning keywords for various entities (Groups, Areas, Actions, Controls)
	      List<string> GroupPosKeywords = new List<string>() 
	      {
	         "addfirst", "addlast", "addafter", "addbefore", "movefirst", "movelast", "moveafter", "movebefore", "modify"
	      };
	      
	      List<string> AreaPosKeywords = new List<string>() 
	      {
	         "addfirst", "addlast", "movefirst", "movelast"
	      };

	      List<string> ActionPosKeywords = new List<string>() 
	      {
	         "addafter", "addbefore", "moveafter", "movebefore", "modify"
	      };

	      List<string> ControlPosKeywords = new List<string>() 
	      {
	         "addafter", "addbefore", "moveafter", "movebefore", "modify"
	      };

	      // Define helper methods for token text matching

	      bool TokenMatches(string text)
	      {
	         return _input.Lt(1).Text.ToLowerInvariant() == text;
	      }

	      bool TokenMatches(List<string> values)
	      {
	         return values.Contains(_input.Lt(1).Text.ToLowerInvariant());
	      }

	public ALCodeParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CommentContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public CommentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_comment; }
	}

	public final CommentContext comment() throws RecognitionException {
		CommentContext _localctx = new CommentContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_comment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(138);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MaxLengthContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public MaxLengthContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_maxLength; }
	}

	public final MaxLengthContext maxLength() throws RecognitionException {
		MaxLengthContext _localctx = new MaxLengthContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_maxLength);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(140);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LockedContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public LockedContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_locked; }
	}

	public final LockedContext locked() throws RecognitionException {
		LockedContext _localctx = new LockedContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_locked);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(142);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class SimplePropertyContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(ALCodeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ALCodeParser.IDENTIFIER, i);
		}
		public TerminalNode EQUAL() { return getToken(ALCodeParser.EQUAL, 0); }
		public TerminalNode SEMICOLON() { return getToken(ALCodeParser.SEMICOLON, 0); }
		public TerminalNode STRING_LITERAL() { return getToken(ALCodeParser.STRING_LITERAL, 0); }
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public TerminalNode FLOAT_LITERAL() { return getToken(ALCodeParser.FLOAT_LITERAL, 0); }
		public BooleanLiteralContext booleanLiteral() {
			return getRuleContext(BooleanLiteralContext.class,0);
		}
		public SimplePropertyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_simpleProperty; }
	}

	public final SimplePropertyContext simpleProperty() throws RecognitionException {
		SimplePropertyContext _localctx = new SimplePropertyContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_simpleProperty);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(144);
			match(IDENTIFIER);
			setState(145);
			match(EQUAL);
			setState(151);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case STRING_LITERAL:
				{
				setState(146);
				match(STRING_LITERAL);
				}
				break;
			case INTEGER_LITERAL:
				{
				setState(147);
				match(INTEGER_LITERAL);
				}
				break;
			case FLOAT_LITERAL:
				{
				setState(148);
				match(FLOAT_LITERAL);
				}
				break;
			case IDENTIFIER:
				{
				setState(149);
				match(IDENTIFIER);
				}
				break;
			case TRUE:
			case FALSE:
				{
				setState(150);
				booleanLiteral();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(153);
			match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class SizeDeclarationContext extends ParserRuleContext {
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public SizeDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_sizeDeclaration; }
	}

	public final SizeDeclarationContext sizeDeclaration() throws RecognitionException {
		SizeDeclarationContext _localctx = new SizeDeclarationContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_sizeDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(155);
			match(LEFTBRACKET);
			setState(156);
			match(INTEGER_LITERAL);
			setState(157);
			match(RIGHTBRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class BuiltinTypeContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public BuiltinTypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_builtinType; }
	}

	public final BuiltinTypeContext builtinType() throws RecognitionException {
		BuiltinTypeContext _localctx = new BuiltinTypeContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_builtinType);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(159);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MethodDeclarationContext extends ParserRuleContext {
		public TerminalNode PROCEDURE() { return getToken(ALCodeParser.PROCEDURE, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode LEFTPAREN() { return getToken(ALCodeParser.LEFTPAREN, 0); }
		public TerminalNode RIGHTPAREN() { return getToken(ALCodeParser.RIGHTPAREN, 0); }
		public StatementBlockContext statementBlock() {
			return getRuleContext(StatementBlockContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(ALCodeParser.SEMICOLON, 0); }
		public List<MethodAttributeContext> methodAttribute() {
			return getRuleContexts(MethodAttributeContext.class);
		}
		public MethodAttributeContext methodAttribute(int i) {
			return getRuleContext(MethodAttributeContext.class,i);
		}
		public ParameterListContext parameterList() {
			return getRuleContext(ParameterListContext.class,0);
		}
		public ReturnValueContext returnValue() {
			return getRuleContext(ReturnValueContext.class,0);
		}
		public VarBlockContext varBlock() {
			return getRuleContext(VarBlockContext.class,0);
		}
		public MethodDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodDeclaration; }
	}

	public final MethodDeclarationContext methodDeclaration() throws RecognitionException {
		MethodDeclarationContext _localctx = new MethodDeclarationContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_methodDeclaration);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(164);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,1,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(161);
					methodAttribute();
					}
					} 
				}
				setState(166);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,1,_ctx);
			}
			setState(167);
			match(PROCEDURE);
			setState(168);
			match(IDENTIFIER);
			setState(169);
			match(LEFTPAREN);
			setState(171);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==VAR || _la==IDENTIFIER) {
				{
				setState(170);
				parameterList();
				}
			}

			setState(173);
			match(RIGHTPAREN);
			setState(175);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==COLON) {
				{
				setState(174);
				returnValue();
				}
			}

			setState(178);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==VAR) {
				{
				setState(177);
				varBlock();
				}
			}

			setState(180);
			statementBlock();
			setState(181);
			match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AttributeArgumentContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode COLON() { return getToken(ALCodeParser.COLON, 0); }
		public BuiltinTypeContext builtinType() {
			return getRuleContext(BuiltinTypeContext.class,0);
		}
		public AttributeArgumentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_attributeArgument; }
	}

	public final AttributeArgumentContext attributeArgument() throws RecognitionException {
		AttributeArgumentContext _localctx = new AttributeArgumentContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_attributeArgument);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(183);
			match(IDENTIFIER);
			setState(184);
			match(COLON);
			setState(185);
			builtinType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class AttributeArgumentListContext extends ParserRuleContext {
		public List<AttributeArgumentContext> attributeArgument() {
			return getRuleContexts(AttributeArgumentContext.class);
		}
		public AttributeArgumentContext attributeArgument(int i) {
			return getRuleContext(AttributeArgumentContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public AttributeArgumentListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_attributeArgumentList; }
	}

	public final AttributeArgumentListContext attributeArgumentList() throws RecognitionException {
		AttributeArgumentListContext _localctx = new AttributeArgumentListContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_attributeArgumentList);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(187);
			attributeArgument();
			setState(192);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(188);
					match(COMMA);
					setState(189);
					attributeArgument();
					}
					} 
				}
				setState(194);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MethodAttributeContext extends ParserRuleContext {
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public TerminalNode LEFTPAREN() { return getToken(ALCodeParser.LEFTPAREN, 0); }
		public TerminalNode RIGHTPAREN() { return getToken(ALCodeParser.RIGHTPAREN, 0); }
		public AttributeArgumentListContext attributeArgumentList() {
			return getRuleContext(AttributeArgumentListContext.class,0);
		}
		public MethodAttributeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodAttribute; }
	}

	public final MethodAttributeContext methodAttribute() throws RecognitionException {
		MethodAttributeContext _localctx = new MethodAttributeContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_methodAttribute);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(195);
			match(LEFTBRACKET);
			setState(196);
			match(IDENTIFIER);
			setState(202);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==LEFTPAREN) {
				{
				setState(197);
				match(LEFTPAREN);
				setState(199);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==IDENTIFIER) {
					{
					setState(198);
					attributeArgumentList();
					}
				}

				setState(201);
				match(RIGHTPAREN);
				}
			}

			setState(204);
			match(RIGHTBRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DictionaryKeyContext extends ParserRuleContext {
		public VariableTypeDeclarationContext variableTypeDeclaration() {
			return getRuleContext(VariableTypeDeclarationContext.class,0);
		}
		public DictionaryKeyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_dictionaryKey; }
	}

	public final DictionaryKeyContext dictionaryKey() throws RecognitionException {
		DictionaryKeyContext _localctx = new DictionaryKeyContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_dictionaryKey);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(206);
			variableTypeDeclaration();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DictionaryDataTypeContext extends ParserRuleContext {
		public VariableTypeDeclarationContext variableTypeDeclaration() {
			return getRuleContext(VariableTypeDeclarationContext.class,0);
		}
		public DictionaryDataTypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_dictionaryDataType; }
	}

	public final DictionaryDataTypeContext dictionaryDataType() throws RecognitionException {
		DictionaryDataTypeContext _localctx = new DictionaryDataTypeContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_dictionaryDataType);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(208);
			variableTypeDeclaration();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LabelTextContext extends ParserRuleContext {
		public TerminalNode STRING_LITERAL() { return getToken(ALCodeParser.STRING_LITERAL, 0); }
		public LabelTextContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelText; }
	}

	public final LabelTextContext labelText() throws RecognitionException {
		LabelTextContext _localctx = new LabelTextContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_labelText);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(210);
			match(STRING_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LabelMaxLengthContext extends ParserRuleContext {
		public MaxLengthContext maxLength() {
			return getRuleContext(MaxLengthContext.class,0);
		}
		public TerminalNode EQUAL() { return getToken(ALCodeParser.EQUAL, 0); }
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public LabelMaxLengthContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelMaxLength; }
	}

	public final LabelMaxLengthContext labelMaxLength() throws RecognitionException {
		LabelMaxLengthContext _localctx = new LabelMaxLengthContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_labelMaxLength);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(212);
			maxLength();
			setState(213);
			match(EQUAL);
			setState(214);
			match(INTEGER_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LabelCommentContext extends ParserRuleContext {
		public CommentContext comment() {
			return getRuleContext(CommentContext.class,0);
		}
		public TerminalNode EQUAL() { return getToken(ALCodeParser.EQUAL, 0); }
		public TerminalNode STRING_LITERAL() { return getToken(ALCodeParser.STRING_LITERAL, 0); }
		public LabelCommentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelComment; }
	}

	public final LabelCommentContext labelComment() throws RecognitionException {
		LabelCommentContext _localctx = new LabelCommentContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_labelComment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(216);
			comment();
			setState(217);
			match(EQUAL);
			setState(218);
			match(STRING_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LabelLockedContext extends ParserRuleContext {
		public LockedContext locked() {
			return getRuleContext(LockedContext.class,0);
		}
		public TerminalNode EQUAL() { return getToken(ALCodeParser.EQUAL, 0); }
		public TerminalNode TRUE() { return getToken(ALCodeParser.TRUE, 0); }
		public TerminalNode FALSE() { return getToken(ALCodeParser.FALSE, 0); }
		public LabelLockedContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelLocked; }
	}

	public final LabelLockedContext labelLocked() throws RecognitionException {
		LabelLockedContext _localctx = new LabelLockedContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_labelLocked);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(220);
			locked();
			setState(221);
			match(EQUAL);
			setState(222);
			_la = _input.LA(1);
			if ( !(_la==TRUE || _la==FALSE) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LabelArgumentContext extends ParserRuleContext {
		public LabelMaxLengthContext labelMaxLength() {
			return getRuleContext(LabelMaxLengthContext.class,0);
		}
		public LabelCommentContext labelComment() {
			return getRuleContext(LabelCommentContext.class,0);
		}
		public LabelLockedContext labelLocked() {
			return getRuleContext(LabelLockedContext.class,0);
		}
		public LabelArgumentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelArgument; }
	}

	public final LabelArgumentContext labelArgument() throws RecognitionException {
		LabelArgumentContext _localctx = new LabelArgumentContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_labelArgument);
		try {
			setState(227);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(224);
				labelMaxLength();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(225);
				labelComment();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(226);
				labelLocked();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class LabelArgsContext extends ParserRuleContext {
		public List<LabelArgumentContext> labelArgument() {
			return getRuleContexts(LabelArgumentContext.class);
		}
		public LabelArgumentContext labelArgument(int i) {
			return getRuleContext(LabelArgumentContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public LabelArgsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_labelArgs; }
	}

	public final LabelArgsContext labelArgs() throws RecognitionException {
		LabelArgsContext _localctx = new LabelArgsContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_labelArgs);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(229);
			labelArgument();
			setState(234);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,9,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(230);
					match(COMMA);
					setState(231);
					labelArgument();
					}
					} 
				}
				setState(236);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,9,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class OptionValueContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public OptionValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_optionValue; }
	}

	public final OptionValueContext optionValue() throws RecognitionException {
		OptionValueContext _localctx = new OptionValueContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_optionValue);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(237);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class OptionValueListContext extends ParserRuleContext {
		public List<OptionValueContext> optionValue() {
			return getRuleContexts(OptionValueContext.class);
		}
		public OptionValueContext optionValue(int i) {
			return getRuleContext(OptionValueContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public OptionValueListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_optionValueList; }
	}

	public final OptionValueListContext optionValueList() throws RecognitionException {
		OptionValueListContext _localctx = new OptionValueListContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_optionValueList);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(239);
			optionValue();
			setState(244);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,10,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(240);
					match(COMMA);
					setState(241);
					optionValue();
					}
					} 
				}
				setState(246);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,10,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ObjectIdContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public ObjectIdContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_objectId; }
	}

	public final ObjectIdContext objectId() throws RecognitionException {
		ObjectIdContext _localctx = new ObjectIdContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_objectId);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(247);
			_la = _input.LA(1);
			if ( !(_la==INTEGER_LITERAL || _la==IDENTIFIER) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DimensionsContext extends ParserRuleContext {
		public List<TerminalNode> INTEGER_LITERAL() { return getTokens(ALCodeParser.INTEGER_LITERAL); }
		public TerminalNode INTEGER_LITERAL(int i) {
			return getToken(ALCodeParser.INTEGER_LITERAL, i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public DimensionsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_dimensions; }
	}

	public final DimensionsContext dimensions() throws RecognitionException {
		DimensionsContext _localctx = new DimensionsContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_dimensions);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(249);
			match(INTEGER_LITERAL);
			setState(254);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,11,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(250);
					match(COMMA);
					setState(251);
					match(INTEGER_LITERAL);
					}
					} 
				}
				setState(256);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,11,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class VariableTypeDeclarationContext extends ParserRuleContext {
		public VariableTypeDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableTypeDeclaration; }
	 
		public VariableTypeDeclarationContext() { }
		public void copyFrom(VariableTypeDeclarationContext ctx) {
			super.copyFrom(ctx);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class TextConstantVariableContext extends VariableTypeDeclarationContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(ALCodeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ALCodeParser.IDENTIFIER, i);
		}
		public TerminalNode EQUAL() { return getToken(ALCodeParser.EQUAL, 0); }
		public TerminalNode STRING_LITERAL() { return getToken(ALCodeParser.STRING_LITERAL, 0); }
		public TextConstantVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ApplicationObjectVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public ObjectIdContext objectId() {
			return getRuleContext(ObjectIdContext.class,0);
		}
		public ApplicationObjectVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class DictionaryVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode OF() { return getToken(ALCodeParser.OF, 0); }
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public DictionaryKeyContext dictionaryKey() {
			return getRuleContext(DictionaryKeyContext.class,0);
		}
		public TerminalNode COMMA() { return getToken(ALCodeParser.COMMA, 0); }
		public DictionaryDataTypeContext dictionaryDataType() {
			return getRuleContext(DictionaryDataTypeContext.class,0);
		}
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public DictionaryVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ListVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode OF() { return getToken(ALCodeParser.OF, 0); }
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public VariableTypeDeclarationContext variableTypeDeclaration() {
			return getRuleContext(VariableTypeDeclarationContext.class,0);
		}
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public ListVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ArrayVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode ARRAY() { return getToken(ALCodeParser.ARRAY, 0); }
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public DimensionsContext dimensions() {
			return getRuleContext(DimensionsContext.class,0);
		}
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public TerminalNode OF() { return getToken(ALCodeParser.OF, 0); }
		public VariableTypeDeclarationContext variableTypeDeclaration() {
			return getRuleContext(VariableTypeDeclarationContext.class,0);
		}
		public ArrayVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class LabelVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public LabelTextContext labelText() {
			return getRuleContext(LabelTextContext.class,0);
		}
		public TerminalNode COMMA() { return getToken(ALCodeParser.COMMA, 0); }
		public LabelArgsContext labelArgs() {
			return getRuleContext(LabelArgsContext.class,0);
		}
		public LabelVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class RecordVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public ObjectIdContext objectId() {
			return getRuleContext(ObjectIdContext.class,0);
		}
		public TerminalNode TEMPORARY() { return getToken(ALCodeParser.TEMPORARY, 0); }
		public RecordVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class TextVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public SizeDeclarationContext sizeDeclaration() {
			return getRuleContext(SizeDeclarationContext.class,0);
		}
		public TextVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class SimpleVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public SimpleVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class CodeVariableContext extends VariableTypeDeclarationContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public SizeDeclarationContext sizeDeclaration() {
			return getRuleContext(SizeDeclarationContext.class,0);
		}
		public CodeVariableContext(VariableTypeDeclarationContext ctx) { copyFrom(ctx); }
	}

	public final VariableTypeDeclarationContext variableTypeDeclaration() throws RecognitionException {
		VariableTypeDeclarationContext _localctx = new VariableTypeDeclarationContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_variableTypeDeclaration);
		int _la;
		try {
			setState(311);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
			case 1:
				_localctx = new DictionaryVariableContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(257);
				if (!(TokenMatches("dictionary"))) throw new FailedPredicateException(this, "TokenMatches(\"dictionary\")");
				setState(258);
				match(IDENTIFIER);
				setState(259);
				match(OF);
				setState(260);
				match(LEFTBRACKET);
				setState(261);
				dictionaryKey();
				setState(262);
				match(COMMA);
				setState(263);
				dictionaryDataType();
				setState(264);
				match(RIGHTBRACKET);
				}
				break;
			case 2:
				_localctx = new ListVariableContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(266);
				if (!(TokenMatches("list"))) throw new FailedPredicateException(this, "TokenMatches(\"list\")");
				setState(267);
				match(IDENTIFIER);
				setState(268);
				match(OF);
				setState(269);
				match(LEFTBRACKET);
				setState(270);
				variableTypeDeclaration();
				setState(271);
				match(RIGHTBRACKET);
				}
				break;
			case 3:
				_localctx = new ArrayVariableContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(273);
				match(ARRAY);
				setState(274);
				match(LEFTBRACKET);
				setState(275);
				dimensions();
				setState(276);
				match(RIGHTBRACKET);
				setState(277);
				match(OF);
				setState(278);
				variableTypeDeclaration();
				}
				break;
			case 4:
				_localctx = new ApplicationObjectVariableContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(280);
				if (!(TokenMatches(VarAppObjects))) throw new FailedPredicateException(this, "TokenMatches(VarAppObjects)");
				setState(281);
				match(IDENTIFIER);
				setState(282);
				objectId();
				}
				break;
			case 5:
				_localctx = new LabelVariableContext(_localctx);
				enterOuterAlt(_localctx, 5);
				{
				setState(283);
				if (!(TokenMatches("label"))) throw new FailedPredicateException(this, "TokenMatches(\"label\")");
				setState(284);
				match(IDENTIFIER);
				setState(285);
				labelText();
				setState(288);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
				case 1:
					{
					setState(286);
					match(COMMA);
					setState(287);
					labelArgs();
					}
					break;
				}
				}
				break;
			case 6:
				_localctx = new RecordVariableContext(_localctx);
				enterOuterAlt(_localctx, 6);
				{
				setState(290);
				if (!(TokenMatches("record"))) throw new FailedPredicateException(this, "TokenMatches(\"record\")");
				setState(291);
				match(IDENTIFIER);
				setState(292);
				objectId();
				setState(294);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==TEMPORARY) {
					{
					setState(293);
					match(TEMPORARY);
					}
				}

				}
				break;
			case 7:
				_localctx = new TextVariableContext(_localctx);
				enterOuterAlt(_localctx, 7);
				{
				setState(296);
				if (!(TokenMatches("text"))) throw new FailedPredicateException(this, "TokenMatches(\"text\")");
				setState(297);
				match(IDENTIFIER);
				setState(299);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==LEFTBRACKET) {
					{
					setState(298);
					sizeDeclaration();
					}
				}

				}
				break;
			case 8:
				_localctx = new CodeVariableContext(_localctx);
				enterOuterAlt(_localctx, 8);
				{
				setState(301);
				if (!(TokenMatches("code"))) throw new FailedPredicateException(this, "TokenMatches(\"code\")");
				setState(302);
				match(IDENTIFIER);
				setState(303);
				sizeDeclaration();
				}
				break;
			case 9:
				_localctx = new TextConstantVariableContext(_localctx);
				enterOuterAlt(_localctx, 9);
				{
				setState(304);
				if (!(TokenMatches("textconst"))) throw new FailedPredicateException(this, "TokenMatches(\"textconst\")");
				setState(305);
				match(IDENTIFIER);
				setState(306);
				match(IDENTIFIER);
				setState(307);
				match(EQUAL);
				setState(308);
				match(STRING_LITERAL);
				}
				break;
			case 10:
				_localctx = new SimpleVariableContext(_localctx);
				enterOuterAlt(_localctx, 10);
				{
				setState(309);
				if (!(TokenMatches(VariableTypes))) throw new FailedPredicateException(this, "TokenMatches(VariableTypes)");
				setState(310);
				match(IDENTIFIER);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ParameterNameContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public ParameterNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterName; }
	}

	public final ParameterNameContext parameterName() throws RecognitionException {
		ParameterNameContext _localctx = new ParameterNameContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_parameterName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(313);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ParameterDeclarationContext extends ParserRuleContext {
		public ParameterNameContext parameterName() {
			return getRuleContext(ParameterNameContext.class,0);
		}
		public TerminalNode COLON() { return getToken(ALCodeParser.COLON, 0); }
		public VariableTypeDeclarationContext variableTypeDeclaration() {
			return getRuleContext(VariableTypeDeclarationContext.class,0);
		}
		public TerminalNode VAR() { return getToken(ALCodeParser.VAR, 0); }
		public ParameterDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterDeclaration; }
	}

	public final ParameterDeclarationContext parameterDeclaration() throws RecognitionException {
		ParameterDeclarationContext _localctx = new ParameterDeclarationContext(_ctx, getState());
		enterRule(_localctx, 48, RULE_parameterDeclaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(316);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==VAR) {
				{
				setState(315);
				match(VAR);
				}
			}

			setState(318);
			parameterName();
			setState(319);
			match(COLON);
			setState(320);
			variableTypeDeclaration();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ParameterListContext extends ParserRuleContext {
		public List<ParameterDeclarationContext> parameterDeclaration() {
			return getRuleContexts(ParameterDeclarationContext.class);
		}
		public ParameterDeclarationContext parameterDeclaration(int i) {
			return getRuleContext(ParameterDeclarationContext.class,i);
		}
		public List<TerminalNode> SEMICOLON() { return getTokens(ALCodeParser.SEMICOLON); }
		public TerminalNode SEMICOLON(int i) {
			return getToken(ALCodeParser.SEMICOLON, i);
		}
		public ParameterListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterList; }
	}

	public final ParameterListContext parameterList() throws RecognitionException {
		ParameterListContext _localctx = new ParameterListContext(_ctx, getState());
		enterRule(_localctx, 50, RULE_parameterList);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(322);
			parameterDeclaration();
			setState(327);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(323);
					match(SEMICOLON);
					setState(324);
					parameterDeclaration();
					}
					} 
				}
				setState(329);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class VariableNameListContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(ALCodeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ALCodeParser.IDENTIFIER, i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public VariableNameListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableNameList; }
	}

	public final VariableNameListContext variableNameList() throws RecognitionException {
		VariableNameListContext _localctx = new VariableNameListContext(_ctx, getState());
		enterRule(_localctx, 52, RULE_variableNameList);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(330);
			match(IDENTIFIER);
			setState(335);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,18,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(331);
					match(COMMA);
					setState(332);
					match(IDENTIFIER);
					}
					} 
				}
				setState(337);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,18,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class VariableDeclarationContext extends ParserRuleContext {
		public VariableNameListContext variableNameList() {
			return getRuleContext(VariableNameListContext.class,0);
		}
		public TerminalNode COLON() { return getToken(ALCodeParser.COLON, 0); }
		public VariableTypeDeclarationContext variableTypeDeclaration() {
			return getRuleContext(VariableTypeDeclarationContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(ALCodeParser.SEMICOLON, 0); }
		public VariableDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableDeclaration; }
	}

	public final VariableDeclarationContext variableDeclaration() throws RecognitionException {
		VariableDeclarationContext _localctx = new VariableDeclarationContext(_ctx, getState());
		enterRule(_localctx, 54, RULE_variableDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(338);
			variableNameList();
			setState(339);
			match(COLON);
			setState(340);
			variableTypeDeclaration();
			setState(341);
			match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class VariableDeclarationsContext extends ParserRuleContext {
		public List<VariableDeclarationContext> variableDeclaration() {
			return getRuleContexts(VariableDeclarationContext.class);
		}
		public VariableDeclarationContext variableDeclaration(int i) {
			return getRuleContext(VariableDeclarationContext.class,i);
		}
		public VariableDeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableDeclarations; }
	}

	public final VariableDeclarationsContext variableDeclarations() throws RecognitionException {
		VariableDeclarationsContext _localctx = new VariableDeclarationsContext(_ctx, getState());
		enterRule(_localctx, 56, RULE_variableDeclarations);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(343);
			variableDeclaration();
			setState(347);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(344);
					variableDeclaration();
					}
					} 
				}
				setState(349);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class VarBlockContext extends ParserRuleContext {
		public TerminalNode VAR() { return getToken(ALCodeParser.VAR, 0); }
		public VariableDeclarationsContext variableDeclarations() {
			return getRuleContext(VariableDeclarationsContext.class,0);
		}
		public VarBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_varBlock; }
	}

	public final VarBlockContext varBlock() throws RecognitionException {
		VarBlockContext _localctx = new VarBlockContext(_ctx, getState());
		enterRule(_localctx, 58, RULE_varBlock);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(350);
			match(VAR);
			setState(351);
			variableDeclarations();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ProtectedVarBlockContext extends ParserRuleContext {
		public TerminalNode PROTECTED() { return getToken(ALCodeParser.PROTECTED, 0); }
		public TerminalNode VAR() { return getToken(ALCodeParser.VAR, 0); }
		public VariableDeclarationContext variableDeclaration() {
			return getRuleContext(VariableDeclarationContext.class,0);
		}
		public ProtectedVarBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_protectedVarBlock; }
	}

	public final ProtectedVarBlockContext protectedVarBlock() throws RecognitionException {
		ProtectedVarBlockContext _localctx = new ProtectedVarBlockContext(_ctx, getState());
		enterRule(_localctx, 60, RULE_protectedVarBlock);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(353);
			match(PROTECTED);
			setState(354);
			match(VAR);
			setState(355);
			variableDeclaration();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ReturnValueContext extends ParserRuleContext {
		public TerminalNode COLON() { return getToken(ALCodeParser.COLON, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public ReturnValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_returnValue; }
	}

	public final ReturnValueContext returnValue() throws RecognitionException {
		ReturnValueContext _localctx = new ReturnValueContext(_ctx, getState());
		enterRule(_localctx, 62, RULE_returnValue);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(357);
			match(COLON);
			setState(358);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class TriggerNameContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TriggerNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_triggerName; }
	}

	public final TriggerNameContext triggerName() throws RecognitionException {
		TriggerNameContext _localctx = new TriggerNameContext(_ctx, getState());
		enterRule(_localctx, 64, RULE_triggerName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(360);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class TriggerDeclarationContext extends ParserRuleContext {
		public TerminalNode TRIGGER() { return getToken(ALCodeParser.TRIGGER, 0); }
		public TriggerNameContext triggerName() {
			return getRuleContext(TriggerNameContext.class,0);
		}
		public TerminalNode LEFTPAREN() { return getToken(ALCodeParser.LEFTPAREN, 0); }
		public TerminalNode RIGHTPAREN() { return getToken(ALCodeParser.RIGHTPAREN, 0); }
		public StatementBlockContext statementBlock() {
			return getRuleContext(StatementBlockContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(ALCodeParser.SEMICOLON, 0); }
		public ParameterListContext parameterList() {
			return getRuleContext(ParameterListContext.class,0);
		}
		public ReturnValueContext returnValue() {
			return getRuleContext(ReturnValueContext.class,0);
		}
		public VarBlockContext varBlock() {
			return getRuleContext(VarBlockContext.class,0);
		}
		public TriggerDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_triggerDeclaration; }
	}

	public final TriggerDeclarationContext triggerDeclaration() throws RecognitionException {
		TriggerDeclarationContext _localctx = new TriggerDeclarationContext(_ctx, getState());
		enterRule(_localctx, 66, RULE_triggerDeclaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(362);
			match(TRIGGER);
			setState(363);
			triggerName();
			setState(364);
			match(LEFTPAREN);
			setState(366);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==VAR || _la==IDENTIFIER) {
				{
				setState(365);
				parameterList();
				}
			}

			setState(368);
			match(RIGHTPAREN);
			setState(370);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==COLON) {
				{
				setState(369);
				returnValue();
				}
			}

			setState(373);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==VAR) {
				{
				setState(372);
				varBlock();
				}
			}

			setState(375);
			statementBlock();
			setState(376);
			match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CodeEntityContext extends ParserRuleContext {
		public VarBlockContext varBlock() {
			return getRuleContext(VarBlockContext.class,0);
		}
		public ProtectedVarBlockContext protectedVarBlock() {
			return getRuleContext(ProtectedVarBlockContext.class,0);
		}
		public TriggerDeclarationContext triggerDeclaration() {
			return getRuleContext(TriggerDeclarationContext.class,0);
		}
		public MethodDeclarationContext methodDeclaration() {
			return getRuleContext(MethodDeclarationContext.class,0);
		}
		public CodeEntityContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_codeEntity; }
	}

	public final CodeEntityContext codeEntity() throws RecognitionException {
		CodeEntityContext _localctx = new CodeEntityContext(_ctx, getState());
		enterRule(_localctx, 68, RULE_codeEntity);
		try {
			setState(382);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case VAR:
				enterOuterAlt(_localctx, 1);
				{
				setState(378);
				varBlock();
				}
				break;
			case PROTECTED:
				enterOuterAlt(_localctx, 2);
				{
				setState(379);
				protectedVarBlock();
				}
				break;
			case TRIGGER:
				enterOuterAlt(_localctx, 3);
				{
				setState(380);
				triggerDeclaration();
				}
				break;
			case LEFTBRACKET:
			case PROCEDURE:
				enterOuterAlt(_localctx, 4);
				{
				setState(381);
				methodDeclaration();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CodeDeclarationsContext extends ParserRuleContext {
		public List<CodeEntityContext> codeEntity() {
			return getRuleContexts(CodeEntityContext.class);
		}
		public CodeEntityContext codeEntity(int i) {
			return getRuleContext(CodeEntityContext.class,i);
		}
		public CodeDeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_codeDeclarations; }
	}

	public final CodeDeclarationsContext codeDeclarations() throws RecognitionException {
		CodeDeclarationsContext _localctx = new CodeDeclarationsContext(_ctx, getState());
		enterRule(_localctx, 70, RULE_codeDeclarations);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(385); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(384);
				codeEntity();
				}
				}
				setState(387); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( ((((_la - 27)) & ~0x3f) == 0 && ((1L << (_la - 27)) & 88046829568001L) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IfConditionStatementContext extends ParserRuleContext {
		public TerminalNode IF() { return getToken(ALCodeParser.IF, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode THEN() { return getToken(ALCodeParser.THEN, 0); }
		public IfConditionStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ifConditionStatement; }
	}

	public final IfConditionStatementContext ifConditionStatement() throws RecognitionException {
		IfConditionStatementContext _localctx = new IfConditionStatementContext(_ctx, getState());
		enterRule(_localctx, 72, RULE_ifConditionStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(389);
			match(IF);
			setState(390);
			expression(0);
			setState(391);
			match(THEN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ElseStatementContext extends ParserRuleContext {
		public TerminalNode ELSE() { return getToken(ALCodeParser.ELSE, 0); }
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public ElseStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_elseStatement; }
	}

	public final ElseStatementContext elseStatement() throws RecognitionException {
		ElseStatementContext _localctx = new ElseStatementContext(_ctx, getState());
		enterRule(_localctx, 74, RULE_elseStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(393);
			match(ELSE);
			setState(394);
			statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IfStatementContext extends ParserRuleContext {
		public IfConditionStatementContext ifConditionStatement() {
			return getRuleContext(IfConditionStatementContext.class,0);
		}
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public ElseStatementContext elseStatement() {
			return getRuleContext(ElseStatementContext.class,0);
		}
		public IfStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ifStatement; }
	}

	public final IfStatementContext ifStatement() throws RecognitionException {
		IfStatementContext _localctx = new IfStatementContext(_ctx, getState());
		enterRule(_localctx, 76, RULE_ifStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(396);
			ifConditionStatement();
			setState(397);
			statement();
			setState(399);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,25,_ctx) ) {
			case 1:
				{
				setState(398);
				elseStatement();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class WhileConditionalStatementContext extends ParserRuleContext {
		public TerminalNode WHILE() { return getToken(ALCodeParser.WHILE, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode DO() { return getToken(ALCodeParser.DO, 0); }
		public WhileConditionalStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_whileConditionalStatement; }
	}

	public final WhileConditionalStatementContext whileConditionalStatement() throws RecognitionException {
		WhileConditionalStatementContext _localctx = new WhileConditionalStatementContext(_ctx, getState());
		enterRule(_localctx, 78, RULE_whileConditionalStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(401);
			match(WHILE);
			setState(402);
			expression(0);
			setState(403);
			match(DO);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class WhileStatementContext extends ParserRuleContext {
		public WhileConditionalStatementContext whileConditionalStatement() {
			return getRuleContext(WhileConditionalStatementContext.class,0);
		}
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public WhileStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_whileStatement; }
	}

	public final WhileStatementContext whileStatement() throws RecognitionException {
		WhileStatementContext _localctx = new WhileStatementContext(_ctx, getState());
		enterRule(_localctx, 80, RULE_whileStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(405);
			whileConditionalStatement();
			setState(406);
			statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ForValueContext extends ParserRuleContext {
		public TerminalNode DATE_LITERAL() { return getToken(ALCodeParser.DATE_LITERAL, 0); }
		public TerminalNode TIME_LITERAL() { return getToken(ALCodeParser.TIME_LITERAL, 0); }
		public BooleanLiteralContext booleanLiteral() {
			return getRuleContext(BooleanLiteralContext.class,0);
		}
		public NumberLiteralContext numberLiteral() {
			return getRuleContext(NumberLiteralContext.class,0);
		}
		public ForValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_forValue; }
	}

	public final ForValueContext forValue() throws RecognitionException {
		ForValueContext _localctx = new ForValueContext(_ctx, getState());
		enterRule(_localctx, 82, RULE_forValue);
		try {
			setState(412);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case DATE_LITERAL:
				enterOuterAlt(_localctx, 1);
				{
				setState(408);
				match(DATE_LITERAL);
				}
				break;
			case TIME_LITERAL:
				enterOuterAlt(_localctx, 2);
				{
				setState(409);
				match(TIME_LITERAL);
				}
				break;
			case TRUE:
			case FALSE:
				enterOuterAlt(_localctx, 3);
				{
				setState(410);
				booleanLiteral();
				}
				break;
			case INTEGER_LITERAL:
			case FLOAT_LITERAL:
				enterOuterAlt(_localctx, 4);
				{
				setState(411);
				numberLiteral();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ForControlStatementContext extends ParserRuleContext {
		public TerminalNode FOR() { return getToken(ALCodeParser.FOR, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode ASSGN() { return getToken(ALCodeParser.ASSGN, 0); }
		public List<ForValueContext> forValue() {
			return getRuleContexts(ForValueContext.class);
		}
		public ForValueContext forValue(int i) {
			return getRuleContext(ForValueContext.class,i);
		}
		public TerminalNode DO() { return getToken(ALCodeParser.DO, 0); }
		public TerminalNode TO() { return getToken(ALCodeParser.TO, 0); }
		public TerminalNode DOWNTO() { return getToken(ALCodeParser.DOWNTO, 0); }
		public ForControlStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_forControlStatement; }
	}

	public final ForControlStatementContext forControlStatement() throws RecognitionException {
		ForControlStatementContext _localctx = new ForControlStatementContext(_ctx, getState());
		enterRule(_localctx, 84, RULE_forControlStatement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(414);
			match(FOR);
			setState(415);
			match(IDENTIFIER);
			setState(416);
			match(ASSGN);
			setState(417);
			forValue();
			setState(418);
			_la = _input.LA(1);
			if ( !(_la==DOWNTO || _la==TO) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			setState(419);
			forValue();
			setState(420);
			match(DO);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ForStatementContext extends ParserRuleContext {
		public ForControlStatementContext forControlStatement() {
			return getRuleContext(ForControlStatementContext.class,0);
		}
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public ForStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_forStatement; }
	}

	public final ForStatementContext forStatement() throws RecognitionException {
		ForStatementContext _localctx = new ForStatementContext(_ctx, getState());
		enterRule(_localctx, 86, RULE_forStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(422);
			forControlStatement();
			setState(423);
			statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseValueContext extends ParserRuleContext {
		public NumberLiteralContext numberLiteral() {
			return getRuleContext(NumberLiteralContext.class,0);
		}
		public BooleanLiteralContext booleanLiteral() {
			return getRuleContext(BooleanLiteralContext.class,0);
		}
		public TerminalNode DATE_LITERAL() { return getToken(ALCodeParser.DATE_LITERAL, 0); }
		public TerminalNode TIME_LITERAL() { return getToken(ALCodeParser.TIME_LITERAL, 0); }
		public TerminalNode DATETIME_LITERAL() { return getToken(ALCodeParser.DATETIME_LITERAL, 0); }
		public OptionLiteralContext optionLiteral() {
			return getRuleContext(OptionLiteralContext.class,0);
		}
		public TerminalNode STRING_LITERAL() { return getToken(ALCodeParser.STRING_LITERAL, 0); }
		public CaseValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseValue; }
	}

	public final CaseValueContext caseValue() throws RecognitionException {
		CaseValueContext _localctx = new CaseValueContext(_ctx, getState());
		enterRule(_localctx, 88, RULE_caseValue);
		try {
			setState(432);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case INTEGER_LITERAL:
			case FLOAT_LITERAL:
				enterOuterAlt(_localctx, 1);
				{
				setState(425);
				numberLiteral();
				}
				break;
			case TRUE:
			case FALSE:
				enterOuterAlt(_localctx, 2);
				{
				setState(426);
				booleanLiteral();
				}
				break;
			case DATE_LITERAL:
				enterOuterAlt(_localctx, 3);
				{
				setState(427);
				match(DATE_LITERAL);
				}
				break;
			case TIME_LITERAL:
				enterOuterAlt(_localctx, 4);
				{
				setState(428);
				match(TIME_LITERAL);
				}
				break;
			case DATETIME_LITERAL:
				enterOuterAlt(_localctx, 5);
				{
				setState(429);
				match(DATETIME_LITERAL);
				}
				break;
			case IDENTIFIER:
				enterOuterAlt(_localctx, 6);
				{
				setState(430);
				optionLiteral();
				}
				break;
			case STRING_LITERAL:
				enterOuterAlt(_localctx, 7);
				{
				setState(431);
				match(STRING_LITERAL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseSetContext extends ParserRuleContext {
		public List<CaseValueContext> caseValue() {
			return getRuleContexts(CaseValueContext.class);
		}
		public CaseValueContext caseValue(int i) {
			return getRuleContext(CaseValueContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public CaseSetContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseSet; }
	}

	public final CaseSetContext caseSet() throws RecognitionException {
		CaseSetContext _localctx = new CaseSetContext(_ctx, getState());
		enterRule(_localctx, 90, RULE_caseSet);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(434);
			caseValue();
			setState(439);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,28,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(435);
					match(COMMA);
					setState(436);
					caseValue();
					}
					} 
				}
				setState(441);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,28,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseRangeContext extends ParserRuleContext {
		public List<CaseValueContext> caseValue() {
			return getRuleContexts(CaseValueContext.class);
		}
		public CaseValueContext caseValue(int i) {
			return getRuleContext(CaseValueContext.class,i);
		}
		public TerminalNode RANGE() { return getToken(ALCodeParser.RANGE, 0); }
		public CaseRangeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseRange; }
	}

	public final CaseRangeContext caseRange() throws RecognitionException {
		CaseRangeContext _localctx = new CaseRangeContext(_ctx, getState());
		enterRule(_localctx, 92, RULE_caseRange);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(442);
			caseValue();
			setState(443);
			match(RANGE);
			setState(444);
			caseValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseValueStatementContext extends ParserRuleContext {
		public TerminalNode COLON() { return getToken(ALCodeParser.COLON, 0); }
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public CaseSetContext caseSet() {
			return getRuleContext(CaseSetContext.class,0);
		}
		public CaseRangeContext caseRange() {
			return getRuleContext(CaseRangeContext.class,0);
		}
		public CaseValueStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseValueStatement; }
	}

	public final CaseValueStatementContext caseValueStatement() throws RecognitionException {
		CaseValueStatementContext _localctx = new CaseValueStatementContext(_ctx, getState());
		enterRule(_localctx, 94, RULE_caseValueStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(448);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,29,_ctx) ) {
			case 1:
				{
				setState(446);
				caseSet();
				}
				break;
			case 2:
				{
				setState(447);
				caseRange();
				}
				break;
			}
			setState(450);
			match(COLON);
			setState(451);
			statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseElseStatementContext extends ParserRuleContext {
		public TerminalNode ELSE() { return getToken(ALCodeParser.ELSE, 0); }
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public CaseElseStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseElseStatement; }
	}

	public final CaseElseStatementContext caseElseStatement() throws RecognitionException {
		CaseElseStatementContext _localctx = new CaseElseStatementContext(_ctx, getState());
		enterRule(_localctx, 96, RULE_caseElseStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(453);
			match(ELSE);
			setState(454);
			statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseBodyContext extends ParserRuleContext {
		public List<CaseValueStatementContext> caseValueStatement() {
			return getRuleContexts(CaseValueStatementContext.class);
		}
		public CaseValueStatementContext caseValueStatement(int i) {
			return getRuleContext(CaseValueStatementContext.class,i);
		}
		public CaseElseStatementContext caseElseStatement() {
			return getRuleContext(CaseElseStatementContext.class,0);
		}
		public List<TerminalNode> SEMICOLON() { return getTokens(ALCodeParser.SEMICOLON); }
		public TerminalNode SEMICOLON(int i) {
			return getToken(ALCodeParser.SEMICOLON, i);
		}
		public CaseBodyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseBody; }
	}

	public final CaseBodyContext caseBody() throws RecognitionException {
		CaseBodyContext _localctx = new CaseBodyContext(_ctx, getState());
		enterRule(_localctx, 98, RULE_caseBody);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(464);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (((((_la - 77)) & ~0x3f) == 0 && ((1L << (_la - 77)) & 511L) != 0)) {
				{
				setState(456);
				caseValueStatement();
				setState(461);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,30,_ctx);
				while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1+1 ) {
						{
						{
						setState(457);
						match(SEMICOLON);
						setState(458);
						caseValueStatement();
						}
						} 
					}
					setState(463);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,30,_ctx);
				}
				}
			}

			setState(467);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==ELSE) {
				{
				setState(466);
				caseElseStatement();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseControlStatementContext extends ParserRuleContext {
		public TerminalNode CASE() { return getToken(ALCodeParser.CASE, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode OF() { return getToken(ALCodeParser.OF, 0); }
		public CaseControlStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseControlStatement; }
	}

	public final CaseControlStatementContext caseControlStatement() throws RecognitionException {
		CaseControlStatementContext _localctx = new CaseControlStatementContext(_ctx, getState());
		enterRule(_localctx, 100, RULE_caseControlStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(469);
			match(CASE);
			setState(470);
			expression(0);
			setState(471);
			match(OF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CaseStatementContext extends ParserRuleContext {
		public CaseControlStatementContext caseControlStatement() {
			return getRuleContext(CaseControlStatementContext.class,0);
		}
		public CaseBodyContext caseBody() {
			return getRuleContext(CaseBodyContext.class,0);
		}
		public TerminalNode END() { return getToken(ALCodeParser.END, 0); }
		public CaseStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_caseStatement; }
	}

	public final CaseStatementContext caseStatement() throws RecognitionException {
		CaseStatementContext _localctx = new CaseStatementContext(_ctx, getState());
		enterRule(_localctx, 102, RULE_caseStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(473);
			caseControlStatement();
			setState(474);
			caseBody();
			setState(475);
			match(END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class UntilConditionContext extends ParserRuleContext {
		public TerminalNode UNTIL() { return getToken(ALCodeParser.UNTIL, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public UntilConditionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_untilCondition; }
	}

	public final UntilConditionContext untilCondition() throws RecognitionException {
		UntilConditionContext _localctx = new UntilConditionContext(_ctx, getState());
		enterRule(_localctx, 104, RULE_untilCondition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(477);
			match(UNTIL);
			setState(478);
			expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class RepeatUntilStatementContext extends ParserRuleContext {
		public TerminalNode REPEAT() { return getToken(ALCodeParser.REPEAT, 0); }
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public UntilConditionContext untilCondition() {
			return getRuleContext(UntilConditionContext.class,0);
		}
		public RepeatUntilStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_repeatUntilStatement; }
	}

	public final RepeatUntilStatementContext repeatUntilStatement() throws RecognitionException {
		RepeatUntilStatementContext _localctx = new RepeatUntilStatementContext(_ctx, getState());
		enterRule(_localctx, 106, RULE_repeatUntilStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(480);
			match(REPEAT);
			setState(481);
			statement();
			setState(482);
			untilCondition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class WithControlStatementContext extends ParserRuleContext {
		public TerminalNode WITH() { return getToken(ALCodeParser.WITH, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode DO() { return getToken(ALCodeParser.DO, 0); }
		public WithControlStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_withControlStatement; }
	}

	public final WithControlStatementContext withControlStatement() throws RecognitionException {
		WithControlStatementContext _localctx = new WithControlStatementContext(_ctx, getState());
		enterRule(_localctx, 108, RULE_withControlStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(484);
			match(WITH);
			setState(485);
			match(IDENTIFIER);
			setState(486);
			match(DO);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class WithStatementContext extends ParserRuleContext {
		public WithControlStatementContext withControlStatement() {
			return getRuleContext(WithControlStatementContext.class,0);
		}
		public StatementContext statement() {
			return getRuleContext(StatementContext.class,0);
		}
		public WithStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_withStatement; }
	}

	public final WithStatementContext withStatement() throws RecognitionException {
		WithStatementContext _localctx = new WithStatementContext(_ctx, getState());
		enterRule(_localctx, 110, RULE_withStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(488);
			withControlStatement();
			setState(489);
			statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ExitStatementContext extends ParserRuleContext {
		public TerminalNode EXIT() { return getToken(ALCodeParser.EXIT, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public ExitStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exitStatement; }
	}

	public final ExitStatementContext exitStatement() throws RecognitionException {
		ExitStatementContext _localctx = new ExitStatementContext(_ctx, getState());
		enterRule(_localctx, 112, RULE_exitStatement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(491);
			match(EXIT);
			setState(493);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (((((_la - 22)) & ~0x3f) == 0 && ((1L << (_la - 22)) & -36028797018947543L) != 0)) {
				{
				setState(492);
				expression(0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StatementLineContext extends ParserRuleContext {
		public IfStatementContext ifStatement() {
			return getRuleContext(IfStatementContext.class,0);
		}
		public ForStatementContext forStatement() {
			return getRuleContext(ForStatementContext.class,0);
		}
		public CaseStatementContext caseStatement() {
			return getRuleContext(CaseStatementContext.class,0);
		}
		public WithStatementContext withStatement() {
			return getRuleContext(WithStatementContext.class,0);
		}
		public WhileStatementContext whileStatement() {
			return getRuleContext(WhileStatementContext.class,0);
		}
		public RepeatUntilStatementContext repeatUntilStatement() {
			return getRuleContext(RepeatUntilStatementContext.class,0);
		}
		public ExitStatementContext exitStatement() {
			return getRuleContext(ExitStatementContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public StatementLineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statementLine; }
	}

	public final StatementLineContext statementLine() throws RecognitionException {
		StatementLineContext _localctx = new StatementLineContext(_ctx, getState());
		enterRule(_localctx, 114, RULE_statementLine);
		try {
			setState(503);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case IF:
				enterOuterAlt(_localctx, 1);
				{
				setState(495);
				ifStatement();
				}
				break;
			case FOR:
				enterOuterAlt(_localctx, 2);
				{
				setState(496);
				forStatement();
				}
				break;
			case CASE:
				enterOuterAlt(_localctx, 3);
				{
				setState(497);
				caseStatement();
				}
				break;
			case WITH:
				enterOuterAlt(_localctx, 4);
				{
				setState(498);
				withStatement();
				}
				break;
			case WHILE:
				enterOuterAlt(_localctx, 5);
				{
				setState(499);
				whileStatement();
				}
				break;
			case REPEAT:
				enterOuterAlt(_localctx, 6);
				{
				setState(500);
				repeatUntilStatement();
				}
				break;
			case EXIT:
				enterOuterAlt(_localctx, 7);
				{
				setState(501);
				exitStatement();
				}
				break;
			case MINUS:
			case LEFTPAREN:
			case LEFTBRACKET:
			case NOT:
			case TRUE:
			case FALSE:
			case DATE_LITERAL:
			case TIME_LITERAL:
			case DATETIME_LITERAL:
			case INTEGER_LITERAL:
			case FLOAT_LITERAL:
			case STRING_LITERAL:
			case IDENTIFIER:
				enterOuterAlt(_localctx, 8);
				{
				setState(502);
				expression(0);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StatementBlockContext extends ParserRuleContext {
		public TerminalNode BEGIN() { return getToken(ALCodeParser.BEGIN, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode END() { return getToken(ALCodeParser.END, 0); }
		public StatementBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statementBlock; }
	}

	public final StatementBlockContext statementBlock() throws RecognitionException {
		StatementBlockContext _localctx = new StatementBlockContext(_ctx, getState());
		enterRule(_localctx, 116, RULE_statementBlock);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(505);
			match(BEGIN);
			setState(506);
			statementList();
			setState(507);
			match(END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StatementContext extends ParserRuleContext {
		public StatementLineContext statementLine() {
			return getRuleContext(StatementLineContext.class,0);
		}
		public StatementBlockContext statementBlock() {
			return getRuleContext(StatementBlockContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(ALCodeParser.SEMICOLON, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 118, RULE_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(511);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case MINUS:
			case LEFTPAREN:
			case LEFTBRACKET:
			case NOT:
			case CASE:
			case EXIT:
			case FOR:
			case IF:
			case REPEAT:
			case WHILE:
			case WITH:
			case TRUE:
			case FALSE:
			case DATE_LITERAL:
			case TIME_LITERAL:
			case DATETIME_LITERAL:
			case INTEGER_LITERAL:
			case FLOAT_LITERAL:
			case STRING_LITERAL:
			case IDENTIFIER:
				{
				setState(509);
				statementLine();
				}
				break;
			case BEGIN:
				{
				setState(510);
				statementBlock();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(514);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,36,_ctx) ) {
			case 1:
				{
				setState(513);
				match(SEMICOLON);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StatementListContext extends ParserRuleContext {
		public List<StatementLineContext> statementLine() {
			return getRuleContexts(StatementLineContext.class);
		}
		public StatementLineContext statementLine(int i) {
			return getRuleContext(StatementLineContext.class,i);
		}
		public List<TerminalNode> SEMICOLON() { return getTokens(ALCodeParser.SEMICOLON); }
		public TerminalNode SEMICOLON(int i) {
			return getToken(ALCodeParser.SEMICOLON, i);
		}
		public StatementListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statementList; }
	}

	public final StatementListContext statementList() throws RecognitionException {
		StatementListContext _localctx = new StatementListContext(_ctx, getState());
		enterRule(_localctx, 120, RULE_statementList);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(524);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (((((_la - 22)) & ~0x3f) == 0 && ((1L << (_la - 22)) & -22513597739417559L) != 0)) {
				{
				setState(516);
				statementLine();
				setState(521);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,37,_ctx);
				while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1+1 ) {
						{
						{
						setState(517);
						match(SEMICOLON);
						setState(518);
						statementLine();
						}
						} 
					}
					setState(523);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,37,_ctx);
				}
				}
			}

			setState(527);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==SEMICOLON) {
				{
				setState(526);
				match(SEMICOLON);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IndexAccessorValueContext extends ParserRuleContext {
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public IndexAccessorValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_indexAccessorValue; }
	}

	public final IndexAccessorValueContext indexAccessorValue() throws RecognitionException {
		IndexAccessorValueContext _localctx = new IndexAccessorValueContext(_ctx, getState());
		enterRule(_localctx, 122, RULE_indexAccessorValue);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(529);
			_la = _input.LA(1);
			if ( !(_la==INTEGER_LITERAL || _la==IDENTIFIER) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IndexAccessorSetContext extends ParserRuleContext {
		public List<IndexAccessorValueContext> indexAccessorValue() {
			return getRuleContexts(IndexAccessorValueContext.class);
		}
		public IndexAccessorValueContext indexAccessorValue(int i) {
			return getRuleContext(IndexAccessorValueContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public IndexAccessorSetContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_indexAccessorSet; }
	}

	public final IndexAccessorSetContext indexAccessorSet() throws RecognitionException {
		IndexAccessorSetContext _localctx = new IndexAccessorSetContext(_ctx, getState());
		enterRule(_localctx, 124, RULE_indexAccessorSet);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(531);
			indexAccessorValue();
			setState(536);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,40,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(532);
					match(COMMA);
					setState(533);
					indexAccessorValue();
					}
					} 
				}
				setState(538);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,40,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ValueSetContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public ValueSetContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_valueSet; }
	}

	public final ValueSetContext valueSet() throws RecognitionException {
		ValueSetContext _localctx = new ValueSetContext(_ctx, getState());
		enterRule(_localctx, 126, RULE_valueSet);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(539);
			expression(0);
			setState(544);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,41,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(540);
					match(COMMA);
					setState(541);
					expression(0);
					}
					} 
				}
				setState(546);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,41,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ExpressionContext extends ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	 
		public ExpressionContext() { }
		public void copyFrom(ExpressionContext ctx) {
			super.copyFrom(ctx);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class NegationExpressionContext extends ExpressionContext {
		public TerminalNode NOT() { return getToken(ALCodeParser.NOT, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public NegationExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class MemberAccessExpressionContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public List<TerminalNode> PERIOD() { return getTokens(ALCodeParser.PERIOD); }
		public TerminalNode PERIOD(int i) {
			return getToken(ALCodeParser.PERIOD, i);
		}
		public List<TerminalNode> IDENTIFIER() { return getTokens(ALCodeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ALCodeParser.IDENTIFIER, i);
		}
		public MemberAccessExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class SetExpressionContext extends ExpressionContext {
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public ValueSetContext valueSet() {
			return getRuleContext(ValueSetContext.class,0);
		}
		public SetExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class StringLiteralExpressionContext extends ExpressionContext {
		public TerminalNode STRING_LITERAL() { return getToken(ALCodeParser.STRING_LITERAL, 0); }
		public StringLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class FloatLiteralExpressionContext extends ExpressionContext {
		public TerminalNode FLOAT_LITERAL() { return getToken(ALCodeParser.FLOAT_LITERAL, 0); }
		public FloatLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ParenthesisExpressionContext extends ExpressionContext {
		public TerminalNode LEFTPAREN() { return getToken(ALCodeParser.LEFTPAREN, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode RIGHTPAREN() { return getToken(ALCodeParser.RIGHTPAREN, 0); }
		public ParenthesisExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class InSetExpressionContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode IN() { return getToken(ALCodeParser.IN, 0); }
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public ValueSetContext valueSet() {
			return getRuleContext(ValueSetContext.class,0);
		}
		public InSetExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class IndexExpressionContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode LEFTBRACKET() { return getToken(ALCodeParser.LEFTBRACKET, 0); }
		public IndexAccessorSetContext indexAccessorSet() {
			return getRuleContext(IndexAccessorSetContext.class,0);
		}
		public TerminalNode RIGHTBRACKET() { return getToken(ALCodeParser.RIGHTBRACKET, 0); }
		public IndexExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class DateLiteralExpressionContext extends ExpressionContext {
		public TerminalNode DATE_LITERAL() { return getToken(ALCodeParser.DATE_LITERAL, 0); }
		public DateLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class FunctionCallExpressionContext extends ExpressionContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public TerminalNode RIGHTPAREN() { return getToken(ALCodeParser.RIGHTPAREN, 0); }
		public FunctionCallExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class IdentifierExpressionContext extends ExpressionContext {
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public IdentifierExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class TimeLiteralExpressionContext extends ExpressionContext {
		public TerminalNode TIME_LITERAL() { return getToken(ALCodeParser.TIME_LITERAL, 0); }
		public TimeLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ComparisonExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode LESSTHAN() { return getToken(ALCodeParser.LESSTHAN, 0); }
		public TerminalNode GREATERTHAN() { return getToken(ALCodeParser.GREATERTHAN, 0); }
		public TerminalNode LESSTHANEQUAL() { return getToken(ALCodeParser.LESSTHANEQUAL, 0); }
		public TerminalNode GREATERTHANEQUAL() { return getToken(ALCodeParser.GREATERTHANEQUAL, 0); }
		public TerminalNode NOTEQUAL() { return getToken(ALCodeParser.NOTEQUAL, 0); }
		public TerminalNode EQUAL() { return getToken(ALCodeParser.EQUAL, 0); }
		public ComparisonExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class MethodCallExpressionContext extends ExpressionContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(ALCodeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ALCodeParser.IDENTIFIER, i);
		}
		public TerminalNode LEFTPAREN() { return getToken(ALCodeParser.LEFTPAREN, 0); }
		public TerminalNode RIGHTPAREN() { return getToken(ALCodeParser.RIGHTPAREN, 0); }
		public List<TerminalNode> PERIOD() { return getTokens(ALCodeParser.PERIOD); }
		public TerminalNode PERIOD(int i) {
			return getToken(ALCodeParser.PERIOD, i);
		}
		public MethodCallArgumentsContext methodCallArguments() {
			return getRuleContext(MethodCallArgumentsContext.class,0);
		}
		public MethodCallExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class DivMultExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode ASTERISK() { return getToken(ALCodeParser.ASTERISK, 0); }
		public TerminalNode BACKSLASH() { return getToken(ALCodeParser.BACKSLASH, 0); }
		public TerminalNode MOD() { return getToken(ALCodeParser.MOD, 0); }
		public DivMultExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class AssignmentExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode ASSGN() { return getToken(ALCodeParser.ASSGN, 0); }
		public TerminalNode DIV_ASSGN() { return getToken(ALCodeParser.DIV_ASSGN, 0); }
		public TerminalNode MULTIPLY_ASSGN() { return getToken(ALCodeParser.MULTIPLY_ASSGN, 0); }
		public TerminalNode ADD_ASSGN() { return getToken(ALCodeParser.ADD_ASSGN, 0); }
		public TerminalNode MINUS_ASSGN() { return getToken(ALCodeParser.MINUS_ASSGN, 0); }
		public AssignmentExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class ScopeExpressionContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode SCOPE() { return getToken(ALCodeParser.SCOPE, 0); }
		public TerminalNode IDENTIFIER() { return getToken(ALCodeParser.IDENTIFIER, 0); }
		public ScopeExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class AddSubtractExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode PLUS() { return getToken(ALCodeParser.PLUS, 0); }
		public TerminalNode MINUS() { return getToken(ALCodeParser.MINUS, 0); }
		public AddSubtractExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class IntegerLiteralExpressionContext extends ExpressionContext {
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public IntegerLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class LogicalComparisonExpressionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode AND() { return getToken(ALCodeParser.AND, 0); }
		public TerminalNode OR() { return getToken(ALCodeParser.OR, 0); }
		public LogicalComparisonExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class BooleanLiteralExpressionContext extends ExpressionContext {
		public BooleanLiteralContext booleanLiteral() {
			return getRuleContext(BooleanLiteralContext.class,0);
		}
		public BooleanLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class DatetimeLiteralExpressionContext extends ExpressionContext {
		public TerminalNode DATETIME_LITERAL() { return getToken(ALCodeParser.DATETIME_LITERAL, 0); }
		public DatetimeLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class OptionLiteralExpressionContext extends ExpressionContext {
		public OptionLiteralContext optionLiteral() {
			return getRuleContext(OptionLiteralContext.class,0);
		}
		public OptionLiteralExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	@SuppressWarnings("CheckReturnValue")
	public static class NegativeExpressionContext extends ExpressionContext {
		public TerminalNode MINUS() { return getToken(ALCodeParser.MINUS, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public NegativeExpressionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}

	public final ExpressionContext expression() throws RecognitionException {
		return expression(0);
	}

	private ExpressionContext expression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 128;
		enterRecursionRule(_localctx, 128, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(585);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,45,_ctx) ) {
			case 1:
				{
				_localctx = new ParenthesisExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(548);
				match(LEFTPAREN);
				setState(549);
				expression(0);
				setState(550);
				match(RIGHTPAREN);
				}
				break;
			case 2:
				{
				_localctx = new NegationExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(552);
				match(NOT);
				setState(553);
				expression(20);
				}
				break;
			case 3:
				{
				_localctx = new SetExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(554);
				match(LEFTBRACKET);
				setState(556);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (((((_la - 22)) & ~0x3f) == 0 && ((1L << (_la - 22)) & -36028797018947543L) != 0)) {
					{
					setState(555);
					valueSet();
					}
				}

				setState(558);
				match(RIGHTBRACKET);
				}
				break;
			case 4:
				{
				_localctx = new MethodCallExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(559);
				match(IDENTIFIER);
				setState(564);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,43,_ctx);
				while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1+1 ) {
						{
						{
						setState(560);
						match(PERIOD);
						setState(561);
						match(IDENTIFIER);
						}
						} 
					}
					setState(566);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,43,_ctx);
				}
				setState(567);
				match(LEFTPAREN);
				setState(569);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (((((_la - 22)) & ~0x3f) == 0 && ((1L << (_la - 22)) & -36028797018947543L) != 0)) {
					{
					setState(568);
					methodCallArguments();
					}
				}

				setState(571);
				match(RIGHTPAREN);
				}
				break;
			case 5:
				{
				_localctx = new FunctionCallExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(572);
				match(IDENTIFIER);
				setState(573);
				match(RIGHTPAREN);
				}
				break;
			case 6:
				{
				_localctx = new BooleanLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(574);
				booleanLiteral();
				}
				break;
			case 7:
				{
				_localctx = new DateLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(575);
				match(DATE_LITERAL);
				}
				break;
			case 8:
				{
				_localctx = new TimeLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(576);
				match(TIME_LITERAL);
				}
				break;
			case 9:
				{
				_localctx = new DatetimeLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(577);
				match(DATETIME_LITERAL);
				}
				break;
			case 10:
				{
				_localctx = new IdentifierExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(578);
				match(IDENTIFIER);
				}
				break;
			case 11:
				{
				_localctx = new StringLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(579);
				match(STRING_LITERAL);
				}
				break;
			case 12:
				{
				_localctx = new FloatLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(580);
				match(FLOAT_LITERAL);
				}
				break;
			case 13:
				{
				_localctx = new IntegerLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(581);
				match(INTEGER_LITERAL);
				}
				break;
			case 14:
				{
				_localctx = new OptionLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(582);
				optionLiteral();
				}
				break;
			case 15:
				{
				_localctx = new NegativeExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(583);
				match(MINUS);
				setState(584);
				expression(1);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(629);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,49,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(627);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,48,_ctx) ) {
					case 1:
						{
						_localctx = new DivMultExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(587);
						if (!(precpred(_ctx, 23))) throw new FailedPredicateException(this, "precpred(_ctx, 23)");
						setState(588);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 34361311232L) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(589);
						expression(24);
						}
						break;
					case 2:
						{
						_localctx = new AddSubtractExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(590);
						if (!(precpred(_ctx, 22))) throw new FailedPredicateException(this, "precpred(_ctx, 22)");
						setState(591);
						_la = _input.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(592);
						expression(23);
						}
						break;
					case 3:
						{
						_localctx = new ComparisonExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(593);
						if (!(precpred(_ctx, 21))) throw new FailedPredicateException(this, "precpred(_ctx, 21)");
						setState(594);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 25181184L) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(595);
						expression(22);
						}
						break;
					case 4:
						{
						_localctx = new LogicalComparisonExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(596);
						if (!(precpred(_ctx, 19))) throw new FailedPredicateException(this, "precpred(_ctx, 19)");
						setState(597);
						_la = _input.LA(1);
						if ( !(_la==AND || _la==OR) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(598);
						expression(20);
						}
						break;
					case 5:
						{
						_localctx = new AssignmentExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(599);
						if (!(precpred(_ctx, 18))) throw new FailedPredicateException(this, "precpred(_ctx, 18)");
						setState(600);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 507904L) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(601);
						expression(19);
						}
						break;
					case 6:
						{
						_localctx = new ScopeExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(602);
						if (!(precpred(_ctx, 17))) throw new FailedPredicateException(this, "precpred(_ctx, 17)");
						setState(603);
						match(SCOPE);
						setState(604);
						match(IDENTIFIER);
						}
						break;
					case 7:
						{
						_localctx = new IndexExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(605);
						if (!(precpred(_ctx, 16))) throw new FailedPredicateException(this, "precpred(_ctx, 16)");
						setState(606);
						match(LEFTBRACKET);
						setState(607);
						indexAccessorSet();
						setState(608);
						match(RIGHTBRACKET);
						}
						break;
					case 8:
						{
						_localctx = new MemberAccessExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(610);
						if (!(precpred(_ctx, 13))) throw new FailedPredicateException(this, "precpred(_ctx, 13)");
						setState(611);
						match(PERIOD);
						setState(612);
						match(IDENTIFIER);
						setState(617);
						_errHandler.sync(this);
						_alt = getInterpreter().adaptivePredict(_input,46,_ctx);
						while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
							if ( _alt==1+1 ) {
								{
								{
								setState(613);
								match(PERIOD);
								setState(614);
								match(IDENTIFIER);
								}
								} 
							}
							setState(619);
							_errHandler.sync(this);
							_alt = getInterpreter().adaptivePredict(_input,46,_ctx);
						}
						}
						break;
					case 9:
						{
						_localctx = new InSetExpressionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(620);
						if (!(precpred(_ctx, 11))) throw new FailedPredicateException(this, "precpred(_ctx, 11)");
						setState(621);
						match(IN);
						setState(622);
						match(LEFTBRACKET);
						setState(624);
						_errHandler.sync(this);
						_la = _input.LA(1);
						if (((((_la - 22)) & ~0x3f) == 0 && ((1L << (_la - 22)) & -36028797018947543L) != 0)) {
							{
							setState(623);
							valueSet();
							}
						}

						setState(626);
						match(RIGHTBRACKET);
						}
						break;
					}
					} 
				}
				setState(631);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,49,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MethodCallArgumentsContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ALCodeParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ALCodeParser.COMMA, i);
		}
		public MethodCallArgumentsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodCallArguments; }
	}

	public final MethodCallArgumentsContext methodCallArguments() throws RecognitionException {
		MethodCallArgumentsContext _localctx = new MethodCallArgumentsContext(_ctx, getState());
		enterRule(_localctx, 130, RULE_methodCallArguments);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(632);
			expression(0);
			setState(637);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,50,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(633);
					match(COMMA);
					setState(634);
					expression(0);
					}
					} 
				}
				setState(639);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,50,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class OptionLiteralContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(ALCodeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ALCodeParser.IDENTIFIER, i);
		}
		public TerminalNode SCOPE() { return getToken(ALCodeParser.SCOPE, 0); }
		public OptionLiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_optionLiteral; }
	}

	public final OptionLiteralContext optionLiteral() throws RecognitionException {
		OptionLiteralContext _localctx = new OptionLiteralContext(_ctx, getState());
		enterRule(_localctx, 132, RULE_optionLiteral);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(640);
			match(IDENTIFIER);
			setState(641);
			match(SCOPE);
			setState(642);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class BooleanLiteralContext extends ParserRuleContext {
		public TerminalNode TRUE() { return getToken(ALCodeParser.TRUE, 0); }
		public TerminalNode FALSE() { return getToken(ALCodeParser.FALSE, 0); }
		public BooleanLiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_booleanLiteral; }
	}

	public final BooleanLiteralContext booleanLiteral() throws RecognitionException {
		BooleanLiteralContext _localctx = new BooleanLiteralContext(_ctx, getState());
		enterRule(_localctx, 134, RULE_booleanLiteral);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(644);
			_la = _input.LA(1);
			if ( !(_la==TRUE || _la==FALSE) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class NumberLiteralContext extends ParserRuleContext {
		public TerminalNode FLOAT_LITERAL() { return getToken(ALCodeParser.FLOAT_LITERAL, 0); }
		public TerminalNode INTEGER_LITERAL() { return getToken(ALCodeParser.INTEGER_LITERAL, 0); }
		public NumberLiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberLiteral; }
	}

	public final NumberLiteralContext numberLiteral() throws RecognitionException {
		NumberLiteralContext _localctx = new NumberLiteralContext(_ctx, getState());
		enterRule(_localctx, 136, RULE_numberLiteral);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(646);
			_la = _input.LA(1);
			if ( !(_la==INTEGER_LITERAL || _la==FLOAT_LITERAL) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 22:
			return variableTypeDeclaration_sempred((VariableTypeDeclarationContext)_localctx, predIndex);
		case 64:
			return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean variableTypeDeclaration_sempred(VariableTypeDeclarationContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return TokenMatches("dictionary");
		case 1:
			return TokenMatches("list");
		case 2:
			return TokenMatches(VarAppObjects);
		case 3:
			return TokenMatches("label");
		case 4:
			return TokenMatches("record");
		case 5:
			return TokenMatches("text");
		case 6:
			return TokenMatches("code");
		case 7:
			return TokenMatches("textconst");
		case 8:
			return TokenMatches(VariableTypes);
		}
		return true;
	}
	private boolean expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 9:
			return precpred(_ctx, 23);
		case 10:
			return precpred(_ctx, 22);
		case 11:
			return precpred(_ctx, 21);
		case 12:
			return precpred(_ctx, 19);
		case 13:
			return precpred(_ctx, 18);
		case 14:
			return precpred(_ctx, 17);
		case 15:
			return precpred(_ctx, 16);
		case 16:
			return precpred(_ctx, 13);
		case 17:
			return precpred(_ctx, 11);
		}
		return true;
	}

	public static final String _serializedATN =
		"\u0004\u0001X\u0289\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002"+
		"\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002"+
		"\f\u0007\f\u0002\r\u0007\r\u0002\u000e\u0007\u000e\u0002\u000f\u0007\u000f"+
		"\u0002\u0010\u0007\u0010\u0002\u0011\u0007\u0011\u0002\u0012\u0007\u0012"+
		"\u0002\u0013\u0007\u0013\u0002\u0014\u0007\u0014\u0002\u0015\u0007\u0015"+
		"\u0002\u0016\u0007\u0016\u0002\u0017\u0007\u0017\u0002\u0018\u0007\u0018"+
		"\u0002\u0019\u0007\u0019\u0002\u001a\u0007\u001a\u0002\u001b\u0007\u001b"+
		"\u0002\u001c\u0007\u001c\u0002\u001d\u0007\u001d\u0002\u001e\u0007\u001e"+
		"\u0002\u001f\u0007\u001f\u0002 \u0007 \u0002!\u0007!\u0002\"\u0007\"\u0002"+
		"#\u0007#\u0002$\u0007$\u0002%\u0007%\u0002&\u0007&\u0002\'\u0007\'\u0002"+
		"(\u0007(\u0002)\u0007)\u0002*\u0007*\u0002+\u0007+\u0002,\u0007,\u0002"+
		"-\u0007-\u0002.\u0007.\u0002/\u0007/\u00020\u00070\u00021\u00071\u0002"+
		"2\u00072\u00023\u00073\u00024\u00074\u00025\u00075\u00026\u00076\u0002"+
		"7\u00077\u00028\u00078\u00029\u00079\u0002:\u0007:\u0002;\u0007;\u0002"+
		"<\u0007<\u0002=\u0007=\u0002>\u0007>\u0002?\u0007?\u0002@\u0007@\u0002"+
		"A\u0007A\u0002B\u0007B\u0002C\u0007C\u0002D\u0007D\u0001\u0000\u0001\u0000"+
		"\u0001\u0001\u0001\u0001\u0001\u0002\u0001\u0002\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0003\u0003"+
		"\u0098\b\u0003\u0001\u0003\u0001\u0003\u0001\u0004\u0001\u0004\u0001\u0004"+
		"\u0001\u0004\u0001\u0005\u0001\u0005\u0001\u0006\u0005\u0006\u00a3\b\u0006"+
		"\n\u0006\f\u0006\u00a6\t\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001"+
		"\u0006\u0003\u0006\u00ac\b\u0006\u0001\u0006\u0001\u0006\u0003\u0006\u00b0"+
		"\b\u0006\u0001\u0006\u0003\u0006\u00b3\b\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\b\u0001"+
		"\b\u0001\b\u0005\b\u00bf\b\b\n\b\f\b\u00c2\t\b\u0001\t\u0001\t\u0001\t"+
		"\u0001\t\u0003\t\u00c8\b\t\u0001\t\u0003\t\u00cb\b\t\u0001\t\u0001\t\u0001"+
		"\n\u0001\n\u0001\u000b\u0001\u000b\u0001\f\u0001\f\u0001\r\u0001\r\u0001"+
		"\r\u0001\r\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000e\u0001\u000f"+
		"\u0001\u000f\u0001\u000f\u0001\u000f\u0001\u0010\u0001\u0010\u0001\u0010"+
		"\u0003\u0010\u00e4\b\u0010\u0001\u0011\u0001\u0011\u0001\u0011\u0005\u0011"+
		"\u00e9\b\u0011\n\u0011\f\u0011\u00ec\t\u0011\u0001\u0012\u0001\u0012\u0001"+
		"\u0013\u0001\u0013\u0001\u0013\u0005\u0013\u00f3\b\u0013\n\u0013\f\u0013"+
		"\u00f6\t\u0013\u0001\u0014\u0001\u0014\u0001\u0015\u0001\u0015\u0001\u0015"+
		"\u0005\u0015\u00fd\b\u0015\n\u0015\f\u0015\u0100\t\u0015\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0003"+
		"\u0016\u0121\b\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0003"+
		"\u0016\u0127\b\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0003\u0016\u012c"+
		"\b\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001"+
		"\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0001\u0016\u0003\u0016\u0138"+
		"\b\u0016\u0001\u0017\u0001\u0017\u0001\u0018\u0003\u0018\u013d\b\u0018"+
		"\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0018\u0001\u0019\u0001\u0019"+
		"\u0001\u0019\u0005\u0019\u0146\b\u0019\n\u0019\f\u0019\u0149\t\u0019\u0001"+
		"\u001a\u0001\u001a\u0001\u001a\u0005\u001a\u014e\b\u001a\n\u001a\f\u001a"+
		"\u0151\t\u001a\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b\u0001\u001b"+
		"\u0001\u001c\u0001\u001c\u0005\u001c\u015a\b\u001c\n\u001c\f\u001c\u015d"+
		"\t\u001c\u0001\u001d\u0001\u001d\u0001\u001d\u0001\u001e\u0001\u001e\u0001"+
		"\u001e\u0001\u001e\u0001\u001f\u0001\u001f\u0001\u001f\u0001 \u0001 \u0001"+
		"!\u0001!\u0001!\u0001!\u0003!\u016f\b!\u0001!\u0001!\u0003!\u0173\b!\u0001"+
		"!\u0003!\u0176\b!\u0001!\u0001!\u0001!\u0001\"\u0001\"\u0001\"\u0001\""+
		"\u0003\"\u017f\b\"\u0001#\u0004#\u0182\b#\u000b#\f#\u0183\u0001$\u0001"+
		"$\u0001$\u0001$\u0001%\u0001%\u0001%\u0001&\u0001&\u0001&\u0003&\u0190"+
		"\b&\u0001\'\u0001\'\u0001\'\u0001\'\u0001(\u0001(\u0001(\u0001)\u0001"+
		")\u0001)\u0001)\u0003)\u019d\b)\u0001*\u0001*\u0001*\u0001*\u0001*\u0001"+
		"*\u0001*\u0001*\u0001+\u0001+\u0001+\u0001,\u0001,\u0001,\u0001,\u0001"+
		",\u0001,\u0001,\u0003,\u01b1\b,\u0001-\u0001-\u0001-\u0005-\u01b6\b-\n"+
		"-\f-\u01b9\t-\u0001.\u0001.\u0001.\u0001.\u0001/\u0001/\u0003/\u01c1\b"+
		"/\u0001/\u0001/\u0001/\u00010\u00010\u00010\u00011\u00011\u00011\u0005"+
		"1\u01cc\b1\n1\f1\u01cf\t1\u00031\u01d1\b1\u00011\u00031\u01d4\b1\u0001"+
		"2\u00012\u00012\u00012\u00013\u00013\u00013\u00013\u00014\u00014\u0001"+
		"4\u00015\u00015\u00015\u00015\u00016\u00016\u00016\u00016\u00017\u0001"+
		"7\u00017\u00018\u00018\u00038\u01ee\b8\u00019\u00019\u00019\u00019\u0001"+
		"9\u00019\u00019\u00019\u00039\u01f8\b9\u0001:\u0001:\u0001:\u0001:\u0001"+
		";\u0001;\u0003;\u0200\b;\u0001;\u0003;\u0203\b;\u0001<\u0001<\u0001<\u0005"+
		"<\u0208\b<\n<\f<\u020b\t<\u0003<\u020d\b<\u0001<\u0003<\u0210\b<\u0001"+
		"=\u0001=\u0001>\u0001>\u0001>\u0005>\u0217\b>\n>\f>\u021a\t>\u0001?\u0001"+
		"?\u0001?\u0005?\u021f\b?\n?\f?\u0222\t?\u0001@\u0001@\u0001@\u0001@\u0001"+
		"@\u0001@\u0001@\u0001@\u0001@\u0003@\u022d\b@\u0001@\u0001@\u0001@\u0001"+
		"@\u0005@\u0233\b@\n@\f@\u0236\t@\u0001@\u0001@\u0003@\u023a\b@\u0001@"+
		"\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001"+
		"@\u0001@\u0001@\u0001@\u0003@\u024a\b@\u0001@\u0001@\u0001@\u0001@\u0001"+
		"@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001"+
		"@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001@\u0001"+
		"@\u0001@\u0001@\u0001@\u0005@\u0268\b@\n@\f@\u026b\t@\u0001@\u0001@\u0001"+
		"@\u0001@\u0003@\u0271\b@\u0001@\u0005@\u0274\b@\n@\f@\u0277\t@\u0001A"+
		"\u0001A\u0001A\u0005A\u027c\bA\nA\fA\u027f\tA\u0001B\u0001B\u0001B\u0001"+
		"B\u0001C\u0001C\u0001D\u0001D\u0001D\u0010\u00a4\u00c0\u00ea\u00f4\u00fe"+
		"\u0147\u014f\u015b\u01b7\u01cd\u0209\u0218\u0220\u0234\u0269\u027d\u0001"+
		"\u0080E\u0000\u0002\u0004\u0006\b\n\f\u000e\u0010\u0012\u0014\u0016\u0018"+
		"\u001a\u001c\u001e \"$&(*,.02468:<>@BDFHJLNPRTVXZ\\^`bdfhjlnprtvxz|~\u0080"+
		"\u0082\u0084\u0086\u0088\u0000\t\u0001\u0000MN\u0002\u0000RRUU\u0002\u0000"+
		"--FF\u0002\u0000\u0013\u0014##\u0001\u0000\u0015\u0016\u0002\u0000\n\r"+
		"\u0017\u0018\u0002\u0000!!%%\u0001\u0000\u000e\u0012\u0001\u0000RS\u02a5"+
		"\u0000\u008a\u0001\u0000\u0000\u0000\u0002\u008c\u0001\u0000\u0000\u0000"+
		"\u0004\u008e\u0001\u0000\u0000\u0000\u0006\u0090\u0001\u0000\u0000\u0000"+
		"\b\u009b\u0001\u0000\u0000\u0000\n\u009f\u0001\u0000\u0000\u0000\f\u00a4"+
		"\u0001\u0000\u0000\u0000\u000e\u00b7\u0001\u0000\u0000\u0000\u0010\u00bb"+
		"\u0001\u0000\u0000\u0000\u0012\u00c3\u0001\u0000\u0000\u0000\u0014\u00ce"+
		"\u0001\u0000\u0000\u0000\u0016\u00d0\u0001\u0000\u0000\u0000\u0018\u00d2"+
		"\u0001\u0000\u0000\u0000\u001a\u00d4\u0001\u0000\u0000\u0000\u001c\u00d8"+
		"\u0001\u0000\u0000\u0000\u001e\u00dc\u0001\u0000\u0000\u0000 \u00e3\u0001"+
		"\u0000\u0000\u0000\"\u00e5\u0001\u0000\u0000\u0000$\u00ed\u0001\u0000"+
		"\u0000\u0000&\u00ef\u0001\u0000\u0000\u0000(\u00f7\u0001\u0000\u0000\u0000"+
		"*\u00f9\u0001\u0000\u0000\u0000,\u0137\u0001\u0000\u0000\u0000.\u0139"+
		"\u0001\u0000\u0000\u00000\u013c\u0001\u0000\u0000\u00002\u0142\u0001\u0000"+
		"\u0000\u00004\u014a\u0001\u0000\u0000\u00006\u0152\u0001\u0000\u0000\u0000"+
		"8\u0157\u0001\u0000\u0000\u0000:\u015e\u0001\u0000\u0000\u0000<\u0161"+
		"\u0001\u0000\u0000\u0000>\u0165\u0001\u0000\u0000\u0000@\u0168\u0001\u0000"+
		"\u0000\u0000B\u016a\u0001\u0000\u0000\u0000D\u017e\u0001\u0000\u0000\u0000"+
		"F\u0181\u0001\u0000\u0000\u0000H\u0185\u0001\u0000\u0000\u0000J\u0189"+
		"\u0001\u0000\u0000\u0000L\u018c\u0001\u0000\u0000\u0000N\u0191\u0001\u0000"+
		"\u0000\u0000P\u0195\u0001\u0000\u0000\u0000R\u019c\u0001\u0000\u0000\u0000"+
		"T\u019e\u0001\u0000\u0000\u0000V\u01a6\u0001\u0000\u0000\u0000X\u01b0"+
		"\u0001\u0000\u0000\u0000Z\u01b2\u0001\u0000\u0000\u0000\\\u01ba\u0001"+
		"\u0000\u0000\u0000^\u01c0\u0001\u0000\u0000\u0000`\u01c5\u0001\u0000\u0000"+
		"\u0000b\u01d0\u0001\u0000\u0000\u0000d\u01d5\u0001\u0000\u0000\u0000f"+
		"\u01d9\u0001\u0000\u0000\u0000h\u01dd\u0001\u0000\u0000\u0000j\u01e0\u0001"+
		"\u0000\u0000\u0000l\u01e4\u0001\u0000\u0000\u0000n\u01e8\u0001\u0000\u0000"+
		"\u0000p\u01eb\u0001\u0000\u0000\u0000r\u01f7\u0001\u0000\u0000\u0000t"+
		"\u01f9\u0001\u0000\u0000\u0000v\u01ff\u0001\u0000\u0000\u0000x\u020c\u0001"+
		"\u0000\u0000\u0000z\u0211\u0001\u0000\u0000\u0000|\u0213\u0001\u0000\u0000"+
		"\u0000~\u021b\u0001\u0000\u0000\u0000\u0080\u0249\u0001\u0000\u0000\u0000"+
		"\u0082\u0278\u0001\u0000\u0000\u0000\u0084\u0280\u0001\u0000\u0000\u0000"+
		"\u0086\u0284\u0001\u0000\u0000\u0000\u0088\u0286\u0001\u0000\u0000\u0000"+
		"\u008a\u008b\u0005U\u0000\u0000\u008b\u0001\u0001\u0000\u0000\u0000\u008c"+
		"\u008d\u0005U\u0000\u0000\u008d\u0003\u0001\u0000\u0000\u0000\u008e\u008f"+
		"\u0005U\u0000\u0000\u008f\u0005\u0001\u0000\u0000\u0000\u0090\u0091\u0005"+
		"U\u0000\u0000\u0091\u0097\u0005\r\u0000\u0000\u0092\u0098\u0005T\u0000"+
		"\u0000\u0093\u0098\u0005R\u0000\u0000\u0094\u0098\u0005S\u0000\u0000\u0095"+
		"\u0098\u0005U\u0000\u0000\u0096\u0098\u0003\u0086C\u0000\u0097\u0092\u0001"+
		"\u0000\u0000\u0000\u0097\u0093\u0001\u0000\u0000\u0000\u0097\u0094\u0001"+
		"\u0000\u0000\u0000\u0097\u0095\u0001\u0000\u0000\u0000\u0097\u0096\u0001"+
		"\u0000\u0000\u0000\u0098\u0099\u0001\u0000\u0000\u0000\u0099\u009a\u0005"+
		"\u0006\u0000\u0000\u009a\u0007\u0001\u0000\u0000\u0000\u009b\u009c\u0005"+
		"\u001b\u0000\u0000\u009c\u009d\u0005R\u0000\u0000\u009d\u009e\u0005\u001c"+
		"\u0000\u0000\u009e\t\u0001\u0000\u0000\u0000\u009f\u00a0\u0005U\u0000"+
		"\u0000\u00a0\u000b\u0001\u0000\u0000\u0000\u00a1\u00a3\u0003\u0012\t\u0000"+
		"\u00a2\u00a1\u0001\u0000\u0000\u0000\u00a3\u00a6\u0001\u0000\u0000\u0000"+
		"\u00a4\u00a5\u0001\u0000\u0000\u0000\u00a4\u00a2\u0001\u0000\u0000\u0000"+
		"\u00a5\u00a7\u0001\u0000\u0000\u0000\u00a6\u00a4\u0001\u0000\u0000\u0000"+
		"\u00a7\u00a8\u0005=\u0000\u0000\u00a8\u00a9\u0005U\u0000\u0000\u00a9\u00ab"+
		"\u0005\u0019\u0000\u0000\u00aa\u00ac\u00032\u0019\u0000\u00ab\u00aa\u0001"+
		"\u0000\u0000\u0000\u00ab\u00ac\u0001\u0000\u0000\u0000\u00ac\u00ad\u0001"+
		"\u0000\u0000\u0000\u00ad\u00af\u0005\u001a\u0000\u0000\u00ae\u00b0\u0003"+
		">\u001f\u0000\u00af\u00ae\u0001\u0000\u0000\u0000\u00af\u00b0\u0001\u0000"+
		"\u0000\u0000\u00b0\u00b2\u0001\u0000\u0000\u0000\u00b1\u00b3\u0003:\u001d"+
		"\u0000\u00b2\u00b1\u0001\u0000\u0000\u0000\u00b2\u00b3\u0001\u0000\u0000"+
		"\u0000\u00b3\u00b4\u0001\u0000\u0000\u0000\u00b4\u00b5\u0003t:\u0000\u00b5"+
		"\u00b6\u0005\u0006\u0000\u0000\u00b6\r\u0001\u0000\u0000\u0000\u00b7\u00b8"+
		"\u0005U\u0000\u0000\u00b8\u00b9\u0005\u0007\u0000\u0000\u00b9\u00ba\u0003"+
		"\n\u0005\u0000\u00ba\u000f\u0001\u0000\u0000\u0000\u00bb\u00c0\u0003\u000e"+
		"\u0007\u0000\u00bc\u00bd\u0005\b\u0000\u0000\u00bd\u00bf\u0003\u000e\u0007"+
		"\u0000\u00be\u00bc\u0001\u0000\u0000\u0000\u00bf\u00c2\u0001\u0000\u0000"+
		"\u0000\u00c0\u00c1\u0001\u0000\u0000\u0000\u00c0\u00be\u0001\u0000\u0000"+
		"\u0000\u00c1\u0011\u0001\u0000\u0000\u0000\u00c2\u00c0\u0001\u0000\u0000"+
		"\u0000\u00c3\u00c4\u0005\u001b\u0000\u0000\u00c4\u00ca\u0005U\u0000\u0000"+
		"\u00c5\u00c7\u0005\u0019\u0000\u0000\u00c6\u00c8\u0003\u0010\b\u0000\u00c7"+
		"\u00c6\u0001\u0000\u0000\u0000\u00c7\u00c8\u0001\u0000\u0000\u0000\u00c8"+
		"\u00c9\u0001\u0000\u0000\u0000\u00c9\u00cb\u0005\u001a\u0000\u0000\u00ca"+
		"\u00c5\u0001\u0000\u0000\u0000\u00ca\u00cb\u0001\u0000\u0000\u0000\u00cb"+
		"\u00cc\u0001\u0000\u0000\u0000\u00cc\u00cd\u0005\u001c\u0000\u0000\u00cd"+
		"\u0013\u0001\u0000\u0000\u0000\u00ce\u00cf\u0003,\u0016\u0000\u00cf\u0015"+
		"\u0001\u0000\u0000\u0000\u00d0\u00d1\u0003,\u0016\u0000\u00d1\u0017\u0001"+
		"\u0000\u0000\u0000\u00d2\u00d3\u0005T\u0000\u0000\u00d3\u0019\u0001\u0000"+
		"\u0000\u0000\u00d4\u00d5\u0003\u0002\u0001\u0000\u00d5\u00d6\u0005\r\u0000"+
		"\u0000\u00d6\u00d7\u0005R\u0000\u0000\u00d7\u001b\u0001\u0000\u0000\u0000"+
		"\u00d8\u00d9\u0003\u0000\u0000\u0000\u00d9\u00da\u0005\r\u0000\u0000\u00da"+
		"\u00db\u0005T\u0000\u0000\u00db\u001d\u0001\u0000\u0000\u0000\u00dc\u00dd"+
		"\u0003\u0004\u0002\u0000\u00dd\u00de\u0005\r\u0000\u0000\u00de\u00df\u0007"+
		"\u0000\u0000\u0000\u00df\u001f\u0001\u0000\u0000\u0000\u00e0\u00e4\u0003"+
		"\u001a\r\u0000\u00e1\u00e4\u0003\u001c\u000e\u0000\u00e2\u00e4\u0003\u001e"+
		"\u000f\u0000\u00e3\u00e0\u0001\u0000\u0000\u0000\u00e3\u00e1\u0001\u0000"+
		"\u0000\u0000\u00e3\u00e2\u0001\u0000\u0000\u0000\u00e4!\u0001\u0000\u0000"+
		"\u0000\u00e5\u00ea\u0003 \u0010\u0000\u00e6\u00e7\u0005\b\u0000\u0000"+
		"\u00e7\u00e9\u0003 \u0010\u0000\u00e8\u00e6\u0001\u0000\u0000\u0000\u00e9"+
		"\u00ec\u0001\u0000\u0000\u0000\u00ea\u00eb\u0001\u0000\u0000\u0000\u00ea"+
		"\u00e8\u0001\u0000\u0000\u0000\u00eb#\u0001\u0000\u0000\u0000\u00ec\u00ea"+
		"\u0001\u0000\u0000\u0000\u00ed\u00ee\u0005U\u0000\u0000\u00ee%\u0001\u0000"+
		"\u0000\u0000\u00ef\u00f4\u0003$\u0012\u0000\u00f0\u00f1\u0005\b\u0000"+
		"\u0000\u00f1\u00f3\u0003$\u0012\u0000\u00f2\u00f0\u0001\u0000\u0000\u0000"+
		"\u00f3\u00f6\u0001\u0000\u0000\u0000\u00f4\u00f5\u0001\u0000\u0000\u0000"+
		"\u00f4\u00f2\u0001\u0000\u0000\u0000\u00f5\'\u0001\u0000\u0000\u0000\u00f6"+
		"\u00f4\u0001\u0000\u0000\u0000\u00f7\u00f8\u0007\u0001\u0000\u0000\u00f8"+
		")\u0001\u0000\u0000\u0000\u00f9\u00fe\u0005R\u0000\u0000\u00fa\u00fb\u0005"+
		"\b\u0000\u0000\u00fb\u00fd\u0005R\u0000\u0000\u00fc\u00fa\u0001\u0000"+
		"\u0000\u0000\u00fd\u0100\u0001\u0000\u0000\u0000\u00fe\u00ff\u0001\u0000"+
		"\u0000\u0000\u00fe\u00fc\u0001\u0000\u0000\u0000\u00ff+\u0001\u0000\u0000"+
		"\u0000\u0100\u00fe\u0001\u0000\u0000\u0000\u0101\u0102\u0004\u0016\u0000"+
		"\u0000\u0102\u0103\u0005U\u0000\u0000\u0103\u0104\u0005<\u0000\u0000\u0104"+
		"\u0105\u0005\u001b\u0000\u0000\u0105\u0106\u0003\u0014\n\u0000\u0106\u0107"+
		"\u0005\b\u0000\u0000\u0107\u0108\u0003\u0016\u000b\u0000\u0108\u0109\u0005"+
		"\u001c\u0000\u0000\u0109\u0138\u0001\u0000\u0000\u0000\u010a\u010b\u0004"+
		"\u0016\u0001\u0000\u010b\u010c\u0005U\u0000\u0000\u010c\u010d\u0005<\u0000"+
		"\u0000\u010d\u010e\u0005\u001b\u0000\u0000\u010e\u010f\u0003,\u0016\u0000"+
		"\u010f\u0110\u0005\u001c\u0000\u0000\u0110\u0138\u0001\u0000\u0000\u0000"+
		"\u0111\u0112\u0005\'\u0000\u0000\u0112\u0113\u0005\u001b\u0000\u0000\u0113"+
		"\u0114\u0003*\u0015\u0000\u0114\u0115\u0005\u001c\u0000\u0000\u0115\u0116"+
		"\u0005<\u0000\u0000\u0116\u0117\u0003,\u0016\u0000\u0117\u0138\u0001\u0000"+
		"\u0000\u0000\u0118\u0119\u0004\u0016\u0002\u0000\u0119\u011a\u0005U\u0000"+
		"\u0000\u011a\u0138\u0003(\u0014\u0000\u011b\u011c\u0004\u0016\u0003\u0000"+
		"\u011c\u011d\u0005U\u0000\u0000\u011d\u0120\u0003\u0018\f\u0000\u011e"+
		"\u011f\u0005\b\u0000\u0000\u011f\u0121\u0003\"\u0011\u0000\u0120\u011e"+
		"\u0001\u0000\u0000\u0000\u0120\u0121\u0001\u0000\u0000\u0000\u0121\u0138"+
		"\u0001\u0000\u0000\u0000\u0122\u0123\u0004\u0016\u0004\u0000\u0123\u0124"+
		"\u0005U\u0000\u0000\u0124\u0126\u0003(\u0014\u0000\u0125\u0127\u0005D"+
		"\u0000\u0000\u0126\u0125\u0001\u0000\u0000\u0000\u0126\u0127\u0001\u0000"+
		"\u0000\u0000\u0127\u0138\u0001\u0000\u0000\u0000\u0128\u0129\u0004\u0016"+
		"\u0005\u0000\u0129\u012b\u0005U\u0000\u0000\u012a\u012c\u0003\b\u0004"+
		"\u0000\u012b\u012a\u0001\u0000\u0000\u0000\u012b\u012c\u0001\u0000\u0000"+
		"\u0000\u012c\u0138\u0001\u0000\u0000\u0000\u012d\u012e\u0004\u0016\u0006"+
		"\u0000\u012e\u012f\u0005U\u0000\u0000\u012f\u0138\u0003\b\u0004\u0000"+
		"\u0130\u0131\u0004\u0016\u0007\u0000\u0131\u0132\u0005U\u0000\u0000\u0132"+
		"\u0133\u0005U\u0000\u0000\u0133\u0134\u0005\r\u0000\u0000\u0134\u0138"+
		"\u0005T\u0000\u0000\u0135\u0136\u0004\u0016\b\u0000\u0136\u0138\u0005"+
		"U\u0000\u0000\u0137\u0101\u0001\u0000\u0000\u0000\u0137\u010a\u0001\u0000"+
		"\u0000\u0000\u0137\u0111\u0001\u0000\u0000\u0000\u0137\u0118\u0001\u0000"+
		"\u0000\u0000\u0137\u011b\u0001\u0000\u0000\u0000\u0137\u0122\u0001\u0000"+
		"\u0000\u0000\u0137\u0128\u0001\u0000\u0000\u0000\u0137\u012d\u0001\u0000"+
		"\u0000\u0000\u0137\u0130\u0001\u0000\u0000\u0000\u0137\u0135\u0001\u0000"+
		"\u0000\u0000\u0138-\u0001\u0000\u0000\u0000\u0139\u013a\u0005U\u0000\u0000"+
		"\u013a/\u0001\u0000\u0000\u0000\u013b\u013d\u0005I\u0000\u0000\u013c\u013b"+
		"\u0001\u0000\u0000\u0000\u013c\u013d\u0001\u0000\u0000\u0000\u013d\u013e"+
		"\u0001\u0000\u0000\u0000\u013e\u013f\u0003.\u0017\u0000\u013f\u0140\u0005"+
		"\u0007\u0000\u0000\u0140\u0141\u0003,\u0016\u0000\u01411\u0001\u0000\u0000"+
		"\u0000\u0142\u0147\u00030\u0018\u0000\u0143\u0144\u0005\u0006\u0000\u0000"+
		"\u0144\u0146\u00030\u0018\u0000\u0145\u0143\u0001\u0000\u0000\u0000\u0146"+
		"\u0149\u0001\u0000\u0000\u0000\u0147\u0148\u0001\u0000\u0000\u0000\u0147"+
		"\u0145\u0001\u0000\u0000\u0000\u01483\u0001\u0000\u0000\u0000\u0149\u0147"+
		"\u0001\u0000\u0000\u0000\u014a\u014f\u0005U\u0000\u0000\u014b\u014c\u0005"+
		"\b\u0000\u0000\u014c\u014e\u0005U\u0000\u0000\u014d\u014b\u0001\u0000"+
		"\u0000\u0000\u014e\u0151\u0001\u0000\u0000\u0000\u014f\u0150\u0001\u0000"+
		"\u0000\u0000\u014f\u014d\u0001\u0000\u0000\u0000\u01505\u0001\u0000\u0000"+
		"\u0000\u0151\u014f\u0001\u0000\u0000\u0000\u0152\u0153\u00034\u001a\u0000"+
		"\u0153\u0154\u0005\u0007\u0000\u0000\u0154\u0155\u0003,\u0016\u0000\u0155"+
		"\u0156\u0005\u0006\u0000\u0000\u01567\u0001\u0000\u0000\u0000\u0157\u015b"+
		"\u00036\u001b\u0000\u0158\u015a\u00036\u001b\u0000\u0159\u0158\u0001\u0000"+
		"\u0000\u0000\u015a\u015d\u0001\u0000\u0000\u0000\u015b\u015c\u0001\u0000"+
		"\u0000\u0000\u015b\u0159\u0001\u0000\u0000\u0000\u015c9\u0001\u0000\u0000"+
		"\u0000\u015d\u015b\u0001\u0000\u0000\u0000\u015e\u015f\u0005I\u0000\u0000"+
		"\u015f\u0160\u00038\u001c\u0000\u0160;\u0001\u0000\u0000\u0000\u0161\u0162"+
		"\u0005?\u0000\u0000\u0162\u0163\u0005I\u0000\u0000\u0163\u0164\u00036"+
		"\u001b\u0000\u0164=\u0001\u0000\u0000\u0000\u0165\u0166\u0005\u0007\u0000"+
		"\u0000\u0166\u0167\u0005U\u0000\u0000\u0167?\u0001\u0000\u0000\u0000\u0168"+
		"\u0169\u0005U\u0000\u0000\u0169A\u0001\u0000\u0000\u0000\u016a\u016b\u0005"+
		"G\u0000\u0000\u016b\u016c\u0003@ \u0000\u016c\u016e\u0005\u0019\u0000"+
		"\u0000\u016d\u016f\u00032\u0019\u0000\u016e\u016d\u0001\u0000\u0000\u0000"+
		"\u016e\u016f\u0001\u0000\u0000\u0000\u016f\u0170\u0001\u0000\u0000\u0000"+
		"\u0170\u0172\u0005\u001a\u0000\u0000\u0171\u0173\u0003>\u001f\u0000\u0172"+
		"\u0171\u0001\u0000\u0000\u0000\u0172\u0173\u0001\u0000\u0000\u0000\u0173"+
		"\u0175\u0001\u0000\u0000\u0000\u0174\u0176\u0003:\u001d\u0000\u0175\u0174"+
		"\u0001\u0000\u0000\u0000\u0175\u0176\u0001\u0000\u0000\u0000\u0176\u0177"+
		"\u0001\u0000\u0000\u0000\u0177\u0178\u0003t:\u0000\u0178\u0179\u0005\u0006"+
		"\u0000\u0000\u0179C\u0001\u0000\u0000\u0000\u017a\u017f\u0003:\u001d\u0000"+
		"\u017b\u017f\u0003<\u001e\u0000\u017c\u017f\u0003B!\u0000\u017d\u017f"+
		"\u0003\f\u0006\u0000\u017e\u017a\u0001\u0000\u0000\u0000\u017e\u017b\u0001"+
		"\u0000\u0000\u0000\u017e\u017c\u0001\u0000\u0000\u0000\u017e\u017d\u0001"+
		"\u0000\u0000\u0000\u017fE\u0001\u0000\u0000\u0000\u0180\u0182\u0003D\""+
		"\u0000\u0181\u0180\u0001\u0000\u0000\u0000\u0182\u0183\u0001\u0000\u0000"+
		"\u0000\u0183\u0181\u0001\u0000\u0000\u0000\u0183\u0184\u0001\u0000\u0000"+
		"\u0000\u0184G\u0001\u0000\u0000\u0000\u0185\u0186\u00055\u0000\u0000\u0186"+
		"\u0187\u0003\u0080@\u0000\u0187\u0188\u0005E\u0000\u0000\u0188I\u0001"+
		"\u0000\u0000\u0000\u0189\u018a\u0005.\u0000\u0000\u018a\u018b\u0003v;"+
		"\u0000\u018bK\u0001\u0000\u0000\u0000\u018c\u018d\u0003H$\u0000\u018d"+
		"\u018f\u0003v;\u0000\u018e\u0190\u0003J%\u0000\u018f\u018e\u0001\u0000"+
		"\u0000\u0000\u018f\u0190\u0001\u0000\u0000\u0000\u0190M\u0001\u0000\u0000"+
		"\u0000\u0191\u0192\u0005J\u0000\u0000\u0192\u0193\u0003\u0080@\u0000\u0193"+
		"\u0194\u0005,\u0000\u0000\u0194O\u0001\u0000\u0000\u0000\u0195\u0196\u0003"+
		"N\'\u0000\u0196\u0197\u0003v;\u0000\u0197Q\u0001\u0000\u0000\u0000\u0198"+
		"\u019d\u0005O\u0000\u0000\u0199\u019d\u0005P\u0000\u0000\u019a\u019d\u0003"+
		"\u0086C\u0000\u019b\u019d\u0003\u0088D\u0000\u019c\u0198\u0001\u0000\u0000"+
		"\u0000\u019c\u0199\u0001\u0000\u0000\u0000\u019c\u019a\u0001\u0000\u0000"+
		"\u0000\u019c\u019b\u0001\u0000\u0000\u0000\u019dS\u0001\u0000\u0000\u0000"+
		"\u019e\u019f\u00051\u0000\u0000\u019f\u01a0\u0005U\u0000\u0000\u01a0\u01a1"+
		"\u0005\u000e\u0000\u0000\u01a1\u01a2\u0003R)\u0000\u01a2\u01a3\u0007\u0002"+
		"\u0000\u0000\u01a3\u01a4\u0003R)\u0000\u01a4\u01a5\u0005,\u0000\u0000"+
		"\u01a5U\u0001\u0000\u0000\u0000\u01a6\u01a7\u0003T*\u0000\u01a7\u01a8"+
		"\u0003v;\u0000\u01a8W\u0001\u0000\u0000\u0000\u01a9\u01b1\u0003\u0088"+
		"D\u0000\u01aa\u01b1\u0003\u0086C\u0000\u01ab\u01b1\u0005O\u0000\u0000"+
		"\u01ac\u01b1\u0005P\u0000\u0000\u01ad\u01b1\u0005Q\u0000\u0000\u01ae\u01b1"+
		"\u0003\u0084B\u0000\u01af\u01b1\u0005T\u0000\u0000\u01b0\u01a9\u0001\u0000"+
		"\u0000\u0000\u01b0\u01aa\u0001\u0000\u0000\u0000\u01b0\u01ab\u0001\u0000"+
		"\u0000\u0000\u01b0\u01ac\u0001\u0000\u0000\u0000\u01b0\u01ad\u0001\u0000"+
		"\u0000\u0000\u01b0\u01ae\u0001\u0000\u0000\u0000\u01b0\u01af\u0001\u0000"+
		"\u0000\u0000\u01b1Y\u0001\u0000\u0000\u0000\u01b2\u01b7\u0003X,\u0000"+
		"\u01b3\u01b4\u0005\b\u0000\u0000\u01b4\u01b6\u0003X,\u0000\u01b5\u01b3"+
		"\u0001\u0000\u0000\u0000\u01b6\u01b9\u0001\u0000\u0000\u0000\u01b7\u01b8"+
		"\u0001\u0000\u0000\u0000\u01b7\u01b5\u0001\u0000\u0000\u0000\u01b8[\u0001"+
		"\u0000\u0000\u0000\u01b9\u01b7\u0001\u0000\u0000\u0000\u01ba\u01bb\u0003"+
		"X,\u0000\u01bb\u01bc\u0005\u0005\u0000\u0000\u01bc\u01bd\u0003X,\u0000"+
		"\u01bd]\u0001\u0000\u0000\u0000\u01be\u01c1\u0003Z-\u0000\u01bf\u01c1"+
		"\u0003\\.\u0000\u01c0\u01be\u0001\u0000\u0000\u0000\u01c0\u01bf\u0001"+
		"\u0000\u0000\u0000\u01c1\u01c2\u0001\u0000\u0000\u0000\u01c2\u01c3\u0005"+
		"\u0007\u0000\u0000\u01c3\u01c4\u0003v;\u0000\u01c4_\u0001\u0000\u0000"+
		"\u0000\u01c5\u01c6\u0005.\u0000\u0000\u01c6\u01c7\u0003v;\u0000\u01c7"+
		"a\u0001\u0000\u0000\u0000\u01c8\u01cd\u0003^/\u0000\u01c9\u01ca\u0005"+
		"\u0006\u0000\u0000\u01ca\u01cc\u0003^/\u0000\u01cb\u01c9\u0001\u0000\u0000"+
		"\u0000\u01cc\u01cf\u0001\u0000\u0000\u0000\u01cd\u01ce\u0001\u0000\u0000"+
		"\u0000\u01cd\u01cb\u0001\u0000\u0000\u0000\u01ce\u01d1\u0001\u0000\u0000"+
		"\u0000\u01cf\u01cd\u0001\u0000\u0000\u0000\u01d0\u01c8\u0001\u0000\u0000"+
		"\u0000\u01d0\u01d1\u0001\u0000\u0000\u0000\u01d1\u01d3\u0001\u0000\u0000"+
		"\u0000\u01d2\u01d4\u0003`0\u0000\u01d3\u01d2\u0001\u0000\u0000\u0000\u01d3"+
		"\u01d4\u0001\u0000\u0000\u0000\u01d4c\u0001\u0000\u0000\u0000\u01d5\u01d6"+
		"\u0005+\u0000\u0000\u01d6\u01d7\u0003\u0080@\u0000\u01d7\u01d8\u0005<"+
		"\u0000\u0000\u01d8e\u0001\u0000\u0000\u0000\u01d9\u01da\u0003d2\u0000"+
		"\u01da\u01db\u0003b1\u0000\u01db\u01dc\u0005/\u0000\u0000\u01dcg\u0001"+
		"\u0000\u0000\u0000\u01dd\u01de\u0005H\u0000\u0000\u01de\u01df\u0003\u0080"+
		"@\u0000\u01dfi\u0001\u0000\u0000\u0000\u01e0\u01e1\u0005@\u0000\u0000"+
		"\u01e1\u01e2\u0003v;\u0000\u01e2\u01e3\u0003h4\u0000\u01e3k\u0001\u0000"+
		"\u0000\u0000\u01e4\u01e5\u0005K\u0000\u0000\u01e5\u01e6\u0005U\u0000\u0000"+
		"\u01e6\u01e7\u0005,\u0000\u0000\u01e7m\u0001\u0000\u0000\u0000\u01e8\u01e9"+
		"\u0003l6\u0000\u01e9\u01ea\u0003v;\u0000\u01eao\u0001\u0000\u0000\u0000"+
		"\u01eb\u01ed\u00050\u0000\u0000\u01ec\u01ee\u0003\u0080@\u0000\u01ed\u01ec"+
		"\u0001\u0000\u0000\u0000\u01ed\u01ee\u0001\u0000\u0000\u0000\u01eeq\u0001"+
		"\u0000\u0000\u0000\u01ef\u01f8\u0003L&\u0000\u01f0\u01f8\u0003V+\u0000"+
		"\u01f1\u01f8\u0003f3\u0000\u01f2\u01f8\u0003n7\u0000\u01f3\u01f8\u0003"+
		"P(\u0000\u01f4\u01f8\u0003j5\u0000\u01f5\u01f8\u0003p8\u0000\u01f6\u01f8"+
		"\u0003\u0080@\u0000\u01f7\u01ef\u0001\u0000\u0000\u0000\u01f7\u01f0\u0001"+
		"\u0000\u0000\u0000\u01f7\u01f1\u0001\u0000\u0000\u0000\u01f7\u01f2\u0001"+
		"\u0000\u0000\u0000\u01f7\u01f3\u0001\u0000\u0000\u0000\u01f7\u01f4\u0001"+
		"\u0000\u0000\u0000\u01f7\u01f5\u0001\u0000\u0000\u0000\u01f7\u01f6\u0001"+
		"\u0000\u0000\u0000\u01f8s\u0001\u0000\u0000\u0000\u01f9\u01fa\u0005)\u0000"+
		"\u0000\u01fa\u01fb\u0003x<\u0000\u01fb\u01fc\u0005/\u0000\u0000\u01fc"+
		"u\u0001\u0000\u0000\u0000\u01fd\u0200\u0003r9\u0000\u01fe\u0200\u0003"+
		"t:\u0000\u01ff\u01fd\u0001\u0000\u0000\u0000\u01ff\u01fe\u0001\u0000\u0000"+
		"\u0000\u0200\u0202\u0001\u0000\u0000\u0000\u0201\u0203\u0005\u0006\u0000"+
		"\u0000\u0202\u0201\u0001\u0000\u0000\u0000\u0202\u0203\u0001\u0000\u0000"+
		"\u0000\u0203w\u0001\u0000\u0000\u0000\u0204\u0209\u0003r9\u0000\u0205"+
		"\u0206\u0005\u0006\u0000\u0000\u0206\u0208\u0003r9\u0000\u0207\u0205\u0001"+
		"\u0000\u0000\u0000\u0208\u020b\u0001\u0000\u0000\u0000\u0209\u020a\u0001"+
		"\u0000\u0000\u0000\u0209\u0207\u0001\u0000\u0000\u0000\u020a\u020d\u0001"+
		"\u0000\u0000\u0000\u020b\u0209\u0001\u0000\u0000\u0000\u020c\u0204\u0001"+
		"\u0000\u0000\u0000\u020c\u020d\u0001\u0000\u0000\u0000\u020d\u020f\u0001"+
		"\u0000\u0000\u0000\u020e\u0210\u0005\u0006\u0000\u0000\u020f\u020e\u0001"+
		"\u0000\u0000\u0000\u020f\u0210\u0001\u0000\u0000\u0000\u0210y\u0001\u0000"+
		"\u0000\u0000\u0211\u0212\u0007\u0001\u0000\u0000\u0212{\u0001\u0000\u0000"+
		"\u0000\u0213\u0218\u0003z=\u0000\u0214\u0215\u0005\b\u0000\u0000\u0215"+
		"\u0217\u0003z=\u0000\u0216\u0214\u0001\u0000\u0000\u0000\u0217\u021a\u0001"+
		"\u0000\u0000\u0000\u0218\u0219\u0001\u0000\u0000\u0000\u0218\u0216\u0001"+
		"\u0000\u0000\u0000\u0219}\u0001\u0000\u0000\u0000\u021a\u0218\u0001\u0000"+
		"\u0000\u0000\u021b\u0220\u0003\u0080@\u0000\u021c\u021d\u0005\b\u0000"+
		"\u0000\u021d\u021f\u0003\u0080@\u0000\u021e\u021c\u0001\u0000\u0000\u0000"+
		"\u021f\u0222\u0001\u0000\u0000\u0000\u0220\u0221\u0001\u0000\u0000\u0000"+
		"\u0220\u021e\u0001\u0000\u0000\u0000\u0221\u007f\u0001\u0000\u0000\u0000"+
		"\u0222\u0220\u0001\u0000\u0000\u0000\u0223\u0224\u0006@\uffff\uffff\u0000"+
		"\u0224\u0225\u0005\u0019\u0000\u0000\u0225\u0226\u0003\u0080@\u0000\u0226"+
		"\u0227\u0005\u001a\u0000\u0000\u0227\u024a\u0001\u0000\u0000\u0000\u0228"+
		"\u0229\u0005$\u0000\u0000\u0229\u024a\u0003\u0080@\u0014\u022a\u022c\u0005"+
		"\u001b\u0000\u0000\u022b\u022d\u0003~?\u0000\u022c\u022b\u0001\u0000\u0000"+
		"\u0000\u022c\u022d\u0001\u0000\u0000\u0000\u022d\u022e\u0001\u0000\u0000"+
		"\u0000\u022e\u024a\u0005\u001c\u0000\u0000\u022f\u0234\u0005U\u0000\u0000"+
		"\u0230\u0231\u0005\t\u0000\u0000\u0231\u0233\u0005U\u0000\u0000\u0232"+
		"\u0230\u0001\u0000\u0000\u0000\u0233\u0236\u0001\u0000\u0000\u0000\u0234"+
		"\u0235\u0001\u0000\u0000\u0000\u0234\u0232\u0001\u0000\u0000\u0000\u0235"+
		"\u0237\u0001\u0000\u0000\u0000\u0236\u0234\u0001\u0000\u0000\u0000\u0237"+
		"\u0239\u0005\u0019\u0000\u0000\u0238\u023a\u0003\u0082A\u0000\u0239\u0238"+
		"\u0001\u0000\u0000\u0000\u0239\u023a\u0001\u0000\u0000\u0000\u023a\u023b"+
		"\u0001\u0000\u0000\u0000\u023b\u024a\u0005\u001a\u0000\u0000\u023c\u023d"+
		"\u0005U\u0000\u0000\u023d\u024a\u0005\u001a\u0000\u0000\u023e\u024a\u0003"+
		"\u0086C\u0000\u023f\u024a\u0005O\u0000\u0000\u0240\u024a\u0005P\u0000"+
		"\u0000\u0241\u024a\u0005Q\u0000\u0000\u0242\u024a\u0005U\u0000\u0000\u0243"+
		"\u024a\u0005T\u0000\u0000\u0244\u024a\u0005S\u0000\u0000\u0245\u024a\u0005"+
		"R\u0000\u0000\u0246\u024a\u0003\u0084B\u0000\u0247\u0248\u0005\u0016\u0000"+
		"\u0000\u0248\u024a\u0003\u0080@\u0001\u0249\u0223\u0001\u0000\u0000\u0000"+
		"\u0249\u0228\u0001\u0000\u0000\u0000\u0249\u022a\u0001\u0000\u0000\u0000"+
		"\u0249\u022f\u0001\u0000\u0000\u0000\u0249\u023c\u0001\u0000\u0000\u0000"+
		"\u0249\u023e\u0001\u0000\u0000\u0000\u0249\u023f\u0001\u0000\u0000\u0000"+
		"\u0249\u0240\u0001\u0000\u0000\u0000\u0249\u0241\u0001\u0000\u0000\u0000"+
		"\u0249\u0242\u0001\u0000\u0000\u0000\u0249\u0243\u0001\u0000\u0000\u0000"+
		"\u0249\u0244\u0001\u0000\u0000\u0000\u0249\u0245\u0001\u0000\u0000\u0000"+
		"\u0249\u0246\u0001\u0000\u0000\u0000\u0249\u0247\u0001\u0000\u0000\u0000"+
		"\u024a\u0275\u0001\u0000\u0000\u0000\u024b\u024c\n\u0017\u0000\u0000\u024c"+
		"\u024d\u0007\u0003\u0000\u0000\u024d\u0274\u0003\u0080@\u0018\u024e\u024f"+
		"\n\u0016\u0000\u0000\u024f\u0250\u0007\u0004\u0000\u0000\u0250\u0274\u0003"+
		"\u0080@\u0017\u0251\u0252\n\u0015\u0000\u0000\u0252\u0253\u0007\u0005"+
		"\u0000\u0000\u0253\u0274\u0003\u0080@\u0016\u0254\u0255\n\u0013\u0000"+
		"\u0000\u0255\u0256\u0007\u0006\u0000\u0000\u0256\u0274\u0003\u0080@\u0014"+
		"\u0257\u0258\n\u0012\u0000\u0000\u0258\u0259\u0007\u0007\u0000\u0000\u0259"+
		"\u0274\u0003\u0080@\u0013\u025a\u025b\n\u0011\u0000\u0000\u025b\u025c"+
		"\u0005\u0004\u0000\u0000\u025c\u0274\u0005U\u0000\u0000\u025d\u025e\n"+
		"\u0010\u0000\u0000\u025e\u025f\u0005\u001b\u0000\u0000\u025f\u0260\u0003"+
		"|>\u0000\u0260\u0261\u0005\u001c\u0000\u0000\u0261\u0274\u0001\u0000\u0000"+
		"\u0000\u0262\u0263\n\r\u0000\u0000\u0263\u0264\u0005\t\u0000\u0000\u0264"+
		"\u0269\u0005U\u0000\u0000\u0265\u0266\u0005\t\u0000\u0000\u0266\u0268"+
		"\u0005U\u0000\u0000\u0267\u0265\u0001\u0000\u0000\u0000\u0268\u026b\u0001"+
		"\u0000\u0000\u0000\u0269\u026a\u0001\u0000\u0000\u0000\u0269\u0267\u0001"+
		"\u0000\u0000\u0000\u026a\u0274\u0001\u0000\u0000\u0000\u026b\u0269\u0001"+
		"\u0000\u0000\u0000\u026c\u026d\n\u000b\u0000\u0000\u026d\u026e\u00057"+
		"\u0000\u0000\u026e\u0270\u0005\u001b\u0000\u0000\u026f\u0271\u0003~?\u0000"+
		"\u0270\u026f\u0001\u0000\u0000\u0000\u0270\u0271\u0001\u0000\u0000\u0000"+
		"\u0271\u0272\u0001\u0000\u0000\u0000\u0272\u0274\u0005\u001c\u0000\u0000"+
		"\u0273\u024b\u0001\u0000\u0000\u0000\u0273\u024e\u0001\u0000\u0000\u0000"+
		"\u0273\u0251\u0001\u0000\u0000\u0000\u0273\u0254\u0001\u0000\u0000\u0000"+
		"\u0273\u0257\u0001\u0000\u0000\u0000\u0273\u025a\u0001\u0000\u0000\u0000"+
		"\u0273\u025d\u0001\u0000\u0000\u0000\u0273\u0262\u0001\u0000\u0000\u0000"+
		"\u0273\u026c\u0001\u0000\u0000\u0000\u0274\u0277\u0001\u0000\u0000\u0000"+
		"\u0275\u0273\u0001\u0000\u0000\u0000\u0275\u0276\u0001\u0000\u0000\u0000"+
		"\u0276\u0081\u0001\u0000\u0000\u0000\u0277\u0275\u0001\u0000\u0000\u0000"+
		"\u0278\u027d\u0003\u0080@\u0000\u0279\u027a\u0005\b\u0000\u0000\u027a"+
		"\u027c\u0003\u0080@\u0000\u027b\u0279\u0001\u0000\u0000\u0000\u027c\u027f"+
		"\u0001\u0000\u0000\u0000\u027d\u027e\u0001\u0000\u0000\u0000\u027d\u027b"+
		"\u0001\u0000\u0000\u0000\u027e\u0083\u0001\u0000\u0000\u0000\u027f\u027d"+
		"\u0001\u0000\u0000\u0000\u0280\u0281\u0005U\u0000\u0000\u0281\u0282\u0005"+
		"\u0004\u0000\u0000\u0282\u0283\u0005U\u0000\u0000\u0283\u0085\u0001\u0000"+
		"\u0000\u0000\u0284\u0285\u0007\u0000\u0000\u0000\u0285\u0087\u0001\u0000"+
		"\u0000\u0000\u0286\u0287\u0007\b\u0000\u0000\u0287\u0089\u0001\u0000\u0000"+
		"\u00003\u0097\u00a4\u00ab\u00af\u00b2\u00c0\u00c7\u00ca\u00e3\u00ea\u00f4"+
		"\u00fe\u0120\u0126\u012b\u0137\u013c\u0147\u014f\u015b\u016e\u0172\u0175"+
		"\u017e\u0183\u018f\u019c\u01b0\u01b7\u01c0\u01cd\u01d0\u01d3\u01ed\u01f7"+
		"\u01ff\u0202\u0209\u020c\u020f\u0218\u0220\u022c\u0234\u0239\u0249\u0269"+
		"\u0270\u0273\u0275\u027d";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}