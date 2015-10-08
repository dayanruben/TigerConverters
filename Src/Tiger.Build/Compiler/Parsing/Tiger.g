grammar Tiger;

options
{ 
	language=CSharp3;
}
@parser::namespace{Tiger.Build.Compiler.Parsing}
@lexer::namespace{Tiger.Build.Compiler.Parsing}

@parser::header
{
	using System;
	using Tiger.Build.Compiler.Ast;
	using Scope = Tiger.Build.Compiler.Common.Scope;
	using Tiger.Build.Compiler.Common;
}

@lexer::members{int HIDDEN=Hidden;}

/*
TODO:
- refactor grammar
- add nested comments support
*/

// MAIN
program returns [ProgramExpression expression]
	:	e=test {expression=new ProgramExpression{Program=e, Start=e.Start};}
	;

public parse returns [ProgramExpression expression]
@after {expression=e;}
	:	e=program EOF
	;

expr_stmt returns [Expression expression]
	:	i=if_stmt {expression=i;}
	| 	w=while_stmt {expression=w;}
	| 	f=for_stmt {expression=f;}
	|	list=curly_list_stmt {expression=list;}
	|	let=let_stmt {expression=let;}
	|	fi=for_in_stmt {expression=fi;}
	|	arr=array_init {expression=arr;}
	|	match=match_stmt {expression=match;}
	;

match_stmt returns [MatchExpression expression]
@init{expression=new MatchExpression();}
@after{expression.Start=Loc($t); expression.Match=tx;}
	:	t='match' tx=program_list_comma 'with' ((VBAR) => g=guard {expression.Add(g);})+
	;

guard returns [GuardNode node]
@init{node=new GuardNode();}
@after{node.Start=Loc($t); node.Test=tx; node.Result=res;}
	:	t=VBAR tx=program_list_comma '->' res=program
	;

for_in_stmt returns [ForInExpression expression]
@after{expression=new ForInExpression{Identifier=i, Collection=c, Body=b};}
	:	t='for' i=identifier 'in' c=program 'do' b=program
	;

array_init returns [ArrayInitExpression expression]
@after{expression=new ArrayInitExpression{Initializers=init,Start=Loc($t)};}
	:	t=LBRACK init=program_list_comma RBRACK
	;
	
curly_list_stmt returns [ListSemiExpression expression]
@init{expression=new ListSemiExpression();}
@after{expression.Start=Loc($t); }

	:	t=LCURLY (p=program { expression.Add(p); } (SEMI p=program {expression.Add(p);})*)? SEMI? RCURLY
	;

root_list_semi returns [ListSemiExpression expression]
@init {var res=new ListSemiExpression();}
@after {expression=res;}
	: 	p=program { res.Add(p); } (SEMI p=program {res.Add(p);} )*
	|	//() empty parentesis
    	;

program_list_comma returns [IEnumerable<Expression> expression]
@init{var result=new List<Expression>();}
@after {expression=result;}
	: 	p=program {result.Add(p);} (COMMA p=program {result.Add(p);})*
    	;

if_stmt returns [IfThenExpression expression]
	: 	t='if' c1=test 'then' c2=program
		(
			('else')=>'else' c3=program {expression=new IfThenElseExpression{Test = new ToBooleanExpression( c1 ),Then=c2, Else=c3, Start=Loc($t)};}
		| 	{expression=new IfThenExpression{Test = new ToBooleanExpression( c1 ),Then=c2, Start=Loc($t)};}
		)
	;

while_stmt returns [WhileExpression expression]
@init {var res=new WhileExpression();}
@after {expression=res; expression.Start=Loc($t);}
	: 	t='while' assert=test 'do' body=program {res.Test= new ToBooleanExpression( assert ); res.Body=body;}
	;

for_stmt returns [ForLoopExpression expression]
@init {expression=new ForLoopExpression();}
@after {expression.VariableName=name; expression.From=low; expression.To=up; expression.Body=body; expression.Start=Loc($t);}
	: 	t='for' name=identifier ASSIGN low=program 'to' up=program 'do' body=program
	;

//*******

let_stmt returns [LetInExpression expression]
@init {var res=new LetInExpression();}
@after {res.Start=Loc($tt); expression=res; }
	:	tt='let'
	(	t=type_declaration {res.AddType(t);}
	|	e=variable_declaration {res.AddVar(e);}
	|	f=func_definition { res.AddFunc(f); }
	)* 'in' l=root_list_semi SEMI? 'end' {res.Body=l;}
	;

