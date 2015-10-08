// $ANTLR 3.3 Nov 30, 2010 12:45:30 E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g 2012-03-19 18:43:02

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


	using System;
	using Tiger.Build.Compiler.Ast;
	using Scope = Tiger.Build.Compiler.Common.Scope;
	using Tiger.Build.Compiler.Common;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;
namespace Tiger.Build.Compiler.Parsing
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "VBAR", "LBRACK", "RBRACK", "LCURLY", "SEMI", "RCURLY", "COMMA", "ASSIGN", "EQUAL", "COLON", "LPAREN", "RPAREN", "NAME", "AMPER", "LESS", "GREATER", "GREATEREQUAL", "LESSEQUAL", "NOTEQUAL", "PLUS", "MINUS", "STAR", "SLASH", "PERCENT", "DOUBLESLASH", "DOUBLESTAR", "INT", "STRING", "DOT", "PLUSEQUAL", "MINUSEQUAL", "STAREQUAL", "SLASHEQUAL", "VBAREQUAL", "DOUBLESTAREQUAL", "DOUBLESLASHEQUAL", "DIGITS", "ESC", "NEWLINE", "WS", "COMMENT", "'match'", "'with'", "'->'", "'for'", "'in'", "'do'", "'if'", "'then'", "'else'", "'while'", "'to'", "'let'", "'end'", "'type'", "'array'", "'of'", "'var'", "'function'", "'not'", "'true'", "'false'", "'break'", "'continue'", "'nil'", "'return'"
	};
	public const int EOF=-1;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int VBAR=4;
	public const int LBRACK=5;
	public const int RBRACK=6;
	public const int LCURLY=7;
	public const int SEMI=8;
	public const int RCURLY=9;
	public const int COMMA=10;
	public const int ASSIGN=11;
	public const int EQUAL=12;
	public const int COLON=13;
	public const int LPAREN=14;
	public const int RPAREN=15;
	public const int NAME=16;
	public const int AMPER=17;
	public const int LESS=18;
	public const int GREATER=19;
	public const int GREATEREQUAL=20;
	public const int LESSEQUAL=21;
	public const int NOTEQUAL=22;
	public const int PLUS=23;
	public const int MINUS=24;
	public const int STAR=25;
	public const int SLASH=26;
	public const int PERCENT=27;
	public const int DOUBLESLASH=28;
	public const int DOUBLESTAR=29;
	public const int INT=30;
	public const int STRING=31;
	public const int DOT=32;
	public const int PLUSEQUAL=33;
	public const int MINUSEQUAL=34;
	public const int STAREQUAL=35;
	public const int SLASHEQUAL=36;
	public const int VBAREQUAL=37;
	public const int DOUBLESTAREQUAL=38;
	public const int DOUBLESLASHEQUAL=39;
	public const int DIGITS=40;
	public const int ESC=41;
	public const int NEWLINE=42;
	public const int WS=43;
	public const int COMMENT=44;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, true, false, false, false, false, false, false, true, false, 
				false, false, false, false, false, false, false, false, true, true, 
				false, true, false, false, true, true, false, false, false, true, false, 
				false, true, true, false, true, true, false, false, false, false, false, 
				false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public TigerParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public TigerParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
		

	public override string[] TokenNames { get { return TigerParser.tokenNames; } }
	public override string GrammarFileName { get { return "E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:27:1: program returns [ProgramExpression expression] : e= test ;
	[GrammarRule("program")]
	private ProgramExpression program()
	{
		Enter_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		ProgramExpression expression = default(ProgramExpression);

		Expression e = default(Expression);

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(27, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:28:2: (e= test )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:28:4: e= test
			{
			DebugLocation(28, 5);
			PushFollow(Follow._test_in_program64);
			e=test();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(28, 11);
			if ( state.backtracking == 0 )
			{
				expression=new ProgramExpression{Program=e, Start=e.Start};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			Leave_program();
		}
		DebugLocation(29, 1);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return expression;

	}
	// $ANTLR end "program"


	partial void Enter_parse();
	partial void Leave_parse();

	// $ANTLR start "parse"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:31:8: public parse returns [ProgramExpression expression] : e= program EOF ;
	[GrammarRule("parse")]
	public ProgramExpression parse()
	{
		Enter_parse();
		EnterRule("parse", 2);
		TraceIn("parse", 2);
		ProgramExpression expression = default(ProgramExpression);

		ProgramExpression e = default(ProgramExpression);

		try { DebugEnterRule(GrammarFileName, "parse");
		DebugLocation(31, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:33:2: (e= program EOF )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:33:4: e= program EOF
			{
			DebugLocation(33, 5);
			PushFollow(Follow._program_in_parse90);
			e=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(33, 14);
			Match(input,EOF,Follow._EOF_in_parse92); if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression=e;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("parse", 2);
			LeaveRule("parse", 2);
			Leave_parse();
		}
		DebugLocation(34, 1);
		} finally { DebugExitRule(GrammarFileName, "parse"); }
		return expression;

	}
	// $ANTLR end "parse"


	partial void Enter_expr_stmt();
	partial void Leave_expr_stmt();

	// $ANTLR start "expr_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:36:1: expr_stmt returns [Expression expression] : (i= if_stmt | w= while_stmt | f= for_stmt | list= curly_list_stmt | let= let_stmt | fi= for_in_stmt | arr= array_init | match= match_stmt );
	[GrammarRule("expr_stmt")]
	private Expression expr_stmt()
	{
		Enter_expr_stmt();
		EnterRule("expr_stmt", 3);
		TraceIn("expr_stmt", 3);
		Expression expression = default(Expression);

		IfThenExpression i = default(IfThenExpression);
		WhileExpression w = default(WhileExpression);
		ForLoopExpression f = default(ForLoopExpression);
		ListSemiExpression list = default(ListSemiExpression);
		LetInExpression let = default(LetInExpression);
		ForInExpression fi = default(ForInExpression);
		ArrayInitExpression arr = default(ArrayInitExpression);
		MatchExpression match = default(MatchExpression);

		try { DebugEnterRule(GrammarFileName, "expr_stmt");
		DebugLocation(36, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:37:2: (i= if_stmt | w= while_stmt | f= for_stmt | list= curly_list_stmt | let= let_stmt | fi= for_in_stmt | arr= array_init | match= match_stmt )
			int alt1=8;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			try
			{
				alt1 = dfa1.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:37:4: i= if_stmt
				{
				DebugLocation(37, 5);
				PushFollow(Follow._if_stmt_in_expr_stmt109);
				i=if_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(37, 14);
				if ( state.backtracking == 0 )
				{
					expression=i;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:38:5: w= while_stmt
				{
				DebugLocation(38, 6);
				PushFollow(Follow._while_stmt_in_expr_stmt119);
				w=while_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(38, 18);
				if ( state.backtracking == 0 )
				{
					expression=w;
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:39:5: f= for_stmt
				{
				DebugLocation(39, 6);
				PushFollow(Follow._for_stmt_in_expr_stmt129);
				f=for_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(39, 16);
				if ( state.backtracking == 0 )
				{
					expression=f;
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:40:4: list= curly_list_stmt
				{
				DebugLocation(40, 8);
				PushFollow(Follow._curly_list_stmt_in_expr_stmt138);
				list=curly_list_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(40, 25);
				if ( state.backtracking == 0 )
				{
					expression=list;
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:41:4: let= let_stmt
				{
				DebugLocation(41, 7);
				PushFollow(Follow._let_stmt_in_expr_stmt147);
				let=let_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(41, 17);
				if ( state.backtracking == 0 )
				{
					expression=let;
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:42:4: fi= for_in_stmt
				{
				DebugLocation(42, 6);
				PushFollow(Follow._for_in_stmt_in_expr_stmt156);
				fi=for_in_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(42, 19);
				if ( state.backtracking == 0 )
				{
					expression=fi;
				}

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:43:4: arr= array_init
				{
				DebugLocation(43, 7);
				PushFollow(Follow._array_init_in_expr_stmt165);
				arr=array_init();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(43, 19);
				if ( state.backtracking == 0 )
				{
					expression=arr;
				}

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:44:4: match= match_stmt
				{
				DebugLocation(44, 9);
				PushFollow(Follow._match_stmt_in_expr_stmt174);
				match=match_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(44, 21);
				if ( state.backtracking == 0 )
				{
					expression=match;
				}

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
			TraceOut("expr_stmt", 3);
			LeaveRule("expr_stmt", 3);
			Leave_expr_stmt();
		}
		DebugLocation(45, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_stmt"); }
		return expression;

	}
	// $ANTLR end "expr_stmt"


	partial void Enter_match_stmt();
	partial void Leave_match_stmt();

	// $ANTLR start "match_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:47:1: match_stmt returns [MatchExpression expression] : t= 'match' tx= program_list_comma 'with' ( ( VBAR )=>g= guard )+ ;
	[GrammarRule("match_stmt")]
	private MatchExpression match_stmt()
	{
		Enter_match_stmt();
		EnterRule("match_stmt", 4);
		TraceIn("match_stmt", 4);
		MatchExpression expression = default(MatchExpression);

		IToken t=null;
		IEnumerable<Expression> tx = default(IEnumerable<Expression>);
		GuardNode g = default(GuardNode);

		expression=new MatchExpression();
		try { DebugEnterRule(GrammarFileName, "match_stmt");
		DebugLocation(47, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:50:2: (t= 'match' tx= program_list_comma 'with' ( ( VBAR )=>g= guard )+ )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:50:4: t= 'match' tx= program_list_comma 'with' ( ( VBAR )=>g= guard )+
			{
			DebugLocation(50, 5);
			t=(IToken)Match(input,45,Follow._45_in_match_stmt201); if (state.failed) return expression;
			DebugLocation(50, 16);
			PushFollow(Follow._program_list_comma_in_match_stmt205);
			tx=program_list_comma();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(50, 36);
			Match(input,46,Follow._46_in_match_stmt207); if (state.failed) return expression;
			DebugLocation(50, 43);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:50:43: ( ( VBAR )=>g= guard )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==VBAR))
				{
					int LA2_2 = input.LA(2);

					if ((EvaluatePredicate(synpred1_Tiger_fragment)))
					{
						alt2=1;
					}


				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:50:44: ( VBAR )=>g= guard
					{
					DebugLocation(50, 55);
					PushFollow(Follow._guard_in_match_stmt218);
					g=guard();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(50, 62);
					if ( state.backtracking == 0 )
					{
						expression.Add(g);
					}

					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					if (state.backtracking>0) {state.failed=true; return expression;}
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

			if ( state.backtracking == 0 )
			{
				expression.Start=Loc(t); expression.Match=tx;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("match_stmt", 4);
			LeaveRule("match_stmt", 4);
			Leave_match_stmt();
		}
		DebugLocation(51, 1);
		} finally { DebugExitRule(GrammarFileName, "match_stmt"); }
		return expression;

	}
	// $ANTLR end "match_stmt"


	partial void Enter_guard();
	partial void Leave_guard();

	// $ANTLR start "guard"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:53:1: guard returns [GuardNode node] : t= VBAR tx= program_list_comma '->' res= program ;
	[GrammarRule("guard")]
	private GuardNode guard()
	{
		Enter_guard();
		EnterRule("guard", 5);
		TraceIn("guard", 5);
		GuardNode node = default(GuardNode);

		IToken t=null;
		IEnumerable<Expression> tx = default(IEnumerable<Expression>);
		ProgramExpression res = default(ProgramExpression);

		node=new GuardNode();
		try { DebugEnterRule(GrammarFileName, "guard");
		DebugLocation(53, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:56:2: (t= VBAR tx= program_list_comma '->' res= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:56:4: t= VBAR tx= program_list_comma '->' res= program
			{
			DebugLocation(56, 5);
			t=(IToken)Match(input,VBAR,Follow._VBAR_in_guard247); if (state.failed) return node;
			DebugLocation(56, 13);
			PushFollow(Follow._program_list_comma_in_guard251);
			tx=program_list_comma();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(56, 33);
			Match(input,47,Follow._47_in_guard253); if (state.failed) return node;
			DebugLocation(56, 41);
			PushFollow(Follow._program_in_guard257);
			res=program();
			PopFollow();
			if (state.failed) return node;

			}

			if ( state.backtracking == 0 )
			{
				node.Start=Loc(t); node.Test=tx; node.Result=res;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("guard", 5);
			LeaveRule("guard", 5);
			Leave_guard();
		}
		DebugLocation(57, 1);
		} finally { DebugExitRule(GrammarFileName, "guard"); }
		return node;

	}
	// $ANTLR end "guard"


	partial void Enter_for_in_stmt();
	partial void Leave_for_in_stmt();

	// $ANTLR start "for_in_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:59:1: for_in_stmt returns [ForInExpression expression] : t= 'for' i= identifier 'in' c= program 'do' b= program ;
	[GrammarRule("for_in_stmt")]
	private ForInExpression for_in_stmt()
	{
		Enter_for_in_stmt();
		EnterRule("for_in_stmt", 6);
		TraceIn("for_in_stmt", 6);
		ForInExpression expression = default(ForInExpression);

		IToken t=null;
		IdentifierNode i = default(IdentifierNode);
		ProgramExpression c = default(ProgramExpression);
		ProgramExpression b = default(ProgramExpression);

		try { DebugEnterRule(GrammarFileName, "for_in_stmt");
		DebugLocation(59, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:61:2: (t= 'for' i= identifier 'in' c= program 'do' b= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:61:4: t= 'for' i= identifier 'in' c= program 'do' b= program
			{
			DebugLocation(61, 5);
			t=(IToken)Match(input,48,Follow._48_in_for_in_stmt278); if (state.failed) return expression;
			DebugLocation(61, 13);
			PushFollow(Follow._identifier_in_for_in_stmt282);
			i=identifier();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(61, 25);
			Match(input,49,Follow._49_in_for_in_stmt284); if (state.failed) return expression;
			DebugLocation(61, 31);
			PushFollow(Follow._program_in_for_in_stmt288);
			c=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(61, 40);
			Match(input,50,Follow._50_in_for_in_stmt290); if (state.failed) return expression;
			DebugLocation(61, 46);
			PushFollow(Follow._program_in_for_in_stmt294);
			b=program();
			PopFollow();
			if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression=new ForInExpression{Identifier=i, Collection=c, Body=b};
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("for_in_stmt", 6);
			LeaveRule("for_in_stmt", 6);
			Leave_for_in_stmt();
		}
		DebugLocation(62, 1);
		} finally { DebugExitRule(GrammarFileName, "for_in_stmt"); }
		return expression;

	}
	// $ANTLR end "for_in_stmt"


	partial void Enter_array_init();
	partial void Leave_array_init();

	// $ANTLR start "array_init"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:64:1: array_init returns [ArrayInitExpression expression] : t= LBRACK init= program_list_comma RBRACK ;
	[GrammarRule("array_init")]
	private ArrayInitExpression array_init()
	{
		Enter_array_init();
		EnterRule("array_init", 7);
		TraceIn("array_init", 7);
		ArrayInitExpression expression = default(ArrayInitExpression);

		IToken t=null;
		IEnumerable<Expression> init = default(IEnumerable<Expression>);

		try { DebugEnterRule(GrammarFileName, "array_init");
		DebugLocation(64, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:66:2: (t= LBRACK init= program_list_comma RBRACK )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:66:4: t= LBRACK init= program_list_comma RBRACK
			{
			DebugLocation(66, 5);
			t=(IToken)Match(input,LBRACK,Follow._LBRACK_in_array_init315); if (state.failed) return expression;
			DebugLocation(66, 17);
			PushFollow(Follow._program_list_comma_in_array_init319);
			init=program_list_comma();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(66, 37);
			Match(input,RBRACK,Follow._RBRACK_in_array_init321); if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression=new ArrayInitExpression{Initializers=init,Start=Loc(t)};
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("array_init", 7);
			LeaveRule("array_init", 7);
			Leave_array_init();
		}
		DebugLocation(67, 1);
		} finally { DebugExitRule(GrammarFileName, "array_init"); }
		return expression;

	}
	// $ANTLR end "array_init"


	partial void Enter_curly_list_stmt();
	partial void Leave_curly_list_stmt();

	// $ANTLR start "curly_list_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:69:1: curly_list_stmt returns [ListSemiExpression expression] : t= LCURLY (p= program ( SEMI p= program )* )? ( SEMI )? RCURLY ;
	[GrammarRule("curly_list_stmt")]
	private ListSemiExpression curly_list_stmt()
	{
		Enter_curly_list_stmt();
		EnterRule("curly_list_stmt", 8);
		TraceIn("curly_list_stmt", 8);
		ListSemiExpression expression = default(ListSemiExpression);

		IToken t=null;
		ProgramExpression p = default(ProgramExpression);

		expression=new ListSemiExpression();
		try { DebugEnterRule(GrammarFileName, "curly_list_stmt");
		DebugLocation(69, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:2: (t= LCURLY (p= program ( SEMI p= program )* )? ( SEMI )? RCURLY )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:4: t= LCURLY (p= program ( SEMI p= program )* )? ( SEMI )? RCURLY
			{
			DebugLocation(73, 5);
			t=(IToken)Match(input,LCURLY,Follow._LCURLY_in_curly_list_stmt348); if (state.failed) return expression;
			DebugLocation(73, 13);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:13: (p= program ( SEMI p= program )* )?
			int alt4=2;
			try { DebugEnterSubRule(4);
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==LBRACK||LA4_0==LCURLY||LA4_0==LPAREN||LA4_0==NAME||(LA4_0>=PLUS && LA4_0<=MINUS)||(LA4_0>=INT && LA4_0<=STRING)||LA4_0==45||LA4_0==48||LA4_0==51||LA4_0==54||LA4_0==56||(LA4_0>=63 && LA4_0<=69)))
			{
				alt4=1;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:14: p= program ( SEMI p= program )*
				{
				DebugLocation(73, 15);
				PushFollow(Follow._program_in_curly_list_stmt353);
				p=program();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(73, 24);
				if ( state.backtracking == 0 )
				{
					 expression.Add(p); 
				}
				DebugLocation(73, 47);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:47: ( SEMI p= program )*
				try { DebugEnterSubRule(3);
				while (true)
				{
					int alt3=2;
					try { DebugEnterDecision(3, decisionCanBacktrack[3]);
					int LA3_0 = input.LA(1);

					if ((LA3_0==SEMI))
					{
						int LA3_1 = input.LA(2);

						if ((LA3_1==LBRACK||LA3_1==LCURLY||LA3_1==LPAREN||LA3_1==NAME||(LA3_1>=PLUS && LA3_1<=MINUS)||(LA3_1>=INT && LA3_1<=STRING)||LA3_1==45||LA3_1==48||LA3_1==51||LA3_1==54||LA3_1==56||(LA3_1>=63 && LA3_1<=69)))
						{
							alt3=1;
						}


					}


					} finally { DebugExitDecision(3); }
					switch ( alt3 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:48: SEMI p= program
						{
						DebugLocation(73, 48);
						Match(input,SEMI,Follow._SEMI_in_curly_list_stmt358); if (state.failed) return expression;
						DebugLocation(73, 54);
						PushFollow(Follow._program_in_curly_list_stmt362);
						p=program();
						PopFollow();
						if (state.failed) return expression;
						DebugLocation(73, 63);
						if ( state.backtracking == 0 )
						{
							expression.Add(p);
						}

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
				break;

			}
			} finally { DebugExitSubRule(4); }

			DebugLocation(73, 88);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:88: ( SEMI )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==SEMI))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:73:88: SEMI
				{
				DebugLocation(73, 88);
				Match(input,SEMI,Follow._SEMI_in_curly_list_stmt370); if (state.failed) return expression;

				}
				break;

			}
			} finally { DebugExitSubRule(5); }

			DebugLocation(73, 94);
			Match(input,RCURLY,Follow._RCURLY_in_curly_list_stmt373); if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression.Start=Loc(t); 
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("curly_list_stmt", 8);
			LeaveRule("curly_list_stmt", 8);
			Leave_curly_list_stmt();
		}
		DebugLocation(74, 1);
		} finally { DebugExitRule(GrammarFileName, "curly_list_stmt"); }
		return expression;

	}
	// $ANTLR end "curly_list_stmt"


	partial void Enter_root_list_semi();
	partial void Leave_root_list_semi();

	// $ANTLR start "root_list_semi"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:76:1: root_list_semi returns [ListSemiExpression expression] : (p= program ( SEMI p= program )* | );
	[GrammarRule("root_list_semi")]
	private ListSemiExpression root_list_semi()
	{
		Enter_root_list_semi();
		EnterRule("root_list_semi", 9);
		TraceIn("root_list_semi", 9);
		ListSemiExpression expression = default(ListSemiExpression);

		ProgramExpression p = default(ProgramExpression);

		var res=new ListSemiExpression();
		try { DebugEnterRule(GrammarFileName, "root_list_semi");
		DebugLocation(76, 5);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:79:2: (p= program ( SEMI p= program )* | )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==LBRACK||LA7_0==LCURLY||LA7_0==LPAREN||LA7_0==NAME||(LA7_0>=PLUS && LA7_0<=MINUS)||(LA7_0>=INT && LA7_0<=STRING)||LA7_0==45||LA7_0==48||LA7_0==51||LA7_0==54||LA7_0==56||(LA7_0>=63 && LA7_0<=69)))
			{
				alt7=1;
			}
			else if ((LA7_0==SEMI||LA7_0==57))
			{
				alt7=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return expression;}
				NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:79:5: p= program ( SEMI p= program )*
				{
				DebugLocation(79, 6);
				PushFollow(Follow._program_in_root_list_semi401);
				p=program();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(79, 15);
				if ( state.backtracking == 0 )
				{
					 res.Add(p); 
				}
				DebugLocation(79, 31);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:79:31: ( SEMI p= program )*
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if ((LA6_0==SEMI))
					{
						int LA6_1 = input.LA(2);

						if ((LA6_1==LBRACK||LA6_1==LCURLY||LA6_1==LPAREN||LA6_1==NAME||(LA6_1>=PLUS && LA6_1<=MINUS)||(LA6_1>=INT && LA6_1<=STRING)||LA6_1==45||LA6_1==48||LA6_1==51||LA6_1==54||LA6_1==56||(LA6_1>=63 && LA6_1<=69)))
						{
							alt6=1;
						}


					}


					} finally { DebugExitDecision(6); }
					switch ( alt6 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:79:32: SEMI p= program
						{
						DebugLocation(79, 32);
						Match(input,SEMI,Follow._SEMI_in_root_list_semi406); if (state.failed) return expression;
						DebugLocation(79, 38);
						PushFollow(Follow._program_in_root_list_semi410);
						p=program();
						PopFollow();
						if (state.failed) return expression;
						DebugLocation(79, 47);
						if ( state.backtracking == 0 )
						{
							res.Add(p);
						}

						}
						break;

					default:
						goto loop6;
					}
				}

				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:81:6: 
				{
				}
				break;

			}
			if ( state.backtracking == 0 )
			{
				expression=res;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("root_list_semi", 9);
			LeaveRule("root_list_semi", 9);
			Leave_root_list_semi();
		}
		DebugLocation(81, 5);
		} finally { DebugExitRule(GrammarFileName, "root_list_semi"); }
		return expression;

	}
	// $ANTLR end "root_list_semi"


	partial void Enter_program_list_comma();
	partial void Leave_program_list_comma();

	// $ANTLR start "program_list_comma"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:83:1: program_list_comma returns [IEnumerable<Expression> expression] : p= program ( COMMA p= program )* ;
	[GrammarRule("program_list_comma")]
	private IEnumerable<Expression> program_list_comma()
	{
		Enter_program_list_comma();
		EnterRule("program_list_comma", 10);
		TraceIn("program_list_comma", 10);
		IEnumerable<Expression> expression = default(IEnumerable<Expression>);

		ProgramExpression p = default(ProgramExpression);

		var result=new List<Expression>();
		try { DebugEnterRule(GrammarFileName, "program_list_comma");
		DebugLocation(83, 5);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:86:2: (p= program ( COMMA p= program )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:86:5: p= program ( COMMA p= program )*
			{
			DebugLocation(86, 6);
			PushFollow(Follow._program_in_program_list_comma450);
			p=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(86, 15);
			if ( state.backtracking == 0 )
			{
				result.Add(p);
			}
			DebugLocation(86, 32);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:86:32: ( COMMA p= program )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==COMMA))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:86:33: COMMA p= program
					{
					DebugLocation(86, 33);
					Match(input,COMMA,Follow._COMMA_in_program_list_comma455); if (state.failed) return expression;
					DebugLocation(86, 40);
					PushFollow(Follow._program_in_program_list_comma459);
					p=program();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(86, 49);
					if ( state.backtracking == 0 )
					{
						result.Add(p);
					}

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			if ( state.backtracking == 0 )
			{
				expression=result;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("program_list_comma", 10);
			LeaveRule("program_list_comma", 10);
			Leave_program_list_comma();
		}
		DebugLocation(87, 5);
		} finally { DebugExitRule(GrammarFileName, "program_list_comma"); }
		return expression;

	}
	// $ANTLR end "program_list_comma"


	partial void Enter_if_stmt();
	partial void Leave_if_stmt();

	// $ANTLR start "if_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:89:1: if_stmt returns [IfThenExpression expression] : t= 'if' c1= test 'then' c2= program ( ( 'else' )=> 'else' c3= program | ) ;
	[GrammarRule("if_stmt")]
	private IfThenExpression if_stmt()
	{
		Enter_if_stmt();
		EnterRule("if_stmt", 11);
		TraceIn("if_stmt", 11);
		IfThenExpression expression = default(IfThenExpression);

		IToken t=null;
		Expression c1 = default(Expression);
		ProgramExpression c2 = default(ProgramExpression);
		ProgramExpression c3 = default(ProgramExpression);

		try { DebugEnterRule(GrammarFileName, "if_stmt");
		DebugLocation(89, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:90:2: (t= 'if' c1= test 'then' c2= program ( ( 'else' )=> 'else' c3= program | ) )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:90:5: t= 'if' c1= test 'then' c2= program ( ( 'else' )=> 'else' c3= program | )
			{
			DebugLocation(90, 6);
			t=(IToken)Match(input,51,Follow._51_in_if_stmt485); if (state.failed) return expression;
			DebugLocation(90, 14);
			PushFollow(Follow._test_in_if_stmt489);
			c1=test();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(90, 20);
			Match(input,52,Follow._52_in_if_stmt491); if (state.failed) return expression;
			DebugLocation(90, 29);
			PushFollow(Follow._program_in_if_stmt495);
			c2=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(91, 3);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:91:3: ( ( 'else' )=> 'else' c3= program | )
			int alt9=2;
			try { DebugEnterSubRule(9);
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==53))
			{
				int LA9_1 = input.LA(2);

				if ((EvaluatePredicate(synpred2_Tiger_fragment)))
				{
					alt9=1;
				}
				else if ((true))
				{
					alt9=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return expression;}
					NoViableAltException nvae = new NoViableAltException("", 9, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA9_0==EOF||(LA9_0>=VBAR && LA9_0<=RBRACK)||(LA9_0>=SEMI && LA9_0<=COMMA)||LA9_0==EQUAL||LA9_0==RPAREN||(LA9_0>=AMPER && LA9_0<=DOUBLESTAR)||LA9_0==DOT||(LA9_0>=46 && LA9_0<=47)||(LA9_0>=49 && LA9_0<=50)||LA9_0==52||LA9_0==55||(LA9_0>=57 && LA9_0<=58)||(LA9_0>=61 && LA9_0<=62)))
			{
				alt9=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return expression;}
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:92:4: ( 'else' )=> 'else' c3= program
				{
				DebugLocation(92, 14);
				Match(input,53,Follow._53_in_if_stmt508); if (state.failed) return expression;
				DebugLocation(92, 23);
				PushFollow(Follow._program_in_if_stmt512);
				c3=program();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(92, 32);
				if ( state.backtracking == 0 )
				{
					expression=new IfThenElseExpression{Test = new ToBooleanExpression( c1 ),Then=c2, Else=c3, Start=Loc(t)};
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:93:6: 
				{
				DebugLocation(93, 6);
				if ( state.backtracking == 0 )
				{
					expression=new IfThenExpression{Test = new ToBooleanExpression( c1 ),Then=c2, Start=Loc(t)};
				}

				}
				break;

			}
			} finally { DebugExitSubRule(9); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("if_stmt", 11);
			LeaveRule("if_stmt", 11);
			Leave_if_stmt();
		}
		DebugLocation(95, 1);
		} finally { DebugExitRule(GrammarFileName, "if_stmt"); }
		return expression;

	}
	// $ANTLR end "if_stmt"


	partial void Enter_while_stmt();
	partial void Leave_while_stmt();

	// $ANTLR start "while_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:97:1: while_stmt returns [WhileExpression expression] : t= 'while' assert= test 'do' body= program ;
	[GrammarRule("while_stmt")]
	private WhileExpression while_stmt()
	{
		Enter_while_stmt();
		EnterRule("while_stmt", 12);
		TraceIn("while_stmt", 12);
		WhileExpression expression = default(WhileExpression);

		IToken t=null;
		Expression assert = default(Expression);
		ProgramExpression body = default(ProgramExpression);

		var res=new WhileExpression();
		try { DebugEnterRule(GrammarFileName, "while_stmt");
		DebugLocation(97, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:100:2: (t= 'while' assert= test 'do' body= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:100:5: t= 'while' assert= test 'do' body= program
			{
			DebugLocation(100, 6);
			t=(IToken)Match(input,54,Follow._54_in_while_stmt553); if (state.failed) return expression;
			DebugLocation(100, 21);
			PushFollow(Follow._test_in_while_stmt557);
			assert=test();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(100, 27);
			Match(input,50,Follow._50_in_while_stmt559); if (state.failed) return expression;
			DebugLocation(100, 36);
			PushFollow(Follow._program_in_while_stmt563);
			body=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(100, 45);
			if ( state.backtracking == 0 )
			{
				res.Test= new ToBooleanExpression( assert ); res.Body=body;
			}

			}

			if ( state.backtracking == 0 )
			{
				expression=res; expression.Start=Loc(t);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("while_stmt", 12);
			LeaveRule("while_stmt", 12);
			Leave_while_stmt();
		}
		DebugLocation(101, 1);
		} finally { DebugExitRule(GrammarFileName, "while_stmt"); }
		return expression;

	}
	// $ANTLR end "while_stmt"


	partial void Enter_for_stmt();
	partial void Leave_for_stmt();

	// $ANTLR start "for_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:103:1: for_stmt returns [ForLoopExpression expression] : t= 'for' name= identifier ASSIGN low= program 'to' up= program 'do' body= program ;
	[GrammarRule("for_stmt")]
	private ForLoopExpression for_stmt()
	{
		Enter_for_stmt();
		EnterRule("for_stmt", 13);
		TraceIn("for_stmt", 13);
		ForLoopExpression expression = default(ForLoopExpression);

		IToken t=null;
		IdentifierNode name = default(IdentifierNode);
		ProgramExpression low = default(ProgramExpression);
		ProgramExpression up = default(ProgramExpression);
		ProgramExpression body = default(ProgramExpression);

		expression=new ForLoopExpression();
		try { DebugEnterRule(GrammarFileName, "for_stmt");
		DebugLocation(103, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:106:2: (t= 'for' name= identifier ASSIGN low= program 'to' up= program 'do' body= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:106:5: t= 'for' name= identifier ASSIGN low= program 'to' up= program 'do' body= program
			{
			DebugLocation(106, 6);
			t=(IToken)Match(input,48,Follow._48_in_for_stmt593); if (state.failed) return expression;
			DebugLocation(106, 17);
			PushFollow(Follow._identifier_in_for_stmt597);
			name=identifier();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(106, 29);
			Match(input,ASSIGN,Follow._ASSIGN_in_for_stmt599); if (state.failed) return expression;
			DebugLocation(106, 39);
			PushFollow(Follow._program_in_for_stmt603);
			low=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(106, 48);
			Match(input,55,Follow._55_in_for_stmt605); if (state.failed) return expression;
			DebugLocation(106, 55);
			PushFollow(Follow._program_in_for_stmt609);
			up=program();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(106, 64);
			Match(input,50,Follow._50_in_for_stmt611); if (state.failed) return expression;
			DebugLocation(106, 73);
			PushFollow(Follow._program_in_for_stmt615);
			body=program();
			PopFollow();
			if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression.VariableName=name; expression.From=low; expression.To=up; expression.Body=body; expression.Start=Loc(t);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("for_stmt", 13);
			LeaveRule("for_stmt", 13);
			Leave_for_stmt();
		}
		DebugLocation(107, 1);
		} finally { DebugExitRule(GrammarFileName, "for_stmt"); }
		return expression;

	}
	// $ANTLR end "for_stmt"


	partial void Enter_let_stmt();
	partial void Leave_let_stmt();

	// $ANTLR start "let_stmt"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:111:1: let_stmt returns [LetInExpression expression] : tt= 'let' (t= type_declaration | e= variable_declaration | f= func_definition )* 'in' l= root_list_semi ( SEMI )? 'end' ;
	[GrammarRule("let_stmt")]
	private LetInExpression let_stmt()
	{
		Enter_let_stmt();
		EnterRule("let_stmt", 14);
		TraceIn("let_stmt", 14);
		LetInExpression expression = default(LetInExpression);

		IToken tt=null;
		TypeDeclarationNode t = default(TypeDeclarationNode);
		VariableDeclarationExpression e = default(VariableDeclarationExpression);
		FunctionDefinitionExpression f = default(FunctionDefinitionExpression);
		ListSemiExpression l = default(ListSemiExpression);

		var res=new LetInExpression();
		try { DebugEnterRule(GrammarFileName, "let_stmt");
		DebugLocation(111, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:114:2: (tt= 'let' (t= type_declaration | e= variable_declaration | f= func_definition )* 'in' l= root_list_semi ( SEMI )? 'end' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:114:4: tt= 'let' (t= type_declaration | e= variable_declaration | f= func_definition )* 'in' l= root_list_semi ( SEMI )? 'end'
			{
			DebugLocation(114, 6);
			tt=(IToken)Match(input,56,Follow._56_in_let_stmt644); if (state.failed) return expression;
			DebugLocation(115, 2);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:115:2: (t= type_declaration | e= variable_declaration | f= func_definition )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=4;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				switch (input.LA(1))
				{
				case 58:
					{
					alt10=1;
					}
					break;
				case 61:
					{
					alt10=2;
					}
					break;
				case 62:
					{
					alt10=3;
					}
					break;

				}

				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:115:4: t= type_declaration
					{
					DebugLocation(115, 5);
					PushFollow(Follow._type_declaration_in_let_stmt651);
					t=type_declaration();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(115, 23);
					if ( state.backtracking == 0 )
					{
						res.AddType(t);
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:116:4: e= variable_declaration
					{
					DebugLocation(116, 5);
					PushFollow(Follow._variable_declaration_in_let_stmt660);
					e=variable_declaration();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(116, 27);
					if ( state.backtracking == 0 )
					{
						res.AddVar(e);
					}

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:117:4: f= func_definition
					{
					DebugLocation(117, 5);
					PushFollow(Follow._func_definition_in_let_stmt669);
					f=func_definition();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(117, 22);
					if ( state.backtracking == 0 )
					{
						 res.AddFunc(f); 
					}

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }

			DebugLocation(118, 5);
			Match(input,49,Follow._49_in_let_stmt677); if (state.failed) return expression;
			DebugLocation(118, 11);
			PushFollow(Follow._root_list_semi_in_let_stmt681);
			l=root_list_semi();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(118, 27);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:118:27: ( SEMI )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==SEMI))
			{
				alt11=1;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:118:27: SEMI
				{
				DebugLocation(118, 27);
				Match(input,SEMI,Follow._SEMI_in_let_stmt683); if (state.failed) return expression;

				}
				break;

			}
			} finally { DebugExitSubRule(11); }

			DebugLocation(118, 33);
			Match(input,57,Follow._57_in_let_stmt686); if (state.failed) return expression;
			DebugLocation(118, 39);
			if ( state.backtracking == 0 )
			{
				res.Body=l;
			}

			}

			if ( state.backtracking == 0 )
			{
				res.Start=Loc(tt); expression=res; 
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("let_stmt", 14);
			LeaveRule("let_stmt", 14);
			Leave_let_stmt();
		}
		DebugLocation(119, 1);
		} finally { DebugExitRule(GrammarFileName, "let_stmt"); }
		return expression;

	}
	// $ANTLR end "let_stmt"


	partial void Enter_type_declaration();
	partial void Leave_type_declaration();

	// $ANTLR start "type_declaration"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:121:1: type_declaration returns [TypeDeclarationNode node] : t= 'type' typeName= type_identifier EQUAL ( LCURLY fields= fieldList RCURLY | 'array' 'of' extra= type_reference | extra= type_reference ) ;
	[GrammarRule("type_declaration")]
	private TypeDeclarationNode type_declaration()
	{
		Enter_type_declaration();
		EnterRule("type_declaration", 15);
		TraceIn("type_declaration", 15);
		TypeDeclarationNode node = default(TypeDeclarationNode);

		IToken t=null;
		TypeIdentifierNode typeName = default(TypeIdentifierNode);
		IEnumerable<RecordFieldNode> fields = default(IEnumerable<RecordFieldNode>);
		TypeReferenceNode extra = default(TypeReferenceNode);

		try { DebugEnterRule(GrammarFileName, "type_declaration");
		DebugLocation(121, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:122:2: (t= 'type' typeName= type_identifier EQUAL ( LCURLY fields= fieldList RCURLY | 'array' 'of' extra= type_reference | extra= type_reference ) )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:122:4: t= 'type' typeName= type_identifier EQUAL ( LCURLY fields= fieldList RCURLY | 'array' 'of' extra= type_reference | extra= type_reference )
			{
			DebugLocation(122, 5);
			t=(IToken)Match(input,58,Follow._58_in_type_declaration705); if (state.failed) return node;
			DebugLocation(122, 21);
			PushFollow(Follow._type_identifier_in_type_declaration709);
			typeName=type_identifier();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(122, 38);
			Match(input,EQUAL,Follow._EQUAL_in_type_declaration711); if (state.failed) return node;
			DebugLocation(123, 4);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:123:4: ( LCURLY fields= fieldList RCURLY | 'array' 'of' extra= type_reference | extra= type_reference )
			int alt12=3;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case LCURLY:
				{
				alt12=1;
				}
				break;
			case 59:
				{
				alt12=2;
				}
				break;
			case NAME:
				{
				alt12=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:123:6: LCURLY fields= fieldList RCURLY
				{
				DebugLocation(123, 6);
				Match(input,LCURLY,Follow._LCURLY_in_type_declaration718); if (state.failed) return node;
				DebugLocation(123, 19);
				PushFollow(Follow._fieldList_in_type_declaration722);
				fields=fieldList();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(123, 30);
				Match(input,RCURLY,Follow._RCURLY_in_type_declaration724); if (state.failed) return node;
				DebugLocation(123, 37);
				if ( state.backtracking == 0 )
				{
					node=new RecordDeclarationNode{Name=typeName, Fields=fields, Start=Loc(t)};
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:124:6: 'array' 'of' extra= type_reference
				{
				DebugLocation(124, 6);
				Match(input,59,Follow._59_in_type_declaration733); if (state.failed) return node;
				DebugLocation(124, 14);
				Match(input,60,Follow._60_in_type_declaration735); if (state.failed) return node;
				DebugLocation(124, 24);
				PushFollow(Follow._type_reference_in_type_declaration739);
				extra=type_reference();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(124, 40);
				if ( state.backtracking == 0 )
				{
					node=new ArrayTypeDeclarationNode{Name=typeName, ExistingType=extra, Start=Loc(t)};
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:125:6: extra= type_reference
				{
				DebugLocation(125, 11);
				PushFollow(Follow._type_reference_in_type_declaration750);
				extra=type_reference();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(125, 27);
				if ( state.backtracking == 0 )
				{
					node=new AliasTypeDeclarationNode{Name=typeName, ExistingType=extra, Start=Loc(t)};
				}

				}
				break;

			}
			} finally { DebugExitSubRule(12); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("type_declaration", 15);
			LeaveRule("type_declaration", 15);
			Leave_type_declaration();
		}
		DebugLocation(127, 1);
		} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
		return node;

	}
	// $ANTLR end "type_declaration"


	partial void Enter_field();
	partial void Leave_field();

	// $ANTLR start "field"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:129:1: field returns [RecordFieldNode node] : name= identifier COLON type= type_reference ;
	[GrammarRule("field")]
	private RecordFieldNode field()
	{
		Enter_field();
		EnterRule("field", 16);
		TraceIn("field", 16);
		RecordFieldNode node = default(RecordFieldNode);

		IdentifierNode name = default(IdentifierNode);
		TypeReferenceNode type = default(TypeReferenceNode);

		try { DebugEnterRule(GrammarFileName, "field");
		DebugLocation(129, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:130:2: (name= identifier COLON type= type_reference )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:130:4: name= identifier COLON type= type_reference
			{
			DebugLocation(130, 8);
			PushFollow(Follow._identifier_in_field776);
			name=identifier();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(130, 20);
			Match(input,COLON,Follow._COLON_in_field778); if (state.failed) return node;
			DebugLocation(130, 30);
			PushFollow(Follow._type_reference_in_field782);
			type=type_reference();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(130, 46);
			if ( state.backtracking == 0 )
			{
				node=new RecordFieldNode{FieldName=name, TypeName=type, Start=name.Start};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("field", 16);
			LeaveRule("field", 16);
			Leave_field();
		}
		DebugLocation(131, 1);
		} finally { DebugExitRule(GrammarFileName, "field"); }
		return node;

	}
	// $ANTLR end "field"


	partial void Enter_fieldList();
	partial void Leave_fieldList();

	// $ANTLR start "fieldList"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:133:1: fieldList returns [IEnumerable<RecordFieldNode> parameters] : (f= field ( COMMA f= field )* | );
	[GrammarRule("fieldList")]
	private IEnumerable<RecordFieldNode> fieldList()
	{
		Enter_fieldList();
		EnterRule("fieldList", 17);
		TraceIn("fieldList", 17);
		IEnumerable<RecordFieldNode> parameters = default(IEnumerable<RecordFieldNode>);

		RecordFieldNode f = default(RecordFieldNode);

		var result=new List<RecordFieldNode>();
		try { DebugEnterRule(GrammarFileName, "fieldList");
		DebugLocation(133, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:136:2: (f= field ( COMMA f= field )* | )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==NAME))
			{
				alt14=1;
			}
			else if ((LA14_0==RCURLY))
			{
				alt14=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return parameters;}
				NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:136:4: f= field ( COMMA f= field )*
				{
				DebugLocation(136, 5);
				PushFollow(Follow._field_in_fieldList811);
				f=field();
				PopFollow();
				if (state.failed) return parameters;
				DebugLocation(136, 12);
				if ( state.backtracking == 0 )
				{
					result.Add(f);
				}
				DebugLocation(136, 29);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:136:29: ( COMMA f= field )*
				try { DebugEnterSubRule(13);
				while (true)
				{
					int alt13=2;
					try { DebugEnterDecision(13, decisionCanBacktrack[13]);
					int LA13_0 = input.LA(1);

					if ((LA13_0==COMMA))
					{
						alt13=1;
					}


					} finally { DebugExitDecision(13); }
					switch ( alt13 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:136:30: COMMA f= field
						{
						DebugLocation(136, 30);
						Match(input,COMMA,Follow._COMMA_in_fieldList816); if (state.failed) return parameters;
						DebugLocation(136, 37);
						PushFollow(Follow._field_in_fieldList820);
						f=field();
						PopFollow();
						if (state.failed) return parameters;
						DebugLocation(136, 44);
						if ( state.backtracking == 0 )
						{
							result.Add(f);
						}

						}
						break;

					default:
						goto loop13;
					}
				}

				loop13:
					;

				} finally { DebugExitSubRule(13); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:138:2: 
				{
				}
				break;

			}
			if ( state.backtracking == 0 )
			{
				parameters=result;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("fieldList", 17);
			LeaveRule("fieldList", 17);
			Leave_fieldList();
		}
		DebugLocation(138, 1);
		} finally { DebugExitRule(GrammarFileName, "fieldList"); }
		return parameters;

	}
	// $ANTLR end "fieldList"


	partial void Enter_variable_declaration();
	partial void Leave_variable_declaration();

	// $ANTLR start "variable_declaration"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:140:1: variable_declaration returns [VariableDeclarationExpression expression] : t= 'var' name= member_identifier ( COLON type= type_reference )? ASSIGN e= program ;
	[GrammarRule("variable_declaration")]
	private VariableDeclarationExpression variable_declaration()
	{
		Enter_variable_declaration();
		EnterRule("variable_declaration", 18);
		TraceIn("variable_declaration", 18);
		VariableDeclarationExpression expression = default(VariableDeclarationExpression);

		IToken t=null;
		MemberIdentifierNode name = default(MemberIdentifierNode);
		TypeReferenceNode type = default(TypeReferenceNode);
		ProgramExpression e = default(ProgramExpression);

		expression = new VariableDeclarationExpression();
		try { DebugEnterRule(GrammarFileName, "variable_declaration");
		DebugLocation(140, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:143:2: (t= 'var' name= member_identifier ( COLON type= type_reference )? ASSIGN e= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:143:4: t= 'var' name= member_identifier ( COLON type= type_reference )? ASSIGN e= program
			{
			DebugLocation(143, 5);
			t=(IToken)Match(input,61,Follow._61_in_variable_declaration855); if (state.failed) return expression;
			DebugLocation(143, 16);
			PushFollow(Follow._member_identifier_in_variable_declaration859);
			name=member_identifier();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(143, 35);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:143:35: ( COLON type= type_reference )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==COLON))
			{
				alt15=1;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:143:36: COLON type= type_reference
				{
				DebugLocation(143, 36);
				Match(input,COLON,Follow._COLON_in_variable_declaration862); if (state.failed) return expression;
				DebugLocation(143, 46);
				PushFollow(Follow._type_reference_in_variable_declaration866);
				type=type_reference();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(143, 62);
				if ( state.backtracking == 0 )
				{
					expression.VariableTypeName=type;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(15); }

			DebugLocation(143, 100);
			Match(input,ASSIGN,Follow._ASSIGN_in_variable_declaration872); if (state.failed) return expression;
			DebugLocation(143, 108);
			PushFollow(Follow._program_in_variable_declaration876);
			e=program();
			PopFollow();
			if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression.VariableName = name; expression.Value = e; expression.Start=Loc(t); 
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("variable_declaration", 18);
			LeaveRule("variable_declaration", 18);
			Leave_variable_declaration();
		}
		DebugLocation(144, 1);
		} finally { DebugExitRule(GrammarFileName, "variable_declaration"); }
		return expression;

	}
	// $ANTLR end "variable_declaration"


	partial void Enter_func_definition();
	partial void Leave_func_definition();

	// $ANTLR start "func_definition"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:146:1: func_definition returns [FunctionDefinitionExpression expression] : t= 'function' name= identifier LPAREN parameters= func_parameter_list RPAREN ( COLON type= type_reference )? EQUAL body= program ;
	[GrammarRule("func_definition")]
	private FunctionDefinitionExpression func_definition()
	{
		Enter_func_definition();
		EnterRule("func_definition", 19);
		TraceIn("func_definition", 19);
		FunctionDefinitionExpression expression = default(FunctionDefinitionExpression);

		IToken t=null;
		IdentifierNode name = default(IdentifierNode);
		IEnumerable<FunctionParameterExpression> parameters = default(IEnumerable<FunctionParameterExpression>);
		TypeReferenceNode type = default(TypeReferenceNode);
		ProgramExpression body = default(ProgramExpression);

		expression = new FunctionDefinitionExpression();
		try { DebugEnterRule(GrammarFileName, "func_definition");
		DebugLocation(146, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:149:2: (t= 'function' name= identifier LPAREN parameters= func_parameter_list RPAREN ( COLON type= type_reference )? EQUAL body= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:149:4: t= 'function' name= identifier LPAREN parameters= func_parameter_list RPAREN ( COLON type= type_reference )? EQUAL body= program
			{
			DebugLocation(149, 5);
			t=(IToken)Match(input,62,Follow._62_in_func_definition903); if (state.failed) return expression;
			DebugLocation(149, 21);
			PushFollow(Follow._identifier_in_func_definition907);
			name=identifier();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(149, 33);
			Match(input,LPAREN,Follow._LPAREN_in_func_definition909); if (state.failed) return expression;
			DebugLocation(149, 50);
			PushFollow(Follow._func_parameter_list_in_func_definition913);
			parameters=func_parameter_list();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(149, 71);
			Match(input,RPAREN,Follow._RPAREN_in_func_definition915); if (state.failed) return expression;
			DebugLocation(149, 78);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:149:78: ( COLON type= type_reference )?
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==COLON))
			{
				alt16=1;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:149:79: COLON type= type_reference
				{
				DebugLocation(149, 79);
				Match(input,COLON,Follow._COLON_in_func_definition918); if (state.failed) return expression;
				DebugLocation(149, 89);
				PushFollow(Follow._type_reference_in_func_definition922);
				type=type_reference();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(149, 105);
				if ( state.backtracking == 0 )
				{
					expression.ReturnTypeName=type;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(16); }

			DebugLocation(149, 141);
			Match(input,EQUAL,Follow._EQUAL_in_func_definition928); if (state.failed) return expression;
			DebugLocation(149, 151);
			PushFollow(Follow._program_in_func_definition932);
			body=program();
			PopFollow();
			if (state.failed) return expression;

			}

			if ( state.backtracking == 0 )
			{
				expression.Name = name; expression.Body=body; expression.Parameters=parameters; expression.Start=Loc(t);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("func_definition", 19);
			LeaveRule("func_definition", 19);
			Leave_func_definition();
		}
		DebugLocation(150, 1);
		} finally { DebugExitRule(GrammarFileName, "func_definition"); }
		return expression;

	}
	// $ANTLR end "func_definition"


	partial void Enter_func_parameter_list();
	partial void Leave_func_parameter_list();

	// $ANTLR start "func_parameter_list"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:152:1: func_parameter_list returns [IEnumerable<FunctionParameterExpression> parameters] : (name= identifier COLON type= type_reference ( COMMA name= identifier COLON type= type_reference )* | );
	[GrammarRule("func_parameter_list")]
	private IEnumerable<FunctionParameterExpression> func_parameter_list()
	{
		Enter_func_parameter_list();
		EnterRule("func_parameter_list", 20);
		TraceIn("func_parameter_list", 20);
		IEnumerable<FunctionParameterExpression> parameters = default(IEnumerable<FunctionParameterExpression>);

		IdentifierNode name = default(IdentifierNode);
		TypeReferenceNode type = default(TypeReferenceNode);

		var result=new List<FunctionParameterExpression>();
		try { DebugEnterRule(GrammarFileName, "func_parameter_list");
		DebugLocation(152, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:155:2: (name= identifier COLON type= type_reference ( COMMA name= identifier COLON type= type_reference )* | )
			int alt18=2;
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==NAME))
			{
				alt18=1;
			}
			else if ((LA18_0==RPAREN))
			{
				alt18=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return parameters;}
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:155:4: name= identifier COLON type= type_reference ( COMMA name= identifier COLON type= type_reference )*
				{
				DebugLocation(155, 8);
				PushFollow(Follow._identifier_in_func_parameter_list960);
				name=identifier();
				PopFollow();
				if (state.failed) return parameters;
				DebugLocation(155, 20);
				Match(input,COLON,Follow._COLON_in_func_parameter_list962); if (state.failed) return parameters;
				DebugLocation(155, 30);
				PushFollow(Follow._type_reference_in_func_parameter_list966);
				type=type_reference();
				PopFollow();
				if (state.failed) return parameters;
				DebugLocation(155, 46);
				if ( state.backtracking == 0 )
				{
					result.Add(new FunctionParameterExpression{Name=name, TypeName=type, Start=name.Start});
				}
				DebugLocation(156, 3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:156:3: ( COMMA name= identifier COLON type= type_reference )*
				try { DebugEnterSubRule(17);
				while (true)
				{
					int alt17=2;
					try { DebugEnterDecision(17, decisionCanBacktrack[17]);
					int LA17_0 = input.LA(1);

					if ((LA17_0==COMMA))
					{
						alt17=1;
					}


					} finally { DebugExitDecision(17); }
					switch ( alt17 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:156:4: COMMA name= identifier COLON type= type_reference
						{
						DebugLocation(156, 4);
						Match(input,COMMA,Follow._COMMA_in_func_parameter_list974); if (state.failed) return parameters;
						DebugLocation(156, 14);
						PushFollow(Follow._identifier_in_func_parameter_list978);
						name=identifier();
						PopFollow();
						if (state.failed) return parameters;
						DebugLocation(156, 26);
						Match(input,COLON,Follow._COLON_in_func_parameter_list980); if (state.failed) return parameters;
						DebugLocation(156, 36);
						PushFollow(Follow._type_reference_in_func_parameter_list984);
						type=type_reference();
						PopFollow();
						if (state.failed) return parameters;
						DebugLocation(156, 52);
						if ( state.backtracking == 0 )
						{
							result.Add(new FunctionParameterExpression{Name=name, TypeName=type, Start=name.Start});
						}

						}
						break;

					default:
						goto loop17;
					}
				}

				loop17:
					;

				} finally { DebugExitSubRule(17); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:158:2: 
				{
				}
				break;

			}
			if ( state.backtracking == 0 )
			{
				parameters=result;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("func_parameter_list", 20);
			LeaveRule("func_parameter_list", 20);
			Leave_func_parameter_list();
		}
		DebugLocation(158, 1);
		} finally { DebugExitRule(GrammarFileName, "func_parameter_list"); }
		return parameters;

	}
	// $ANTLR end "func_parameter_list"


	partial void Enter_identifier();
	partial void Leave_identifier();

	// $ANTLR start "identifier"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:160:1: identifier returns [IdentifierNode identifier] : t= NAME ;
	[GrammarRule("identifier")]
	private IdentifierNode identifier()
	{
		Enter_identifier();
		EnterRule("identifier", 21);
		TraceIn("identifier", 21);
		IdentifierNode identifier = default(IdentifierNode);

		IToken t=null;

		try { DebugEnterRule(GrammarFileName, "identifier");
		DebugLocation(160, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:161:2: (t= NAME )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:161:4: t= NAME
			{
			DebugLocation(161, 5);
			t=(IToken)Match(input,NAME,Follow._NAME_in_identifier1008); if (state.failed) return identifier;
			DebugLocation(161, 11);
			if ( state.backtracking == 0 )
			{
				identifier=new IdentifierNode{Name=t.Text, Start=Loc(t)};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("identifier", 21);
			LeaveRule("identifier", 21);
			Leave_identifier();
		}
		DebugLocation(162, 1);
		} finally { DebugExitRule(GrammarFileName, "identifier"); }
		return identifier;

	}
	// $ANTLR end "identifier"


	partial void Enter_member_identifier();
	partial void Leave_member_identifier();

	// $ANTLR start "member_identifier"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:164:1: member_identifier returns [MemberIdentifierNode identifier] : t= NAME ;
	[GrammarRule("member_identifier")]
	private MemberIdentifierNode member_identifier()
	{
		Enter_member_identifier();
		EnterRule("member_identifier", 22);
		TraceIn("member_identifier", 22);
		MemberIdentifierNode identifier = default(MemberIdentifierNode);

		IToken t=null;

		try { DebugEnterRule(GrammarFileName, "member_identifier");
		DebugLocation(164, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:165:2: (t= NAME )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:165:4: t= NAME
			{
			DebugLocation(165, 5);
			t=(IToken)Match(input,NAME,Follow._NAME_in_member_identifier1028); if (state.failed) return identifier;
			DebugLocation(165, 11);
			if ( state.backtracking == 0 )
			{
				identifier=new MemberIdentifierNode{Name=t.Text, Start=Loc(t)};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("member_identifier", 22);
			LeaveRule("member_identifier", 22);
			Leave_member_identifier();
		}
		DebugLocation(166, 1);
		} finally { DebugExitRule(GrammarFileName, "member_identifier"); }
		return identifier;

	}
	// $ANTLR end "member_identifier"


	partial void Enter_type_identifier();
	partial void Leave_type_identifier();

	// $ANTLR start "type_identifier"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:168:1: type_identifier returns [TypeIdentifierNode identifier] : t= NAME ;
	[GrammarRule("type_identifier")]
	private TypeIdentifierNode type_identifier()
	{
		Enter_type_identifier();
		EnterRule("type_identifier", 23);
		TraceIn("type_identifier", 23);
		TypeIdentifierNode identifier = default(TypeIdentifierNode);

		IToken t=null;

		try { DebugEnterRule(GrammarFileName, "type_identifier");
		DebugLocation(168, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:169:2: (t= NAME )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:169:4: t= NAME
			{
			DebugLocation(169, 5);
			t=(IToken)Match(input,NAME,Follow._NAME_in_type_identifier1048); if (state.failed) return identifier;
			DebugLocation(169, 11);
			if ( state.backtracking == 0 )
			{
				identifier=new TypeIdentifierNode{Name=t.Text, Start=Loc(t)};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("type_identifier", 23);
			LeaveRule("type_identifier", 23);
			Leave_type_identifier();
		}
		DebugLocation(170, 1);
		} finally { DebugExitRule(GrammarFileName, "type_identifier"); }
		return identifier;

	}
	// $ANTLR end "type_identifier"


	partial void Enter_type_reference();
	partial void Leave_type_reference();

	// $ANTLR start "type_reference"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:172:1: type_reference returns [TypeReferenceNode reference] : t= NAME ;
	[GrammarRule("type_reference")]
	private TypeReferenceNode type_reference()
	{
		Enter_type_reference();
		EnterRule("type_reference", 24);
		TraceIn("type_reference", 24);
		TypeReferenceNode reference = default(TypeReferenceNode);

		IToken t=null;

		try { DebugEnterRule(GrammarFileName, "type_reference");
		DebugLocation(172, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:173:2: (t= NAME )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:173:4: t= NAME
			{
			DebugLocation(173, 5);
			t=(IToken)Match(input,NAME,Follow._NAME_in_type_reference1067); if (state.failed) return reference;
			DebugLocation(173, 11);
			if ( state.backtracking == 0 )
			{
				reference=new TypeReferenceNode{TypeName=t.Text, Start=Loc(t)};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("type_reference", 24);
			LeaveRule("type_reference", 24);
			Leave_type_reference();
		}
		DebugLocation(174, 1);
		} finally { DebugExitRule(GrammarFileName, "type_reference"); }
		return reference;

	}
	// $ANTLR end "type_reference"


	partial void Enter_test();
	partial void Leave_test();

	// $ANTLR start "test"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:178:1: test returns [Expression expression] : e= and_test ( ( VBAR VBAR )=> VBAR VBAR e= and_test )* ;
	[GrammarRule("test")]
	private Expression test()
	{
		Enter_test();
		EnterRule("test", 25);
		TraceIn("test", 25);
		Expression expression = default(Expression);

		Expression e = default(Expression);

		try { DebugEnterRule(GrammarFileName, "test");
		DebugLocation(178, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:179:2: (e= and_test ( ( VBAR VBAR )=> VBAR VBAR e= and_test )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:179:5: e= and_test ( ( VBAR VBAR )=> VBAR VBAR e= and_test )*
			{
			DebugLocation(179, 6);
			PushFollow(Follow._and_test_in_test1090);
			e=and_test();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(179, 16);
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
			DebugLocation(179, 32);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:179:32: ( ( VBAR VBAR )=> VBAR VBAR e= and_test )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==VBAR))
				{
					int LA19_2 = input.LA(2);

					if ((EvaluatePredicate(synpred3_Tiger_fragment)))
					{
						alt19=1;
					}


				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:179:33: ( VBAR VBAR )=> VBAR VBAR e= and_test
					{
					DebugLocation(179, 47);
					Match(input,VBAR,Follow._VBAR_in_test1102); if (state.failed) return expression;
					DebugLocation(179, 52);
					Match(input,VBAR,Follow._VBAR_in_test1104); if (state.failed) return expression;
					DebugLocation(179, 58);
					PushFollow(Follow._and_test_in_test1108);
					e=and_test();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(179, 68);
					if ( state.backtracking == 0 )
					{
						expression=new LogicalBinaryOperationExpression{Left= new ToBooleanExpression( expression ), Right= new ToBooleanExpression( e ), Operator=TigerOperator.OrElse};
					}

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("test", 25);
			LeaveRule("test", 25);
			Leave_test();
		}
		DebugLocation(180, 1);
		} finally { DebugExitRule(GrammarFileName, "test"); }
		return expression;

	}
	// $ANTLR end "test"


	partial void Enter_and_test();
	partial void Leave_and_test();

	// $ANTLR start "and_test"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:182:1: and_test returns [Expression expression] : e= not_test ( ( AMPER AMPER )=> AMPER AMPER e= not_test )* ;
	[GrammarRule("and_test")]
	private Expression and_test()
	{
		Enter_and_test();
		EnterRule("and_test", 26);
		TraceIn("and_test", 26);
		Expression expression = default(Expression);

		Expression e = default(Expression);

		var list=new List<Expression>();
		try { DebugEnterRule(GrammarFileName, "and_test");
		DebugLocation(182, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:184:2: (e= not_test ( ( AMPER AMPER )=> AMPER AMPER e= not_test )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:184:5: e= not_test ( ( AMPER AMPER )=> AMPER AMPER e= not_test )*
			{
			DebugLocation(184, 6);
			PushFollow(Follow._not_test_in_and_test1134);
			e=not_test();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(184, 16);
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
			DebugLocation(184, 32);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:184:32: ( ( AMPER AMPER )=> AMPER AMPER e= not_test )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==AMPER))
				{
					int LA20_2 = input.LA(2);

					if ((EvaluatePredicate(synpred4_Tiger_fragment)))
					{
						alt20=1;
					}


				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:184:33: ( AMPER AMPER )=> AMPER AMPER e= not_test
					{
					DebugLocation(184, 49);
					Match(input,AMPER,Follow._AMPER_in_and_test1146); if (state.failed) return expression;
					DebugLocation(184, 55);
					Match(input,AMPER,Follow._AMPER_in_and_test1148); if (state.failed) return expression;
					DebugLocation(184, 62);
					PushFollow(Follow._not_test_in_and_test1152);
					e=not_test();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(184, 72);
					if ( state.backtracking == 0 )
					{
						expression=new LogicalBinaryOperationExpression{Left= new ToBooleanExpression( expression ), Right= new ToBooleanExpression( e ), Operator=TigerOperator.AndAlso};
					}

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("and_test", 26);
			LeaveRule("and_test", 26);
			Leave_and_test();
		}
		DebugLocation(185, 1);
		} finally { DebugExitRule(GrammarFileName, "and_test"); }
		return expression;

	}
	// $ANTLR end "and_test"


	partial void Enter_not_test();
	partial void Leave_not_test();

	// $ANTLR start "not_test"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:187:1: not_test returns [Expression expression] : (t= 'not' e= not_test | e= comparison );
	[GrammarRule("not_test")]
	private Expression not_test()
	{
		Enter_not_test();
		EnterRule("not_test", 27);
		TraceIn("not_test", 27);
		Expression expression = default(Expression);

		IToken t=null;
		Expression e = default(Expression);

		try { DebugEnterRule(GrammarFileName, "not_test");
		DebugLocation(187, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:189:2: (t= 'not' e= not_test | e= comparison )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==63))
			{
				alt21=1;
			}
			else if ((LA21_0==LBRACK||LA21_0==LCURLY||LA21_0==LPAREN||LA21_0==NAME||(LA21_0>=PLUS && LA21_0<=MINUS)||(LA21_0>=INT && LA21_0<=STRING)||LA21_0==45||LA21_0==48||LA21_0==51||LA21_0==54||LA21_0==56||(LA21_0>=64 && LA21_0<=69)))
			{
				alt21=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return expression;}
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:189:5: t= 'not' e= not_test
				{
				DebugLocation(189, 6);
				t=(IToken)Match(input,63,Follow._63_in_not_test1179); if (state.failed) return expression;
				DebugLocation(189, 14);
				PushFollow(Follow._not_test_in_not_test1183);
				e=not_test();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(189, 24);
				if ( state.backtracking == 0 )
				{
					 e=new UnaryOperationExpression {Expression = new ToBooleanExpression( e ), Operator = TigerOperator.Not, Start=Loc(t)}; 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:190:5: e= comparison
				{
				DebugLocation(190, 6);
				PushFollow(Follow._comparison_in_not_test1193);
				e=comparison();
				PopFollow();
				if (state.failed) return expression;

				}
				break;

			}
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("not_test", 27);
			LeaveRule("not_test", 27);
			Leave_not_test();
		}
		DebugLocation(191, 1);
		} finally { DebugExitRule(GrammarFileName, "not_test"); }
		return expression;

	}
	// $ANTLR end "not_test"


	partial void Enter_comparison();
	partial void Leave_comparison();

	// $ANTLR start "comparison"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:193:1: comparison returns [Expression expression] : e= expr ( ( comp_op )=>op= comp_op e= expr )? ;
	[GrammarRule("comparison")]
	private Expression comparison()
	{
		Enter_comparison();
		EnterRule("comparison", 28);
		TraceIn("comparison", 28);
		Expression expression = default(Expression);

		Expression e = default(Expression);
		TigerParser.comp_op_return op = default(TigerParser.comp_op_return);

		try { DebugEnterRule(GrammarFileName, "comparison");
		DebugLocation(193, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:194:2: (e= expr ( ( comp_op )=>op= comp_op e= expr )? )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:194:5: e= expr ( ( comp_op )=>op= comp_op e= expr )?
			{
			DebugLocation(194, 6);
			PushFollow(Follow._expr_in_comparison1211);
			e=expr();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(194, 12);
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
			DebugLocation(194, 28);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:194:28: ( ( comp_op )=>op= comp_op e= expr )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			switch (input.LA(1))
			{
			case LESS:
				{
				int LA22_1 = input.LA(2);

				if ((EvaluatePredicate(synpred5_Tiger_fragment)))
				{
					alt22=1;
				}
				}
				break;
			case GREATER:
				{
				int LA22_2 = input.LA(2);

				if ((EvaluatePredicate(synpred5_Tiger_fragment)))
				{
					alt22=1;
				}
				}
				break;
			case EQUAL:
				{
				int LA22_3 = input.LA(2);

				if ((EvaluatePredicate(synpred5_Tiger_fragment)))
				{
					alt22=1;
				}
				}
				break;
			case GREATEREQUAL:
				{
				int LA22_4 = input.LA(2);

				if ((EvaluatePredicate(synpred5_Tiger_fragment)))
				{
					alt22=1;
				}
				}
				break;
			case LESSEQUAL:
				{
				int LA22_5 = input.LA(2);

				if ((EvaluatePredicate(synpred5_Tiger_fragment)))
				{
					alt22=1;
				}
				}
				break;
			case NOTEQUAL:
				{
				int LA22_6 = input.LA(2);

				if ((EvaluatePredicate(synpred5_Tiger_fragment)))
				{
					alt22=1;
				}
				}
				break;
			}

			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:194:29: ( comp_op )=>op= comp_op e= expr
				{
				DebugLocation(194, 44);
				PushFollow(Follow._comp_op_in_comparison1224);
				op=comp_op();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(194, 54);
				PushFollow(Follow._expr_in_comparison1228);
				e=expr();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(194, 60);
				if ( state.backtracking == 0 )
				{
					expression=new LogicalBinaryOperationExpression{Left= expression, Right= e ,Operator=op.op,Start=op.loc};
				}

				}
				break;

			}
			} finally { DebugExitSubRule(22); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("comparison", 28);
			LeaveRule("comparison", 28);
			Leave_comparison();
		}
		DebugLocation(195, 1);
		} finally { DebugExitRule(GrammarFileName, "comparison"); }
		return expression;

	}
	// $ANTLR end "comparison"

	public class comp_op_return : ParserRuleReturnScope<IToken>
	{
		public TigerOperator op;
		public SourceLocation loc;
	}

	partial void Enter_comp_op();
	partial void Leave_comp_op();

	// $ANTLR start "comp_op"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:197:1: comp_op returns [TigerOperator op, SourceLocation loc] : (t= LESS | t= GREATER | t= EQUAL | t= GREATEREQUAL | t= LESSEQUAL | t= NOTEQUAL );
	[GrammarRule("comp_op")]
	private TigerParser.comp_op_return comp_op()
	{
		Enter_comp_op();
		EnterRule("comp_op", 29);
		TraceIn("comp_op", 29);
		TigerParser.comp_op_return retval = new TigerParser.comp_op_return();
		retval.Start = (IToken)input.LT(1);

		IToken t=null;

		try { DebugEnterRule(GrammarFileName, "comp_op");
		DebugLocation(197, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:199:2: (t= LESS | t= GREATER | t= EQUAL | t= GREATEREQUAL | t= LESSEQUAL | t= NOTEQUAL )
			int alt23=6;
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			switch (input.LA(1))
			{
			case LESS:
				{
				alt23=1;
				}
				break;
			case GREATER:
				{
				alt23=2;
				}
				break;
			case EQUAL:
				{
				alt23=3;
				}
				break;
			case GREATEREQUAL:
				{
				alt23=4;
				}
				break;
			case LESSEQUAL:
				{
				alt23=5;
				}
				break;
			case NOTEQUAL:
				{
				alt23=6;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:199:5: t= LESS
				{
				DebugLocation(199, 6);
				t=(IToken)Match(input,LESS,Follow._LESS_in_comp_op1254); if (state.failed) return retval;
				DebugLocation(199, 12);
				if ( state.backtracking == 0 )
				{
					retval.op =TigerOperator.LessThan;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:200:4: t= GREATER
				{
				DebugLocation(200, 5);
				t=(IToken)Match(input,GREATER,Follow._GREATER_in_comp_op1263); if (state.failed) return retval;
				DebugLocation(200, 14);
				if ( state.backtracking == 0 )
				{
					retval.op =TigerOperator.GreaterThan;
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:201:4: t= EQUAL
				{
				DebugLocation(201, 5);
				t=(IToken)Match(input,EQUAL,Follow._EQUAL_in_comp_op1272); if (state.failed) return retval;
				DebugLocation(201, 12);
				if ( state.backtracking == 0 )
				{
					retval.op =TigerOperator.Equal;
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:202:4: t= GREATEREQUAL
				{
				DebugLocation(202, 5);
				t=(IToken)Match(input,GREATEREQUAL,Follow._GREATEREQUAL_in_comp_op1281); if (state.failed) return retval;
				DebugLocation(202, 19);
				if ( state.backtracking == 0 )
				{
					retval.op =TigerOperator.GreaterThanOrEqual;
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:203:4: t= LESSEQUAL
				{
				DebugLocation(203, 5);
				t=(IToken)Match(input,LESSEQUAL,Follow._LESSEQUAL_in_comp_op1290); if (state.failed) return retval;
				DebugLocation(203, 16);
				if ( state.backtracking == 0 )
				{
					retval.op =TigerOperator.LessThanOrEqual;
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:204:4: t= NOTEQUAL
				{
				DebugLocation(204, 5);
				t=(IToken)Match(input,NOTEQUAL,Follow._NOTEQUAL_in_comp_op1299); if (state.failed) return retval;
				DebugLocation(204, 15);
				if ( state.backtracking == 0 )
				{
					retval.op =TigerOperator.NotEqual;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 )
			{
				retval.loc =Loc(t);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("comp_op", 29);
			LeaveRule("comp_op", 29);
			Leave_comp_op();
		}
		DebugLocation(205, 1);
		} finally { DebugExitRule(GrammarFileName, "comp_op"); }
		return retval;

	}
	// $ANTLR end "comp_op"


	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:207:1: expr returns [Expression expression] : e= term ( ( PLUS | MINUS )=> ( PLUS | MINUS ) e= term )* ;
	[GrammarRule("expr")]
	private Expression expr()
	{
		Enter_expr();
		EnterRule("expr", 30);
		TraceIn("expr", 30);
		Expression expression = default(Expression);

		Expression e = default(Expression);

		var op=TigerOperator.Add;
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(207, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:2: (e= term ( ( PLUS | MINUS )=> ( PLUS | MINUS ) e= term )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:5: e= term ( ( PLUS | MINUS )=> ( PLUS | MINUS ) e= term )*
			{
			DebugLocation(209, 6);
			PushFollow(Follow._term_in_expr1323);
			e=term();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(209, 12);
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
			DebugLocation(209, 28);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:28: ( ( PLUS | MINUS )=> ( PLUS | MINUS ) e= term )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==PLUS))
				{
					int LA25_2 = input.LA(2);

					if ((EvaluatePredicate(synpred6_Tiger_fragment)))
					{
						alt25=1;
					}


				}
				else if ((LA25_0==MINUS))
				{
					int LA25_3 = input.LA(2);

					if ((EvaluatePredicate(synpred6_Tiger_fragment)))
					{
						alt25=1;
					}


				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:29: ( PLUS | MINUS )=> ( PLUS | MINUS ) e= term
					{
					DebugLocation(209, 44);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:44: ( PLUS | MINUS )
					int alt24=2;
					try { DebugEnterSubRule(24);
					try { DebugEnterDecision(24, decisionCanBacktrack[24]);
					int LA24_0 = input.LA(1);

					if ((LA24_0==PLUS))
					{
						alt24=1;
					}
					else if ((LA24_0==MINUS))
					{
						alt24=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return expression;}
						NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(24); }
					switch (alt24)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:45: PLUS
						{
						DebugLocation(209, 45);
						Match(input,PLUS,Follow._PLUS_in_expr1336); if (state.failed) return expression;

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:50: MINUS
						{
						DebugLocation(209, 50);
						Match(input,MINUS,Follow._MINUS_in_expr1338); if (state.failed) return expression;
						DebugLocation(209, 56);
						if ( state.backtracking == 0 )
						{
							op=TigerOperator.Subtract;
						}

						}
						break;

					}
					} finally { DebugExitSubRule(24); }

					DebugLocation(209, 87);
					PushFollow(Follow._term_in_expr1345);
					e=term();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(209, 93);
					if ( state.backtracking == 0 )
					{
						expression=new BinaryOperationExpression{Left=expression, Right=e, Operator=op};
					}

					}
					break;

				default:
					goto loop25;
				}
			}

			loop25:
				;

			} finally { DebugExitSubRule(25); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr", 30);
			LeaveRule("expr", 30);
			Leave_expr();
		}
		DebugLocation(210, 1);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return expression;

	}
	// $ANTLR end "expr"


	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:212:1: term returns [Expression expression] : e= factor ( ( mult_op )=>op= mult_op e= factor )* ;
	[GrammarRule("term")]
	private Expression term()
	{
		Enter_term();
		EnterRule("term", 31);
		TraceIn("term", 31);
		Expression expression = default(Expression);

		Expression e = default(Expression);
		TigerOperator op = default(TigerOperator);

		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(212, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:213:2: (e= factor ( ( mult_op )=>op= mult_op e= factor )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:213:5: e= factor ( ( mult_op )=>op= mult_op e= factor )*
			{
			DebugLocation(213, 6);
			PushFollow(Follow._factor_in_term1367);
			e=factor();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(213, 14);
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
			DebugLocation(213, 30);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:213:30: ( ( mult_op )=>op= mult_op e= factor )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				switch (input.LA(1))
				{
				case STAR:
					{
					int LA26_2 = input.LA(2);

					if ((EvaluatePredicate(synpred7_Tiger_fragment)))
					{
						alt26=1;
					}


					}
					break;
				case SLASH:
					{
					int LA26_3 = input.LA(2);

					if ((EvaluatePredicate(synpred7_Tiger_fragment)))
					{
						alt26=1;
					}


					}
					break;
				case PERCENT:
					{
					int LA26_4 = input.LA(2);

					if ((EvaluatePredicate(synpred7_Tiger_fragment)))
					{
						alt26=1;
					}


					}
					break;
				case DOUBLESLASH:
					{
					int LA26_5 = input.LA(2);

					if ((EvaluatePredicate(synpred7_Tiger_fragment)))
					{
						alt26=1;
					}


					}
					break;

				}

				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:213:31: ( mult_op )=>op= mult_op e= factor
					{
					DebugLocation(213, 45);
					PushFollow(Follow._mult_op_in_term1379);
					op=mult_op();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(213, 55);
					PushFollow(Follow._factor_in_term1383);
					e=factor();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(213, 63);
					if ( state.backtracking == 0 )
					{
						expression=new BinaryOperationExpression{Left= expression,Right=e,Operator=op};
					}

					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("term", 31);
			LeaveRule("term", 31);
			Leave_term();
		}
		DebugLocation(214, 1);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return expression;

	}
	// $ANTLR end "term"


	partial void Enter_factor();
	partial void Leave_factor();

	// $ANTLR start "factor"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:216:1: factor returns [Expression expression] : ( PLUS e= factor | t= MINUS e= factor | e= power );
	[GrammarRule("factor")]
	private Expression factor()
	{
		Enter_factor();
		EnterRule("factor", 32);
		TraceIn("factor", 32);
		Expression expression = default(Expression);

		IToken t=null;
		Expression e = default(Expression);

		try { DebugEnterRule(GrammarFileName, "factor");
		DebugLocation(216, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:217:2: ( PLUS e= factor | t= MINUS e= factor | e= power )
			int alt27=3;
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			switch (input.LA(1))
			{
			case PLUS:
				{
				alt27=1;
				}
				break;
			case MINUS:
				{
				alt27=2;
				}
				break;
			case LBRACK:
			case LCURLY:
			case LPAREN:
			case NAME:
			case INT:
			case STRING:
			case 45:
			case 48:
			case 51:
			case 54:
			case 56:
			case 64:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
				{
				alt27=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return expression;}
					NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:217:5: PLUS e= factor
				{
				DebugLocation(217, 5);
				Match(input,PLUS,Follow._PLUS_in_factor1403); if (state.failed) return expression;
				DebugLocation(217, 11);
				PushFollow(Follow._factor_in_factor1407);
				e=factor();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(217, 19);
				if ( state.backtracking == 0 )
				{
					expression=e;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:218:4: t= MINUS e= factor
				{
				DebugLocation(218, 5);
				t=(IToken)Match(input,MINUS,Follow._MINUS_in_factor1416); if (state.failed) return expression;
				DebugLocation(218, 13);
				PushFollow(Follow._factor_in_factor1420);
				e=factor();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(218, 21);
				if ( state.backtracking == 0 )
				{
					expression=new UnaryOperationExpression{Expression=e, Operator=TigerOperator.Negate, Start=Loc(t)};
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:219:5: e= power
				{
				DebugLocation(219, 6);
				PushFollow(Follow._power_in_factor1430);
				e=power();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(219, 13);
				if ( state.backtracking == 0 )
				{
					expression=e;
				}

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
			TraceOut("factor", 32);
			LeaveRule("factor", 32);
			Leave_factor();
		}
		DebugLocation(220, 1);
		} finally { DebugExitRule(GrammarFileName, "factor"); }
		return expression;

	}
	// $ANTLR end "factor"


	partial void Enter_mult_op();
	partial void Leave_mult_op();

	// $ANTLR start "mult_op"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:222:1: mult_op returns [TigerOperator op] : ( STAR | SLASH | PERCENT | DOUBLESLASH );
	[GrammarRule("mult_op")]
	private TigerOperator mult_op()
	{
		Enter_mult_op();
		EnterRule("mult_op", 33);
		TraceIn("mult_op", 33);
		TigerOperator op = default(TigerOperator);

		try { DebugEnterRule(GrammarFileName, "mult_op");
		DebugLocation(222, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:223:2: ( STAR | SLASH | PERCENT | DOUBLESLASH )
			int alt28=4;
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			switch (input.LA(1))
			{
			case STAR:
				{
				alt28=1;
				}
				break;
			case SLASH:
				{
				alt28=2;
				}
				break;
			case PERCENT:
				{
				alt28=3;
				}
				break;
			case DOUBLESLASH:
				{
				alt28=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return op;}
					NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:223:4: STAR
				{
				DebugLocation(223, 4);
				Match(input,STAR,Follow._STAR_in_mult_op1448); if (state.failed) return op;
				DebugLocation(223, 9);
				if ( state.backtracking == 0 )
				{
					op =TigerOperator.Multiply;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:224:5: SLASH
				{
				DebugLocation(224, 5);
				Match(input,SLASH,Follow._SLASH_in_mult_op1456); if (state.failed) return op;
				DebugLocation(224, 11);
				if ( state.backtracking == 0 )
				{
					op =TigerOperator.Divide;
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:225:5: PERCENT
				{
				DebugLocation(225, 5);
				Match(input,PERCENT,Follow._PERCENT_in_mult_op1464); if (state.failed) return op;
				DebugLocation(225, 13);
				if ( state.backtracking == 0 )
				{
					op =TigerOperator.Mod;
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:226:5: DOUBLESLASH
				{
				DebugLocation(226, 5);
				Match(input,DOUBLESLASH,Follow._DOUBLESLASH_in_mult_op1472); if (state.failed) return op;
				DebugLocation(226, 17);
				if ( state.backtracking == 0 )
				{
					op =TigerOperator.TrueDivide;
				}

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
			TraceOut("mult_op", 33);
			LeaveRule("mult_op", 33);
			Leave_mult_op();
		}
		DebugLocation(227, 1);
		} finally { DebugExitRule(GrammarFileName, "mult_op"); }
		return op;

	}
	// $ANTLR end "mult_op"


	partial void Enter_power();
	partial void Leave_power();

	// $ANTLR start "power"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:229:1: power returns [Expression expression] : e= power_base ( options {greedy=true; } : t= DOUBLESTAR e= factor )? ;
	[GrammarRule("power")]
	private Expression power()
	{
		Enter_power();
		EnterRule("power", 34);
		TraceIn("power", 34);
		Expression expression = default(Expression);

		IToken t=null;
		Expression e = default(Expression);

		try { DebugEnterRule(GrammarFileName, "power");
		DebugLocation(229, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:230:2: (e= power_base ( options {greedy=true; } : t= DOUBLESTAR e= factor )? )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:230:6: e= power_base ( options {greedy=true; } : t= DOUBLESTAR e= factor )?
			{
			DebugLocation(230, 7);
			PushFollow(Follow._power_base_in_power1493);
			e=power_base();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(230, 19);
			if ( state.backtracking == 0 )
			{
				expression=e;
			}
			DebugLocation(230, 35);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:230:35: ( options {greedy=true; } : t= DOUBLESTAR e= factor )?
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==DOUBLESTAR))
			{
				alt29=1;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:230:60: t= DOUBLESTAR e= factor
				{
				DebugLocation(230, 61);
				t=(IToken)Match(input,DOUBLESTAR,Follow._DOUBLESTAR_in_power1508); if (state.failed) return expression;
				DebugLocation(230, 74);
				PushFollow(Follow._factor_in_power1512);
				e=factor();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(230, 82);
				if ( state.backtracking == 0 )
				{
					expression=new BinaryOperationExpression{Left= expression,Right=e,Operator=TigerOperator.Power, Start=Loc(t)};
				}

				}
				break;

			}
			} finally { DebugExitSubRule(29); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("power", 34);
			LeaveRule("power", 34);
			Leave_power();
		}
		DebugLocation(231, 1);
		} finally { DebugExitRule(GrammarFileName, "power"); }
		return expression;

	}
	// $ANTLR end "power"


	partial void Enter_power_base();
	partial void Leave_power_base();

	// $ANTLR start "power_base"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:233:1: power_base returns [Expression expression] : prev= atom ( ( LBRACK | DOT )=>next= member_access[prev] )* ;
	[GrammarRule("power_base")]
	private Expression power_base()
	{
		Enter_power_base();
		EnterRule("power_base", 35);
		TraceIn("power_base", 35);
		Expression expression = default(Expression);

		Expression prev = default(Expression);
		Expression next = default(Expression);

		try { DebugEnterRule(GrammarFileName, "power_base");
		DebugLocation(233, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:234:2: (prev= atom ( ( LBRACK | DOT )=>next= member_access[prev] )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:234:4: prev= atom ( ( LBRACK | DOT )=>next= member_access[prev] )*
			{
			DebugLocation(234, 8);
			PushFollow(Follow._atom_in_power_base1534);
			prev=atom();
			PopFollow();
			if (state.failed) return expression;
			DebugLocation(234, 14);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:234:14: ( ( LBRACK | DOT )=>next= member_access[prev] )*
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==LBRACK))
				{
					int LA30_2 = input.LA(2);

					if ((EvaluatePredicate(synpred8_Tiger_fragment)))
					{
						alt30=1;
					}


				}
				else if ((LA30_0==DOT))
				{
					int LA30_3 = input.LA(2);

					if ((EvaluatePredicate(synpred8_Tiger_fragment)))
					{
						alt30=1;
					}


				}


				} finally { DebugExitDecision(30); }
				switch ( alt30 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:234:15: ( LBRACK | DOT )=>next= member_access[prev]
					{
					DebugLocation(234, 34);
					PushFollow(Follow._member_access_in_power_base1546);
					next=member_access(prev);
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(234, 55);
					if ( state.backtracking == 0 )
					{
						prev=next;
					}

					}
					break;

				default:
					goto loop30;
				}
			}

			loop30:
				;

			} finally { DebugExitSubRule(30); }

			DebugLocation(234, 70);
			if ( state.backtracking == 0 )
			{
				expression=prev;
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("power_base", 35);
			LeaveRule("power_base", 35);
			Leave_power_base();
		}
		DebugLocation(235, 1);
		} finally { DebugExitRule(GrammarFileName, "power_base"); }
		return expression;

	}
	// $ANTLR end "power_base"


	partial void Enter_atom();
	partial void Leave_atom();

	// $ANTLR start "atom"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:237:1: atom returns [Expression expression] : (name= identifier ( LCURLY fields= memberinitlist RCURLY | ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program | (t= ASSIGN e1= program )? | LPAREN (args= program_list_comma )? RPAREN ) | e= literal | e= expr_stmt | ( LPAREN type_reference RPAREN )=>t= LPAREN cast= type_reference RPAREN ex= program | LPAREN p= program RPAREN );
	[GrammarRule("atom")]
	private Expression atom()
	{
		Enter_atom();
		EnterRule("atom", 36);
		TraceIn("atom", 36);
		Expression expression = default(Expression);

		IToken t=null;
		IdentifierNode name = default(IdentifierNode);
		IEnumerable<FieldInitializationNode> fields = default(IEnumerable<FieldInitializationNode>);
		ProgramExpression lenght = default(ProgramExpression);
		ProgramExpression init = default(ProgramExpression);
		ProgramExpression e1 = default(ProgramExpression);
		IEnumerable<Expression> args = default(IEnumerable<Expression>);
		Expression e = default(Expression);
		TypeReferenceNode cast = default(TypeReferenceNode);
		ProgramExpression ex = default(ProgramExpression);
		ProgramExpression p = default(ProgramExpression);

		FunctionInvokeExpression r=null;
		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(237, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:239:2: (name= identifier ( LCURLY fields= memberinitlist RCURLY | ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program | (t= ASSIGN e1= program )? | LPAREN (args= program_list_comma )? RPAREN ) | e= literal | e= expr_stmt | ( LPAREN type_reference RPAREN )=>t= LPAREN cast= type_reference RPAREN ex= program | LPAREN p= program RPAREN )
			int alt34=5;
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			try
			{
				alt34 = dfa34.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:239:4: name= identifier ( LCURLY fields= memberinitlist RCURLY | ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program | (t= ASSIGN e1= program )? | LPAREN (args= program_list_comma )? RPAREN )
				{
				DebugLocation(239, 8);
				PushFollow(Follow._identifier_in_atom1574);
				name=identifier();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(239, 20);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:239:20: ( LCURLY fields= memberinitlist RCURLY | ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program | (t= ASSIGN e1= program )? | LPAREN (args= program_list_comma )? RPAREN )
				int alt33=4;
				try { DebugEnterSubRule(33);
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				try
				{
					alt33 = dfa33.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(33); }
				switch (alt33)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:239:22: LCURLY fields= memberinitlist RCURLY
					{
					DebugLocation(239, 22);
					Match(input,LCURLY,Follow._LCURLY_in_atom1578); if (state.failed) return expression;
					DebugLocation(239, 35);
					PushFollow(Follow._memberinitlist_in_atom1582);
					fields=memberinitlist();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(239, 51);
					Match(input,RCURLY,Follow._RCURLY_in_atom1584); if (state.failed) return expression;
					DebugLocation(239, 58);
					if ( state.backtracking == 0 )
					{
						expression=new RecordInitExpression{TypeName=new TypeReferenceNode{TypeName= name.Name}, Fields=fields, Start=name.Start};
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:240:7: ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program
					{
					DebugLocation(240, 39);
					Match(input,LBRACK,Follow._LBRACK_in_atom1606); if (state.failed) return expression;
					DebugLocation(240, 52);
					PushFollow(Follow._program_in_atom1610);
					lenght=program();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(240, 61);
					Match(input,RBRACK,Follow._RBRACK_in_atom1612); if (state.failed) return expression;
					DebugLocation(240, 68);
					Match(input,60,Follow._60_in_atom1614); if (state.failed) return expression;
					DebugLocation(240, 77);
					PushFollow(Follow._program_in_atom1618);
					init=program();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(240, 86);
					if ( state.backtracking == 0 )
					{
						expression=new ArrayDefaultInitializationExpression{ArrayTypeName=new TypeReferenceNode{TypeName= name.Name}, Lenght=lenght, InitialValue=init, Start=name.Start};
					}

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:241:8: (t= ASSIGN e1= program )?
					{
					DebugLocation(241, 8);
					if ( state.backtracking == 0 )
					{
						expression=new VariableAccessExpression{VariableName=name.Name, Start=name.Start};
					}
					DebugLocation(241, 93);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:241:93: (t= ASSIGN e1= program )?
					int alt31=2;
					try { DebugEnterSubRule(31);
					try { DebugEnterDecision(31, decisionCanBacktrack[31]);
					int LA31_0 = input.LA(1);

					if ((LA31_0==ASSIGN))
					{
						alt31=1;
					}
					} finally { DebugExitDecision(31); }
					switch (alt31)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:241:94: t= ASSIGN e1= program
						{
						DebugLocation(241, 95);
						t=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_atom1634); if (state.failed) return expression;
						DebugLocation(241, 105);
						PushFollow(Follow._program_in_atom1638);
						e1=program();
						PopFollow();
						if (state.failed) return expression;
						DebugLocation(241, 114);
						if ( state.backtracking == 0 )
						{
							expression=new AssignExpression{Left=expression,Right=e1, Start=Loc(t)};
						}

						}
						break;

					}
					} finally { DebugExitSubRule(31); }


					}
					break;
				case 4:
					DebugEnterAlt(4);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:242:8: LPAREN (args= program_list_comma )? RPAREN
					{
					DebugLocation(242, 8);
					if ( state.backtracking == 0 )
					{
						r=new FunctionInvokeExpression{FunctionName=name, Start=name.Start};
					}
					DebugLocation(242, 79);
					Match(input,LPAREN,Follow._LPAREN_in_atom1653); if (state.failed) return expression;
					DebugLocation(242, 86);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:242:86: (args= program_list_comma )?
					int alt32=2;
					try { DebugEnterSubRule(32);
					try { DebugEnterDecision(32, decisionCanBacktrack[32]);
					int LA32_0 = input.LA(1);

					if ((LA32_0==LBRACK||LA32_0==LCURLY||LA32_0==LPAREN||LA32_0==NAME||(LA32_0>=PLUS && LA32_0<=MINUS)||(LA32_0>=INT && LA32_0<=STRING)||LA32_0==45||LA32_0==48||LA32_0==51||LA32_0==54||LA32_0==56||(LA32_0>=63 && LA32_0<=69)))
					{
						alt32=1;
					}
					} finally { DebugExitDecision(32); }
					switch (alt32)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:242:87: args= program_list_comma
						{
						DebugLocation(242, 91);
						PushFollow(Follow._program_list_comma_in_atom1658);
						args=program_list_comma();
						PopFollow();
						if (state.failed) return expression;
						DebugLocation(242, 111);
						if ( state.backtracking == 0 )
						{
							r.Args=args;
						}

						}
						break;

					}
					} finally { DebugExitSubRule(32); }

					DebugLocation(242, 128);
					Match(input,RPAREN,Follow._RPAREN_in_atom1664); if (state.failed) return expression;
					DebugLocation(242, 135);
					if ( state.backtracking == 0 )
					{
						expression=r;
					}

					}
					break;

				}
				} finally { DebugExitSubRule(33); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:244:5: e= literal
				{
				DebugLocation(244, 6);
				PushFollow(Follow._literal_in_atom1681);
				e=literal();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(244, 15);
				if ( state.backtracking == 0 )
				{
					expression=e;
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:245:5: e= expr_stmt
				{
				DebugLocation(245, 6);
				PushFollow(Follow._expr_stmt_in_atom1691);
				e=expr_stmt();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(245, 17);
				if ( state.backtracking == 0 )
				{
					expression=e;
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:246:4: ( LPAREN type_reference RPAREN )=>t= LPAREN cast= type_reference RPAREN ex= program
				{
				DebugLocation(246, 39);
				t=(IToken)Match(input,LPAREN,Follow._LPAREN_in_atom1710); if (state.failed) return expression;
				DebugLocation(246, 51);
				PushFollow(Follow._type_reference_in_atom1714);
				cast=type_reference();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(246, 67);
				Match(input,RPAREN,Follow._RPAREN_in_atom1716); if (state.failed) return expression;
				DebugLocation(246, 76);
				PushFollow(Follow._program_in_atom1720);
				ex=program();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(246, 85);
				if ( state.backtracking == 0 )
				{
					expression=new CastExpression{TargetType=cast,Expression=ex,Start=Loc(t)};
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:247:4: LPAREN p= program RPAREN
				{
				DebugLocation(247, 4);
				Match(input,LPAREN,Follow._LPAREN_in_atom1727); if (state.failed) return expression;
				DebugLocation(247, 12);
				PushFollow(Follow._program_in_atom1731);
				p=program();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(247, 21);
				Match(input,RPAREN,Follow._RPAREN_in_atom1733); if (state.failed) return expression;
				DebugLocation(247, 28);
				if ( state.backtracking == 0 )
				{
					expression=p;
				}

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
			TraceOut("atom", 36);
			LeaveRule("atom", 36);
			Leave_atom();
		}
		DebugLocation(248, 1);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return expression;

	}
	// $ANTLR end "atom"


	partial void Enter_literal();
	partial void Leave_literal();

	// $ANTLR start "literal"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:250:1: literal returns [Expression expression] : (t= 'true' | t= 'false' | t= 'break' | t= 'continue' | t= 'nil' | t= 'return' v= program | t= INT | e= stringLiteral );
	[GrammarRule("literal")]
	private Expression literal()
	{
		Enter_literal();
		EnterRule("literal", 37);
		TraceIn("literal", 37);
		Expression expression = default(Expression);

		IToken t=null;
		ProgramExpression v = default(ProgramExpression);
		StringLiteralExpression e = default(StringLiteralExpression);

		try { DebugEnterRule(GrammarFileName, "literal");
		DebugLocation(250, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:251:2: (t= 'true' | t= 'false' | t= 'break' | t= 'continue' | t= 'nil' | t= 'return' v= program | t= INT | e= stringLiteral )
			int alt35=8;
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			switch (input.LA(1))
			{
			case 64:
				{
				alt35=1;
				}
				break;
			case 65:
				{
				alt35=2;
				}
				break;
			case 66:
				{
				alt35=3;
				}
				break;
			case 67:
				{
				alt35=4;
				}
				break;
			case 68:
				{
				alt35=5;
				}
				break;
			case 69:
				{
				alt35=6;
				}
				break;
			case INT:
				{
				alt35=7;
				}
				break;
			case STRING:
				{
				alt35=8;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return expression;}
					NoViableAltException nvae = new NoViableAltException("", 35, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:251:4: t= 'true'
				{
				DebugLocation(251, 5);
				t=(IToken)Match(input,64,Follow._64_in_literal1752); if (state.failed) return expression;
				DebugLocation(251, 13);
				if ( state.backtracking == 0 )
				{
					expression=new BoolLiteral(true){Start=Loc(t)};
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:252:4: t= 'false'
				{
				DebugLocation(252, 5);
				t=(IToken)Match(input,65,Follow._65_in_literal1761); if (state.failed) return expression;
				DebugLocation(252, 14);
				if ( state.backtracking == 0 )
				{
					expression=new BoolLiteral(false){Start=Loc(t)};
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:253:4: t= 'break'
				{
				DebugLocation(253, 5);
				t=(IToken)Match(input,66,Follow._66_in_literal1770); if (state.failed) return expression;
				DebugLocation(253, 14);
				if ( state.backtracking == 0 )
				{
					expression = new BreakExpression{Start=Loc(t)}; 
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:254:4: t= 'continue'
				{
				DebugLocation(254, 5);
				t=(IToken)Match(input,67,Follow._67_in_literal1779); if (state.failed) return expression;
				DebugLocation(254, 17);
				if ( state.backtracking == 0 )
				{
					expression = new ContinueExpression{Start=Loc(t)}; 
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:255:4: t= 'nil'
				{
				DebugLocation(255, 5);
				t=(IToken)Match(input,68,Follow._68_in_literal1788); if (state.failed) return expression;
				DebugLocation(255, 12);
				if ( state.backtracking == 0 )
				{
					 expression=new NullLiteralExpression{Start=Loc(t)}; 
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:256:4: t= 'return' v= program
				{
				DebugLocation(256, 5);
				t=(IToken)Match(input,69,Follow._69_in_literal1797); if (state.failed) return expression;
				DebugLocation(256, 16);
				PushFollow(Follow._program_in_literal1801);
				v=program();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(256, 25);
				if ( state.backtracking == 0 )
				{
					expression=new ReturnExpression{Value=v,Start=Loc(t)};
				}

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:257:4: t= INT
				{
				DebugLocation(257, 5);
				t=(IToken)Match(input,INT,Follow._INT_in_literal1810); if (state.failed) return expression;
				DebugLocation(257, 10);
				if ( state.backtracking == 0 )
				{
					expression=new IntLiteralExpression(t.Text){Start=Loc(t)};
				}

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:258:5: e= stringLiteral
				{
				DebugLocation(258, 6);
				PushFollow(Follow._stringLiteral_in_literal1821);
				e=stringLiteral();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(258, 21);
				if ( state.backtracking == 0 )
				{
					expression=e;
				}

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
			TraceOut("literal", 37);
			LeaveRule("literal", 37);
			Leave_literal();
		}
		DebugLocation(259, 1);
		} finally { DebugExitRule(GrammarFileName, "literal"); }
		return expression;

	}
	// $ANTLR end "literal"


	partial void Enter_stringLiteral();
	partial void Leave_stringLiteral();

	// $ANTLR start "stringLiteral"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:261:1: stringLiteral returns [StringLiteralExpression expression] : t= STRING ( ( PERCENT )=> PERCENT ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program ) )? ;
	[GrammarRule("stringLiteral")]
	private StringLiteralExpression stringLiteral()
	{
		Enter_stringLiteral();
		EnterRule("stringLiteral", 38);
		TraceIn("stringLiteral", 38);
		StringLiteralExpression expression = default(StringLiteralExpression);

		IToken t=null;
		IEnumerable<Expression> args = default(IEnumerable<Expression>);
		ProgramExpression e = default(ProgramExpression);

		try { DebugEnterRule(GrammarFileName, "stringLiteral");
		DebugLocation(261, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:262:2: (t= STRING ( ( PERCENT )=> PERCENT ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program ) )? )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:262:4: t= STRING ( ( PERCENT )=> PERCENT ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program ) )?
			{
			DebugLocation(262, 5);
			t=(IToken)Match(input,STRING,Follow._STRING_in_stringLiteral1840); if (state.failed) return expression;
			DebugLocation(262, 13);
			if ( state.backtracking == 0 )
			{
				expression=new StringLiteralExpression(t.Text){Start=Loc(t)};
			}
			DebugLocation(263, 4);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:4: ( ( PERCENT )=> PERCENT ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program ) )?
			int alt37=2;
			try { DebugEnterSubRule(37);
			try { DebugEnterDecision(37, decisionCanBacktrack[37]);
			try
			{
				alt37 = dfa37.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(37); }
			switch (alt37)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:5: ( PERCENT )=> PERCENT ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program )
				{
				DebugLocation(263, 18);
				Match(input,PERCENT,Follow._PERCENT_in_stringLiteral1854); if (state.failed) return expression;
				DebugLocation(263, 26);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:26: ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program )
				int alt36=2;
				try { DebugEnterSubRule(36);
				try { DebugEnterDecision(36, decisionCanBacktrack[36]);
				try
				{
					alt36 = dfa36.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(36); }
				switch (alt36)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:27: ( LPAREN )=> LPAREN args= program_list_comma RPAREN
					{
					DebugLocation(263, 39);
					Match(input,LPAREN,Follow._LPAREN_in_stringLiteral1863); if (state.failed) return expression;
					DebugLocation(263, 50);
					PushFollow(Follow._program_list_comma_in_stringLiteral1867);
					args=program_list_comma();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(263, 70);
					Match(input,RPAREN,Follow._RPAREN_in_stringLiteral1869); if (state.failed) return expression;
					DebugLocation(263, 77);
					if ( state.backtracking == 0 )
					{
						expression.Args=args;
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:264:9: e= program
					{
					DebugLocation(264, 10);
					PushFollow(Follow._program_in_stringLiteral1884);
					e=program();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(264, 19);
					if ( state.backtracking == 0 )
					{
						expression.Args=new[]{e};
					}

					}
					break;

				}
				} finally { DebugExitSubRule(36); }


				}
				break;

			}
			} finally { DebugExitSubRule(37); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("stringLiteral", 38);
			LeaveRule("stringLiteral", 38);
			Leave_stringLiteral();
		}
		DebugLocation(265, 1);
		} finally { DebugExitRule(GrammarFileName, "stringLiteral"); }
		return expression;

	}
	// $ANTLR end "stringLiteral"


	partial void Enter_member_access();
	partial void Leave_member_access();

	// $ANTLR start "member_access"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:267:1: member_access[Expression target] returns [Expression expression] : ( LBRACK e= program_list_comma RBRACK (t= ASSIGN e1= program )? | DOT name= identifier ( LPAREN (args= program_list_comma )? RPAREN | (t= ASSIGN e1= program )? ) );
	[GrammarRule("member_access")]
	private Expression member_access(Expression target)
	{
		Enter_member_access();
		EnterRule("member_access", 39);
		TraceIn("member_access", 39);
		Expression expression = default(Expression);

		IToken t=null;
		IEnumerable<Expression> e = default(IEnumerable<Expression>);
		ProgramExpression e1 = default(ProgramExpression);
		IdentifierNode name = default(IdentifierNode);
		IEnumerable<Expression> args = default(IEnumerable<Expression>);

		MethodCallExpression method=null;
		try { DebugEnterRule(GrammarFileName, "member_access");
		DebugLocation(267, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:269:2: ( LBRACK e= program_list_comma RBRACK (t= ASSIGN e1= program )? | DOT name= identifier ( LPAREN (args= program_list_comma )? RPAREN | (t= ASSIGN e1= program )? ) )
			int alt42=2;
			try { DebugEnterDecision(42, decisionCanBacktrack[42]);
			int LA42_0 = input.LA(1);

			if ((LA42_0==LBRACK))
			{
				alt42=1;
			}
			else if ((LA42_0==DOT))
			{
				alt42=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return expression;}
				NoViableAltException nvae = new NoViableAltException("", 42, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(42); }
			switch (alt42)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:269:4: LBRACK e= program_list_comma RBRACK (t= ASSIGN e1= program )?
				{
				DebugLocation(269, 4);
				Match(input,LBRACK,Follow._LBRACK_in_member_access1910); if (state.failed) return expression;
				DebugLocation(269, 12);
				PushFollow(Follow._program_list_comma_in_member_access1914);
				e=program_list_comma();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(269, 32);
				Match(input,RBRACK,Follow._RBRACK_in_member_access1916); if (state.failed) return expression;
				DebugLocation(269, 39);
				if ( state.backtracking == 0 )
				{
					expression = new ArrayIndexExpression{Target=target, Indexes=e};
				}
				DebugLocation(269, 106);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:269:106: (t= ASSIGN e1= program )?
				int alt38=2;
				try { DebugEnterSubRule(38);
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				int LA38_0 = input.LA(1);

				if ((LA38_0==ASSIGN))
				{
					alt38=1;
				}
				} finally { DebugExitDecision(38); }
				switch (alt38)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:269:107: t= ASSIGN e1= program
					{
					DebugLocation(269, 108);
					t=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_member_access1923); if (state.failed) return expression;
					DebugLocation(269, 118);
					PushFollow(Follow._program_in_member_access1927);
					e1=program();
					PopFollow();
					if (state.failed) return expression;
					DebugLocation(269, 127);
					if ( state.backtracking == 0 )
					{
						expression=new AssignExpression{Left=expression, Right=e1, Start=Loc(t)};
					}

					}
					break;

				}
				} finally { DebugExitSubRule(38); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:270:4: DOT name= identifier ( LPAREN (args= program_list_comma )? RPAREN | (t= ASSIGN e1= program )? )
				{
				DebugLocation(270, 4);
				Match(input,DOT,Follow._DOT_in_member_access1936); if (state.failed) return expression;
				DebugLocation(270, 12);
				PushFollow(Follow._identifier_in_member_access1940);
				name=identifier();
				PopFollow();
				if (state.failed) return expression;
				DebugLocation(271, 4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:271:4: ( LPAREN (args= program_list_comma )? RPAREN | (t= ASSIGN e1= program )? )
				int alt41=2;
				try { DebugEnterSubRule(41);
				try { DebugEnterDecision(41, decisionCanBacktrack[41]);
				int LA41_0 = input.LA(1);

				if ((LA41_0==LPAREN))
				{
					alt41=1;
				}
				else if ((LA41_0==EOF||(LA41_0>=VBAR && LA41_0<=RBRACK)||(LA41_0>=SEMI && LA41_0<=EQUAL)||LA41_0==RPAREN||(LA41_0>=AMPER && LA41_0<=DOUBLESTAR)||LA41_0==DOT||(LA41_0>=46 && LA41_0<=47)||(LA41_0>=49 && LA41_0<=50)||(LA41_0>=52 && LA41_0<=53)||LA41_0==55||(LA41_0>=57 && LA41_0<=58)||(LA41_0>=61 && LA41_0<=62)))
				{
					alt41=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return expression;}
					NoViableAltException nvae = new NoViableAltException("", 41, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(41); }
				switch (alt41)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:271:6: LPAREN (args= program_list_comma )? RPAREN
					{
					DebugLocation(271, 6);
					if ( state.backtracking == 0 )
					{
						method=new MethodCallExpression{Target=target,MethodName=name, Start=name.Start};
					}
					DebugLocation(271, 90);
					Match(input,LPAREN,Follow._LPAREN_in_member_access1949); if (state.failed) return expression;
					DebugLocation(271, 97);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:271:97: (args= program_list_comma )?
					int alt39=2;
					try { DebugEnterSubRule(39);
					try { DebugEnterDecision(39, decisionCanBacktrack[39]);
					int LA39_0 = input.LA(1);

					if ((LA39_0==LBRACK||LA39_0==LCURLY||LA39_0==LPAREN||LA39_0==NAME||(LA39_0>=PLUS && LA39_0<=MINUS)||(LA39_0>=INT && LA39_0<=STRING)||LA39_0==45||LA39_0==48||LA39_0==51||LA39_0==54||LA39_0==56||(LA39_0>=63 && LA39_0<=69)))
					{
						alt39=1;
					}
					} finally { DebugExitDecision(39); }
					switch (alt39)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:271:98: args= program_list_comma
						{
						DebugLocation(271, 102);
						PushFollow(Follow._program_list_comma_in_member_access1954);
						args=program_list_comma();
						PopFollow();
						if (state.failed) return expression;
						DebugLocation(271, 122);
						if ( state.backtracking == 0 )
						{
							method.Args=args; 
						}

						}
						break;

					}
					} finally { DebugExitSubRule(39); }

					DebugLocation(271, 145);
					Match(input,RPAREN,Follow._RPAREN_in_member_access1960); if (state.failed) return expression;
					DebugLocation(271, 153);
					if ( state.backtracking == 0 )
					{
						expression=method;
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:272:7: (t= ASSIGN e1= program )?
					{
					DebugLocation(272, 7);
					if ( state.backtracking == 0 )
					{
						expression=new FieldAccessExpression{Target=target, FieldName=name, Start=name.Start};
					}
					DebugLocation(272, 96);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:272:96: (t= ASSIGN e1= program )?
					int alt40=2;
					try { DebugEnterSubRule(40);
					try { DebugEnterDecision(40, decisionCanBacktrack[40]);
					int LA40_0 = input.LA(1);

					if ((LA40_0==ASSIGN))
					{
						alt40=1;
					}
					} finally { DebugExitDecision(40); }
					switch (alt40)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:272:97: t= ASSIGN e1= program
						{
						DebugLocation(272, 98);
						t=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_member_access1976); if (state.failed) return expression;
						DebugLocation(272, 108);
						PushFollow(Follow._program_in_member_access1980);
						e1=program();
						PopFollow();
						if (state.failed) return expression;
						DebugLocation(272, 117);
						if ( state.backtracking == 0 )
						{
							expression=new AssignExpression{Left=expression,Right=e1, Start=Loc(t)};
						}

						}
						break;

					}
					} finally { DebugExitSubRule(40); }


					}
					break;

				}
				} finally { DebugExitSubRule(41); }


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
			TraceOut("member_access", 39);
			LeaveRule("member_access", 39);
			Leave_member_access();
		}
		DebugLocation(275, 1);
		} finally { DebugExitRule(GrammarFileName, "member_access"); }
		return expression;

	}
	// $ANTLR end "member_access"


	partial void Enter_memberinit();
	partial void Leave_memberinit();

	// $ANTLR start "memberinit"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:278:1: memberinit returns [FieldInitializationNode node] : name= identifier EQUAL e= program ;
	[GrammarRule("memberinit")]
	private FieldInitializationNode memberinit()
	{
		Enter_memberinit();
		EnterRule("memberinit", 40);
		TraceIn("memberinit", 40);
		FieldInitializationNode node = default(FieldInitializationNode);

		IdentifierNode name = default(IdentifierNode);
		ProgramExpression e = default(ProgramExpression);

		try { DebugEnterRule(GrammarFileName, "memberinit");
		DebugLocation(278, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:279:2: (name= identifier EQUAL e= program )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:279:4: name= identifier EQUAL e= program
			{
			DebugLocation(279, 8);
			PushFollow(Follow._identifier_in_memberinit2009);
			name=identifier();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(279, 20);
			Match(input,EQUAL,Follow._EQUAL_in_memberinit2011); if (state.failed) return node;
			DebugLocation(279, 27);
			PushFollow(Follow._program_in_memberinit2015);
			e=program();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(279, 36);
			if ( state.backtracking == 0 )
			{
				node=new FieldInitializationNode{FieldName=name, Value=e, Start=name.Start};
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("memberinit", 40);
			LeaveRule("memberinit", 40);
			Leave_memberinit();
		}
		DebugLocation(280, 1);
		} finally { DebugExitRule(GrammarFileName, "memberinit"); }
		return node;

	}
	// $ANTLR end "memberinit"


	partial void Enter_memberinitlist();
	partial void Leave_memberinitlist();

	// $ANTLR start "memberinitlist"
	// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:282:1: memberinitlist returns [IEnumerable<FieldInitializationNode> result] : f= memberinit ( options {k=2; } : COMMA f= memberinit )* ( COMMA )? ;
	[GrammarRule("memberinitlist")]
	private IEnumerable<FieldInitializationNode> memberinitlist()
	{
		Enter_memberinitlist();
		EnterRule("memberinitlist", 41);
		TraceIn("memberinitlist", 41);
		IEnumerable<FieldInitializationNode> result = default(IEnumerable<FieldInitializationNode>);

		FieldInitializationNode f = default(FieldInitializationNode);

		var list=new List<FieldInitializationNode>();
		try { DebugEnterRule(GrammarFileName, "memberinitlist");
		DebugLocation(282, 1);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:285:6: (f= memberinit ( options {k=2; } : COMMA f= memberinit )* ( COMMA )? )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:285:8: f= memberinit ( options {k=2; } : COMMA f= memberinit )* ( COMMA )?
			{
			DebugLocation(285, 9);
			PushFollow(Follow._memberinit_in_memberinitlist2046);
			f=memberinit();
			PopFollow();
			if (state.failed) return result;
			DebugLocation(285, 21);
			if ( state.backtracking == 0 )
			{
				list.Add(f);
			}
			DebugLocation(285, 36);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:285:36: ( options {k=2; } : COMMA f= memberinit )*
			try { DebugEnterSubRule(43);
			while (true)
			{
				int alt43=2;
				try { DebugEnterDecision(43, decisionCanBacktrack[43]);
				int LA43_0 = input.LA(1);

				if ((LA43_0==COMMA))
				{
					int LA43_1 = input.LA(2);

					if ((LA43_1==NAME))
					{
						alt43=1;
					}


				}


				} finally { DebugExitDecision(43); }
				switch ( alt43 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:285:52: COMMA f= memberinit
					{
					DebugLocation(285, 52);
					Match(input,COMMA,Follow._COMMA_in_memberinitlist2058); if (state.failed) return result;
					DebugLocation(285, 59);
					PushFollow(Follow._memberinit_in_memberinitlist2062);
					f=memberinit();
					PopFollow();
					if (state.failed) return result;
					DebugLocation(285, 71);
					if ( state.backtracking == 0 )
					{
						list.Add(f);
					}

					}
					break;

				default:
					goto loop43;
				}
			}

			loop43:
				;

			} finally { DebugExitSubRule(43); }

			DebugLocation(285, 88);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:285:88: ( COMMA )?
			int alt44=2;
			try { DebugEnterSubRule(44);
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			int LA44_0 = input.LA(1);

			if ((LA44_0==COMMA))
			{
				alt44=1;
			}
			} finally { DebugExitDecision(44); }
			switch (alt44)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:285:89: COMMA
				{
				DebugLocation(285, 89);
				Match(input,COMMA,Follow._COMMA_in_memberinitlist2069); if (state.failed) return result;

				}
				break;

			}
			} finally { DebugExitSubRule(44); }


			}

			if ( state.backtracking == 0 )
			{
				result=list;
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("memberinitlist", 41);
			LeaveRule("memberinitlist", 41);
			Leave_memberinitlist();
		}
		DebugLocation(286, 1);
		} finally { DebugExitRule(GrammarFileName, "memberinitlist"); }
		return result;

	}
	// $ANTLR end "memberinitlist"

	partial void Enter_synpred1_Tiger_fragment();
	partial void Leave_synpred1_Tiger_fragment();

	// $ANTLR start synpred1_Tiger
	public void synpred1_Tiger_fragment()
	{
		Enter_synpred1_Tiger_fragment();
		EnterRule("synpred1_Tiger_fragment", 42);
		TraceIn("synpred1_Tiger_fragment", 42);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:50:44: ( VBAR )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:50:45: VBAR
			{
			DebugLocation(50, 45);
			Match(input,VBAR,Follow._VBAR_in_synpred1_Tiger211); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_Tiger_fragment", 42);
			LeaveRule("synpred1_Tiger_fragment", 42);
			Leave_synpred1_Tiger_fragment();
		}
	}
	// $ANTLR end synpred1_Tiger

	partial void Enter_synpred2_Tiger_fragment();
	partial void Leave_synpred2_Tiger_fragment();

	// $ANTLR start synpred2_Tiger
	public void synpred2_Tiger_fragment()
	{
		Enter_synpred2_Tiger_fragment();
		EnterRule("synpred2_Tiger_fragment", 43);
		TraceIn("synpred2_Tiger_fragment", 43);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:92:4: ( 'else' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:92:5: 'else'
			{
			DebugLocation(92, 5);
			Match(input,53,Follow._53_in_synpred2_Tiger505); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_Tiger_fragment", 43);
			LeaveRule("synpred2_Tiger_fragment", 43);
			Leave_synpred2_Tiger_fragment();
		}
	}
	// $ANTLR end synpred2_Tiger

	partial void Enter_synpred3_Tiger_fragment();
	partial void Leave_synpred3_Tiger_fragment();

	// $ANTLR start synpred3_Tiger
	public void synpred3_Tiger_fragment()
	{
		Enter_synpred3_Tiger_fragment();
		EnterRule("synpred3_Tiger_fragment", 44);
		TraceIn("synpred3_Tiger_fragment", 44);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:179:33: ( VBAR VBAR )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:179:34: VBAR VBAR
			{
			DebugLocation(179, 34);
			Match(input,VBAR,Follow._VBAR_in_synpred3_Tiger1096); if (state.failed) return;
			DebugLocation(179, 39);
			Match(input,VBAR,Follow._VBAR_in_synpred3_Tiger1098); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred3_Tiger_fragment", 44);
			LeaveRule("synpred3_Tiger_fragment", 44);
			Leave_synpred3_Tiger_fragment();
		}
	}
	// $ANTLR end synpred3_Tiger

	partial void Enter_synpred4_Tiger_fragment();
	partial void Leave_synpred4_Tiger_fragment();

	// $ANTLR start synpred4_Tiger
	public void synpred4_Tiger_fragment()
	{
		Enter_synpred4_Tiger_fragment();
		EnterRule("synpred4_Tiger_fragment", 45);
		TraceIn("synpred4_Tiger_fragment", 45);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:184:33: ( AMPER AMPER )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:184:34: AMPER AMPER
			{
			DebugLocation(184, 34);
			Match(input,AMPER,Follow._AMPER_in_synpred4_Tiger1140); if (state.failed) return;
			DebugLocation(184, 40);
			Match(input,AMPER,Follow._AMPER_in_synpred4_Tiger1142); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred4_Tiger_fragment", 45);
			LeaveRule("synpred4_Tiger_fragment", 45);
			Leave_synpred4_Tiger_fragment();
		}
	}
	// $ANTLR end synpred4_Tiger

	partial void Enter_synpred5_Tiger_fragment();
	partial void Leave_synpred5_Tiger_fragment();

	// $ANTLR start synpred5_Tiger
	public void synpred5_Tiger_fragment()
	{
		Enter_synpred5_Tiger_fragment();
		EnterRule("synpred5_Tiger_fragment", 46);
		TraceIn("synpred5_Tiger_fragment", 46);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:194:29: ( comp_op )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:194:30: comp_op
			{
			DebugLocation(194, 30);
			PushFollow(Follow._comp_op_in_synpred5_Tiger1217);
			comp_op();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred5_Tiger_fragment", 46);
			LeaveRule("synpred5_Tiger_fragment", 46);
			Leave_synpred5_Tiger_fragment();
		}
	}
	// $ANTLR end synpred5_Tiger

	partial void Enter_synpred6_Tiger_fragment();
	partial void Leave_synpred6_Tiger_fragment();

	// $ANTLR start synpred6_Tiger
	public void synpred6_Tiger_fragment()
	{
		Enter_synpred6_Tiger_fragment();
		EnterRule("synpred6_Tiger_fragment", 47);
		TraceIn("synpred6_Tiger_fragment", 47);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:209:29: ( PLUS | MINUS )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:
			{
			DebugLocation(209, 29);
			if ((input.LA(1)>=PLUS && input.LA(1)<=MINUS))
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("synpred6_Tiger_fragment", 47);
			LeaveRule("synpred6_Tiger_fragment", 47);
			Leave_synpred6_Tiger_fragment();
		}
	}
	// $ANTLR end synpred6_Tiger

	partial void Enter_synpred7_Tiger_fragment();
	partial void Leave_synpred7_Tiger_fragment();

	// $ANTLR start synpred7_Tiger
	public void synpred7_Tiger_fragment()
	{
		Enter_synpred7_Tiger_fragment();
		EnterRule("synpred7_Tiger_fragment", 48);
		TraceIn("synpred7_Tiger_fragment", 48);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:213:31: ( mult_op )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:213:32: mult_op
			{
			DebugLocation(213, 32);
			PushFollow(Follow._mult_op_in_synpred7_Tiger1373);
			mult_op();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred7_Tiger_fragment", 48);
			LeaveRule("synpred7_Tiger_fragment", 48);
			Leave_synpred7_Tiger_fragment();
		}
	}
	// $ANTLR end synpred7_Tiger

	partial void Enter_synpred8_Tiger_fragment();
	partial void Leave_synpred8_Tiger_fragment();

	// $ANTLR start synpred8_Tiger
	public void synpred8_Tiger_fragment()
	{
		Enter_synpred8_Tiger_fragment();
		EnterRule("synpred8_Tiger_fragment", 49);
		TraceIn("synpred8_Tiger_fragment", 49);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:234:15: ( LBRACK | DOT )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:
			{
			DebugLocation(234, 15);
			if (input.LA(1)==LBRACK||input.LA(1)==DOT)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("synpred8_Tiger_fragment", 49);
			LeaveRule("synpred8_Tiger_fragment", 49);
			Leave_synpred8_Tiger_fragment();
		}
	}
	// $ANTLR end synpred8_Tiger

	partial void Enter_synpred9_Tiger_fragment();
	partial void Leave_synpred9_Tiger_fragment();

	// $ANTLR start synpred9_Tiger
	public void synpred9_Tiger_fragment()
	{
		Enter_synpred9_Tiger_fragment();
		EnterRule("synpred9_Tiger_fragment", 50);
		TraceIn("synpred9_Tiger_fragment", 50);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:240:7: ( LBRACK program RBRACK 'of' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:240:8: LBRACK program RBRACK 'of'
			{
			DebugLocation(240, 8);
			Match(input,LBRACK,Follow._LBRACK_in_synpred9_Tiger1595); if (state.failed) return;
			DebugLocation(240, 15);
			PushFollow(Follow._program_in_synpred9_Tiger1597);
			program();
			PopFollow();
			if (state.failed) return;
			DebugLocation(240, 23);
			Match(input,RBRACK,Follow._RBRACK_in_synpred9_Tiger1599); if (state.failed) return;
			DebugLocation(240, 30);
			Match(input,60,Follow._60_in_synpred9_Tiger1601); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred9_Tiger_fragment", 50);
			LeaveRule("synpred9_Tiger_fragment", 50);
			Leave_synpred9_Tiger_fragment();
		}
	}
	// $ANTLR end synpred9_Tiger

	partial void Enter_synpred10_Tiger_fragment();
	partial void Leave_synpred10_Tiger_fragment();

	// $ANTLR start synpred10_Tiger
	public void synpred10_Tiger_fragment()
	{
		Enter_synpred10_Tiger_fragment();
		EnterRule("synpred10_Tiger_fragment", 51);
		TraceIn("synpred10_Tiger_fragment", 51);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:246:4: ( LPAREN type_reference RPAREN )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:246:5: LPAREN type_reference RPAREN
			{
			DebugLocation(246, 5);
			Match(input,LPAREN,Follow._LPAREN_in_synpred10_Tiger1699); if (state.failed) return;
			DebugLocation(246, 12);
			PushFollow(Follow._type_reference_in_synpred10_Tiger1701);
			type_reference();
			PopFollow();
			if (state.failed) return;
			DebugLocation(246, 27);
			Match(input,RPAREN,Follow._RPAREN_in_synpred10_Tiger1703); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred10_Tiger_fragment", 51);
			LeaveRule("synpred10_Tiger_fragment", 51);
			Leave_synpred10_Tiger_fragment();
		}
	}
	// $ANTLR end synpred10_Tiger

	partial void Enter_synpred11_Tiger_fragment();
	partial void Leave_synpred11_Tiger_fragment();

	// $ANTLR start synpred11_Tiger
	public void synpred11_Tiger_fragment()
	{
		Enter_synpred11_Tiger_fragment();
		EnterRule("synpred11_Tiger_fragment", 52);
		TraceIn("synpred11_Tiger_fragment", 52);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:5: ( PERCENT )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:6: PERCENT
			{
			DebugLocation(263, 6);
			Match(input,PERCENT,Follow._PERCENT_in_synpred11_Tiger1849); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred11_Tiger_fragment", 52);
			LeaveRule("synpred11_Tiger_fragment", 52);
			Leave_synpred11_Tiger_fragment();
		}
	}
	// $ANTLR end synpred11_Tiger

	partial void Enter_synpred12_Tiger_fragment();
	partial void Leave_synpred12_Tiger_fragment();

	// $ANTLR start synpred12_Tiger
	public void synpred12_Tiger_fragment()
	{
		Enter_synpred12_Tiger_fragment();
		EnterRule("synpred12_Tiger_fragment", 53);
		TraceIn("synpred12_Tiger_fragment", 53);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:27: ( LPAREN )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:263:28: LPAREN
			{
			DebugLocation(263, 28);
			Match(input,LPAREN,Follow._LPAREN_in_synpred12_Tiger1858); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred12_Tiger_fragment", 53);
			LeaveRule("synpred12_Tiger_fragment", 53);
			Leave_synpred12_Tiger_fragment();
		}
	}
	// $ANTLR end synpred12_Tiger
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA1 dfa1;
	DFA34 dfa34;
	DFA33 dfa33;
	DFA37 dfa37;
	DFA36 dfa36;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this );
		dfa34 = new DFA34( this, SpecialStateTransition34 );
		dfa33 = new DFA33( this, SpecialStateTransition33 );
		dfa37 = new DFA37( this, SpecialStateTransition37 );
		dfa36 = new DFA36( this, SpecialStateTransition36 );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\xB\xFFFF";
		private const string DFA1_eofS =
			"\xB\xFFFF";
		private const string DFA1_minS =
			"\x1\x5\x2\xFFFF\x1\x10\x4\xFFFF\x1\xB\x2\xFFFF";
		private const string DFA1_maxS =
			"\x1\x38\x2\xFFFF\x1\x10\x4\xFFFF\x1\x31\x2\xFFFF";
		private const string DFA1_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\xFFFF\x1\x4\x1\x5\x1\x7\x1\x8\x1\xFFFF\x1\x3"+
			"\x1\x6";
		private const string DFA1_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x6\x1\xFFFF\x1\x4\x25\xFFFF\x1\x7\x2\xFFFF\x1\x3\x2\xFFFF\x1\x1"+
				"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x5",
				"",
				"",
				"\x1\x8",
				"",
				"",
				"",
				"",
				"\x1\x9\x25\xFFFF\x1\xA",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "36:1: expr_stmt returns [Expression expression] : (i= if_stmt | w= while_stmt | f= for_stmt | list= curly_list_stmt | let= let_stmt | fi= for_in_stmt | arr= array_init | match= match_stmt );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA34 : DFA
	{
		private const string DFA34_eotS =
			"\x14\xFFFF";
		private const string DFA34_eofS =
			"\x14\xFFFF";
		private const string DFA34_minS =
			"\x1\x5\x10\xFFFF\x1\x0\x2\xFFFF";
		private const string DFA34_maxS =
			"\x1\x45\x10\xFFFF\x1\x0\x2\xFFFF";
		private const string DFA34_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x7\xFFFF\x1\x3\x7\xFFFF\x1\x4\x1\x5";
		private const string DFA34_specialS =
			"\x11\xFFFF\x1\x0\x2\xFFFF}>";
		private static readonly string[] DFA34_transitionS =
			{
				"\x1\xA\x1\xFFFF\x1\xA\x6\xFFFF\x1\x11\x1\xFFFF\x1\x1\xD\xFFFF\x2\x2"+
				"\xD\xFFFF\x1\xA\x2\xFFFF\x1\xA\x2\xFFFF\x1\xA\x2\xFFFF\x1\xA\x1\xFFFF"+
				"\x1\xA\x7\xFFFF\x6\x2",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA34_eot = DFA.UnpackEncodedString(DFA34_eotS);
		private static readonly short[] DFA34_eof = DFA.UnpackEncodedString(DFA34_eofS);
		private static readonly char[] DFA34_min = DFA.UnpackEncodedStringToUnsignedChars(DFA34_minS);
		private static readonly char[] DFA34_max = DFA.UnpackEncodedStringToUnsignedChars(DFA34_maxS);
		private static readonly short[] DFA34_accept = DFA.UnpackEncodedString(DFA34_acceptS);
		private static readonly short[] DFA34_special = DFA.UnpackEncodedString(DFA34_specialS);
		private static readonly short[][] DFA34_transition;

		static DFA34()
		{
			int numStates = DFA34_transitionS.Length;
			DFA34_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA34_transition[i] = DFA.UnpackEncodedString(DFA34_transitionS[i]);
			}
		}

		public DFA34( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 34;
			this.eot = DFA34_eot;
			this.eof = DFA34_eof;
			this.min = DFA34_min;
			this.max = DFA34_max;
			this.accept = DFA34_accept;
			this.special = DFA34_special;
			this.transition = DFA34_transition;
		}

		public override string Description { get { return "237:1: atom returns [Expression expression] : (name= identifier ( LCURLY fields= memberinitlist RCURLY | ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program | (t= ASSIGN e1= program )? | LPAREN (args= program_list_comma )? RPAREN ) | e= literal | e= expr_stmt | ( LPAREN type_reference RPAREN )=>t= LPAREN cast= type_reference RPAREN ex= program | LPAREN p= program RPAREN );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition34(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA34_17 = input.LA(1);


				int index34_17 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred10_Tiger_fragment)) ) {s = 18;}

				else if ( (true) ) {s = 19;}


				input.Seek(index34_17);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 34, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA33 : DFA
	{
		private const string DFA33_eotS =
			"\x27\xFFFF";
		private const string DFA33_eofS =
			"\x1\x3\x26\xFFFF";
		private const string DFA33_minS =
			"\x1\x4\x1\xFFFF\x1\x0\x24\xFFFF";
		private const string DFA33_maxS =
			"\x1\x3E\x1\xFFFF\x1\x0\x24\xFFFF";
		private const string DFA33_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x21\xFFFF\x1\x4\x1\x2";
		private const string DFA33_specialS =
			"\x2\xFFFF\x1\x0\x24\xFFFF}>";
		private static readonly string[] DFA33_transitionS =
			{
				"\x1\x3\x1\x2\x1\x3\x1\x1\x5\x3\x1\xFFFF\x1\x25\x1\x3\x1\xFFFF\xD\x3"+
				"\x2\xFFFF\x1\x3\xD\xFFFF\x2\x3\x1\xFFFF\x2\x3\x1\xFFFF\x2\x3\x1\xFFFF"+
				"\x1\x3\x1\xFFFF\x2\x3\x2\xFFFF\x2\x3",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
		private static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
		private static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
		private static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
		private static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
		private static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
		private static readonly short[][] DFA33_transition;

		static DFA33()
		{
			int numStates = DFA33_transitionS.Length;
			DFA33_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA33_transition[i] = DFA.UnpackEncodedString(DFA33_transitionS[i]);
			}
		}

		public DFA33( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 33;
			this.eot = DFA33_eot;
			this.eof = DFA33_eof;
			this.min = DFA33_min;
			this.max = DFA33_max;
			this.accept = DFA33_accept;
			this.special = DFA33_special;
			this.transition = DFA33_transition;
		}

		public override string Description { get { return "239:20: ( LCURLY fields= memberinitlist RCURLY | ( LBRACK program RBRACK 'of' )=> LBRACK lenght= program RBRACK 'of' init= program | (t= ASSIGN e1= program )? | LPAREN (args= program_list_comma )? RPAREN )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition33(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA33_2 = input.LA(1);


				int index33_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred9_Tiger_fragment)) ) {s = 38;}

				else if ( (true) ) {s = 3;}


				input.Seek(index33_2);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 33, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA37 : DFA
	{
		private const string DFA37_eotS =
			"\x24\xFFFF";
		private const string DFA37_eofS =
			"\x1\x2\x23\xFFFF";
		private const string DFA37_minS =
			"\x1\x4\x1\x0\x22\xFFFF";
		private const string DFA37_maxS =
			"\x1\x3E\x1\x0\x22\xFFFF";
		private const string DFA37_acceptS =
			"\x2\xFFFF\x1\x2\x20\xFFFF\x1\x1";
		private const string DFA37_specialS =
			"\x1\xFFFF\x1\x0\x22\xFFFF}>";
		private static readonly string[] DFA37_transitionS =
			{
				"\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\xA\x2"+
				"\x1\x1\x2\x2\x2\xFFFF\x1\x2\xD\xFFFF\x2\x2\x1\xFFFF\x2\x2\x1\xFFFF\x2"+
				"\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x2\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA37_eot = DFA.UnpackEncodedString(DFA37_eotS);
		private static readonly short[] DFA37_eof = DFA.UnpackEncodedString(DFA37_eofS);
		private static readonly char[] DFA37_min = DFA.UnpackEncodedStringToUnsignedChars(DFA37_minS);
		private static readonly char[] DFA37_max = DFA.UnpackEncodedStringToUnsignedChars(DFA37_maxS);
		private static readonly short[] DFA37_accept = DFA.UnpackEncodedString(DFA37_acceptS);
		private static readonly short[] DFA37_special = DFA.UnpackEncodedString(DFA37_specialS);
		private static readonly short[][] DFA37_transition;

		static DFA37()
		{
			int numStates = DFA37_transitionS.Length;
			DFA37_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA37_transition[i] = DFA.UnpackEncodedString(DFA37_transitionS[i]);
			}
		}

		public DFA37( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 37;
			this.eot = DFA37_eot;
			this.eof = DFA37_eof;
			this.min = DFA37_min;
			this.max = DFA37_max;
			this.accept = DFA37_accept;
			this.special = DFA37_special;
			this.transition = DFA37_transition;
		}

		public override string Description { get { return "263:4: ( ( PERCENT )=> PERCENT ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program ) )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition37(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA37_1 = input.LA(1);


				int index37_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred11_Tiger_fragment)) ) {s = 35;}

				else if ( (true) ) {s = 2;}


				input.Seek(index37_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 37, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA36 : DFA
	{
		private const string DFA36_eotS =
			"\x16\xFFFF";
		private const string DFA36_eofS =
			"\x16\xFFFF";
		private const string DFA36_minS =
			"\x1\x5\x1\x0\x14\xFFFF";
		private const string DFA36_maxS =
			"\x1\x45\x1\x0\x14\xFFFF";
		private const string DFA36_acceptS =
			"\x2\xFFFF\x1\x2\x12\xFFFF\x1\x1";
		private const string DFA36_specialS =
			"\x1\xFFFF\x1\x0\x14\xFFFF}>";
		private static readonly string[] DFA36_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x1\x1\xFFFF\x1\x2\x6\xFFFF\x2\x2"+
				"\x5\xFFFF\x2\x2\xD\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2\xFFFF"+
				"\x1\x2\x1\xFFFF\x1\x2\x6\xFFFF\x7\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA36_eot = DFA.UnpackEncodedString(DFA36_eotS);
		private static readonly short[] DFA36_eof = DFA.UnpackEncodedString(DFA36_eofS);
		private static readonly char[] DFA36_min = DFA.UnpackEncodedStringToUnsignedChars(DFA36_minS);
		private static readonly char[] DFA36_max = DFA.UnpackEncodedStringToUnsignedChars(DFA36_maxS);
		private static readonly short[] DFA36_accept = DFA.UnpackEncodedString(DFA36_acceptS);
		private static readonly short[] DFA36_special = DFA.UnpackEncodedString(DFA36_specialS);
		private static readonly short[][] DFA36_transition;

		static DFA36()
		{
			int numStates = DFA36_transitionS.Length;
			DFA36_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA36_transition[i] = DFA.UnpackEncodedString(DFA36_transitionS[i]);
			}
		}

		public DFA36( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 36;
			this.eot = DFA36_eot;
			this.eof = DFA36_eof;
			this.min = DFA36_min;
			this.max = DFA36_max;
			this.accept = DFA36_accept;
			this.special = DFA36_special;
			this.transition = DFA36_transition;
		}

		public override string Description { get { return "263:26: ( ( LPAREN )=> LPAREN args= program_list_comma RPAREN | e= program )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition36(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA36_1 = input.LA(1);


				int index36_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred12_Tiger_fragment)) ) {s = 21;}

				else if ( (true) ) {s = 2;}


				input.Seek(index36_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 36, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _test_in_program64 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_parse90 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_parse92 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if_stmt_in_expr_stmt109 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _while_stmt_in_expr_stmt119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _for_stmt_in_expr_stmt129 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _curly_list_stmt_in_expr_stmt138 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _let_stmt_in_expr_stmt147 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _for_in_stmt_in_expr_stmt156 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_init_in_expr_stmt165 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _match_stmt_in_expr_stmt174 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _45_in_match_stmt201 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_match_stmt205 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_match_stmt207 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _guard_in_match_stmt218 = new BitSet(new ulong[]{0x12UL});
		public static readonly BitSet _VBAR_in_guard247 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_guard251 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_guard253 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_guard257 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _48_in_for_in_stmt278 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _identifier_in_for_in_stmt282 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _49_in_for_in_stmt284 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_for_in_stmt288 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_for_in_stmt290 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_for_in_stmt294 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LBRACK_in_array_init315 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_array_init319 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _RBRACK_in_array_init321 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCURLY_in_curly_list_stmt348 = new BitSet(new ulong[]{0x81492000C18143A0UL,0x3FUL});
		public static readonly BitSet _program_in_curly_list_stmt353 = new BitSet(new ulong[]{0x300UL});
		public static readonly BitSet _SEMI_in_curly_list_stmt358 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_curly_list_stmt362 = new BitSet(new ulong[]{0x300UL});
		public static readonly BitSet _SEMI_in_curly_list_stmt370 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _RCURLY_in_curly_list_stmt373 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_root_list_semi401 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _SEMI_in_root_list_semi406 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_root_list_semi410 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _program_in_program_list_comma450 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _COMMA_in_program_list_comma455 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_program_list_comma459 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _51_in_if_stmt485 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _test_in_if_stmt489 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _52_in_if_stmt491 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_if_stmt495 = new BitSet(new ulong[]{0x20000000000002UL});
		public static readonly BitSet _53_in_if_stmt508 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_if_stmt512 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _54_in_while_stmt553 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _test_in_while_stmt557 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_while_stmt559 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_while_stmt563 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _48_in_for_stmt593 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _identifier_in_for_stmt597 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _ASSIGN_in_for_stmt599 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_for_stmt603 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _55_in_for_stmt605 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_for_stmt609 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _50_in_for_stmt611 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_for_stmt615 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _56_in_let_stmt644 = new BitSet(new ulong[]{0x6402000000000000UL});
		public static readonly BitSet _type_declaration_in_let_stmt651 = new BitSet(new ulong[]{0x6402000000000000UL});
		public static readonly BitSet _variable_declaration_in_let_stmt660 = new BitSet(new ulong[]{0x6402000000000000UL});
		public static readonly BitSet _func_definition_in_let_stmt669 = new BitSet(new ulong[]{0x6402000000000000UL});
		public static readonly BitSet _49_in_let_stmt677 = new BitSet(new ulong[]{0x83492000C18141A0UL,0x3FUL});
		public static readonly BitSet _root_list_semi_in_let_stmt681 = new BitSet(new ulong[]{0x200000000000100UL});
		public static readonly BitSet _SEMI_in_let_stmt683 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _57_in_let_stmt686 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _58_in_type_declaration705 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _type_identifier_in_type_declaration709 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _EQUAL_in_type_declaration711 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _LCURLY_in_type_declaration718 = new BitSet(new ulong[]{0x10200UL});
		public static readonly BitSet _fieldList_in_type_declaration722 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _RCURLY_in_type_declaration724 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _59_in_type_declaration733 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_type_declaration735 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_type_declaration739 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_reference_in_type_declaration750 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_in_field776 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _COLON_in_field778 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_field782 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _field_in_fieldList811 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _COMMA_in_fieldList816 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _field_in_fieldList820 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _61_in_variable_declaration855 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _member_identifier_in_variable_declaration859 = new BitSet(new ulong[]{0x2800UL});
		public static readonly BitSet _COLON_in_variable_declaration862 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_variable_declaration866 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _ASSIGN_in_variable_declaration872 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_variable_declaration876 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _62_in_func_definition903 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _identifier_in_func_definition907 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _LPAREN_in_func_definition909 = new BitSet(new ulong[]{0x18000UL});
		public static readonly BitSet _func_parameter_list_in_func_definition913 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_func_definition915 = new BitSet(new ulong[]{0x3000UL});
		public static readonly BitSet _COLON_in_func_definition918 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_func_definition922 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _EQUAL_in_func_definition928 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_func_definition932 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_in_func_parameter_list960 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _COLON_in_func_parameter_list962 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_func_parameter_list966 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _COMMA_in_func_parameter_list974 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _identifier_in_func_parameter_list978 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _COLON_in_func_parameter_list980 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_func_parameter_list984 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _NAME_in_identifier1008 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NAME_in_member_identifier1028 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NAME_in_type_identifier1048 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NAME_in_type_reference1067 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_test_in_test1090 = new BitSet(new ulong[]{0x12UL});
		public static readonly BitSet _VBAR_in_test1102 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _VBAR_in_test1104 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _and_test_in_test1108 = new BitSet(new ulong[]{0x12UL});
		public static readonly BitSet _not_test_in_and_test1134 = new BitSet(new ulong[]{0x20002UL});
		public static readonly BitSet _AMPER_in_and_test1146 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _AMPER_in_and_test1148 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _not_test_in_and_test1152 = new BitSet(new ulong[]{0x20002UL});
		public static readonly BitSet _63_in_not_test1179 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _not_test_in_not_test1183 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _comparison_in_not_test1193 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_comparison1211 = new BitSet(new ulong[]{0x7C1002UL});
		public static readonly BitSet _comp_op_in_comparison1224 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _expr_in_comparison1228 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_in_comp_op1254 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _GREATER_in_comp_op1263 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_in_comp_op1272 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _GREATEREQUAL_in_comp_op1281 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESSEQUAL_in_comp_op1290 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOTEQUAL_in_comp_op1299 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_expr1323 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _PLUS_in_expr1336 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _MINUS_in_expr1338 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _term_in_expr1345 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _factor_in_term1367 = new BitSet(new ulong[]{0x1E000002UL});
		public static readonly BitSet _mult_op_in_term1379 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _factor_in_term1383 = new BitSet(new ulong[]{0x1E000002UL});
		public static readonly BitSet _PLUS_in_factor1403 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _factor_in_factor1407 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_factor1416 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _factor_in_factor1420 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _power_in_factor1430 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STAR_in_mult_op1448 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SLASH_in_mult_op1456 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PERCENT_in_mult_op1464 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOUBLESLASH_in_mult_op1472 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _power_base_in_power1493 = new BitSet(new ulong[]{0x20000002UL});
		public static readonly BitSet _DOUBLESTAR_in_power1508 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _factor_in_power1512 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _atom_in_power_base1534 = new BitSet(new ulong[]{0x100000022UL});
		public static readonly BitSet _member_access_in_power_base1546 = new BitSet(new ulong[]{0x100000022UL});
		public static readonly BitSet _identifier_in_atom1574 = new BitSet(new ulong[]{0x48A2UL});
		public static readonly BitSet _LCURLY_in_atom1578 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _memberinitlist_in_atom1582 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _RCURLY_in_atom1584 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LBRACK_in_atom1606 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_atom1610 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _RBRACK_in_atom1612 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_atom1614 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_atom1618 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ASSIGN_in_atom1634 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_atom1638 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LPAREN_in_atom1653 = new BitSet(new ulong[]{0x81492000C181C0A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_atom1658 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_atom1664 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literal_in_atom1681 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_stmt_in_atom1691 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LPAREN_in_atom1710 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_atom1714 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_atom1716 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_atom1720 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LPAREN_in_atom1727 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_atom1731 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_atom1733 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _64_in_literal1752 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _65_in_literal1761 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _66_in_literal1770 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _67_in_literal1779 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _68_in_literal1788 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_literal1797 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_literal1801 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_literal1810 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _stringLiteral_in_literal1821 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_in_stringLiteral1840 = new BitSet(new ulong[]{0x8000002UL});
		public static readonly BitSet _PERCENT_in_stringLiteral1854 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _LPAREN_in_stringLiteral1863 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_stringLiteral1867 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_stringLiteral1869 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_stringLiteral1884 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LBRACK_in_member_access1910 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_member_access1914 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _RBRACK_in_member_access1916 = new BitSet(new ulong[]{0x802UL});
		public static readonly BitSet _ASSIGN_in_member_access1923 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_member_access1927 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOT_in_member_access1936 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _identifier_in_member_access1940 = new BitSet(new ulong[]{0x4802UL});
		public static readonly BitSet _LPAREN_in_member_access1949 = new BitSet(new ulong[]{0x81492000C181C0A0UL,0x3FUL});
		public static readonly BitSet _program_list_comma_in_member_access1954 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_member_access1960 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ASSIGN_in_member_access1976 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_member_access1980 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_in_memberinit2009 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _EQUAL_in_memberinit2011 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_memberinit2015 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberinit_in_memberinitlist2046 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _COMMA_in_memberinitlist2058 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _memberinit_in_memberinitlist2062 = new BitSet(new ulong[]{0x402UL});
		public static readonly BitSet _COMMA_in_memberinitlist2069 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VBAR_in_synpred1_Tiger211 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _53_in_synpred2_Tiger505 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VBAR_in_synpred3_Tiger1096 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _VBAR_in_synpred3_Tiger1098 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _AMPER_in_synpred4_Tiger1140 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _AMPER_in_synpred4_Tiger1142 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _comp_op_in_synpred5_Tiger1217 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred6_Tiger1328 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mult_op_in_synpred7_Tiger1373 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_synpred8_Tiger1537 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LBRACK_in_synpred9_Tiger1595 = new BitSet(new ulong[]{0x81492000C18140A0UL,0x3FUL});
		public static readonly BitSet _program_in_synpred9_Tiger1597 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _RBRACK_in_synpred9_Tiger1599 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_synpred9_Tiger1601 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LPAREN_in_synpred10_Tiger1699 = new BitSet(new ulong[]{0x800000000010080UL});
		public static readonly BitSet _type_reference_in_synpred10_Tiger1701 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _RPAREN_in_synpred10_Tiger1703 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PERCENT_in_synpred11_Tiger1849 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LPAREN_in_synpred12_Tiger1858 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace Tiger.Build.Compiler.Parsing
