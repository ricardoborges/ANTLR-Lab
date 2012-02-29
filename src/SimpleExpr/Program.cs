using Antlr.Runtime;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ANTLRStringStream("a=(3+4)*5\r\na+1\r\n");
            var lexer = new ExprLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ExprParser(tokens);
            
            parser.prog();
        }
    }
}
