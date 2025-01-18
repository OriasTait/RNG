using System;
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
		private void Unsigned_BYTE_Same_Value()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned BYTE when the parameters that are provided
		are the same value.
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
			Con.WriteLine(@"Pass the same value");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MinValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
		} // private void Unsigned_BYTE_Same_Value
	} // partial class Integer_Testing
} // namespace RNG_Test
