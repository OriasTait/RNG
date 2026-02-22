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
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1481:Unused local variables should be removed", Justification = "<Pending>")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
		private void Unsigned_Integer_Negative_Values()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned BYTE when the parameters that are provided
		are negative.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		An error message if the values are outside the range; otherwise a randomly generated Unsigned
		BYTE value.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- When a value is passed to the RNG, the appropriate overloaded function will be called.
		  Because of this, a value outside of an Unsigned Integer becomes a larger unit depending on
		  the value.  To ensure the RESULTS are not outside the range, the calling process needs to
		  validate the values PRIOR to calling.

		- Passing a negative value to a Unsigned 32-bit integer causes it to cycle.
		  For example -1 becomes 4,294,967,295.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			uint MinValue = uint.MinValue;
			uint MaxValue = uint.MaxValue;
			bool IsValid = true;  // Assume the value is valid

			//=============
			// Variables - outside the scope of an Unsigned Integer
			//=============
			int Bad_MinValue = int.MinValue;
			int Bad_MaxValue = -1;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass negative values");

			if (Bad_MinValue < 0)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED INTEGER.", Bad_MinValue);
				IsValid = false;
			}

			if (Bad_MaxValue < 0)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED INTEGER.", Bad_MaxValue);
				IsValid = false;
			}

			if (IsValid)
			{
				Con.WriteLine("Something is wrong with the validation.");
				Con.WriteLine("Values greater than {0} or less than {1} are not allowed.", MaxValue, MinValue);
			}
		} // private void Unsigned_Integer_Negative_Values
	} // partial class Integer_Testing
} // namespace RNG_Test
