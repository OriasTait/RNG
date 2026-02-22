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
		private void Boolean_Same_Value()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for a boolean when the parameters that are provided are the
		same value.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated boolean values.
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
			Con.WriteLine(@"Pass the same value");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MinValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
		} // private void Boolean_Same_Value
	} // partial class Boolean_Testing
} // namespace RNG_Test
