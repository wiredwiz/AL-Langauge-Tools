lexer grammar ALLexer;

channels { COMMENTS_CHANNEL }

SINGLE_LINE_COMMENT
	: '//' INPUT_CHARACTER* -> channel(COMMENTS_CHANNEL);

DELIMITED_COMMENT
	: '/*' .*? '*/' -> channel(COMMENTS_CHANNEL);

WS
	:	[ \t\r\n] -> channel(HIDDEN)
	;

// SYMBOLS

SCOPE
   : '::';

RANGE
   : '..';

SEMICOLON
   : ';';

COLON
   : ':';

COMMA
   : ',';

PERIOD
   : '.';

GREATERTHANEQUAL
   : '>=';

LESSTHANEQUAL
   : '<=';

NOTEQUAL
   : '<>';

EQUAL
   : '=';

BACKSLASH
   : '/';

PLUS
   : '+';

MINUS
   : '-';

LESSTHAN
   : '<';

GREATERTHAN
   : '>';

LEFTPAREN
   : '(';

RIGHTPAREN
   : ')';

LEFTBRACKET
   : '[';

RIGHTBRACKET
   : ']';

LEFTCBRACE
   : '{';

RIGHTCBRACE
   : '}';

PIPE
   : '|';

AMPERSAND
   : '&';

// WORDS

ACTION
   : A C T I O N
   ;

ADD
   : A D D
   ;

ADDFIRST
   : A D D F I R S T
   ;

ADDLAST
   : A D D L A S T
   ;

ADDAFTER
   : A D D A F T E R
   ;

ADDBEFORE
   : A D D B E F O R E
   ;

ACTIONS
   : A C T I O N S
   ;

ANY
   : A N Y
   ;

AREA
   : A R E A
   ;

ARRAY
   : A R R A Y
   ;

ASCENDING
   : A S C E N D I N G
   ;

ASSEMBLY
   : A S S E M B L Y
   ;

ASSERTERROR
   : A S S E R T E R R O R
   ;

AUDITCATEGORY
   : A U D I T C A T E G O R Y
   ;

AUTOMATION
   : A U T O M A T I O N
   ;

AVERAGE
   : A V E R A G E
   ;

BEGIN
   : B E G I N -> pushMode(AL_CODE)
   ;

BIGINTEGER
   : B I G I N T E G E R
   ;

BIGTEXT
   : B I G T E X T
   ;

BINARY
   : B I N A R Y
   ;

BLOB
   : B L O B
   ;

BOOLEAN
   : B O O L E A N
   ;

BYTE
   : B Y T E
   ;

CHAR
   : C H A R
   ;

CHARTPART
   : C H A R T P A R T
   ;

CLIENTTYPE
   : C L I E N T T Y P E
   ;

CODE
   : C O D E
   ;

CODEUNIT
   : C O D E U N I T
   ;

COMMENT
   : C O M M E N T
   ;

COMMITBEHAVIOR
   : C O M M I T B E H A V I O R
   ;

COMPANYPROPERTY
   : C O M P A N Y P R O P E R T Y
   ;

COMPLETIONTRIGGERERRORLEVEL
   : C O M P L E T I O N T R I G G E R E R R O R L E V E L
   ;

CONNECTIONTYPE
   : C O N N E C T I O N T Y P E
   ;

CONST
   : C O N S T
   ;

CONTROLADDIN
   : C O N T R O L A D D I N
   ;

CUEGROUP
   : C U E G R O U P
   ;

CUSTOMIZES
   : C U S T O M I Z E S
   ;

COLUMN
   : C O L U M N
   ;

COUNT
   : C O U N T
   ;

DATABASE
   : D A T A B A S E
   ;

DATACLASSIFICATION
   : D A T A C L A S S I F I C A T I O N
   ;

DATAITEM
   : D A T A I T E M
   ;

DATASET
   : D A T A S E T
   ;

