tree grammar CMinusWalker;

options {
tokenVocab=CMinus;
language=CSharp3;
ASTLabelType=CommonTree;
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
    :   ^(VAR type ID)
	{System.Console.Out.WriteLine(string.Format("Define {0} {1}",$type.text, $ID.text));}
    ;

type:   'int' 
    |   'char'
    ;

function
    :   ^(FUNC type ID formalParameter* block)
   	 {System.Console.Out.WriteLine(string.Format("Define {0} {1}()",$type.text, $ID.text));}
    ;

formalParameter
    :   ^(ARG type ID)
    ;


block
    :   ^(SLIST variable* stat*)
    ;

stat: forStat
    | expr
    | block
    | assignStat
    ;

forStat
    :   ^('for' assignStat expr assignStat block)
    ;

assignStat
    :   ^('=' ID expr)
    ;

expr: ^('==' expr expr)
| ^('!=' expr expr)
| ^('+' expr expr)
| ^('*' expr expr)
| ID
| INT
;
