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
		private void Unsigned_Short_Correct_Order()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned Short when the parameters are provided in the
		correct order => Minimum value, Maximum value
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Unsigned Short values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			ushort MinValue = ushort.MinValue;
			ushort MaxValue = ushort.MaxValue;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass the valid values in the correct order (MinValue, MaxValue)");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
		} // private void Unsigned_Short_Correct_Order
	} // partial class Integer_Testing
} // namespace RNG_Test
