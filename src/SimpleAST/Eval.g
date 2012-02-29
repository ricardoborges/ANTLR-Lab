tree grammar Eval;

options {
    language=CSharp3;
    tokenVocab=Expr;
    ASTLabelType=CommonTree;
}

// START:members
@header {
using System.Collections;
}

@members {
/** Map variable name to Integer object holding value */
Hashtable memory = new Hashtable();
}
// END:members

// START:stat
public prog:   stat+ ;

stat:   expr
        {System.Console.Out.WriteLine($expr.value);}
    |   ^('=' ID expr)
        {memory.Add($ID.text, $expr.value);}
    ;
// END:stat

// START:expr
expr returns [int value]
    :   ^('+' a=expr b=expr) {$value = a+b;}
    |   ^('-' a=expr b=expr) {$value = a-b;}   
    |   ^('*' a=expr b=expr) {$value = a*b;}
    |   ID 
        {
        var v = (int)memory[$ID.text];
        if ( v!=null ) $value = v;
        else System.Console.Out.WriteLine("undefined variable "+$ID.text);
        }
    |   INT                  {$value = int.Parse($INT.text);}
    ;
// END:expr