type_declaration returns [TypeDeclarationNode node]
	:	t='type' typeName=type_identifier EQUAL
			(	LCURLY fields=fieldList RCURLY {node=new RecordDeclarationNode{Name=typeName, Fields=fields, Start=Loc($t)};}
			|	'array' 'of' extra=type_reference {node=new ArrayTypeDeclarationNode{Name=typeName, ExistingType=extra, Start=Loc($t)};}
			|	extra=type_reference {node=new AliasTypeDeclarationNode{Name=typeName, ExistingType=extra, Start=Loc($t)};}
			)
	;
	
field returns [RecordFieldNode node]	
	:	name=identifier COLON type=type_reference {node=new RecordFieldNode{FieldName=name, TypeName=type, Start=name.Start};}
	;

fieldList returns [IEnumerable<RecordFieldNode> parameters]
@init {var result=new List<RecordFieldNode>();}
@after {parameters=result;}
	:	f=field {result.Add(f);} (COMMA f=field {result.Add(f);} )*
	|
	;

variable_declaration returns [VariableDeclarationExpression expression]
@init {expression = new VariableDeclarationExpression();}
@after {expression.VariableName = name; expression.Value = e; expression.Start=Loc($t); }
	:	t='var' name=member_identifier (COLON type=type_reference {expression.VariableTypeName=type;})? ASSIGN e=program
	;

func_definition returns [FunctionDefinitionExpression expression]
@init {expression = new FunctionDefinitionExpression();}
@after {expression.Name = name; expression.Body=body; expression.Parameters=parameters; expression.Start=Loc($t);}
	:	t='function' name=identifier LPAREN parameters=func_parameter_list RPAREN (COLON type=type_reference {expression.ReturnTypeName=type;})? EQUAL body=program
	;
	
func_parameter_list returns [IEnumerable<FunctionParameterExpression> parameters]
@init {var result=new List<FunctionParameterExpression>();}
@after {parameters=result;}
	:	name=identifier COLON type=type_reference {result.Add(new FunctionParameterExpression{Name=name, TypeName=type, Start=name.Start});} 
		(COMMA name=identifier COLON type=type_reference {result.Add(new FunctionParameterExpression{Name=name, TypeName=type, Start=name.Start});})*
	|
	;

identifier returns [IdentifierNode identifier]
	:	t=NAME {identifier=new IdentifierNode{Name=t.Text, Start=Loc($t)};}
	;
	
member_identifier returns [MemberIdentifierNode identifier]
	:	t=NAME {identifier=new MemberIdentifierNode{Name=t.Text, Start=Loc($t)};}
	;
	
type_identifier returns [TypeIdentifierNode identifier]
	:	t=NAME {identifier=new TypeIdentifierNode{Name=t.Text, Start=Loc($t)};}
	;

type_reference returns [TypeReferenceNode reference]
	:	t=NAME {reference=new TypeReferenceNode{TypeName=$t.Text, Start=Loc($t)};}
	;
	
//******
// NEW init a list like Haskell
test returns [Expression expression]
	: 	e=and_test {expression=e;} ((VBAR VBAR)=> VBAR VBAR e=and_test {expression=new LogicalBinaryOperationExpression{Left= new ToBooleanExpression( expression ), Right= new ToBooleanExpression( e ), Operator=TigerOperator.OrElse};})*
	;

and_test returns [Expression expression]
@init{var list=new List<Expression>();}
	: 	e=not_test {expression=e;} ((AMPER AMPER)=> AMPER AMPER e=not_test {expression=new LogicalBinaryOperationExpression{Left= new ToBooleanExpression( expression ), Right= new ToBooleanExpression( e ), Operator=TigerOperator.AndAlso};})*
	;

not_test returns [Expression expression]
@after {expression=e;}
	: 	t='not' e=not_test { e=new UnaryOperationExpression {Expression = new ToBooleanExpression( e ), Operator = TigerOperator.Not, Start=Loc($t)}; }
	| 	e=comparison
	;

