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
		private void Unsigned_Integer_Correct_Order()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned Integer when the parameters are provided in the
		correct order => Minimum value, Maximum value
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
			uint MinValue = uint.MinValue;
			uint MaxValue = uint.MaxValue;

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
		} // private void Signed_Integer_Correct_Order
	} // partial class Integer_Testing
} // namespace RNG_Test
