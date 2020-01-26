/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_ENCODER
using System;
using System.Collections.Generic;
using Iced.Intel;

namespace Iced.UnitTests.Intel.EncoderTests {
	static class OpCodeInfoDicts {
		// GENERATOR-BEGIN: Dicts
		// ⚠️This was generated by GENERATOR!🦹‍♂️
		internal static readonly Dictionary<string, EncodingKind> ToEncodingKind = new Dictionary<string, EncodingKind>(StringComparer.Ordinal) {
			{ "legacy", EncodingKind.Legacy },
			{ "VEX", EncodingKind.VEX },
			{ "EVEX", EncodingKind.EVEX },
			{ "XOP", EncodingKind.XOP },
			{ "3DNow!", EncodingKind.D3NOW },
		};
		internal static readonly Dictionary<string, MandatoryPrefix> ToMandatoryPrefix = new Dictionary<string, MandatoryPrefix>(StringComparer.Ordinal) {
			{ "", MandatoryPrefix.None },
			{ "NP", MandatoryPrefix.PNP },
			{ "66", MandatoryPrefix.P66 },
			{ "F3", MandatoryPrefix.PF3 },
			{ "F2", MandatoryPrefix.PF2 },
		};
		internal static readonly Dictionary<string, OpCodeTableKind> ToOpCodeTableKind = new Dictionary<string, OpCodeTableKind>(StringComparer.Ordinal) {
			{ "legacy", OpCodeTableKind.Normal },
			{ "0F", OpCodeTableKind.T0F },
			{ "0F38", OpCodeTableKind.T0F38 },
			{ "0F3A", OpCodeTableKind.T0F3A },
			{ "X8", OpCodeTableKind.XOP8 },
			{ "X9", OpCodeTableKind.XOP9 },
			{ "XA", OpCodeTableKind.XOPA },
		};
		// GENERATOR-END: Dicts
	}

	// GENERATOR-BEGIN: OpCodeInfoKeys
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	static class OpCodeInfoKeys {
		internal const string GroupIndex = "g";
		internal const string OpCodeOperandKind = "op";
		internal const string TupleType = "tt";
	}
	// GENERATOR-END: OpCodeInfoKeys

	// GENERATOR-BEGIN: OpCodeInfoFlags
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	static class OpCodeInfoFlags {
		internal const string NotInstruction = "notinstr";
		internal const string Bit16 = "16b";
		internal const string Bit32 = "32b";
		internal const string Bit64 = "64b";
		internal const string Fwait = "fwait";
		internal const string OperandSize16 = "o16";
		internal const string OperandSize32 = "o32";
		internal const string OperandSize64 = "o64";
		internal const string AddressSize16 = "a16";
		internal const string AddressSize32 = "a32";
		internal const string AddressSize64 = "a64";
		internal const string LIG = "LIG";
		internal const string L0 = "L0";
		internal const string L1 = "L1";
		internal const string L128 = "L128";
		internal const string L256 = "L256";
		internal const string L512 = "L512";
		internal const string WIG = "WIG";
		internal const string WIG32 = "WIG32";
		internal const string W0 = "W0";
		internal const string W1 = "W1";
		internal const string Broadcast = "b";
		internal const string RoundingControl = "er";
		internal const string SuppressAllExceptions = "sae";
		internal const string OpMaskRegister = "k";
		internal const string RequireNonZeroOpMaskRegister = "knz";
		internal const string ZeroingMasking = "z";
		internal const string LockPrefix = "lock";
		internal const string XacquirePrefix = "xacquire";
		internal const string XreleasePrefix = "xrelease";
		internal const string RepPrefix = "rep";
		internal const string RepePrefix = "repe";
		internal const string RepnePrefix = "repne";
		internal const string BndPrefix = "bnd";
		internal const string HintTakenPrefix = "ht";
		internal const string NotrackPrefix = "notrack";
	}
	// GENERATOR-END: OpCodeInfoFlags
}
#endif
