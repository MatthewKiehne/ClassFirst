//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ClassFirst.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ClassFirst {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public partial class ClassFirstLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, TypeName=6, Modifier=7, Class=8, 
		Public=9, Private=10, Assign=11, Int=12, String=13, Identifier=14, Comment=15, 
		Space=16;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "TypeName", "Modifier", "Class", 
		"Public", "Private", "Assign", "Int", "String", "Identifier", "Comment", 
		"Space"
	};


	public ClassFirstLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ClassFirstLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "'('", "','", "')'", null, null, "'class'", "'public'", 
		"'private'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "TypeName", "Modifier", "Class", "Public", 
		"Private", "Assign", "Int", "String", "Identifier", "Comment", "Space"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ClassFirst.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ClassFirstLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,16,139,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,1,0,1,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,
		3,6,48,8,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,
		1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,11,1,11,5,11,75,8,11,10,11,12,11,78,
		9,11,1,11,3,11,81,8,11,1,12,1,12,1,12,1,12,5,12,87,8,12,10,12,12,12,90,
		9,12,1,12,1,12,1,12,1,12,1,12,5,12,97,8,12,10,12,12,12,100,9,12,1,12,3,
		12,103,8,12,1,13,1,13,5,13,107,8,13,10,13,12,13,110,9,13,1,14,1,14,1,14,
		1,14,5,14,116,8,14,10,14,12,14,119,9,14,1,14,1,14,1,14,1,14,5,14,125,8,
		14,10,14,12,14,128,9,14,1,14,1,14,3,14,132,8,14,1,14,1,14,1,15,1,15,1,
		15,1,15,1,126,0,16,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,
		23,12,25,13,27,14,29,15,31,16,1,0,10,1,0,49,57,1,0,48,57,1,0,34,34,4,0,
		10,10,13,13,34,34,92,92,2,0,10,10,13,13,1,0,39,39,4,0,10,10,13,13,39,39,
		92,92,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,3,0,9,10,12,
		13,32,32,150,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,
		0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,
		1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,
		0,1,33,1,0,0,0,3,35,1,0,0,0,5,37,1,0,0,0,7,39,1,0,0,0,9,41,1,0,0,0,11,
		43,1,0,0,0,13,47,1,0,0,0,15,49,1,0,0,0,17,55,1,0,0,0,19,62,1,0,0,0,21,
		70,1,0,0,0,23,80,1,0,0,0,25,102,1,0,0,0,27,104,1,0,0,0,29,131,1,0,0,0,
		31,135,1,0,0,0,33,34,5,123,0,0,34,2,1,0,0,0,35,36,5,125,0,0,36,4,1,0,0,
		0,37,38,5,40,0,0,38,6,1,0,0,0,39,40,5,44,0,0,40,8,1,0,0,0,41,42,5,41,0,
		0,42,10,1,0,0,0,43,44,3,27,13,0,44,12,1,0,0,0,45,48,3,17,8,0,46,48,3,19,
		9,0,47,45,1,0,0,0,47,46,1,0,0,0,48,14,1,0,0,0,49,50,5,99,0,0,50,51,5,108,
		0,0,51,52,5,97,0,0,52,53,5,115,0,0,53,54,5,115,0,0,54,16,1,0,0,0,55,56,
		5,112,0,0,56,57,5,117,0,0,57,58,5,98,0,0,58,59,5,108,0,0,59,60,5,105,0,
		0,60,61,5,99,0,0,61,18,1,0,0,0,62,63,5,112,0,0,63,64,5,114,0,0,64,65,5,
		105,0,0,65,66,5,118,0,0,66,67,5,97,0,0,67,68,5,116,0,0,68,69,5,101,0,0,
		69,20,1,0,0,0,70,71,5,61,0,0,71,22,1,0,0,0,72,76,7,0,0,0,73,75,7,1,0,0,
		74,73,1,0,0,0,75,78,1,0,0,0,76,74,1,0,0,0,76,77,1,0,0,0,77,81,1,0,0,0,
		78,76,1,0,0,0,79,81,5,48,0,0,80,72,1,0,0,0,80,79,1,0,0,0,81,24,1,0,0,0,
		82,88,7,2,0,0,83,87,8,3,0,0,84,85,5,92,0,0,85,87,8,4,0,0,86,83,1,0,0,0,
		86,84,1,0,0,0,87,90,1,0,0,0,88,86,1,0,0,0,88,89,1,0,0,0,89,91,1,0,0,0,
		90,88,1,0,0,0,91,103,7,2,0,0,92,98,7,5,0,0,93,97,8,6,0,0,94,95,5,92,0,
		0,95,97,8,4,0,0,96,93,1,0,0,0,96,94,1,0,0,0,97,100,1,0,0,0,98,96,1,0,0,
		0,98,99,1,0,0,0,99,101,1,0,0,0,100,98,1,0,0,0,101,103,7,5,0,0,102,82,1,
		0,0,0,102,92,1,0,0,0,103,26,1,0,0,0,104,108,7,7,0,0,105,107,7,8,0,0,106,
		105,1,0,0,0,107,110,1,0,0,0,108,106,1,0,0,0,108,109,1,0,0,0,109,28,1,0,
		0,0,110,108,1,0,0,0,111,112,5,47,0,0,112,113,5,47,0,0,113,117,1,0,0,0,
		114,116,8,4,0,0,115,114,1,0,0,0,116,119,1,0,0,0,117,115,1,0,0,0,117,118,
		1,0,0,0,118,132,1,0,0,0,119,117,1,0,0,0,120,121,5,47,0,0,121,122,5,42,
		0,0,122,126,1,0,0,0,123,125,9,0,0,0,124,123,1,0,0,0,125,128,1,0,0,0,126,
		127,1,0,0,0,126,124,1,0,0,0,127,129,1,0,0,0,128,126,1,0,0,0,129,130,5,
		42,0,0,130,132,5,47,0,0,131,111,1,0,0,0,131,120,1,0,0,0,132,133,1,0,0,
		0,133,134,6,14,0,0,134,30,1,0,0,0,135,136,7,9,0,0,136,137,1,0,0,0,137,
		138,6,15,0,0,138,32,1,0,0,0,13,0,47,76,80,86,88,96,98,102,108,117,126,
		131,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace ClassFirst