DATASCOPE
   : D A T A S C O P E
   ;

DATATRANSFER
   : D A T A T R A N S F E R
   ;

DATE
   : D A T E
   ;

DATEFORMULA
   : D A T E F O R M U L A
   ;

DATETIME
   : D A T E T I M E
   ;

DEBUGGER
   : D E B U G G E R
   ;

DECIMAL
   : D E C I M A L
   ;

DEFAULTLAYOUT
   : D E F A U L T L A Y O U T
   ;

DESCENDING
   : D E S C E N D I N G
   ;

DIALOG
   : D I A L O G
   ;

DICTIONARY
   : D I C T I O N A R Y
   ;

DOTNET
   : D O T N E T
   ;

DOTNETASSEMBLY
   : D O T N E T A S S E M B L Y
   ;

DOTNETTYPEDECLARATION
   : D O T N E T T Y P E D E C L A R A T I O N
   ;

DURATION
   : D U R A T I O N
   ;

ELEMENTS
   : E L E M E N T S
   ;

ENTITLEMENT
   : E N T I T L E M E N T
   ;

ENUM
   : E N U M
   ;

ENUMEXTENSION
   : E N U M E X T E N S I O N
   ;

ERRORBEHAVIOR
   : E R R O R B E H A V I O R
   ;

ERRORINFO
   : E R R O R I N F O
   ;

ERRORTYPE
   : E R R O R T Y P E
   ;

EVENT
   : E V E N T
   ;

EXECUTIONCONTEXT
   : E X E C U T I O N C O N T E X T
   ;

EXECUTIONMODE
   : E X E C U T I O N M O D E
   ;

EXIST
   : E X I S T
   ;

EXTENDS
   : E X T E N D S
   ;

FIELD
   : F I E L D
   ;

FIELDCLASS
   : F I E L D C L A S S
   ;

FIELDGROUP
   : F I E L D G R O U P
   ;

FIELDATTRIBUTE
   : F I E L D A T T R I B U T E
   ;

FIELDELEMENT
   : F I E L D E L E M E N T
   ;

FIELDGROUPS
   : F I E L D G R O U P S
   ;

FIELDREF
   : F I E L D R E F
   ;

FIELDS
   : F I E L D S
   ;

FIELDTYPE
   : F I E L D T Y P E
   ;

FILE
   : F I L E
   ;

FILTER
   : F I L T E R
   ;

FILTERPAGEBUILDER
   : F I L T E R P A G E B U I L D E R
   ;

FIXED
   : F I X E D
   ;

FUNCTION
   : F U N C T I O N
   ;

GRID
   : G R I D
   ;

GROUP
   : G R O U P
   ;

GUID
   : G U I D
   ;

HTTPCONTENT
   : H T T P C O N T E N T
   ;

HTTPHEADERS
   : H T T P H E A D E R S
   ;

HTTPCLIENT
   : H T T P C L I E N T
   ;

HTTPREQUESTMESSAGE
   : H T T P R E Q U E S T M E S S A G E
   ;

HTTPRESPONSEMESSAGE
   : H T T P R E S P O N S E M E S S A G E
   ;

IMPLEMENTS
   : I M P L E M E N T S
   ;

INDATASET
   : I N D A T A S E T
   ;

INHERENTPERMISSIONSSCOPE
   : I N H E R E N T P E R M I S S I O N S S C O P E
   ;

INSTREAM
   : I N S T R E A M
   ;

INTEGER
   : I N T E G E R
   ;

INTERFACE
   : I N T E R F A C E
   ;

INTERNAL
   : I N T E R N A L
   ;

ISOLATEDSTORAGE
   : I S O L A T E D S T O R A G E
   ;

ISOLATIONLEVEL
   : I S O L A T I O N L E V E L
   ;

JOKER
   : J O K E R
   ;

JSONTOKEN
   : J S O N T O K E N
   ;