comparison returns [Expression expression]
	: 	e=expr {expression=e;} ((comp_op) => op=comp_op e=expr {expression=new LogicalBinaryOperationExpression{Left= expression, Right= e ,Operator=op.op,Start=op.loc};})?
	;

comp_op	returns [TigerOperator op, SourceLocation loc]
@after{$loc=Loc($t);}
	: 	t=LESS {$op=TigerOperator.LessThan;}
	|	t=GREATER {$op=TigerOperator.GreaterThan;}
	|	t=EQUAL {$op=TigerOperator.Equal;}
	|	t=GREATEREQUAL {$op=TigerOperator.GreaterThanOrEqual;}
	|	t=LESSEQUAL {$op=TigerOperator.LessThanOrEqual;}
	|	t=NOTEQUAL {$op=TigerOperator.NotEqual;}
	;

expr returns [Expression expression]
@init{var op=TigerOperator.Add;}
	: 	e=term {expression=e;} ((PLUS|MINUS)=> (PLUS|MINUS {op=TigerOperator.Subtract;}) e=term {expression=new BinaryOperationExpression{Left=expression, Right=e, Operator=op};})*
	;

term returns [Expression expression]
	: 	e=factor {expression=e;} ((mult_op)=> op=mult_op e=factor {expression=new BinaryOperationExpression{Left= expression,Right=e,Operator=op};})*
	;

factor returns [Expression expression]
	: 	PLUS e=factor {expression=e;}
	|	t=MINUS e=factor {expression=new UnaryOperationExpression{Expression=e, Operator=TigerOperator.Negate, Start=Loc($t)};}
	| 	e=power {expression=e;}
	;
	
mult_op	returns [TigerOperator op]
	:	STAR {$op=TigerOperator.Multiply;}
	| 	SLASH {$op=TigerOperator.Divide;}
	| 	PERCENT {$op=TigerOperator.Mod;}
	| 	DOUBLESLASH {$op=TigerOperator.TrueDivide;}
	;

power returns [Expression expression]
	:   e=power_base {expression=e;} (options {greedy=true;}: t=DOUBLESTAR e=factor {expression=new BinaryOperationExpression{Left= expression,Right=e,Operator=TigerOperator.Power, Start=Loc($t)};} )?
	;

power_base returns [Expression expression]
	:	prev=atom ((LBRACK|DOT)=> next=member_access[prev] {prev=next;})* {expression=prev;}
	;

atom returns [Expression expression]
@init{FunctionInvokeExpression r=null;}
	:	name=identifier	(	LCURLY fields=memberinitlist RCURLY {expression=new RecordInitExpression{TypeName=new TypeReferenceNode{TypeName= name.Name}, Fields=fields, Start=name.Start};}
				|	(LBRACK program RBRACK 'of') => LBRACK lenght=program RBRACK 'of' init=program {expression=new ArrayDefaultInitializationExpression{ArrayTypeName=new TypeReferenceNode{TypeName= name.Name}, Lenght=lenght, InitialValue=init, Start=name.Start};}
				| 	{expression=new VariableAccessExpression{VariableName=name.Name, Start=name.Start};} (t=ASSIGN e1=program {expression=new AssignExpression{Left=expression,Right=e1, Start=Loc($t)};})?
				| 	{r=new FunctionInvokeExpression{FunctionName=name, Start=name.Start};} LPAREN (args=program_list_comma {r.Args=args;})? RPAREN {expression=r;} 
				)
	| 	e=literal {expression=e;}
	| 	e=expr_stmt {expression=e;}
	|	(LPAREN type_reference RPAREN) => t=LPAREN cast=type_reference RPAREN ex=program {expression=new CastExpression{TargetType=cast,Expression=ex,Start=Loc($t)};}
	|	LPAREN p=program RPAREN {expression=p;}
	;

literal	returns [Expression expression]
	:	t='true' {expression=new BoolLiteral(true){Start=Loc($t)};}
	|	t='false' {expression=new BoolLiteral(false){Start=Loc($t)};}
	|	t='break' {expression = new BreakExpression{Start=Loc($t)}; }
	|	t='continue' {expression = new ContinueExpression{Start=Loc($t)}; }
	|	t='nil' { expression=new NullLiteralExpression{Start=Loc($t)}; }
	|	t='return' v=program {expression=new ReturnExpression{Value=v,Start=Loc($t)};}
	|	t=INT {expression=new IntLiteralExpression($t.Text){Start=Loc($t)};}	
	| 	e=stringLiteral {expression=e;}
	;

