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
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2234:Arguments should be passed in the same order as the method parameters", Justification = "<Pending>")]
		private void Signed_Integer_Negative_Values()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for a Signed BYTE when the parameters that are provided are
		negative.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Signed Integer values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			int MinValue = int.MinValue;
			int MaxValue = -1;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass negative values");

			// Pass in the incorrect order
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");

			// Pass in the correct order
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
		} // private void Signed_Integer_Negative_Values
	} // partial class Integer_Testing
} // namespace RNG_Test
