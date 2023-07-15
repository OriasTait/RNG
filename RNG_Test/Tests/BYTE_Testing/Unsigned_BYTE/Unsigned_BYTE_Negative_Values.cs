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
	partial class BYTE_Testing
	{
		private void Unsigned_BYTE_Negative_Values()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for and Unsigned BYTE when the parameters that are provided
		are negative.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		An error message if the values are outside the range; otherwise a randomly generated Unsigned
		BYTE value.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- When a value is passed to the RNG, the appropriate overloaded function will be called.
		  Because of this, a value outside of an Unsigned BYTE becomes an int/long depending on the
		  value.  To ensure the RESULTS are not outside the range, the calling process needs to
		  validate the values PRIOR to calling.

		- Passing a negative value to a Unsigned 8-bit integer causes it to cycle.
		  For example -1 becomes 255.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			byte MinValue = byte.MinValue;
			byte MaxValue = byte.MaxValue;
			bool IsValid = true;  // Assume the value is valid

			//=============
			// Variables - outside the scope of BYTE
			//=============
			int Bad_MinValue = byte.MinValue - 1;
			int Bad_MaxValue = (byte.MaxValue + 1) * -1;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass negative values");

			if (Bad_MinValue < 0)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED BYTE.", Bad_MinValue);
				IsValid = false;
			}

			if (Bad_MaxValue < 0)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED BYTE.", Bad_MaxValue);
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
		} // private void Unsigned_BYTE_Negative_Values
	} // partial class BYTE_Testing
} // namespace RNG_Test
