﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orias_RNG;

//=============
// Aliases
//=============
using Con = System.Console;

namespace RNG_Test
{
	partial class BYTE_Testing
	{
		private void Signed_BYTE_Same_Value()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for and Signed BYTE when the parameters that are provided
		are the same value.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Signed BYTE values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			sbyte MinValue = sbyte.MinValue;
			sbyte MaxValue = sbyte.MaxValue;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass the same value");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MaxValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate((byte)100, (byte)100));
		} // private void Signed_BYTE_Same_Value
	} // partial class BYTE_Testing
} // namespace RNG_Test
