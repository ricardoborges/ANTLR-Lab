using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SimpleAST
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ANTLRStringStream("a=(3+4)*5\r\na+1\r\n");
            var lexer = new ExprLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ExprParser(tokens);

            var r = parser.prog();

            var t = (CommonTree) r.Tree;

            var nodes = new CommonTreeNodeStream(t);
            
            var walker = new Eval(nodes); // create a tree parser
            
            walker.prog(); // launch at start rule prog
        }
    }
}