// $ANTLR 3.3 Nov 30, 2010 12:45:30 E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g 2012-03-19 18:43:03

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


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
public partial class TigerLexer : Antlr.Runtime.Lexer
{
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
	int HIDDEN=Hidden;

    // delegates
    // delegators

	public TigerLexer()
	{
		OnCreated();
	}

	public TigerLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public TigerLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_T__45();
	partial void Leave_T__45();

	// $ANTLR start "T__45"
	[GrammarRule("T__45")]
	private void mT__45()
	{
		Enter_T__45();
		EnterRule("T__45", 1);
		TraceIn("T__45", 1);
		try
		{
			int _type = T__45;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:10:7: ( 'match' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:10:9: 'match'
			{
			DebugLocation(10, 9);
			Match("match"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__45", 1);
			LeaveRule("T__45", 1);
			Leave_T__45();
		}
	}
	// $ANTLR end "T__45"

	partial void Enter_T__46();
	partial void Leave_T__46();

	// $ANTLR start "T__46"
	[GrammarRule("T__46")]
	private void mT__46()
	{
		Enter_T__46();
		EnterRule("T__46", 2);
		TraceIn("T__46", 2);
		try
		{
			int _type = T__46;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:11:7: ( 'with' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:11:9: 'with'
			{
			DebugLocation(11, 9);
			Match("with"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__46", 2);
			LeaveRule("T__46", 2);
			Leave_T__46();
		}
	}
	// $ANTLR end "T__46"

	partial void Enter_T__47();
	partial void Leave_T__47();

	// $ANTLR start "T__47"
	[GrammarRule("T__47")]
	private void mT__47()
	{
		Enter_T__47();
		EnterRule("T__47", 3);
		TraceIn("T__47", 3);
		try
		{
			int _type = T__47;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:12:7: ( '->' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:12:9: '->'
			{
			DebugLocation(12, 9);
			Match("->"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__47", 3);
			LeaveRule("T__47", 3);
			Leave_T__47();
		}
	}
	// $ANTLR end "T__47"

	partial void Enter_T__48();
	partial void Leave_T__48();

	// $ANTLR start "T__48"
	[GrammarRule("T__48")]
	private void mT__48()
	{
		Enter_T__48();
		EnterRule("T__48", 4);
		TraceIn("T__48", 4);
		try
		{
			int _type = T__48;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:13:7: ( 'for' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:13:9: 'for'
			{
			DebugLocation(13, 9);
			Match("for"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__48", 4);
			LeaveRule("T__48", 4);
			Leave_T__48();
		}
	}
	// $ANTLR end "T__48"

	partial void Enter_T__49();
	partial void Leave_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		Enter_T__49();
		EnterRule("T__49", 5);
		TraceIn("T__49", 5);
		try
		{
			int _type = T__49;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:14:7: ( 'in' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:14:9: 'in'
			{
			DebugLocation(14, 9);
			Match("in"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__49", 5);
			LeaveRule("T__49", 5);
			Leave_T__49();
		}
	}
	// $ANTLR end "T__49"

	partial void Enter_T__50();
	partial void Leave_T__50();

	// $ANTLR start "T__50"
	[GrammarRule("T__50")]
	private void mT__50()
	{
		Enter_T__50();
		EnterRule("T__50", 6);
		TraceIn("T__50", 6);
		try
		{
			int _type = T__50;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:15:7: ( 'do' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:15:9: 'do'
			{
			DebugLocation(15, 9);
			Match("do"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__50", 6);
			LeaveRule("T__50", 6);
			Leave_T__50();
		}
	}
	// $ANTLR end "T__50"

	partial void Enter_T__51();
	partial void Leave_T__51();

	// $ANTLR start "T__51"
	[GrammarRule("T__51")]
	private void mT__51()
	{
		Enter_T__51();
		EnterRule("T__51", 7);
		TraceIn("T__51", 7);
		try
		{
			int _type = T__51;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:16:7: ( 'if' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:16:9: 'if'
			{
			DebugLocation(16, 9);
			Match("if"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__51", 7);
			LeaveRule("T__51", 7);
			Leave_T__51();
		}
	}
	// $ANTLR end "T__51"

	partial void Enter_T__52();
	partial void Leave_T__52();

	// $ANTLR start "T__52"
	[GrammarRule("T__52")]
	private void mT__52()
	{
		Enter_T__52();
		EnterRule("T__52", 8);
		TraceIn("T__52", 8);
		try
		{
			int _type = T__52;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:17:7: ( 'then' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:17:9: 'then'
			{
			DebugLocation(17, 9);
			Match("then"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__52", 8);
			LeaveRule("T__52", 8);
			Leave_T__52();
		}
	}
	// $ANTLR end "T__52"

	partial void Enter_T__53();
	partial void Leave_T__53();

	// $ANTLR start "T__53"
	[GrammarRule("T__53")]
	private void mT__53()
	{
		Enter_T__53();
		EnterRule("T__53", 9);
		TraceIn("T__53", 9);
		try
		{
			int _type = T__53;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:18:7: ( 'else' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:18:9: 'else'
			{
			DebugLocation(18, 9);
			Match("else"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__53", 9);
			LeaveRule("T__53", 9);
			Leave_T__53();
		}
	}
	// $ANTLR end "T__53"

	partial void Enter_T__54();
	partial void Leave_T__54();

	// $ANTLR start "T__54"
	[GrammarRule("T__54")]
	private void mT__54()
	{
		Enter_T__54();
		EnterRule("T__54", 10);
		TraceIn("T__54", 10);
		try
		{
			int _type = T__54;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:19:7: ( 'while' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:19:9: 'while'
			{
			DebugLocation(19, 9);
			Match("while"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__54", 10);
			LeaveRule("T__54", 10);
			Leave_T__54();
		}
	}
	// $ANTLR end "T__54"

	partial void Enter_T__55();
	partial void Leave_T__55();

	// $ANTLR start "T__55"
	[GrammarRule("T__55")]
	private void mT__55()
	{
		Enter_T__55();
		EnterRule("T__55", 11);
		TraceIn("T__55", 11);
		try
		{
			int _type = T__55;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:20:7: ( 'to' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:20:9: 'to'
			{
			DebugLocation(20, 9);
			Match("to"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__55", 11);
			LeaveRule("T__55", 11);
			Leave_T__55();
		}
	}
	// $ANTLR end "T__55"

	partial void Enter_T__56();
	partial void Leave_T__56();

	// $ANTLR start "T__56"
	[GrammarRule("T__56")]
	private void mT__56()
	{
		Enter_T__56();
		EnterRule("T__56", 12);
		TraceIn("T__56", 12);
		try
		{
			int _type = T__56;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:21:7: ( 'let' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:21:9: 'let'
			{
			DebugLocation(21, 9);
			Match("let"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__56", 12);
			LeaveRule("T__56", 12);
			Leave_T__56();
		}
	}
	// $ANTLR end "T__56"

	partial void Enter_T__57();
	partial void Leave_T__57();

	// $ANTLR start "T__57"
	[GrammarRule("T__57")]
	private void mT__57()
	{
		Enter_T__57();
		EnterRule("T__57", 13);
		TraceIn("T__57", 13);
		try
		{
			int _type = T__57;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:22:7: ( 'end' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:22:9: 'end'
			{
			DebugLocation(22, 9);
			Match("end"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__57", 13);
			LeaveRule("T__57", 13);
			Leave_T__57();
		}
	}
	// $ANTLR end "T__57"

	partial void Enter_T__58();
	partial void Leave_T__58();

	// $ANTLR start "T__58"
	[GrammarRule("T__58")]
	private void mT__58()
	{
		Enter_T__58();
		EnterRule("T__58", 14);
		TraceIn("T__58", 14);
		try
		{
			int _type = T__58;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:23:7: ( 'type' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:23:9: 'type'
			{
			DebugLocation(23, 9);
			Match("type"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__58", 14);
			LeaveRule("T__58", 14);
			Leave_T__58();
		}
	}
	// $ANTLR end "T__58"

	partial void Enter_T__59();
	partial void Leave_T__59();

	// $ANTLR start "T__59"
	[GrammarRule("T__59")]
	private void mT__59()
	{
		Enter_T__59();
		EnterRule("T__59", 15);
		TraceIn("T__59", 15);
		try
		{
			int _type = T__59;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:24:7: ( 'array' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:24:9: 'array'
			{
			DebugLocation(24, 9);
			Match("array"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__59", 15);
			LeaveRule("T__59", 15);
			Leave_T__59();
		}
	}
	// $ANTLR end "T__59"

	partial void Enter_T__60();
	partial void Leave_T__60();

	// $ANTLR start "T__60"
	[GrammarRule("T__60")]
	private void mT__60()
	{
		Enter_T__60();
		EnterRule("T__60", 16);
		TraceIn("T__60", 16);
		try
		{
			int _type = T__60;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:25:7: ( 'of' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:25:9: 'of'
			{
			DebugLocation(25, 9);
			Match("of"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__60", 16);
			LeaveRule("T__60", 16);
			Leave_T__60();
		}
	}
	// $ANTLR end "T__60"

	partial void Enter_T__61();
	partial void Leave_T__61();

	// $ANTLR start "T__61"
	[GrammarRule("T__61")]
	private void mT__61()
	{
		Enter_T__61();
		EnterRule("T__61", 17);
		TraceIn("T__61", 17);
		try
		{
			int _type = T__61;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:26:7: ( 'var' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:26:9: 'var'
			{
			DebugLocation(26, 9);
			Match("var"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__61", 17);
			LeaveRule("T__61", 17);
			Leave_T__61();
		}
	}
	// $ANTLR end "T__61"

	partial void Enter_T__62();
	partial void Leave_T__62();

	// $ANTLR start "T__62"
	[GrammarRule("T__62")]
	private void mT__62()
	{
		Enter_T__62();
		EnterRule("T__62", 18);
		TraceIn("T__62", 18);
		try
		{
			int _type = T__62;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:27:7: ( 'function' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:27:9: 'function'
			{
			DebugLocation(27, 9);
			Match("function"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__62", 18);
			LeaveRule("T__62", 18);
			Leave_T__62();
		}
	}
	// $ANTLR end "T__62"

	partial void Enter_T__63();
	partial void Leave_T__63();

	// $ANTLR start "T__63"
	[GrammarRule("T__63")]
	private void mT__63()
	{
		Enter_T__63();
		EnterRule("T__63", 19);
		TraceIn("T__63", 19);
		try
		{
			int _type = T__63;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:28:7: ( 'not' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:28:9: 'not'
			{
			DebugLocation(28, 9);
			Match("not"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__63", 19);
			LeaveRule("T__63", 19);
			Leave_T__63();
		}
	}
	// $ANTLR end "T__63"

	partial void Enter_T__64();
	partial void Leave_T__64();

	// $ANTLR start "T__64"
	[GrammarRule("T__64")]
	private void mT__64()
	{
		Enter_T__64();
		EnterRule("T__64", 20);
		TraceIn("T__64", 20);
		try
		{
			int _type = T__64;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:29:7: ( 'true' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:29:9: 'true'
			{
			DebugLocation(29, 9);
			Match("true"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__64", 20);
			LeaveRule("T__64", 20);
			Leave_T__64();
		}
	}
	// $ANTLR end "T__64"

	partial void Enter_T__65();
	partial void Leave_T__65();

	// $ANTLR start "T__65"
	[GrammarRule("T__65")]
	private void mT__65()
	{
		Enter_T__65();
		EnterRule("T__65", 21);
		TraceIn("T__65", 21);
		try
		{
			int _type = T__65;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:30:7: ( 'false' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:30:9: 'false'
			{
			DebugLocation(30, 9);
			Match("false"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__65", 21);
			LeaveRule("T__65", 21);
			Leave_T__65();
		}
	}
	// $ANTLR end "T__65"

	partial void Enter_T__66();
	partial void Leave_T__66();

	// $ANTLR start "T__66"
	[GrammarRule("T__66")]
	private void mT__66()
	{
		Enter_T__66();
		EnterRule("T__66", 22);
		TraceIn("T__66", 22);
		try
		{
			int _type = T__66;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:31:7: ( 'break' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:31:9: 'break'
			{
			DebugLocation(31, 9);
			Match("break"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__66", 22);
			LeaveRule("T__66", 22);
			Leave_T__66();
		}
	}
	// $ANTLR end "T__66"

	partial void Enter_T__67();
	partial void Leave_T__67();

	// $ANTLR start "T__67"
	[GrammarRule("T__67")]
	private void mT__67()
	{
		Enter_T__67();
		EnterRule("T__67", 23);
		TraceIn("T__67", 23);
		try
		{
			int _type = T__67;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:32:7: ( 'continue' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:32:9: 'continue'
			{
			DebugLocation(32, 9);
			Match("continue"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__67", 23);
			LeaveRule("T__67", 23);
			Leave_T__67();
		}
	}
	// $ANTLR end "T__67"

	partial void Enter_T__68();
	partial void Leave_T__68();

	// $ANTLR start "T__68"
	[GrammarRule("T__68")]
	private void mT__68()
	{
		Enter_T__68();
		EnterRule("T__68", 24);
		TraceIn("T__68", 24);
		try
		{
			int _type = T__68;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:33:7: ( 'nil' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:33:9: 'nil'
			{
			DebugLocation(33, 9);
			Match("nil"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__68", 24);
			LeaveRule("T__68", 24);
			Leave_T__68();
		}
	}
	// $ANTLR end "T__68"

	partial void Enter_T__69();
	partial void Leave_T__69();

	// $ANTLR start "T__69"
	[GrammarRule("T__69")]
	private void mT__69()
	{
		Enter_T__69();
		EnterRule("T__69", 25);
		TraceIn("T__69", 25);
		try
		{
			int _type = T__69;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:34:7: ( 'return' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:34:9: 'return'
			{
			DebugLocation(34, 9);
			Match("return"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__69", 25);
			LeaveRule("T__69", 25);
			Leave_T__69();
		}
	}
	// $ANTLR end "T__69"

	partial void Enter_LPAREN();
	partial void Leave_LPAREN();

	// $ANTLR start "LPAREN"
	[GrammarRule("LPAREN")]
	private void mLPAREN()
	{
		Enter_LPAREN();
		EnterRule("LPAREN", 26);
		TraceIn("LPAREN", 26);
		try
		{
			int _type = LPAREN;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:288:8: ( '(' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:288:10: '('
			{
			DebugLocation(288, 10);
			Match('('); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LPAREN", 26);
			LeaveRule("LPAREN", 26);
			Leave_LPAREN();
		}
	}
	// $ANTLR end "LPAREN"

	partial void Enter_RPAREN();
	partial void Leave_RPAREN();

	// $ANTLR start "RPAREN"
	[GrammarRule("RPAREN")]
	private void mRPAREN()
	{
		Enter_RPAREN();
		EnterRule("RPAREN", 27);
		TraceIn("RPAREN", 27);
		try
		{
			int _type = RPAREN;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:290:8: ( ')' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:290:10: ')'
			{
			DebugLocation(290, 10);
			Match(')'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RPAREN", 27);
			LeaveRule("RPAREN", 27);
			Leave_RPAREN();
		}
	}
	// $ANTLR end "RPAREN"

	partial void Enter_LBRACK();
	partial void Leave_LBRACK();

	// $ANTLR start "LBRACK"
	[GrammarRule("LBRACK")]
	private void mLBRACK()
	{
		Enter_LBRACK();
		EnterRule("LBRACK", 28);
		TraceIn("LBRACK", 28);
		try
		{
			int _type = LBRACK;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:292:8: ( '[' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:292:10: '['
			{
			DebugLocation(292, 10);
			Match('['); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LBRACK", 28);
			LeaveRule("LBRACK", 28);
			Leave_LBRACK();
		}
	}
	// $ANTLR end "LBRACK"

	partial void Enter_RBRACK();
	partial void Leave_RBRACK();

	// $ANTLR start "RBRACK"
	[GrammarRule("RBRACK")]
	private void mRBRACK()
	{
		Enter_RBRACK();
		EnterRule("RBRACK", 29);
		TraceIn("RBRACK", 29);
		try
		{
			int _type = RBRACK;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:294:8: ( ']' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:294:10: ']'
			{
			DebugLocation(294, 10);
			Match(']'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RBRACK", 29);
			LeaveRule("RBRACK", 29);
			Leave_RBRACK();
		}
	}
	// $ANTLR end "RBRACK"

	partial void Enter_LCURLY();
	partial void Leave_LCURLY();

	// $ANTLR start "LCURLY"
	[GrammarRule("LCURLY")]
	private void mLCURLY()
	{
		Enter_LCURLY();
		EnterRule("LCURLY", 30);
		TraceIn("LCURLY", 30);
		try
		{
			int _type = LCURLY;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:296:8: ( '{' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:296:10: '{'
			{
			DebugLocation(296, 10);
			Match('{'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LCURLY", 30);
			LeaveRule("LCURLY", 30);
			Leave_LCURLY();
		}
	}
	// $ANTLR end "LCURLY"

	partial void Enter_RCURLY();
	partial void Leave_RCURLY();

	// $ANTLR start "RCURLY"
	[GrammarRule("RCURLY")]
	private void mRCURLY()
	{
		Enter_RCURLY();
		EnterRule("RCURLY", 31);
		TraceIn("RCURLY", 31);
		try
		{
			int _type = RCURLY;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:298:8: ( '}' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:298:10: '}'
			{
			DebugLocation(298, 10);
			Match('}'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RCURLY", 31);
			LeaveRule("RCURLY", 31);
			Leave_RCURLY();
		}
	}
	// $ANTLR end "RCURLY"

	partial void Enter_COLON();
	partial void Leave_COLON();

	// $ANTLR start "COLON"
	[GrammarRule("COLON")]
	private void mCOLON()
	{
		Enter_COLON();
		EnterRule("COLON", 32);
		TraceIn("COLON", 32);
		try
		{
			int _type = COLON;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:300:8: ( ':' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:300:10: ':'
			{
			DebugLocation(300, 10);
			Match(':'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COLON", 32);
			LeaveRule("COLON", 32);
			Leave_COLON();
		}
	}
	// $ANTLR end "COLON"

	partial void Enter_COMMA();
	partial void Leave_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		Enter_COMMA();
		EnterRule("COMMA", 33);
		TraceIn("COMMA", 33);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:302:7: ( ',' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:302:9: ','
			{
			DebugLocation(302, 9);
			Match(','); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 33);
			LeaveRule("COMMA", 33);
			Leave_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void Enter_SEMI();
	partial void Leave_SEMI();

	// $ANTLR start "SEMI"
	[GrammarRule("SEMI")]
	private void mSEMI()
	{
		Enter_SEMI();
		EnterRule("SEMI", 34);
		TraceIn("SEMI", 34);
		try
		{
			int _type = SEMI;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:304:6: ( ';' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:304:8: ';'
			{
			DebugLocation(304, 8);
			Match(';'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SEMI", 34);
			LeaveRule("SEMI", 34);
			Leave_SEMI();
		}
	}
	// $ANTLR end "SEMI"

	partial void Enter_PLUS();
	partial void Leave_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		Enter_PLUS();
		EnterRule("PLUS", 35);
		TraceIn("PLUS", 35);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:306:6: ( '+' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:306:8: '+'
			{
			DebugLocation(306, 8);
			Match('+'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 35);
			LeaveRule("PLUS", 35);
			Leave_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void Enter_MINUS();
	partial void Leave_MINUS();

	// $ANTLR start "MINUS"
	[GrammarRule("MINUS")]
	private void mMINUS()
	{
		Enter_MINUS();
		EnterRule("MINUS", 36);
		TraceIn("MINUS", 36);
		try
		{
			int _type = MINUS;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:308:7: ( '-' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:308:9: '-'
			{
			DebugLocation(308, 9);
			Match('-'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS", 36);
			LeaveRule("MINUS", 36);
			Leave_MINUS();
		}
	}
	// $ANTLR end "MINUS"

	partial void Enter_STAR();
	partial void Leave_STAR();

	// $ANTLR start "STAR"
	[GrammarRule("STAR")]
	private void mSTAR()
	{
		Enter_STAR();
		EnterRule("STAR", 37);
		TraceIn("STAR", 37);
		try
		{
			int _type = STAR;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:310:6: ( '*' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:310:8: '*'
			{
			DebugLocation(310, 8);
			Match('*'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAR", 37);
			LeaveRule("STAR", 37);
			Leave_STAR();
		}
	}
	// $ANTLR end "STAR"

	partial void Enter_SLASH();
	partial void Leave_SLASH();

	// $ANTLR start "SLASH"
	[GrammarRule("SLASH")]
	private void mSLASH()
	{
		Enter_SLASH();
		EnterRule("SLASH", 38);
		TraceIn("SLASH", 38);
		try
		{
			int _type = SLASH;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:312:7: ( '/' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:312:9: '/'
			{
			DebugLocation(312, 9);
			Match('/'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SLASH", 38);
			LeaveRule("SLASH", 38);
			Leave_SLASH();
		}
	}
	// $ANTLR end "SLASH"

	partial void Enter_VBAR();
	partial void Leave_VBAR();

	// $ANTLR start "VBAR"
	[GrammarRule("VBAR")]
	private void mVBAR()
	{
		Enter_VBAR();
		EnterRule("VBAR", 39);
		TraceIn("VBAR", 39);
		try
		{
			int _type = VBAR;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:314:6: ( '|' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:314:8: '|'
			{
			DebugLocation(314, 8);
			Match('|'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VBAR", 39);
			LeaveRule("VBAR", 39);
			Leave_VBAR();
		}
	}
	// $ANTLR end "VBAR"

	partial void Enter_AMPER();
	partial void Leave_AMPER();

	// $ANTLR start "AMPER"
	[GrammarRule("AMPER")]
	private void mAMPER()
	{
		Enter_AMPER();
		EnterRule("AMPER", 40);
		TraceIn("AMPER", 40);
		try
		{
			int _type = AMPER;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:316:7: ( '&' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:316:9: '&'
			{
			DebugLocation(316, 9);
			Match('&'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AMPER", 40);
			LeaveRule("AMPER", 40);
			Leave_AMPER();
		}
	}
	// $ANTLR end "AMPER"

	partial void Enter_LESS();
	partial void Leave_LESS();

	// $ANTLR start "LESS"
	[GrammarRule("LESS")]
	private void mLESS()
	{
		Enter_LESS();
		EnterRule("LESS", 41);
		TraceIn("LESS", 41);
		try
		{
			int _type = LESS;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:318:6: ( '<' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:318:8: '<'
			{
			DebugLocation(318, 8);
			Match('<'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS", 41);
			LeaveRule("LESS", 41);
			Leave_LESS();
		}
	}
	// $ANTLR end "LESS"

	partial void Enter_GREATER();
	partial void Leave_GREATER();

	// $ANTLR start "GREATER"
	[GrammarRule("GREATER")]
	private void mGREATER()
	{
		Enter_GREATER();
		EnterRule("GREATER", 42);
		TraceIn("GREATER", 42);
		try
		{
			int _type = GREATER;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:320:9: ( '>' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:320:11: '>'
			{
			DebugLocation(320, 11);
			Match('>'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER", 42);
			LeaveRule("GREATER", 42);
			Leave_GREATER();
		}
	}
	// $ANTLR end "GREATER"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 43);
		TraceIn("ASSIGN", 43);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:322:8: ( ':=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:322:10: ':='
			{
			DebugLocation(322, 10);
			Match(":="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 43);
			LeaveRule("ASSIGN", 43);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_PERCENT();
	partial void Leave_PERCENT();

	// $ANTLR start "PERCENT"
	[GrammarRule("PERCENT")]
	private void mPERCENT()
	{
		Enter_PERCENT();
		EnterRule("PERCENT", 44);
		TraceIn("PERCENT", 44);
		try
		{
			int _type = PERCENT;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:324:9: ( '%' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:324:11: '%'
			{
			DebugLocation(324, 11);
			Match('%'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PERCENT", 44);
			LeaveRule("PERCENT", 44);
			Leave_PERCENT();
		}
	}
	// $ANTLR end "PERCENT"

	partial void Enter_EQUAL();
	partial void Leave_EQUAL();

	// $ANTLR start "EQUAL"
	[GrammarRule("EQUAL")]
	private void mEQUAL()
	{
		Enter_EQUAL();
		EnterRule("EQUAL", 45);
		TraceIn("EQUAL", 45);
		try
		{
			int _type = EQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:326:7: ( '=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:326:9: '='
			{
			DebugLocation(326, 9);
			Match('='); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL", 45);
			LeaveRule("EQUAL", 45);
			Leave_EQUAL();
		}
	}
	// $ANTLR end "EQUAL"

	partial void Enter_NOTEQUAL();
	partial void Leave_NOTEQUAL();

	// $ANTLR start "NOTEQUAL"
	[GrammarRule("NOTEQUAL")]
	private void mNOTEQUAL()
	{
		Enter_NOTEQUAL();
		EnterRule("NOTEQUAL", 46);
		TraceIn("NOTEQUAL", 46);
		try
		{
			int _type = NOTEQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:328:10: ( '<>' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:328:12: '<>'
			{
			DebugLocation(328, 12);
			Match("<>"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOTEQUAL", 46);
			LeaveRule("NOTEQUAL", 46);
			Leave_NOTEQUAL();
		}
	}
	// $ANTLR end "NOTEQUAL"

	partial void Enter_LESSEQUAL();
	partial void Leave_LESSEQUAL();

	// $ANTLR start "LESSEQUAL"
	[GrammarRule("LESSEQUAL")]
	private void mLESSEQUAL()
	{
		Enter_LESSEQUAL();
		EnterRule("LESSEQUAL", 47);
		TraceIn("LESSEQUAL", 47);
		try
		{
			int _type = LESSEQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:330:11: ( '<=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:330:13: '<='
			{
			DebugLocation(330, 13);
			Match("<="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESSEQUAL", 47);
			LeaveRule("LESSEQUAL", 47);
			Leave_LESSEQUAL();
		}
	}
	// $ANTLR end "LESSEQUAL"

	partial void Enter_GREATEREQUAL();
	partial void Leave_GREATEREQUAL();

	// $ANTLR start "GREATEREQUAL"
	[GrammarRule("GREATEREQUAL")]
	private void mGREATEREQUAL()
	{
		Enter_GREATEREQUAL();
		EnterRule("GREATEREQUAL", 48);
		TraceIn("GREATEREQUAL", 48);
		try
		{
			int _type = GREATEREQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:332:14: ( '>=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:332:16: '>='
			{
			DebugLocation(332, 16);
			Match(">="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATEREQUAL", 48);
			LeaveRule("GREATEREQUAL", 48);
			Leave_GREATEREQUAL();
		}
	}
	// $ANTLR end "GREATEREQUAL"

	partial void Enter_PLUSEQUAL();
	partial void Leave_PLUSEQUAL();

	// $ANTLR start "PLUSEQUAL"
	[GrammarRule("PLUSEQUAL")]
	private void mPLUSEQUAL()
	{
		Enter_PLUSEQUAL();
		EnterRule("PLUSEQUAL", 49);
		TraceIn("PLUSEQUAL", 49);
		try
		{
			int _type = PLUSEQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:334:11: ( '+=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:334:13: '+='
			{
			DebugLocation(334, 13);
			Match("+="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUSEQUAL", 49);
			LeaveRule("PLUSEQUAL", 49);
			Leave_PLUSEQUAL();
		}
	}
	// $ANTLR end "PLUSEQUAL"

	partial void Enter_MINUSEQUAL();
	partial void Leave_MINUSEQUAL();

	// $ANTLR start "MINUSEQUAL"
	[GrammarRule("MINUSEQUAL")]
	private void mMINUSEQUAL()
	{
		Enter_MINUSEQUAL();
		EnterRule("MINUSEQUAL", 50);
		TraceIn("MINUSEQUAL", 50);
		try
		{
			int _type = MINUSEQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:336:12: ( '-=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:336:14: '-='
			{
			DebugLocation(336, 14);
			Match("-="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUSEQUAL", 50);
			LeaveRule("MINUSEQUAL", 50);
			Leave_MINUSEQUAL();
		}
	}
	// $ANTLR end "MINUSEQUAL"

	partial void Enter_DOUBLESTAR();
	partial void Leave_DOUBLESTAR();

	// $ANTLR start "DOUBLESTAR"
	[GrammarRule("DOUBLESTAR")]
	private void mDOUBLESTAR()
	{
		Enter_DOUBLESTAR();
		EnterRule("DOUBLESTAR", 51);
		TraceIn("DOUBLESTAR", 51);
		try
		{
			int _type = DOUBLESTAR;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:338:12: ( '**' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:338:14: '**'
			{
			DebugLocation(338, 14);
			Match("**"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLESTAR", 51);
			LeaveRule("DOUBLESTAR", 51);
			Leave_DOUBLESTAR();
		}
	}
	// $ANTLR end "DOUBLESTAR"

	partial void Enter_STAREQUAL();
	partial void Leave_STAREQUAL();

	// $ANTLR start "STAREQUAL"
	[GrammarRule("STAREQUAL")]
	private void mSTAREQUAL()
	{
		Enter_STAREQUAL();
		EnterRule("STAREQUAL", 52);
		TraceIn("STAREQUAL", 52);
		try
		{
			int _type = STAREQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:340:11: ( '*=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:340:13: '*='
			{
			DebugLocation(340, 13);
			Match("*="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAREQUAL", 52);
			LeaveRule("STAREQUAL", 52);
			Leave_STAREQUAL();
		}
	}
	// $ANTLR end "STAREQUAL"

	partial void Enter_DOUBLESLASH();
	partial void Leave_DOUBLESLASH();

	// $ANTLR start "DOUBLESLASH"
	[GrammarRule("DOUBLESLASH")]
	private void mDOUBLESLASH()
	{
		Enter_DOUBLESLASH();
		EnterRule("DOUBLESLASH", 53);
		TraceIn("DOUBLESLASH", 53);
		try
		{
			int _type = DOUBLESLASH;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:342:13: ( '//' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:342:15: '//'
			{
			DebugLocation(342, 15);
			Match("//"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLESLASH", 53);
			LeaveRule("DOUBLESLASH", 53);
			Leave_DOUBLESLASH();
		}
	}
	// $ANTLR end "DOUBLESLASH"

	partial void Enter_SLASHEQUAL();
	partial void Leave_SLASHEQUAL();

	// $ANTLR start "SLASHEQUAL"
	[GrammarRule("SLASHEQUAL")]
	private void mSLASHEQUAL()
	{
		Enter_SLASHEQUAL();
		EnterRule("SLASHEQUAL", 54);
		TraceIn("SLASHEQUAL", 54);
		try
		{
			int _type = SLASHEQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:344:12: ( '/=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:344:14: '/='
			{
			DebugLocation(344, 14);
			Match("/="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SLASHEQUAL", 54);
			LeaveRule("SLASHEQUAL", 54);
			Leave_SLASHEQUAL();
		}
	}
	// $ANTLR end "SLASHEQUAL"

	partial void Enter_VBAREQUAL();
	partial void Leave_VBAREQUAL();

	// $ANTLR start "VBAREQUAL"
	[GrammarRule("VBAREQUAL")]
	private void mVBAREQUAL()
	{
		Enter_VBAREQUAL();
		EnterRule("VBAREQUAL", 55);
		TraceIn("VBAREQUAL", 55);
		try
		{
			int _type = VBAREQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:346:11: ( '|=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:346:13: '|='
			{
			DebugLocation(346, 13);
			Match("|="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VBAREQUAL", 55);
			LeaveRule("VBAREQUAL", 55);
			Leave_VBAREQUAL();
		}
	}
	// $ANTLR end "VBAREQUAL"

	partial void Enter_DOUBLESTAREQUAL();
	partial void Leave_DOUBLESTAREQUAL();

	// $ANTLR start "DOUBLESTAREQUAL"
	[GrammarRule("DOUBLESTAREQUAL")]
	private void mDOUBLESTAREQUAL()
	{
		Enter_DOUBLESTAREQUAL();
		EnterRule("DOUBLESTAREQUAL", 56);
		TraceIn("DOUBLESTAREQUAL", 56);
		try
		{
			int _type = DOUBLESTAREQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:348:17: ( '**=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:348:19: '**='
			{
			DebugLocation(348, 19);
			Match("**="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLESTAREQUAL", 56);
			LeaveRule("DOUBLESTAREQUAL", 56);
			Leave_DOUBLESTAREQUAL();
		}
	}
	// $ANTLR end "DOUBLESTAREQUAL"

	partial void Enter_DOUBLESLASHEQUAL();
	partial void Leave_DOUBLESLASHEQUAL();

	// $ANTLR start "DOUBLESLASHEQUAL"
	[GrammarRule("DOUBLESLASHEQUAL")]
	private void mDOUBLESLASHEQUAL()
	{
		Enter_DOUBLESLASHEQUAL();
		EnterRule("DOUBLESLASHEQUAL", 57);
		TraceIn("DOUBLESLASHEQUAL", 57);
		try
		{
			int _type = DOUBLESLASHEQUAL;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:350:18: ( '//=' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:350:20: '//='
			{
			DebugLocation(350, 20);
			Match("//="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLESLASHEQUAL", 57);
			LeaveRule("DOUBLESLASHEQUAL", 57);
			Leave_DOUBLESLASHEQUAL();
		}
	}
	// $ANTLR end "DOUBLESLASHEQUAL"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 58);
		TraceIn("DOT", 58);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:352:5: ( '.' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:352:7: '.'
			{
			DebugLocation(352, 7);
			Match('.'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 58);
			LeaveRule("DOT", 58);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 59);
		TraceIn("INT", 59);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:354:5: ( '0' ( 'x' | 'X' ) ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+ ( 'l' | 'L' )? | '0' ( DIGITS )* | '1' .. '9' ( DIGITS )* )
			int alt5=3;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0=='0'))
			{
				int LA5_1 = input.LA(2);

				if ((LA5_1=='X'||LA5_1=='x'))
				{
					alt5=1;
				}
				else
				{
					alt5=2;}
			}
			else if (((LA5_0>='1' && LA5_0<='9')))
			{
				alt5=3;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:355:9: '0' ( 'x' | 'X' ) ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+ ( 'l' | 'L' )?
				{
				DebugLocation(355, 9);
				Match('0'); if (state.failed) return;
				DebugLocation(355, 13);
				if (input.LA(1)=='X'||input.LA(1)=='x')
				{
					input.Consume();
				state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					Recover(mse);
					throw mse;}

				DebugLocation(355, 25);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:355:25: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+
				int cnt1=0;
				try { DebugEnterSubRule(1);
				while (true)
				{
					int alt1=2;
					try { DebugEnterDecision(1, decisionCanBacktrack[1]);
					int LA1_0 = input.LA(1);

					if (((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='F')||(LA1_0>='a' && LA1_0<='f')))
					{
						alt1=1;
					}


					} finally { DebugExitDecision(1); }
					switch (alt1)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:
						{
						DebugLocation(355, 25);
						if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F')||(input.LA(1)>='a' && input.LA(1)<='f'))
						{
							input.Consume();
						state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							Recover(mse);
							throw mse;}


						}
						break;

					default:
						if (cnt1 >= 1)
							goto loop1;

						if (state.backtracking>0) {state.failed=true; return;}
						EarlyExitException eee1 = new EarlyExitException( 1, input );
						DebugRecognitionException(eee1);
						throw eee1;
					}
					cnt1++;
				}
				loop1:
					;

				} finally { DebugExitSubRule(1); }

				DebugLocation(356, 9);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:356:9: ( 'l' | 'L' )?
				int alt2=2;
				try { DebugEnterSubRule(2);
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='L'||LA2_0=='l'))
				{
					alt2=1;
				}
				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:
					{
					DebugLocation(356, 9);
					if (input.LA(1)=='L'||input.LA(1)=='l')
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				}
				} finally { DebugExitSubRule(2); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:358:9: '0' ( DIGITS )*
				{
				DebugLocation(358, 9);
				Match('0'); if (state.failed) return;
				DebugLocation(358, 13);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:358:13: ( DIGITS )*
				try { DebugEnterSubRule(3);
				while (true)
				{
					int alt3=2;
					try { DebugEnterDecision(3, decisionCanBacktrack[3]);
					int LA3_0 = input.LA(1);

					if (((LA3_0>='0' && LA3_0<='9')))
					{
						alt3=1;
					}


					} finally { DebugExitDecision(3); }
					switch ( alt3 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:358:13: DIGITS
						{
						DebugLocation(358, 13);
						mDIGITS(); if (state.failed) return;

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
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:359:9: '1' .. '9' ( DIGITS )*
				{
				DebugLocation(359, 9);
				MatchRange('1','9'); if (state.failed) return;
				DebugLocation(359, 18);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:359:18: ( DIGITS )*
				try { DebugEnterSubRule(4);
				while (true)
				{
					int alt4=2;
					try { DebugEnterDecision(4, decisionCanBacktrack[4]);
					int LA4_0 = input.LA(1);

					if (((LA4_0>='0' && LA4_0<='9')))
					{
						alt4=1;
					}


					} finally { DebugExitDecision(4); }
					switch ( alt4 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:359:18: DIGITS
						{
						DebugLocation(359, 18);
						mDIGITS(); if (state.failed) return;

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
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 59);
			LeaveRule("INT", 59);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_DIGITS();
	partial void Leave_DIGITS();

	// $ANTLR start "DIGITS"
	[GrammarRule("DIGITS")]
	private void mDIGITS()
	{
		Enter_DIGITS();
		EnterRule("DIGITS", 60);
		TraceIn("DIGITS", 60);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:362:17: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:362:19: ( '0' .. '9' )+
			{
			DebugLocation(362, 19);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:362:19: ( '0' .. '9' )+
			int cnt6=0;
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>='0' && LA6_0<='9')))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:362:21: '0' .. '9'
					{
					DebugLocation(362, 21);
					MatchRange('0','9'); if (state.failed) return;

					}
					break;

				default:
					if (cnt6 >= 1)
						goto loop6;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee6 = new EarlyExitException( 6, input );
					DebugRecognitionException(eee6);
					throw eee6;
				}
				cnt6++;
			}
			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

		}
		finally
		{
			TraceOut("DIGITS", 60);
			LeaveRule("DIGITS", 60);
			Leave_DIGITS();
		}
	}
	// $ANTLR end "DIGITS"

	partial void Enter_NAME();
	partial void Leave_NAME();

	// $ANTLR start "NAME"
	[GrammarRule("NAME")]
	private void mNAME()
	{
		Enter_NAME();
		EnterRule("NAME", 61);
		TraceIn("NAME", 61);
		try
		{
			int _type = NAME;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:364:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:364:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(364, 7);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(365, 9);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:365:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if (((LA7_0>='0' && LA7_0<='9')||(LA7_0>='A' && LA7_0<='Z')||LA7_0=='_'||(LA7_0>='a' && LA7_0<='z')))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:
					{
					DebugLocation(365, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NAME", 61);
			LeaveRule("NAME", 61);
			Leave_NAME();
		}
	}
	// $ANTLR end "NAME"

	partial void Enter_STRING();
	partial void Leave_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		Enter_STRING();
		EnterRule("STRING", 62);
		TraceIn("STRING", 62);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:372:6: ( ( 'r' | 'u' | 'ur' )? ( '\\'\\'\\'' ( options {greedy=false; } : . )* '\\'\\'\\'' | '\"\"\"' ( options {greedy=false; } : . )* '\"\"\"' | '\"' ( ESC | ~ ( '\\\\' | '\\n' | '\"' ) )* '\"' | '\\'' ( ESC | ~ ( '\\\\' | '\\n' | '\\'' ) )* '\\'' ) )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:372:11: ( 'r' | 'u' | 'ur' )? ( '\\'\\'\\'' ( options {greedy=false; } : . )* '\\'\\'\\'' | '\"\"\"' ( options {greedy=false; } : . )* '\"\"\"' | '\"' ( ESC | ~ ( '\\\\' | '\\n' | '\"' ) )* '\"' | '\\'' ( ESC | ~ ( '\\\\' | '\\n' | '\\'' ) )* '\\'' )
			{
			DebugLocation(372, 11);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:372:11: ( 'r' | 'u' | 'ur' )?
			int alt8=4;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0=='r'))
			{
				alt8=1;
			}
			else if ((LA8_0=='u'))
			{
				int LA8_2 = input.LA(2);

				if ((LA8_2=='r'))
				{
					alt8=3;
				}
				else if ((LA8_2=='\"'||LA8_2=='\''))
				{
					alt8=2;
				}
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:372:12: 'r'
				{
				DebugLocation(372, 12);
				Match('r'); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:372:16: 'u'
				{
				DebugLocation(372, 16);
				Match('u'); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:372:20: 'ur'
				{
				DebugLocation(372, 20);
				Match("ur"); if (state.failed) return;


				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(373, 9);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:373:9: ( '\\'\\'\\'' ( options {greedy=false; } : . )* '\\'\\'\\'' | '\"\"\"' ( options {greedy=false; } : . )* '\"\"\"' | '\"' ( ESC | ~ ( '\\\\' | '\\n' | '\"' ) )* '\"' | '\\'' ( ESC | ~ ( '\\\\' | '\\n' | '\\'' ) )* '\\'' )
			int alt13=4;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0=='\''))
			{
				int LA13_1 = input.LA(2);

				if ((LA13_1=='\''))
				{
					int LA13_3 = input.LA(3);

					if ((LA13_3=='\''))
					{
						alt13=1;
					}
					else
					{
						alt13=4;}
				}
				else if (((LA13_1>='\u0000' && LA13_1<='\t')||(LA13_1>='\u000B' && LA13_1<='&')||(LA13_1>='(' && LA13_1<='\uFFFF')))
				{
					alt13=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 13, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA13_0=='\"'))
			{
				int LA13_2 = input.LA(2);

				if ((LA13_2=='\"'))
				{
					int LA13_5 = input.LA(3);

					if ((LA13_5=='\"'))
					{
						alt13=2;
					}
					else
					{
						alt13=3;}
				}
				else if (((LA13_2>='\u0000' && LA13_2<='\t')||(LA13_2>='\u000B' && LA13_2<='!')||(LA13_2>='#' && LA13_2<='\uFFFF')))
				{
					alt13=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 13, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:373:13: '\\'\\'\\'' ( options {greedy=false; } : . )* '\\'\\'\\''
				{
				DebugLocation(373, 13);
				Match("'''"); if (state.failed) return;

				DebugLocation(373, 22);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:373:22: ( options {greedy=false; } : . )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0=='\''))
					{
						int LA9_1 = input.LA(2);

						if ((LA9_1=='\''))
						{
							int LA9_3 = input.LA(3);

							if ((LA9_3=='\''))
							{
								alt9=2;
							}
							else if (((LA9_3>='\u0000' && LA9_3<='&')||(LA9_3>='(' && LA9_3<='\uFFFF')))
							{
								alt9=1;
							}


						}
						else if (((LA9_1>='\u0000' && LA9_1<='&')||(LA9_1>='(' && LA9_1<='\uFFFF')))
						{
							alt9=1;
						}


					}
					else if (((LA9_0>='\u0000' && LA9_0<='&')||(LA9_0>='(' && LA9_0<='\uFFFF')))
					{
						alt9=1;
					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:373:47: .
						{
						DebugLocation(373, 47);
						MatchAny(); if (state.failed) return;

						}
						break;

					default:
						goto loop9;
					}
				}

				loop9:
					;

				} finally { DebugExitSubRule(9); }

				DebugLocation(373, 51);
				Match("'''"); if (state.failed) return;


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:374:13: '\"\"\"' ( options {greedy=false; } : . )* '\"\"\"'
				{
				DebugLocation(374, 13);
				Match("\"\"\""); if (state.failed) return;

				DebugLocation(374, 19);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:374:19: ( options {greedy=false; } : . )*
				try { DebugEnterSubRule(10);
				while (true)
				{
					int alt10=2;
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0=='\"'))
					{
						int LA10_1 = input.LA(2);

						if ((LA10_1=='\"'))
						{
							int LA10_3 = input.LA(3);

							if ((LA10_3=='\"'))
							{
								alt10=2;
							}
							else if (((LA10_3>='\u0000' && LA10_3<='!')||(LA10_3>='#' && LA10_3<='\uFFFF')))
							{
								alt10=1;
							}


						}
						else if (((LA10_1>='\u0000' && LA10_1<='!')||(LA10_1>='#' && LA10_1<='\uFFFF')))
						{
							alt10=1;
						}


					}
					else if (((LA10_0>='\u0000' && LA10_0<='!')||(LA10_0>='#' && LA10_0<='\uFFFF')))
					{
						alt10=1;
					}


					} finally { DebugExitDecision(10); }
					switch ( alt10 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:374:44: .
						{
						DebugLocation(374, 44);
						MatchAny(); if (state.failed) return;

						}
						break;

					default:
						goto loop10;
					}
				}

				loop10:
					;

				} finally { DebugExitSubRule(10); }

				DebugLocation(374, 48);
				Match("\"\"\""); if (state.failed) return;


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:375:13: '\"' ( ESC | ~ ( '\\\\' | '\\n' | '\"' ) )* '\"'
				{
				DebugLocation(375, 13);
				Match('\"'); if (state.failed) return;
				DebugLocation(375, 17);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:375:17: ( ESC | ~ ( '\\\\' | '\\n' | '\"' ) )*
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=3;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0=='\\'))
					{
						alt11=1;
					}
					else if (((LA11_0>='\u0000' && LA11_0<='\t')||(LA11_0>='\u000B' && LA11_0<='!')||(LA11_0>='#' && LA11_0<='[')||(LA11_0>=']' && LA11_0<='\uFFFF')))
					{
						alt11=2;
					}


					} finally { DebugExitDecision(11); }
					switch ( alt11 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:375:18: ESC
						{
						DebugLocation(375, 18);
						mESC(); if (state.failed) return;

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:375:22: ~ ( '\\\\' | '\\n' | '\"' )
						{
						DebugLocation(375, 22);
						if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF'))
						{
							input.Consume();
						state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							Recover(mse);
							throw mse;}


						}
						break;

					default:
						goto loop11;
					}
				}

				loop11:
					;

				} finally { DebugExitSubRule(11); }

				DebugLocation(375, 41);
				Match('\"'); if (state.failed) return;

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:376:13: '\\'' ( ESC | ~ ( '\\\\' | '\\n' | '\\'' ) )* '\\''
				{
				DebugLocation(376, 13);
				Match('\''); if (state.failed) return;
				DebugLocation(376, 18);
				// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:376:18: ( ESC | ~ ( '\\\\' | '\\n' | '\\'' ) )*
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=3;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0=='\\'))
					{
						alt12=1;
					}
					else if (((LA12_0>='\u0000' && LA12_0<='\t')||(LA12_0>='\u000B' && LA12_0<='&')||(LA12_0>='(' && LA12_0<='[')||(LA12_0>=']' && LA12_0<='\uFFFF')))
					{
						alt12=2;
					}


					} finally { DebugExitDecision(12); }
					switch ( alt12 )
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:376:19: ESC
						{
						DebugLocation(376, 19);
						mESC(); if (state.failed) return;

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:376:23: ~ ( '\\\\' | '\\n' | '\\'' )
						{
						DebugLocation(376, 23);
						if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='&')||(input.LA(1)>='(' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF'))
						{
							input.Consume();
						state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							Recover(mse);
							throw mse;}


						}
						break;

					default:
						goto loop12;
					}
				}

				loop12:
					;

				} finally { DebugExitSubRule(12); }

				DebugLocation(376, 43);
				Match('\''); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(13); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 62);
			LeaveRule("STRING", 62);
			Leave_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void Enter_ESC();
	partial void Leave_ESC();

	// $ANTLR start "ESC"
	[GrammarRule("ESC")]
	private void mESC()
	{
		Enter_ESC();
		EnterRule("ESC", 63);
		TraceIn("ESC", 63);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:382:2: ( '\\\\' . )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:382:4: '\\\\' .
			{
			DebugLocation(382, 4);
			Match('\\'); if (state.failed) return;
			DebugLocation(382, 9);
			MatchAny(); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("ESC", 63);
			LeaveRule("ESC", 63);
			Leave_ESC();
		}
	}
	// $ANTLR end "ESC"

	partial void Enter_NEWLINE();
	partial void Leave_NEWLINE();

	// $ANTLR start "NEWLINE"
	[GrammarRule("NEWLINE")]
	private void mNEWLINE()
	{
		Enter_NEWLINE();
		EnterRule("NEWLINE", 64);
		TraceIn("NEWLINE", 64);
		try
		{
			int _type = NEWLINE;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:386:5: ( ( ( '\\r' )? '\\n' )+ )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:386:9: ( ( '\\r' )? '\\n' )+
			{
			DebugLocation(386, 9);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:386:9: ( ( '\\r' )? '\\n' )+
			int cnt15=0;
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0=='\n'||LA15_0=='\r'))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch (alt15)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:386:10: ( '\\r' )? '\\n'
					{
					DebugLocation(386, 10);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:386:10: ( '\\r' )?
					int alt14=2;
					try { DebugEnterSubRule(14);
					try { DebugEnterDecision(14, decisionCanBacktrack[14]);
					int LA14_0 = input.LA(1);

					if ((LA14_0=='\r'))
					{
						alt14=1;
					}
					} finally { DebugExitDecision(14); }
					switch (alt14)
					{
					case 1:
						DebugEnterAlt(1);
						// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:386:11: '\\r'
						{
						DebugLocation(386, 11);
						Match('\r'); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(14); }

					DebugLocation(386, 18);
					Match('\n'); if (state.failed) return;

					}
					break;

				default:
					if (cnt15 >= 1)
						goto loop15;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee15 = new EarlyExitException( 15, input );
					DebugRecognitionException(eee15);
					throw eee15;
				}
				cnt15++;
			}
			loop15:
				;

			} finally { DebugExitSubRule(15); }

			DebugLocation(386, 26);
			if ( state.backtracking == 0 )
			{
				 _channel=HIDDEN; 
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWLINE", 64);
			LeaveRule("NEWLINE", 64);
			Leave_NEWLINE();
		}
	}
	// $ANTLR end "NEWLINE"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 65);
		TraceIn("WS", 65);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:389:4: ( ( ' ' | '\\t' )+ )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:389:7: ( ' ' | '\\t' )+
			{
			DebugLocation(389, 7);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:389:7: ( ' ' | '\\t' )+
			int cnt16=0;
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0=='\t'||LA16_0==' '))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch (alt16)
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:
					{
					DebugLocation(389, 7);
					if (input.LA(1)=='\t'||input.LA(1)==' ')
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt16 >= 1)
						goto loop16;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee16 = new EarlyExitException( 16, input );
					DebugRecognitionException(eee16);
					throw eee16;
				}
				cnt16++;
			}
			loop16:
				;

			} finally { DebugExitSubRule(16); }

			DebugLocation(389, 19);
			if ( state.backtracking == 0 )
			{
				_channel=HIDDEN;
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 65);
			LeaveRule("WS", 65);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_COMMENT();
	partial void Leave_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		Enter_COMMENT();
		EnterRule("COMMENT", 66);
		TraceIn("COMMENT", 66);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:392:8: ( '/*' ( COMMENT | '/' ~ ( '*' ) | ( '*' ~ ( '/' ) )=> '*' | ~ ( '*' | '/' ) )* '*/' )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:393:2: '/*' ( COMMENT | '/' ~ ( '*' ) | ( '*' ~ ( '/' ) )=> '*' | ~ ( '*' | '/' ) )* '*/'
			{
			DebugLocation(393, 2);
			Match("/*"); if (state.failed) return;

			DebugLocation(393, 7);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:393:7: ( COMMENT | '/' ~ ( '*' ) | ( '*' ~ ( '/' ) )=> '*' | ~ ( '*' | '/' ) )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=5;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				try
				{
					alt17 = dfa17.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:393:9: COMMENT
					{
					DebugLocation(393, 9);
					mCOMMENT(); if (state.failed) return;

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:394:4: '/' ~ ( '*' )
					{
					DebugLocation(394, 4);
					Match('/'); if (state.failed) return;
					DebugLocation(394, 8);
					if ((input.LA(1)>='\u0000' && input.LA(1)<=')')||(input.LA(1)>='+' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:395:4: ( '*' ~ ( '/' ) )=> '*'
					{
					DebugLocation(395, 18);
					Match('*'); if (state.failed) return;

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:396:4: ~ ( '*' | '/' )
					{
					DebugLocation(396, 4);
					if ((input.LA(1)>='\u0000' && input.LA(1)<=')')||(input.LA(1)>='+' && input.LA(1)<='.')||(input.LA(1)>='0' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop17;
				}
			}

			loop17:
				;

			} finally { DebugExitSubRule(17); }

			DebugLocation(398, 2);
			Match("*/"); if (state.failed) return;

			DebugLocation(398, 7);
			if ( state.backtracking == 0 )
			{
				_channel=HIDDEN;
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 66);
			LeaveRule("COMMENT", 66);
			Leave_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	public override void mTokens()
	{
		// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:8: ( T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | LPAREN | RPAREN | LBRACK | RBRACK | LCURLY | RCURLY | COLON | COMMA | SEMI | PLUS | MINUS | STAR | SLASH | VBAR | AMPER | LESS | GREATER | ASSIGN | PERCENT | EQUAL | NOTEQUAL | LESSEQUAL | GREATEREQUAL | PLUSEQUAL | MINUSEQUAL | DOUBLESTAR | STAREQUAL | DOUBLESLASH | SLASHEQUAL | VBAREQUAL | DOUBLESTAREQUAL | DOUBLESLASHEQUAL | DOT | INT | NAME | STRING | NEWLINE | WS | COMMENT )
		int alt18=64;
		try { DebugEnterDecision(18, decisionCanBacktrack[18]);
		try
		{
			alt18 = dfa18.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(18); }
		switch (alt18)
		{
		case 1:
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:10: T__45
			{
			DebugLocation(1, 10);
			mT__45(); if (state.failed) return;

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:16: T__46
			{
			DebugLocation(1, 16);
			mT__46(); if (state.failed) return;

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:22: T__47
			{
			DebugLocation(1, 22);
			mT__47(); if (state.failed) return;

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:28: T__48
			{
			DebugLocation(1, 28);
			mT__48(); if (state.failed) return;

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:34: T__49
			{
			DebugLocation(1, 34);
			mT__49(); if (state.failed) return;

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:40: T__50
			{
			DebugLocation(1, 40);
			mT__50(); if (state.failed) return;

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:46: T__51
			{
			DebugLocation(1, 46);
			mT__51(); if (state.failed) return;

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:52: T__52
			{
			DebugLocation(1, 52);
			mT__52(); if (state.failed) return;

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:58: T__53
			{
			DebugLocation(1, 58);
			mT__53(); if (state.failed) return;

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:64: T__54
			{
			DebugLocation(1, 64);
			mT__54(); if (state.failed) return;

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:70: T__55
			{
			DebugLocation(1, 70);
			mT__55(); if (state.failed) return;

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:76: T__56
			{
			DebugLocation(1, 76);
			mT__56(); if (state.failed) return;

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:82: T__57
			{
			DebugLocation(1, 82);
			mT__57(); if (state.failed) return;

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:88: T__58
			{
			DebugLocation(1, 88);
			mT__58(); if (state.failed) return;

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:94: T__59
			{
			DebugLocation(1, 94);
			mT__59(); if (state.failed) return;

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:100: T__60
			{
			DebugLocation(1, 100);
			mT__60(); if (state.failed) return;

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:106: T__61
			{
			DebugLocation(1, 106);
			mT__61(); if (state.failed) return;

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:112: T__62
			{
			DebugLocation(1, 112);
			mT__62(); if (state.failed) return;

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:118: T__63
			{
			DebugLocation(1, 118);
			mT__63(); if (state.failed) return;

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:124: T__64
			{
			DebugLocation(1, 124);
			mT__64(); if (state.failed) return;

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:130: T__65
			{
			DebugLocation(1, 130);
			mT__65(); if (state.failed) return;

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:136: T__66
			{
			DebugLocation(1, 136);
			mT__66(); if (state.failed) return;

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:142: T__67
			{
			DebugLocation(1, 142);
			mT__67(); if (state.failed) return;

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:148: T__68
			{
			DebugLocation(1, 148);
			mT__68(); if (state.failed) return;

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:154: T__69
			{
			DebugLocation(1, 154);
			mT__69(); if (state.failed) return;

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:160: LPAREN
			{
			DebugLocation(1, 160);
			mLPAREN(); if (state.failed) return;

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:167: RPAREN
			{
			DebugLocation(1, 167);
			mRPAREN(); if (state.failed) return;

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:174: LBRACK
			{
			DebugLocation(1, 174);
			mLBRACK(); if (state.failed) return;

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:181: RBRACK
			{
			DebugLocation(1, 181);
			mRBRACK(); if (state.failed) return;

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:188: LCURLY
			{
			DebugLocation(1, 188);
			mLCURLY(); if (state.failed) return;

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:195: RCURLY
			{
			DebugLocation(1, 195);
			mRCURLY(); if (state.failed) return;

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:202: COLON
			{
			DebugLocation(1, 202);
			mCOLON(); if (state.failed) return;

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:208: COMMA
			{
			DebugLocation(1, 208);
			mCOMMA(); if (state.failed) return;

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:214: SEMI
			{
			DebugLocation(1, 214);
			mSEMI(); if (state.failed) return;

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:219: PLUS
			{
			DebugLocation(1, 219);
			mPLUS(); if (state.failed) return;

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:224: MINUS
			{
			DebugLocation(1, 224);
			mMINUS(); if (state.failed) return;

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:230: STAR
			{
			DebugLocation(1, 230);
			mSTAR(); if (state.failed) return;

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:235: SLASH
			{
			DebugLocation(1, 235);
			mSLASH(); if (state.failed) return;

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:241: VBAR
			{
			DebugLocation(1, 241);
			mVBAR(); if (state.failed) return;

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:246: AMPER
			{
			DebugLocation(1, 246);
			mAMPER(); if (state.failed) return;

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:252: LESS
			{
			DebugLocation(1, 252);
			mLESS(); if (state.failed) return;

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:257: GREATER
			{
			DebugLocation(1, 257);
			mGREATER(); if (state.failed) return;

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:265: ASSIGN
			{
			DebugLocation(1, 265);
			mASSIGN(); if (state.failed) return;

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:272: PERCENT
			{
			DebugLocation(1, 272);
			mPERCENT(); if (state.failed) return;

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:280: EQUAL
			{
			DebugLocation(1, 280);
			mEQUAL(); if (state.failed) return;

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:286: NOTEQUAL
			{
			DebugLocation(1, 286);
			mNOTEQUAL(); if (state.failed) return;

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:295: LESSEQUAL
			{
			DebugLocation(1, 295);
			mLESSEQUAL(); if (state.failed) return;

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:305: GREATEREQUAL
			{
			DebugLocation(1, 305);
			mGREATEREQUAL(); if (state.failed) return;

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:318: PLUSEQUAL
			{
			DebugLocation(1, 318);
			mPLUSEQUAL(); if (state.failed) return;

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:328: MINUSEQUAL
			{
			DebugLocation(1, 328);
			mMINUSEQUAL(); if (state.failed) return;

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:339: DOUBLESTAR
			{
			DebugLocation(1, 339);
			mDOUBLESTAR(); if (state.failed) return;

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:350: STAREQUAL
			{
			DebugLocation(1, 350);
			mSTAREQUAL(); if (state.failed) return;

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:360: DOUBLESLASH
			{
			DebugLocation(1, 360);
			mDOUBLESLASH(); if (state.failed) return;

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:372: SLASHEQUAL
			{
			DebugLocation(1, 372);
			mSLASHEQUAL(); if (state.failed) return;

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:383: VBAREQUAL
			{
			DebugLocation(1, 383);
			mVBAREQUAL(); if (state.failed) return;

			}
			break;
		case 56:
			DebugEnterAlt(56);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:393: DOUBLESTAREQUAL
			{
			DebugLocation(1, 393);
			mDOUBLESTAREQUAL(); if (state.failed) return;

			}
			break;
		case 57:
			DebugEnterAlt(57);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:409: DOUBLESLASHEQUAL
			{
			DebugLocation(1, 409);
			mDOUBLESLASHEQUAL(); if (state.failed) return;

			}
			break;
		case 58:
			DebugEnterAlt(58);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:426: DOT
			{
			DebugLocation(1, 426);
			mDOT(); if (state.failed) return;

			}
			break;
		case 59:
			DebugEnterAlt(59);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:430: INT
			{
			DebugLocation(1, 430);
			mINT(); if (state.failed) return;

			}
			break;
		case 60:
			DebugEnterAlt(60);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:434: NAME
			{
			DebugLocation(1, 434);
			mNAME(); if (state.failed) return;

			}
			break;
		case 61:
			DebugEnterAlt(61);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:439: STRING
			{
			DebugLocation(1, 439);
			mSTRING(); if (state.failed) return;

			}
			break;
		case 62:
			DebugEnterAlt(62);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:446: NEWLINE
			{
			DebugLocation(1, 446);
			mNEWLINE(); if (state.failed) return;

			}
			break;
		case 63:
			DebugEnterAlt(63);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:454: WS
			{
			DebugLocation(1, 454);
			mWS(); if (state.failed) return;

			}
			break;
		case 64:
			DebugEnterAlt(64);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:1:457: COMMENT
			{
			DebugLocation(1, 457);
			mCOMMENT(); if (state.failed) return;

			}
			break;

		}

	}

	partial void Enter_synpred1_Tiger_fragment();
	partial void Leave_synpred1_Tiger_fragment();

	// $ANTLR start synpred1_Tiger
	public void synpred1_Tiger_fragment()
	{
		Enter_synpred1_Tiger_fragment();
		EnterRule("synpred1_Tiger_fragment", 68);
		TraceIn("synpred1_Tiger_fragment", 68);
		try
		{
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:395:4: ( '*' ~ ( '/' ) )
			DebugEnterAlt(1);
			// E:\\[Ariel]\\[Projects]\\Compiler\\TigerCompiler [c]\\Src\\Tiger.Build\\Compiler\\Parsing\\Tiger.g:395:5: '*' ~ ( '/' )
			{
			DebugLocation(395, 5);
			Match('*'); if (state.failed) return;
			DebugLocation(395, 9);
			if ((input.LA(1)>='\u0000' && input.LA(1)<='.')||(input.LA(1)>='0' && input.LA(1)<='\uFFFF'))
			{
				input.Consume();
			state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("synpred1_Tiger_fragment", 68);
			LeaveRule("synpred1_Tiger_fragment", 68);
			Leave_synpred1_Tiger_fragment();
		}
	}
	// $ANTLR end synpred1_Tiger

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
	DFA17 dfa17;
	DFA18 dfa18;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa17 = new DFA17(this, SpecialStateTransition17);
		dfa18 = new DFA18(this);
	}

	private class DFA17 : DFA
	{
		private const string DFA17_eotS =
			"\x4\xFFFF\x1\xB\x7\xFFFF";
		private const string DFA17_eofS =
			"\xC\xFFFF";
		private const string DFA17_minS =
			"\x3\x0\x1\xFFFF\x1\x0\x7\xFFFF";
		private const string DFA17_maxS =
			"\x3\xFFFF\x1\xFFFF\x1\xFFFF\x7\xFFFF";
		private const string DFA17_acceptS =
			"\x3\xFFFF\x1\x4\x1\xFFFF\x2\x3\x1\x1\x1\x2\x2\x3\x1\x5";
		private const string DFA17_specialS =
			"\x1\x2\x1\x0\x1\x3\x1\xFFFF\x1\x1\x7\xFFFF}>";
		private static readonly string[] DFA17_transitionS =
			{
				"\x2A\x3\x1\x1\x4\x3\x1\x2\xFFD0\x3",
				"\x2A\x6\x1\x5\x4\x6\x1\x4\xFFD0\x6",
				"\x2A\x8\x1\x7\xFFD5\x8",
				"",
				"\x2A\xA\x1\x9\xFFD5\xA",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
		private static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
		private static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
		private static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
		private static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
		private static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
		private static readonly short[][] DFA17_transition;

		static DFA17()
		{
			int numStates = DFA17_transitionS.Length;
			DFA17_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA17_transition[i] = DFA.UnpackEncodedString(DFA17_transitionS[i]);
			}
		}

		public DFA17( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 17;
			this.eot = DFA17_eot;
			this.eof = DFA17_eof;
			this.min = DFA17_min;
			this.max = DFA17_max;
			this.accept = DFA17_accept;
			this.special = DFA17_special;
			this.transition = DFA17_transition;
		}

		public override string Description { get { return "()* loopback of 393:7: ( COMMENT | '/' ~ ( '*' ) | ( '*' ~ ( '/' ) )=> '*' | ~ ( '*' | '/' ) )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition17(DFA dfa, int s, IIntStream _input)
	{
		IIntStream input = _input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA17_1 = input.LA(1);


				int index17_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA17_1=='/') ) {s = 4;}

				else if ( (LA17_1=='*') && (EvaluatePredicate(synpred1_Tiger_fragment))) {s = 5;}

				else if ( ((LA17_1>='\u0000' && LA17_1<=')')||(LA17_1>='+' && LA17_1<='.')||(LA17_1>='0' && LA17_1<='\uFFFF')) && (EvaluatePredicate(synpred1_Tiger_fragment))) {s = 6;}


				input.Seek(index17_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA17_4 = input.LA(1);


				int index17_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA17_4=='*') && (EvaluatePredicate(synpred1_Tiger_fragment))) {s = 9;}

				else if ( ((LA17_4>='\u0000' && LA17_4<=')')||(LA17_4>='+' && LA17_4<='\uFFFF')) && (EvaluatePredicate(synpred1_Tiger_fragment))) {s = 10;}

				else s = 11;


				input.Seek(index17_4);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA17_0 = input.LA(1);

				s = -1;
				if ( (LA17_0=='*') ) {s = 1;}

				else if ( (LA17_0=='/') ) {s = 2;}

				else if ( ((LA17_0>='\u0000' && LA17_0<=')')||(LA17_0>='+' && LA17_0<='.')||(LA17_0>='0' && LA17_0<='\uFFFF')) ) {s = 3;}

				if ( s>=0 ) return s;
				break;
			case 3:
				int LA17_2 = input.LA(1);

				s = -1;
				if ( (LA17_2=='*') ) {s = 7;}

				else if ( ((LA17_2>='\u0000' && LA17_2<=')')||(LA17_2>='+' && LA17_2<='\uFFFF')) ) {s = 8;}

				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 17, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA18 : DFA
	{
		private const string DFA18_eotS =
			"\x1\xFFFF\x2\x26\x1\x2F\xD\x26\x6\xFFFF\x1\x46\x2\xFFFF\x1\x48\x1\x4B"+
			"\x1\x4F\x1\x51\x1\xFFFF\x1\x54\x1\x56\x4\xFFFF\x1\x26\x4\xFFFF\x3\x26"+
			"\x3\xFFFF\x3\x26\x1\x5E\x1\x5F\x1\x60\x1\x26\x1\x62\x6\x26\x1\x69\x6"+
			"\x26\x4\xFFFF\x1\x71\x2\xFFFF\x1\x73\xA\xFFFF\x4\x26\x1\x77\x2\x26\x3"+
			"\xFFFF\x1\x26\x1\xFFFF\x3\x26\x1\x7E\x1\x7F\x1\x26\x1\xFFFF\x1\x81\x1"+
			"\x82\x1\x83\x3\x26\x4\xFFFF\x1\x26\x1\x88\x1\x26\x1\xFFFF\x2\x26\x1\x8C"+
			"\x1\x8D\x1\x8E\x1\x8F\x2\xFFFF\x1\x26\x3\xFFFF\x3\x26\x1\x94\x1\xFFFF"+
			"\x1\x95\x1\x26\x1\x97\x4\xFFFF\x1\x98\x1\x99\x2\x26\x2\xFFFF\x1\x26\x3"+
			"\xFFFF\x1\x26\x1\x9E\x2\x26\x1\xFFFF\x1\xA1\x1\xA2\x2\xFFFF";
		private const string DFA18_eofS =
			"\xA3\xFFFF";
		private const string DFA18_minS =
			"\x1\x9\x1\x61\x1\x68\x1\x3D\x1\x61\x1\x66\x1\x6F\x1\x68\x1\x6C\x1\x65"+
			"\x1\x72\x1\x66\x1\x61\x1\x69\x1\x72\x1\x6F\x1\x22\x6\xFFFF\x1\x3D\x2"+
			"\xFFFF\x1\x3D\x2\x2A\x1\x3D\x1\xFFFF\x2\x3D\x4\xFFFF\x1\x22\x4\xFFFF"+
			"\x2\x74\x1\x69\x3\xFFFF\x1\x72\x1\x6E\x1\x6C\x3\x30\x1\x65\x1\x30\x1"+
			"\x70\x1\x75\x1\x73\x1\x64\x1\x74\x1\x72\x1\x30\x1\x72\x1\x74\x1\x6C\x1"+
			"\x65\x1\x6E\x1\x74\x4\xFFFF\x1\x3D\x2\xFFFF\x1\x3D\xA\xFFFF\x1\x22\x1"+
			"\x63\x1\x68\x1\x6C\x1\x30\x1\x63\x1\x73\x3\xFFFF\x1\x6E\x1\xFFFF\x3\x65"+
			"\x2\x30\x1\x61\x1\xFFFF\x3\x30\x1\x61\x1\x74\x1\x75\x4\xFFFF\x1\x68\x1"+
			"\x30\x1\x65\x1\xFFFF\x1\x74\x1\x65\x4\x30\x2\xFFFF\x1\x79\x3\xFFFF\x1"+
			"\x6B\x1\x69\x1\x72\x1\x30\x1\xFFFF\x1\x30\x1\x69\x1\x30\x4\xFFFF\x2\x30"+
			"\x2\x6E\x2\xFFFF\x1\x6F\x3\xFFFF\x1\x75\x1\x30\x1\x6E\x1\x65\x1\xFFFF"+
			"\x2\x30\x2\xFFFF";
		private const string DFA18_maxS =
			"\x1\x7D\x1\x61\x1\x69\x1\x3E\x1\x75\x1\x6E\x1\x6F\x1\x79\x1\x6E\x1\x65"+
			"\x1\x72\x1\x66\x1\x61\x1\x6F\x1\x72\x1\x6F\x1\x65\x6\xFFFF\x1\x3D\x2"+
			"\xFFFF\x4\x3D\x1\xFFFF\x1\x3E\x1\x3D\x4\xFFFF\x1\x72\x4\xFFFF\x2\x74"+
			"\x1\x69\x3\xFFFF\x1\x72\x1\x6E\x1\x6C\x3\x7A\x1\x65\x1\x7A\x1\x70\x1"+
			"\x75\x1\x73\x1\x64\x1\x74\x1\x72\x1\x7A\x1\x72\x1\x74\x1\x6C\x1\x65\x1"+
			"\x6E\x1\x74\x4\xFFFF\x1\x3D\x2\xFFFF\x1\x3D\xA\xFFFF\x1\x27\x1\x63\x1"+
			"\x68\x1\x6C\x1\x7A\x1\x63\x1\x73\x3\xFFFF\x1\x6E\x1\xFFFF\x3\x65\x2\x7A"+
			"\x1\x61\x1\xFFFF\x3\x7A\x1\x61\x1\x74\x1\x75\x4\xFFFF\x1\x68\x1\x7A\x1"+
			"\x65\x1\xFFFF\x1\x74\x1\x65\x4\x7A\x2\xFFFF\x1\x79\x3\xFFFF\x1\x6B\x1"+
			"\x69\x1\x72\x1\x7A\x1\xFFFF\x1\x7A\x1\x69\x1\x7A\x4\xFFFF\x2\x7A\x2\x6E"+
			"\x2\xFFFF\x1\x6F\x3\xFFFF\x1\x75\x1\x7A\x1\x6E\x1\x65\x1\xFFFF\x2\x7A"+
			"\x2\xFFFF";
		private const string DFA18_acceptS =
			"\x11\xFFFF\x1\x1A\x1\x1B\x1\x1C\x1\x1D\x1\x1E\x1\x1F\x1\xFFFF\x1\x21"+
			"\x1\x22\x4\xFFFF\x1\x28\x2\xFFFF\x1\x2C\x1\x2D\x1\x3A\x1\x3B\x1\xFFFF"+
			"\x1\x3C\x1\x3D\x1\x3E\x1\x3F\x3\xFFFF\x1\x3\x1\x32\x1\x24\x15\xFFFF\x1"+
			"\x2B\x1\x20\x1\x31\x1\x23\x1\xFFFF\x1\x34\x1\x25\x1\xFFFF\x1\x36\x1\x40"+
			"\x1\x26\x1\x37\x1\x27\x1\x2E\x1\x2F\x1\x29\x1\x30\x1\x2A\x7\xFFFF\x1"+
			"\x5\x1\x7\x1\x6\x1\xFFFF\x1\xB\x6\xFFFF\x1\x10\x6\xFFFF\x1\x38\x1\x33"+
			"\x1\x39\x1\x35\x3\xFFFF\x1\x4\x6\xFFFF\x1\xD\x1\xC\x1\xFFFF\x1\x11\x1"+
			"\x13\x1\x18\x4\xFFFF\x1\x2\x3\xFFFF\x1\x8\x1\xE\x1\x14\x1\x9\x4\xFFFF"+
			"\x1\x1\x1\xA\x1\xFFFF\x1\x15\x1\xF\x1\x16\x4\xFFFF\x1\x19\x2\xFFFF\x1"+
			"\x12\x1\x17";
		private const string DFA18_specialS =
			"\xA3\xFFFF}>";
		private static readonly string[] DFA18_transitionS =
			{
				"\x1\x29\x1\x28\x2\xFFFF\x1\x28\x12\xFFFF\x1\x29\x1\xFFFF\x1\x27\x2"+
				"\xFFFF\x1\x21\x1\x1E\x1\x27\x1\x11\x1\x12\x1\x1B\x1\x1A\x1\x18\x1\x3"+
				"\x1\x23\x1\x1C\xA\x24\x1\x17\x1\x19\x1\x1F\x1\x22\x1\x20\x2\xFFFF\x1A"+
				"\x26\x1\x13\x1\xFFFF\x1\x14\x1\xFFFF\x1\x26\x1\xFFFF\x1\xA\x1\xE\x1"+
				"\xF\x1\x6\x1\x8\x1\x4\x2\x26\x1\x5\x2\x26\x1\x9\x1\x1\x1\xD\x1\xB\x2"+
				"\x26\x1\x10\x1\x26\x1\x7\x1\x25\x1\xC\x1\x2\x3\x26\x1\x15\x1\x1D\x1"+
				"\x16",
				"\x1\x2A",
				"\x1\x2C\x1\x2B",
				"\x1\x2E\x1\x2D",
				"\x1\x32\xD\xFFFF\x1\x30\x5\xFFFF\x1\x31",
				"\x1\x34\x7\xFFFF\x1\x33",
				"\x1\x35",
				"\x1\x36\x6\xFFFF\x1\x37\x2\xFFFF\x1\x39\x6\xFFFF\x1\x38",
				"\x1\x3A\x1\xFFFF\x1\x3B",
				"\x1\x3C",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x3F",
				"\x1\x41\x5\xFFFF\x1\x40",
				"\x1\x42",
				"\x1\x43",
				"\x1\x27\x4\xFFFF\x1\x27\x3D\xFFFF\x1\x44",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x45",
				"",
				"",
				"\x1\x47",
				"\x1\x49\x12\xFFFF\x1\x4A",
				"\x1\x4E\x4\xFFFF\x1\x4C\xD\xFFFF\x1\x4D",
				"\x1\x50",
				"",
				"\x1\x53\x1\x52",
				"\x1\x55",
				"",
				"",
				"",
				"",
				"\x1\x27\x4\xFFFF\x1\x27\x4A\xFFFF\x1\x57",
				"",
				"",
				"",
				"",
				"\x1\x58",
				"\x1\x59",
				"\x1\x5A",
				"",
				"",
				"",
				"\x1\x5B",
				"\x1\x5C",
				"\x1\x5D",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x61",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"\x1\x66",
				"\x1\x67",
				"\x1\x68",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x6A",
				"\x1\x6B",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"",
				"",
				"",
				"",
				"\x1\x70",
				"",
				"",
				"\x1\x72",
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
				"\x1\x27\x4\xFFFF\x1\x27",
				"\x1\x74",
				"\x1\x75",
				"\x1\x76",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x78",
				"\x1\x79",
				"",
				"",
				"",
				"\x1\x7A",
				"",
				"\x1\x7B",
				"\x1\x7C",
				"\x1\x7D",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x80",
				"",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x84",
				"\x1\x85",
				"\x1\x86",
				"",
				"",
				"",
				"",
				"\x1\x87",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x89",
				"",
				"\x1\x8A",
				"\x1\x8B",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"",
				"",
				"\x1\x90",
				"",
				"",
				"",
				"\x1\x91",
				"\x1\x92",
				"\x1\x93",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x96",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"",
				"",
				"",
				"",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x9A",
				"\x1\x9B",
				"",
				"",
				"\x1\x9C",
				"",
				"",
				"",
				"\x1\x9D",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\x1\x9F",
				"\x1\xA0",
				"",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"\xA\x26\x7\xFFFF\x1A\x26\x4\xFFFF\x1\x26\x1\xFFFF\x1A\x26",
				"",
				""
			};

		private static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
		private static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
		private static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
		private static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
		private static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
		private static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
		private static readonly short[][] DFA18_transition;

		static DFA18()
		{
			int numStates = DFA18_transitionS.Length;
			DFA18_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA18_transition[i] = DFA.UnpackEncodedString(DFA18_transitionS[i]);
			}
		}

		public DFA18( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 18;
			this.eot = DFA18_eot;
			this.eof = DFA18_eof;
			this.min = DFA18_min;
			this.max = DFA18_max;
			this.accept = DFA18_accept;
			this.special = DFA18_special;
			this.transition = DFA18_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | LPAREN | RPAREN | LBRACK | RBRACK | LCURLY | RCURLY | COLON | COMMA | SEMI | PLUS | MINUS | STAR | SLASH | VBAR | AMPER | LESS | GREATER | ASSIGN | PERCENT | EQUAL | NOTEQUAL | LESSEQUAL | GREATEREQUAL | PLUSEQUAL | MINUSEQUAL | DOUBLESTAR | STAREQUAL | DOUBLESLASH | SLASHEQUAL | VBAREQUAL | DOUBLESTAREQUAL | DOUBLESLASHEQUAL | DOT | INT | NAME | STRING | NEWLINE | WS | COMMENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace Tiger.Build.Compiler.Parsing