JSONVALUE
   : J S O N V A L U E
   ;

JSONARRAY
   : J S O N A R R A Y
   ;

JSONOBJECT
   : J S O N O B J E C T
   ;

KEY
   : K E Y
   ;

KEYS
   : K E Y S
   ;

KEYREF
   : K E Y R E F
   ;

LABEL
   : L A B E L
   ;

LABELS
   : L A B E L S
   ;

LAYOUT
   : L A Y O U T
   ;

LIST
   : L I S T
   ;

LOCAL
   : L O C A L
   ;

LOCKED
   : L O C K E D
   ;

LOOKUP
   : L O O K U P
   ;

MAX
   : M A X
   ;

MAXLENGTH
   : M A X L E N G T H
   ;

MEDIA
   : M E D I A
   ;

MEDIASET
   : M E D I A S E T
   ;

MIN
   : M I N
   ;

MODIFY
   : M O D I F Y
   ;

MODULEDEPENDENCYINFO
   : M O D U L E D E P E N D E N C Y I N F O
   ;

MODULEINFO
   : M O D U L E I N F O
   ;

MOVEFIRST
   : M O V E F I R S T
   ;

MOVELAST
   : M O V E L A S T
   ;

MOVEBEFORE
   : M O V E B E F O R E
   ;

MOVEAFTER
   : M O V E A F T E R
   ;

NAVAPP
   : N A V A P P
   ;

NONE
   : N O N E
   ;

NOTIFICATION
   : N O T I F I C A T I O N
   ;

NOTIFICATIONSCOPE
   : N O T I F I C A T I O N S C O P E
   ;

NUMBERSEQUENCE
   : N U M B E R S E Q U E N C E
   ;

OBJECTTYPE
   : O B J E C T T Y P E
   ;

OPTION
   : O P T I O N
   ;

ORDER
   : O R D E R
   ;

OUTSTREAM
   : O U T S T R E A M
   ;

PAGE
   : P A G E
   ;

PAGEBACKGROUNDTASKERRORLEVEL
   : P A G E B A C K G R O U N D T A S K E R R O R L E V E L
   ;

PAGEEXTENSION
   : P A G E E X T E N S I O N
   ;

PAGECUSTOMIZATION
   : P A G E C U S T O M I Z A T I O N
   ;

PAGERESULT
   : P A G E R E S U L T
   ;

PART
   : P A R T
   ;

PERMISSIONOBJECTTYPE
   : P E R M I S S I O N O B J E C T T Y P E
   ;

PERMISSIONSET
   : P E R M I S S I O N S E T
   ;

PERMISSIONSETEXTENSION
   : P E R M I S S I O N S E T E X T E N S I O N
   ;

PROCEDURE
   : P R O C E D U R E
   ;

PRODUCTNAME
   : P R O D U C T N A M E
   ;

PROFILE
   : P R O F I L E
   ;

PROGRAM
   : P R O G R A M
   ;

PROTECTED
   : P R O T E C T E D
   ;

QUERY
   : Q U E R Y
   ;

RECORD
   : R E C O R D
   ;

RECORDID
   : R E C O R D I D
   ;

RECORDREF
   : R E C O R D R E F
   ;

REPEATER
   : R E P E A T E R
   ;

REPORT
   : R E P O R T
   ;

REPORTEXTENSION
   : R E P O R T E X T E N S I O N
   ;

REPORTFORMAT
   : R E P O R T F O R M A T
   ;

REPORTLAYOUTTYPE
   : R E P O R T L A Y O U T T Y P E
   ;

REQUESTPAGE
   : R E Q U E S T P A G E
   ;

RUNONCLIENT
   : R U N O N C L I E N T
   ;

SCHEMA
   : S C H E M A
   ;

SECURITYFILTER
   : S E C U R I T Y F I L T E R
   ;

SECURITYFILTERING
   : S E C U R I T Y F I L T E R I N G
   ;

