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
		private void Signed_Short_Values_Outside_Range()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for and Signed Short when the parameters that are provided
		are outside the range of a Signed Short.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		An error message if the values are outside the range; otherwise a randomly generated Signed
		Short value.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- When a value is passed to the RNG, the appropriate overloaded function will be called.
		  Because of this, a value outside of a Signed Short becomes a larger unit depending on the
		  value.  To ensure the RESULTS are not outside the range, the calling process needs to
		  validate the values PRIOR to calling.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			short MinValue = short.MinValue;
			short MaxValue = short.MaxValue;
			bool IsValid = true;  // Assume the value is valid

			//=============
			// Variables - outside the scope of a Signed Integer
			//=============
			long Bad_MinValue = int.MinValue;
			long Bad_MaxValue = int.MaxValue;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass values outside the range");

			// Validate the minimum value
			if (Bad_MinValue < short.MinValue)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to SIGNED Short.", Bad_MinValue);
				IsValid = false;
			}

			// Validate the maximum value
			if (Bad_MaxValue > short.MaxValue)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to SIGNED Short.", Bad_MaxValue);
				IsValid = false;
			}

			// Perform the call if we are still valid
			if (IsValid)
			{
				Con.WriteLine("Something is wrong with the validation.");
				Con.WriteLine("Values greater than {0} and less than {1} are not allowed.", MinValue, MaxValue);
			}
		} // private void Signed_Short_Values_Outside_Range
	} // partial class Integer_Testing
} // namespace RNG_Test
