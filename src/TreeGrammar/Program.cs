using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace TreeGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ANTLRStringStream(
@"
char c;
int x;

int foo(int y, char d) {
    int i;
    for (i=0; i!=3; i=i+1) {
        x=3;
        y=5;
    }
}");
            var lexer = new CMinusLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new CMinusParser(tokens);
            
            var result = parser.program();

            var t = (CommonTree) result.Tree;

            Console.Out.WriteLine(t.ToStringTree());
        }
    }
}