SECURITYOPERATIONRESULT
   : S E C U R I T Y O P E R A T I O N R E S U L T
   ;

SEPARATOR
   : S E P A R A T O R
   ;

SESSION
   : S E S S I O N
   ;

SESSIONINFORMATION
   : S E S S I O N I N F O R M A T I O N
   ;

SESSIONSETTINGS
   : S E S S I O N S E T T I N G S
   ;

SORTING
   : S O R T I N G
   ;

SUM
   : S U M
   ;

SUPPRESSDISPOSE
   : S U P P R E S S D I S P O S E
   ;

SYSTEM
   : S Y S T E M
   ;

SYSTEMPART
   : S Y S T E M P A R T
   ;

TABLE
   : T A B L E
   ;

TABLECONNECTIONTYPE
   : T A B L E C O N N E C T I O N T Y P E
   ;

TABLEDATA
   : T A B L E D A T A
   ;

TABLEELEMENT
   : T A B L E E L E M E N T
   ;

TABLEEXTENSION
   : T A B L E E X T E N S I O N
   ;

TABLEFILTER
   : T A B L E F I L T E R
   ;

TASKSCHEDULER
   : T A S K S C H E D U L E R
   ;

TELEMETRYSCOPE
   : T E L E M E T R Y S C O P E
   ;

TEMPORARY
   : T E M P O R A R Y
   ;

TESTACTION
   : T E S T A C T I O N
   ;

TESTFIELD
   : T E S T F I E L D
   ;

TESTFILTER
   : T E S T F I L T E R
   ;

TESTFILTERFIELD
   : T E S T F I L T E R F I E L D
   ;

TESTPAGE
   : T E S T P A G E
   ;

TESTPART
   : T E S T P A R T
   ;

TESTPERMISSIONS
   : T E S T P E R M I S S I O N S
   ;

TESTREQUESTPAGE
   : T E S T R E Q U E S T P A G E
   ;

TEXT
   : T E X T
   ;

TEXTATTRIBUTE
   : T E X T A T T R I B U T E
   ;

TEXTBUILDER
   : T E X T B U I L D E R
   ;

TEXTCONST
   : T E X T C O N S T
   ;

TEXTELEMENT
   : T E X T E L E M E N T
   ;

TEXTENCODING
   : T E X T E N C O D I N G
   ;

TIME
   : T I M E
   ;

TRANSACTIONMODEL
   : T R A N S A C T I O N M O D E L
   ;

TRANSACTIONTYPE
   : T R A N S A C T I O N T Y P E
   ;

TRIGGER
   : T R I G G E R
   ;

TYPE
   : T Y P E
   ;

UPPERLIMIT
   : U P P E R L I M I T
   ;

USERCONTROL
   : U S E R C O N T R O L
   ;

VALUE
   : V A L U E
   ;

VAR
   : V A R
   ;

VARIANT
   : V A R I A N T
   ;

VERBOSITY
   : V E R B O S I T Y
   ;

VERSION
   : V E R S I O N
   ;

VIEW
   : V I E W
   ;

VIEWS
   : V I E W S
   ;

WEBSERVICEACTIONCONTEXT
   : W E B S E R V I C E A C T I O N C O N T E X T
   ;

WEBSERVICEACTIONRESULTCODE
   : W E B S E R V I C E A C T I O N R E S U L T C O D E
   ;

WHERE
   : W H E R E
   ;

WITHEVENTS
   : W I T H E V E N T S
   ;

XMLATTRIBUTE
   : X M L A T T R I B U T E
   ;

XMLATTRIBUTECOLLECTION
   : X M L A T T R I B U T E C O L L E C T I O N
   ;

XMLCOMMENT
   : X M L C O M M E N T
   ;

XMLCDATA
   : X M L C D A T A
   ;

XMLDECLARATION
   : X M L D E C L A R A T I O N
   ;

