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
		private void Unsigned_Integer_Incorect_Order()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned Integer when the parameters are provided in the
		incorrect order => Maximum value, Minimum value
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
			Con.WriteLine(@"Pass the values in the incorrect order (MaxValue, MinValue)");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));
		} // private void Unsigned_Integer_Incorect_Order
	} // partial class Integer_Testing
} // namespace RNG_Test
