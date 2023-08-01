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
		private void Unsigned_Short_Negative_Values()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned Short when the parameters that are provided
		are negative.
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
			// Variables - outside the scope of an Unsigned Integer
			//=============
			short Bad_MinValue = short.MinValue;
			short Bad_MaxValue = -1;
			bool IsValid = true;  // Assume the value is valid

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass negative values");

			if (Bad_MinValue < 0)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED Short.", Bad_MinValue);
				IsValid = false;
			}

			if (Bad_MaxValue < 0)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED Short.", Bad_MaxValue);
				IsValid = false;
			}

			if (IsValid)
			{
				Con.Write("{0}", MyRandomNumber.Generate(Bad_MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, Bad_MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(Bad_MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, Bad_MaxValue) + "\t");
				Con.WriteLine("{0}", MyRandomNumber.Generate(Bad_MinValue, Bad_MaxValue));
			}
		} // private void Unsigned_Short_Negative_Values
	} // partial class Integer_Testing
} // namespace RNG_Test