XMLDOCUMENT
   : X M L D O C U M E N T
   ;

XMLDOCUMENTTYPE
   : X M L D O C U M E N T T Y P E
   ;

XMLELEMENT
   : X M L E L E M E N T
   ;

XMLNAMESPACEMANAGER
   : X M L N A M E S P A C E M A N A G E R
   ;

XMLNAMETABLE
   : X M L N A M E T A B L E
   ;

XMLNODE
   : X M L N O D E
   ;

XMLNODELIST
   : X M L N O D E L I S T
   ;

XMLPORT
   : X M L P O R T
   ;

XMLPROCESSINGINSTRUCTION
   : X M L P R O C E S S I N G I N S T R U C T I O N
   ;

XMLREADOPTIONS
   : X M L R E A D O P T I O N S
   ;

XMLTEXT
   : X M L T E X T
   ;

XMLWRITEOPTIONS
   : X M L W R I T E O P T I O N S
   ;

/* 
 * boolean 
 */

TRUE
   : T R U E;

FALSE
   : F A L S E;

/* 
 * date 
 */

DATE_LITERAL
   : DIGIT+ D;

/* 
 * time 
 */

TIME_LITERAL
   : DIGIT+ ([.] DIGIT+)? T;

/* 
 * datetime 
 */

DATETIME_LITERAL
   : DIGIT+ D T;

/* 
 * numbers 
 */

INTEGER_LITERAL
   : DIGIT+
   | ('0' X HEXDIGIT*? | DIGIT+) (EXPONENT_NOTATION EXPONENT_SIGN DIGIT+)? (INTEGER_SUFFIX | FLOAT_SUFFIX)?
   ;

FLOAT_LITERAL
	: (DIGIT+ [.] (DIGIT*)? {_input.La(1) != '.'}? (EXPONENT_NOTATION EXPONENT_SIGN DIGIT+)? 
	| [.] DIGIT+ (EXPONENT_NOTATION EXPONENT_SIGN DIGIT+)? 
	| DIGIT+ EXPONENT_NOTATION EXPONENT_SIGN DIGIT+) (INTEGER_SUFFIX | FLOAT_SUFFIX)?
	;

/* 
 * strings 
 */

