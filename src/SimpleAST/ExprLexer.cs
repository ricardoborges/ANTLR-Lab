//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g 2012-02-29 17:47:25

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
public partial class ExprLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__8=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int ID=4;
	public const int INT=5;
	public const int NEWLINE=6;
	public const int WS=7;

    // delegates
    // delegators

	public ExprLexer()
	{
		OnCreated();
	}

	public ExprLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public ExprLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__8();
	partial void LeaveRule_T__8();

	// $ANTLR start "T__8"
	[GrammarRule("T__8")]
	private void mT__8()
	{
		EnterRule_T__8();
		EnterRule("T__8", 1);
		TraceIn("T__8", 1);
		try
		{
			int _type = T__8;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:7:6: ( '(' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:7:8: '('
			{
			DebugLocation(7, 8);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__8", 1);
			LeaveRule("T__8", 1);
			LeaveRule_T__8();
		}
	}
	// $ANTLR end "T__8"

	partial void EnterRule_T__9();
	partial void LeaveRule_T__9();

	// $ANTLR start "T__9"
	[GrammarRule("T__9")]
	private void mT__9()
	{
		EnterRule_T__9();
		EnterRule("T__9", 2);
		TraceIn("T__9", 2);
		try
		{
			int _type = T__9;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:8:6: ( ')' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:8:8: ')'
			{
			DebugLocation(8, 8);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__9", 2);
			LeaveRule("T__9", 2);
			LeaveRule_T__9();
		}
	}
	// $ANTLR end "T__9"

	partial void EnterRule_T__10();
	partial void LeaveRule_T__10();

	// $ANTLR start "T__10"
	[GrammarRule("T__10")]
	private void mT__10()
	{
		EnterRule_T__10();
		EnterRule("T__10", 3);
		TraceIn("T__10", 3);
		try
		{
			int _type = T__10;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:9:7: ( '*' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:9:9: '*'
			{
			DebugLocation(9, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__10", 3);
			LeaveRule("T__10", 3);
			LeaveRule_T__10();
		}
	}
	// $ANTLR end "T__10"

	partial void EnterRule_T__11();
	partial void LeaveRule_T__11();

	// $ANTLR start "T__11"
	[GrammarRule("T__11")]
	private void mT__11()
	{
		EnterRule_T__11();
		EnterRule("T__11", 4);
		TraceIn("T__11", 4);
		try
		{
			int _type = T__11;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:10:7: ( '+' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:10:9: '+'
			{
			DebugLocation(10, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__11", 4);
			LeaveRule("T__11", 4);
			LeaveRule_T__11();
		}
	}
	// $ANTLR end "T__11"

	partial void EnterRule_T__12();
	partial void LeaveRule_T__12();

	// $ANTLR start "T__12"
	[GrammarRule("T__12")]
	private void mT__12()
	{
		EnterRule_T__12();
		EnterRule("T__12", 5);
		TraceIn("T__12", 5);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:11:7: ( '-' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:11:9: '-'
			{
			DebugLocation(11, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 5);
			LeaveRule("T__12", 5);
			LeaveRule_T__12();
		}
	}
	// $ANTLR end "T__12"

	partial void EnterRule_T__13();
	partial void LeaveRule_T__13();

	// $ANTLR start "T__13"
	[GrammarRule("T__13")]
	private void mT__13()
	{
		EnterRule_T__13();
		EnterRule("T__13", 6);
		TraceIn("T__13", 6);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:12:7: ( '=' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:12:9: '='
			{
			DebugLocation(12, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 6);
			LeaveRule("T__13", 6);
			LeaveRule_T__13();
		}
	}
	// $ANTLR end "T__13"

	partial void EnterRule_ID();
	partial void LeaveRule_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		EnterRule_ID();
		EnterRule("ID", 7);
		TraceIn("ID", 7);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:39:5: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:39:9: ( 'a' .. 'z' | 'A' .. 'Z' )+
			{
			DebugLocation(39, 9);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:39:9: ( 'a' .. 'z' | 'A' .. 'Z' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='A' && LA1_0<='Z')||(LA1_0>='a' && LA1_0<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:
					{
					DebugLocation(39, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 7);
			LeaveRule("ID", 7);
			LeaveRule_ID();
		}
	}
	// $ANTLR end "ID"

	partial void EnterRule_INT();
	partial void LeaveRule_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		EnterRule_INT();
		EnterRule("INT", 8);
		TraceIn("INT", 8);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:40:5: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:40:9: ( '0' .. '9' )+
			{
			DebugLocation(40, 9);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:40:9: ( '0' .. '9' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='0' && LA2_0<='9')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:
					{
					DebugLocation(40, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 8);
			LeaveRule("INT", 8);
			LeaveRule_INT();
		}
	}
	// $ANTLR end "INT"

	partial void EnterRule_NEWLINE();
	partial void LeaveRule_NEWLINE();

	// $ANTLR start "NEWLINE"
	[GrammarRule("NEWLINE")]
	private void mNEWLINE()
	{
		EnterRule_NEWLINE();
		EnterRule("NEWLINE", 9);
		TraceIn("NEWLINE", 9);
		try
		{
			int _type = NEWLINE;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:41:8: ( ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:41:9: ( '\\r' )? '\\n'
			{
			DebugLocation(41, 9);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:41:9: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, false);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3 = 1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:41:9: '\\r'
				{
				DebugLocation(41, 9);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(41, 15);
			Match('\n'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWLINE", 9);
			LeaveRule("NEWLINE", 9);
			LeaveRule_NEWLINE();
		}
	}
	// $ANTLR end "NEWLINE"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 10);
		TraceIn("WS", 10);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:42:5: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:42:9: ( ' ' | '\\t' | '\\n' | '\\r' )+
			{
			DebugLocation(42, 9);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:42:9: ( ' ' | '\\t' | '\\n' | '\\r' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='\t' && LA4_0<='\n')||LA4_0=='\r'||LA4_0==' '))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:
					{
					DebugLocation(42, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(42, 31);
			Skip();

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 10);
			LeaveRule("WS", 10);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	public override void mTokens()
	{
		// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:8: ( T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | ID | INT | NEWLINE | WS )
		int alt5=10;
		try { DebugEnterDecision(5, false);
		switch (input.LA(1))
		{
		case '(':
			{
			alt5 = 1;
			}
			break;
		case ')':
			{
			alt5 = 2;
			}
			break;
		case '*':
			{
			alt5 = 3;
			}
			break;
		case '+':
			{
			alt5 = 4;
			}
			break;
		case '-':
			{
			alt5 = 5;
			}
			break;
		case '=':
			{
			alt5 = 6;
			}
			break;
		case 'A':
		case 'B':
		case 'C':
		case 'D':
		case 'E':
		case 'F':
		case 'G':
		case 'H':
		case 'I':
		case 'J':
		case 'K':
		case 'L':
		case 'M':
		case 'N':
		case 'O':
		case 'P':
		case 'Q':
		case 'R':
		case 'S':
		case 'T':
		case 'U':
		case 'V':
		case 'W':
		case 'X':
		case 'Y':
		case 'Z':
		case 'a':
		case 'b':
		case 'c':
		case 'd':
		case 'e':
		case 'f':
		case 'g':
		case 'h':
		case 'i':
		case 'j':
		case 'k':
		case 'l':
		case 'm':
		case 'n':
		case 'o':
		case 'p':
		case 'q':
		case 'r':
		case 's':
		case 't':
		case 'u':
		case 'v':
		case 'w':
		case 'x':
		case 'y':
		case 'z':
			{
			alt5 = 7;
			}
			break;
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
			{
			alt5 = 8;
			}
			break;
		case '\r':
			{
			int LA5_9 = input.LA(2);

			if ((LA5_9=='\n'))
			{
				int LA5_10 = input.LA(3);

				if (((LA5_10>='\t' && LA5_10<='\n')||LA5_10=='\r'||LA5_10==' '))
				{
					alt5 = 10;
				}
				else
				{
					alt5 = 9;
				}
			}
			else
			{
				alt5 = 10;
			}
			}
			break;
		case '\n':
			{
			int LA5_10 = input.LA(2);

			if (((LA5_10>='\t' && LA5_10<='\n')||LA5_10=='\r'||LA5_10==' '))
			{
				alt5 = 10;
			}
			else
			{
				alt5 = 9;
			}
			}
			break;
		case '\t':
		case ' ':
			{
			alt5 = 10;
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(5); }
		switch (alt5)
		{
		case 1:
			DebugEnterAlt(1);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:10: T__8
			{
			DebugLocation(1, 10);
			mT__8(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:15: T__9
			{
			DebugLocation(1, 15);
			mT__9(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:20: T__10
			{
			DebugLocation(1, 20);
			mT__10(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:26: T__11
			{
			DebugLocation(1, 26);
			mT__11(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:32: T__12
			{
			DebugLocation(1, 32);
			mT__12(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:38: T__13
			{
			DebugLocation(1, 38);
			mT__13(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:44: ID
			{
			DebugLocation(1, 44);
			mID(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:47: INT
			{
			DebugLocation(1, 47);
			mINT(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:51: NEWLINE
			{
			DebugLocation(1, 51);
			mNEWLINE(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// E:\\Git\\ANTLR-Lab\\src\\SimpleAST\\Expr.g:1:59: WS
			{
			DebugLocation(1, 59);
			mWS(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}
