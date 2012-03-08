using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr3.ST;

namespace TreeGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            Do(false);
        }

        static void Do(bool dot)
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
            var r = parser.program();
            var t = (CommonTree)r.Tree;

            if (dot) {
                DotTreeGenerator gen = new DotTreeGenerator();
                var st = gen.ToDot(t);
                
                Console.WriteLine(st);
            }
            else {

                Console.WriteLine(t.ToStringTree());
            }

            var nodes = new CommonTreeNodeStream(t);

            nodes.TokenStream = tokens;

            var walker = new CMinusWalker(nodes);

            walker.program();
        }
    }
}