stringLiteral returns [StringLiteralExpression expression]
	:	t=STRING {expression=new StringLiteralExpression($t.Text){Start=Loc($t)};}
			((PERCENT) => PERCENT ((LPAREN) => LPAREN args=program_list_comma RPAREN {expression.Args=args;} 
						| e=program {expression.Args=new[]{e};}) )?
	;

member_access[Expression target] returns [Expression expression]
@init{MethodCallExpression method=null;}
	:	LBRACK e=program_list_comma RBRACK {expression = new ArrayIndexExpression{Target=target, Indexes=e};} (t=ASSIGN e1=program {expression=new AssignExpression{Left=expression, Right=e1, Start=Loc($t)};})?
	|	DOT name=identifier
			(	{method=new MethodCallExpression{Target=target,MethodName=name, Start=name.Start};} LPAREN (args=program_list_comma {method.Args=args; })? RPAREN  {expression=method;}
			| 	{expression=new FieldAccessExpression{Target=target, FieldName=name, Start=name.Start};} (t=ASSIGN e1=program {expression=new AssignExpression{Left=expression,Right=e1, Start=Loc($t)};})?
			)
	//|	'in' program
	;


memberinit returns [FieldInitializationNode node]
	:	name=identifier EQUAL e=program {node=new FieldInitializationNode{FieldName=name, Value=e, Start=name.Start};}
	;

memberinitlist returns [IEnumerable<FieldInitializationNode> result]
@init{var list=new List<FieldInitializationNode>();}
@after{result=list;}
    	:	f=memberinit {list.Add(f);} (options {k=2;}:COMMA f=memberinit {list.Add(f);})* (COMMA)?
	;

LPAREN	: '('  ;

RPAREN	: ')'  ;

LBRACK	: '['  ;

RBRACK	: ']'  ;

LCURLY	: '{'  ;

RCURLY	: '}'  ;

COLON 	: ':' ;

COMMA	: ',' ;

SEMI	: ';' ;

PLUS	: '+' ;

MINUS	: '-' ;

STAR	: '*' ;

SLASH	: '/' ;

VBAR	: '|' ;

AMPER	: '&' ;

LESS	: '<' ;

GREATER	: '>' ;

ASSIGN	: ':=' ;

PERCENT	: '%' ;

EQUAL	: '=' ;

NOTEQUAL	: '<>' ;

LESSEQUAL	: '<=' ;

GREATEREQUAL	: '>=' ;

PLUSEQUAL	: '+=' ;

MINUSEQUAL	: '-=' ;

DOUBLESTAR	: '**' ;

STAREQUAL	: '*=' ;

DOUBLESLASH	: '//' ;

SLASHEQUAL	: '/=' ;

VBAREQUAL	: '|=' ;

DOUBLESTAREQUAL	: '**=' ;

DOUBLESLASHEQUAL	: '//=' ;

DOT : '.' ;

INT :   // Hex
        '0' ('x' | 'X') ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+
        ('l' | 'L')?
    |   // Octal
        '0' DIGITS*
    |   '1'..'9' DIGITS*
    ;

fragment DIGITS : ( '0' .. '9' )+ ;

NAME:	( 'a' .. 'z' | 'A' .. 'Z' | '_')
        ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
    ;

/** Match various string types.  Note that greedy=false implies '''
 *  should make us exit loop not continue.
 */
STRING
    	:	   ('r'|'u'|'ur')?
        (   '\'\'\'' (options {greedy=false;}:.)* '\'\'\''
        |   '"""' (options {greedy=false;}:.)* '"""'
        |   '"' (ESC|~('\\'|'\n'|'"'))* '"'
        |   '\'' (ESC|~('\\'|'\n'|'\''))* '\''
        )
	;

fragment
ESC
	:	'\\' .
	;

NEWLINE
    :   (('\r')? '\n' )+ { $channel=HIDDEN; }
    ;

WS	:	 (' '|'\t')+ {$channel=HIDDEN;}
	;

COMMENT:
	'/*' ( COMMENT
	| '/' ~('*')
	| ('*' ~('/'))=>'*'
	| ~('*'|'/')
	)*
	'*/' {$channel=HIDDEN;}
	;
