grammar CMinus;

options {
output=AST;
language=CSharp3;
}

tokens {
  VAR;   
  FUNC;  
  ARG;   
  SLIST; 
}

public program
    :   declaration+
    ;

declaration
    :   variable
    |   function
    ;

variable
    :   type ID ';' -> ^(VAR type ID)
    ;

type:   'int' 
    |   'char'
    ;

function
    :   type ID
        '(' ( formalParameter (',' formalParameter)* )?  ')'
        block
        -> ^(FUNC type ID formalParameter* block)
    ;

formalParameter
    :   type ID -> ^(ARG type ID)
    ;


block
    :   lc='{' variable* stat* '}'
        -> ^(SLIST[$lc,"SLIST"] variable* stat*)
    ;

stat: forStat
    | expr ';'!
    | block
    | assignStat ';'!
    | ';'!
    ;

forStat
    :   'for' '(' first=assignStat ';' expr ';' inc=assignStat ')' block
        -> ^('for' $first expr $inc block)
    ;

assignStat
    :   ID '=' expr -> ^('=' ID expr)
    ;

expr:   condExpr ;

condExpr
    :   aexpr ( ('=='^|'!='^) aexpr )?
    ;

aexpr
    :   mexpr ('+'^ mexpr)*
    ;

mexpr
    :   atom ('*'^ atom)*
    ;

atom:   ID
    |   INT
    |   '(' expr ')' -> expr
    ;

ID  :   ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ;

INT :   ('0'..'9')+ ;

WS  :   ( ' ' | '\t' | '\r' | '\n' )+ { $channel = Hidden; } ;    
