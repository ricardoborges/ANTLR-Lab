//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g 2012-02-29 16:45:54

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections;


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
public partial class ExprParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ID", "INT", "NEWLINE", "WS", "'('", "')'", "'*'", "'+'", "'-'", "'='"
	};
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

	public ExprParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public ExprParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}

	public override string[] TokenNames { get { return ExprParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g"; } }


	/** Map variable name to Integer object holding value */
	Hashtable memory = new Hashtable();


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_prog();
	partial void LeaveRule_prog();

	// $ANTLR start "prog"
	// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:18:1: prog : ( stat )+ ;
	[GrammarRule("prog")]
	public void prog()
	{
		EnterRule_prog();
		EnterRule("prog", 1);
		TraceIn("prog", 1);
		try { DebugEnterRule(GrammarFileName, "prog");
		DebugLocation(18, 14);
		try
		{
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:18:5: ( ( stat )+ )
			DebugEnterAlt(1);
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:18:9: ( stat )+
			{
			DebugLocation(18, 9);
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:18:9: ( stat )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_0 = input.LA(1);

				if (((LA1_0>=ID && LA1_0<=NEWLINE)||LA1_0==8))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:18:9: stat
					{
					DebugLocation(18, 9);
					PushFollow(Follow._stat_in_prog35);
					stat();
					PopFollow();


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

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("prog", 1);
			LeaveRule("prog", 1);
			LeaveRule_prog();
		}
		DebugLocation(18, 14);
		} finally { DebugExitRule(GrammarFileName, "prog"); }
		return;

	}
	// $ANTLR end "prog"

	partial void EnterRule_stat();
	partial void LeaveRule_stat();

	// $ANTLR start "stat"
	// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:20:1: stat : ( expr NEWLINE | ID '=' expr NEWLINE | NEWLINE );
	[GrammarRule("stat")]
	private void stat()
	{
		EnterRule_stat();
		EnterRule("stat", 2);
		TraceIn("stat", 2);
		IToken ID2 = default(IToken);
		int expr1 = default(int);
		int expr3 = default(int);

		try { DebugEnterRule(GrammarFileName, "stat");
		DebugLocation(20, 4);
		try
		{
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:20:5: ( expr NEWLINE | ID '=' expr NEWLINE | NEWLINE )
			int alt2=3;
			try { DebugEnterDecision(2, false);
			switch (input.LA(1))
			{
			case INT:
			case 8:
				{
				alt2 = 1;
				}
				break;
			case ID:
				{
				int LA2_2 = input.LA(2);

				if ((LA2_2==13))
				{
					alt2 = 2;
				}
				else if ((LA2_2==NEWLINE||(LA2_2>=10 && LA2_2<=12)))
				{
					alt2 = 1;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 2, input);
					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case NEWLINE:
				{
				alt2 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:22:9: expr NEWLINE
				{
				DebugLocation(22, 9);
				PushFollow(Follow._expr_in_stat80);
				expr1=expr();
				PopFollow();

				DebugLocation(22, 14);
				Match(input,NEWLINE,Follow._NEWLINE_in_stat82); 
				DebugLocation(22, 22);
				System.Console.Out.WriteLine(expr1);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:26:9: ID '=' expr NEWLINE
				{
				DebugLocation(26, 9);
				ID2=(IToken)Match(input,ID,Follow._ID_in_stat113); 
				DebugLocation(26, 12);
				Match(input,13,Follow._13_in_stat115); 
				DebugLocation(26, 16);
				PushFollow(Follow._expr_in_stat117);
				expr3=expr();
				PopFollow();

				DebugLocation(26, 21);
				Match(input,NEWLINE,Follow._NEWLINE_in_stat119); 
				DebugLocation(27, 9);
				memory.Add((ID2!=null?ID2.Text:null), expr3);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:30:9: NEWLINE
				{
				DebugLocation(30, 9);
				Match(input,NEWLINE,Follow._NEWLINE_in_stat149); 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("stat", 2);
			LeaveRule("stat", 2);
			LeaveRule_stat();
		}
		DebugLocation(31, 4);
		} finally { DebugExitRule(GrammarFileName, "stat"); }
		return;

	}
	// $ANTLR end "stat"

	partial void EnterRule_expr();
	partial void LeaveRule_expr();

	// $ANTLR start "expr"
	// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:38:1: expr returns [int value] : e= multExpr ( '+' e= multExpr | '-' e= multExpr )* ;
	[GrammarRule("expr")]
	private int expr()
	{
		EnterRule_expr();
		EnterRule("expr", 3);
		TraceIn("expr", 3);
		int value = default(int);


		int e = default(int);

		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(38, 4);
		try
		{
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:39:5: (e= multExpr ( '+' e= multExpr | '-' e= multExpr )* )
			DebugEnterAlt(1);
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:39:9: e= multExpr ( '+' e= multExpr | '-' e= multExpr )*
			{
			DebugLocation(39, 10);
			PushFollow(Follow._multExpr_in_expr178);
			e=multExpr();
			PopFollow();

			DebugLocation(39, 20);
			value = e;
			DebugLocation(40, 9);
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:40:9: ( '+' e= multExpr | '-' e= multExpr )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=3;
				try { DebugEnterDecision(3, false);
				int LA3_0 = input.LA(1);

				if ((LA3_0==11))
				{
					alt3 = 1;
				}
				else if ((LA3_0==12))
				{
					alt3 = 2;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:40:13: '+' e= multExpr
					{
					DebugLocation(40, 13);
					Match(input,11,Follow._11_in_expr194); 
					DebugLocation(40, 18);
					PushFollow(Follow._multExpr_in_expr198);
					e=multExpr();
					PopFollow();

					DebugLocation(40, 28);
					value += e;

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:41:13: '-' e= multExpr
					{
					DebugLocation(41, 13);
					Match(input,12,Follow._12_in_expr214); 
					DebugLocation(41, 18);
					PushFollow(Follow._multExpr_in_expr218);
					e=multExpr();
					PopFollow();

					DebugLocation(41, 28);
					value -= e;

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr", 3);
			LeaveRule("expr", 3);
			LeaveRule_expr();
		}
		DebugLocation(43, 4);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return value;

	}
	// $ANTLR end "expr"

	partial void EnterRule_multExpr();
	partial void LeaveRule_multExpr();

	// $ANTLR start "multExpr"
	// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:52:1: multExpr returns [int value] : e= atom ( '*' e= atom )* ;
	[GrammarRule("multExpr")]
	private int multExpr()
	{
		EnterRule_multExpr();
		EnterRule("multExpr", 4);
		TraceIn("multExpr", 4);
		int value = default(int);


		int e = default(int);

		try { DebugEnterRule(GrammarFileName, "multExpr");
		DebugLocation(52, 4);
		try
		{
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:53:5: (e= atom ( '*' e= atom )* )
			DebugEnterAlt(1);
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:53:9: e= atom ( '*' e= atom )*
			{
			DebugLocation(53, 10);
			PushFollow(Follow._atom_in_multExpr260);
			e=atom();
			PopFollow();

			DebugLocation(53, 16);
			value = e;
			DebugLocation(53, 37);
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:53:37: ( '*' e= atom )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_0 = input.LA(1);

				if ((LA4_0==10))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:53:38: '*' e= atom
					{
					DebugLocation(53, 38);
					Match(input,10,Follow._10_in_multExpr265); 
					DebugLocation(53, 43);
					PushFollow(Follow._atom_in_multExpr269);
					e=atom();
					PopFollow();

					DebugLocation(53, 49);
					value *= e;

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("multExpr", 4);
			LeaveRule("multExpr", 4);
			LeaveRule_multExpr();
		}
		DebugLocation(54, 4);
		} finally { DebugExitRule(GrammarFileName, "multExpr"); }
		return value;

	}
	// $ANTLR end "multExpr"

	partial void EnterRule_atom();
	partial void LeaveRule_atom();

	// $ANTLR start "atom"
	// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:58:1: atom returns [int value] : ( INT | ID | '(' expr ')' );
	[GrammarRule("atom")]
	private int atom()
	{
		EnterRule_atom();
		EnterRule("atom", 5);
		TraceIn("atom", 5);
		int value = default(int);


		IToken INT4 = default(IToken);
		IToken ID5 = default(IToken);
		int expr6 = default(int);

		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(58, 4);
		try
		{
			// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:59:5: ( INT | ID | '(' expr ')' )
			int alt5=3;
			try { DebugEnterDecision(5, false);
			switch (input.LA(1))
			{
			case INT:
				{
				alt5 = 1;
				}
				break;
			case ID:
				{
				alt5 = 2;
				}
				break;
			case 8:
				{
				alt5 = 3;
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
				// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:60:9: INT
				{
				DebugLocation(60, 9);
				INT4=(IToken)Match(input,INT,Follow._INT_in_atom308); 
				DebugLocation(60, 13);
				value = int.Parse((INT4!=null?INT4.Text:null));

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:62:9: ID
				{
				DebugLocation(62, 9);
				ID5=(IToken)Match(input,ID,Follow._ID_in_atom321); 
				DebugLocation(63, 9);

				        // look up value of variable
				        var v = (int)memory[(ID5!=null?ID5.Text:null)];
				        // if found, set return value else error
				        if ( v==null ) System.Console.Out.WriteLine("undefined variable "+(ID5!=null?ID5.Text:null));
				        else 
				           value = v;
				        

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\u031216\\Desktop\\Teste\\Example\\Expr.g:73:9: '(' expr ')'
				{
				DebugLocation(73, 9);
				Match(input,8,Follow._8_in_atom352); 
				DebugLocation(73, 13);
				PushFollow(Follow._expr_in_atom354);
				expr6=expr();
				PopFollow();

				DebugLocation(73, 18);
				Match(input,9,Follow._9_in_atom356); 
				DebugLocation(73, 22);
				value = expr6;

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("atom", 5);
			LeaveRule("atom", 5);
			LeaveRule_atom();
		}
		DebugLocation(74, 4);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return value;

	}
	// $ANTLR end "atom"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _stat_in_prog35 = new BitSet(new ulong[]{0x172UL});
		public static readonly BitSet _expr_in_stat80 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _NEWLINE_in_stat82 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_stat113 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _13_in_stat115 = new BitSet(new ulong[]{0x130UL});
		public static readonly BitSet _expr_in_stat117 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _NEWLINE_in_stat119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEWLINE_in_stat149 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _multExpr_in_expr178 = new BitSet(new ulong[]{0x1802UL});
		public static readonly BitSet _11_in_expr194 = new BitSet(new ulong[]{0x130UL});
		public static readonly BitSet _multExpr_in_expr198 = new BitSet(new ulong[]{0x1802UL});
		public static readonly BitSet _12_in_expr214 = new BitSet(new ulong[]{0x130UL});
		public static readonly BitSet _multExpr_in_expr218 = new BitSet(new ulong[]{0x1802UL});
		public static readonly BitSet _atom_in_multExpr260 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _10_in_multExpr265 = new BitSet(new ulong[]{0x130UL});
		public static readonly BitSet _atom_in_multExpr269 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _INT_in_atom308 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_atom321 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _8_in_atom352 = new BitSet(new ulong[]{0x130UL});
		public static readonly BitSet _expr_in_atom354 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _9_in_atom356 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}