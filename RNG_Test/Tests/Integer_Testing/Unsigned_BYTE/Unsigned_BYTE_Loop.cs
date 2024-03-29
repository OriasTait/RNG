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
	partial class Integer_Testing
	{
		private void Unsigned_BYTE_Loop()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned BYTE within a loop.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Unsigned BYTE values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			byte MinValue = byte.MinValue;
			byte MaxValue = byte.MaxValue;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Generate 5 random numbers 3 times");
			for (int i = 0; i < 3; i++)
			{
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			}
		} // private void Unsigned_BYTE_Loop
	} // partial class Integer_Testing
} // namespace RNG_Test
