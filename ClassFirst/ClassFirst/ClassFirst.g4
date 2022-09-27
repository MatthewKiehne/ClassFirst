grammar ClassFirst;

parse
    : classDeclaration EOF
    ;

classDeclaration
    : Public Class Identifier classBlock 
    ;

classBlock
    : '{' classMember* '}' 
    ;

classMember
    : fieldDeclaration
    | classConstructorDeclaration
    ;

classConstructorDeclaration
    : Public ClassName '(' ( TypeName VariableName ( ',' TypeName VariableName )* )? ')' block
    ;

block
    : '{' statement* '}' 
    ;

statement
    : variableDeclaration
    | assignment
    ;

variableDeclaration
    : TypeName Identifier Assign expression
    ;

assignment
    : Identifier Assign expression
    ;

fieldDeclaration
    : Modifier variableDeclaration
    ;

expression
    : Int                                               #intExpression
    ;

TypeName
    : Identifier
    ;

VariableName
    : Identifier
    ;

ClassName
    : Identifier
    ;

Modifier 
    : Public
    | Private
    ;

Class       : 'class';
Public      : 'public';
Private     : 'private';

// Operators
Assign      : '=';

Int
    : [1-9] [0-9]*
    | '0'
    ;

String
    : ["] ( ~["\r\n\\] | '\\' ~[\r\n] )* ["]
    | ['] ( ~['\r\n\\] | '\\' ~[\r\n] )* [']
    ;

Identifier : [a-zA-Z_] [a-zA-Z_0-9]*;

Comment
    : ( '//' ~[\r\n]* | '/*' .*? '*/' ) -> skip
    ;

Space
    : [ \t\r\n\u000C] -> skip
    ;