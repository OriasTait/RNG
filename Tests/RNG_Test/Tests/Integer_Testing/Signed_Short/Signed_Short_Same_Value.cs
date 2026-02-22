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
		private void Signed_Short_Same_Value()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for a Signed Short when the parameters that are provided
		are the same value.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Signed Short values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			short MinValue = short.MinValue;
			short MaxValue = short.MaxValue;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass the same value");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MinValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
		} // private void Signed_Short_Same_Value
	} // partial class Integer_Testing
} // namespace RNG_Test
