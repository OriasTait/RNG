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
	partial class Boolean_Testing
	{
		private void Boolean_Correct_Order()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for a boolean when the parameters are provided in the
		correct order => Minimum value, Maximum value
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated boolean.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			bool MinValue = false;
			bool MaxValue = true;

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
		} // private void Boolean_Correct_Order
	} // partial class Boolean_Testing
} // namespace RNG_Test
