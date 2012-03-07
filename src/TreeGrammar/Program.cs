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
            var input = new ANTLRStringStream("int soma(int a, int b){};");
            var lexer = new CMinusLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new CMinusParser(tokens);
            CMinusParser.program_return r = parser.program();
            var t = (CommonTree)r.getTree();
        }
    }
}