STRING_LITERAL
	: '\'' ( ESC | ~['\r\n])* '\'';

/* 
 * identifiers 
 */

IDENTIFIER
	: (LETTER | DIGIT | UNDERSCORE)+
   | '"' ~["]+ '"'
	;

UNDERSCORE
	: '_';

LETTER
	: LOWERCASE 
	| UPPERCASE
	;

/*
 * preprocessor directives
 */

PREPROCESSOR_DIRECTIVE
   : '#' ~[\r\n]* '\r'? '\n';

/* 
 * fragments 
 */

fragment LOWERCASE
	: [a-z] ;

fragment UPPERCASE
	: [A-Z] ;

fragment EXPONENT_NOTATION
	: ('E' | 'e');

fragment EXPONENT_SIGN
	: ('-' | '+');

fragment DIGIT
	: [0-9] ;

fragment HEXDIGIT : [0-9] | [A-F] | [a-f];

fragment INTEGER_SUFFIX
   : [uU] [lL]? [lL]? | [lL] [lL]?;

fragment FLOAT_SUFFIX
   : [fF];

fragment ESC 
	: '\'\'' ;

fragment INPUT_CHARACTER
	: ~[\r\n\u0085\u2028\u2029];

fragment A : [aA];
fragment B : [bB];
fragment C : [cC];
fragment D : [dD];
fragment E : [eE];
fragment F : [fF];
fragment G : [gG];
fragment H : [hH];
fragment I : [iI];
fragment J : [jJ];
fragment K : [kK];
fragment L : [lL];
fragment M : [mM];
fragment N : [nN];
fragment O : [oO];
fragment P : [pP];
fragment Q : [qQ];
fragment R : [rR];
fragment S : [sS];
fragment T : [tT];
fragment U : [uU];
fragment V : [vV];
fragment W : [wW];
fragment X : [xX];
fragment Y : [yY];
fragment Z : [zZ];

mode AL_CODE;
/**************************************
 * STARTING AL Code block lexing mode *
 **************************************/

CODE_SINGLE_LINE_COMMENT
	: '//' INPUT_CHARACTER* -> type(SINGLE_LINE_COMMENT), channel(COMMENTS_CHANNEL);

CODE_DELIMITED_COMMENT
	: '/*' .*? '*/' -> type(DELIMITED_COMMENT), channel(COMMENTS_CHANNEL);

CODE_WS
	:	[ \t\r\n] -> channel(HIDDEN)
	;

CODE_SCOPE
   : '::' -> type(SCOPE);

CODE_RANGE
   : '..' -> type(RANGE);

CODE_SEMICOLON
   : ';' -> type(SEMICOLON);

CODE_COLON
   : ':' -> type(COLON);

CODE_COMMA
   : ',' -> type(COMMA);

CODE_PERIOD
   : '.' -> type(PERIOD);

CODE_GREATERTHANEQUAL
   : '>=' -> type(GREATERTHANEQUAL);

CODE_LESSTHANEQUAL
   : '<=' -> type(LESSTHANEQUAL);

CODE_NOTEQUAL
   : '<>' -> type(NOTEQUAL);

ASSGN
   : ':=';

MULTIPLY_ASSGN
   : '*=';

DIV_ASSGN
   : '/=';

ADD_ASSGN
   : '+=';

MINUS_ASSGN
   : '-=';

CODE_EQUAL
   : '=' -> type(EQUAL);

ASTERISK
   : '*';

CODE_BACKSLASH
   : '/' -> type(BACKSLASH);

CODE_PLUS
   : '+' -> type(PLUS);

CODE_MINUS
   : '-' -> type(MINUS);

CODE_LESSTHAN
   : '<' -> type(LESSTHAN);

CODE_GREATERTHAN
   : '>' -> type(GREATERTHAN);

CODE_LEFTPAREN
   : '(' -> type(LEFTPAREN);

CODE_RIGHTPAREN
   : ')' -> type(RIGHTPAREN);

CODE_LEFTBRACKET
   : '[' -> type(LEFTBRACKET);

CODE_RIGHTBRACKET
   : ']' -> type(RIGHTBRACKET);

CODE_BEGIN
   : B E G I N -> type(BEGIN), pushMode(AL_CODE)
   ;

BREAK
   : B R E A K
   ;

CASE
   : C A S E
   ;

DO
   : D O
   ;

DOWNTO
   : D O W N T O
   ;

ELSE
   : E L S E
   ;

END
   : E N D -> popMode
   ;

EXIT
   : E X I T
   ;

FOR
   : F O R
   ;

FOREACH
   : F O R E A C H
   ;

IF
   : I F
   ;

IN
   : I N
   ;

OF
   : O F
   ;

REPEAT
   : R E P E A T
   ;

THEN
   : T H E N
   ;

TO
   : T O
   ;

UNTIL
   : U N T I L
   ;

WHILE
   : W H I L E
   ;

WITH
   : W I T H
   ;

/* 
 * operator keywords 
 */

AND
   : A N D
   ;

DIV
   : D I V
   ;

MOD
   : M O D
   ;

NOT
   : N O T
   ;

OR
   : O R
   ;

XOR
   : X O R
   ;

/* 
 * boolean 
 */

CODE_TRUE
   : T_ R_ U_ E_ -> type(TRUE);

CODE_FALSE
   : F_ A_ L_ S_ E_ -> type(FALSE);

 /* 
 * date 
 */

CODE_DATE_LITERAL
   : CODE_DIGIT+ D -> type(DATE_LITERAL);

/* 
 * time 
 */

CODE_TIME_LITERAL
   : CODE_DIGIT+ ([.] CODE_DIGIT+)? T -> type(TIME_LITERAL);

/* 
 * datetime 
 */

CODE_DATETIME_LITERAL
   : CODE_DIGIT+ D T -> type(DATETIME_LITERAL);

/* 
 * numbers 
 */

CODE_INTEGER_LITERAL
   : (CODE_DIGIT+
   | ('0' X CODE_HEXDIGIT*? | CODE_DIGIT+) (CODE_EXPONENT_NOTATION CODE_EXPONENT_SIGN CODE_DIGIT+)? (CODE_INTEGER_SUFFIX | CODE_FLOAT_SUFFIX)?)  -> type(INTEGER_LITERAL)
   ;

CODE_FLOAT_LITERAL
	: ((CODE_DIGIT+ [.] (CODE_DIGIT*)? {_input.La(1) != '.'}? (CODE_EXPONENT_NOTATION CODE_EXPONENT_SIGN DIGIT+)? 
	| [.] CODE_DIGIT+ (CODE_EXPONENT_NOTATION CODE_EXPONENT_SIGN DIGIT+)? 
	| CODE_DIGIT+ CODE_EXPONENT_NOTATION CODE_EXPONENT_SIGN DIGIT+) (CODE_INTEGER_SUFFIX | CODE_FLOAT_SUFFIX)?) -> type(FLOAT_LITERAL)
	;

/* 
 * strings 
 */

CODE_STRING_LITERAL
	: '\'' ( ESC | ~['\r\n])* '\'' -> type(STRING_LITERAL);

/* 
 * identifiers 
 */

CODE_IDENTIFIER
	: ((CODE_LETTER | CODE_DIGIT | CODE_UNDERSCORE)+
   | '"' ~["]+ '"')  -> type(IDENTIFIER)
	;

CODE_UNDERSCORE
	: '_' -> type(UNDERSCORE);

CODE_LETTER
	: (CODE_LOWERCASE 
	| CODE_UPPERCASE) -> type(LETTER)
	;

/*
 * preprocessor directives
 */

CODE_PREPROCESSOR_DIRECTIVE
   : '#' ~[\r\n]* '\r'? '\n' -> type(PREPROCESSOR_DIRECTIVE);

/* 
 * fragments 
 */

fragment CODE_LOWERCASE
	: [a-z] ;

fragment CODE_UPPERCASE
	: [A-Z] ;

fragment CODE_EXPONENT_NOTATION
	: ('E' | 'e');

fragment CODE_EXPONENT_SIGN
	: ('-' | '+');

fragment CODE_DIGIT
	: [0-9] ;

fragment CODE_HEXDIGIT : [0-9] | [A-F] | [a-f];

fragment CODE_INTEGER_SUFFIX
   : [uU] [lL]? [lL]? | [lL] [lL]?;

fragment CODE_FLOAT_SUFFIX
   : [fF];

fragment CODE_ESC 
	: '\'\'' ;

fragment CODE_INPUT_CHARACTER
	: ~[\r\n\u0085\u2028\u2029];

fragment A_ : [aA];
fragment B_ : [bB];
fragment C_ : [cC];
fragment D_ : [dD];
fragment E_ : [eE];
fragment F_ : [fF];
fragment G_ : [gG];
fragment H_ : [hH];
fragment I_ : [iI];
fragment J_ : [jJ];
fragment K_ : [kK];
fragment L_ : [lL];
fragment M_ : [mM];
fragment N_ : [nN];
fragment O_ : [oO];
fragment P_ : [pP];
fragment Q_ : [qQ];
fragment R_ : [rR];
fragment S_ : [sS];
fragment T_ : [tT];
fragment U_ : [uU];
fragment V_ : [vV];
fragment W_ : [wW];
fragment X_ : [xX];
fragment Y_ : [yY];
fragment Z_ : [zZ];