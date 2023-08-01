﻿using System;
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
		private void Unsigned_Short_Values_Outside_Range()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned Short when the parameters that are provided
		are outside the range of an Unsigned Integer.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		An error message if the values are outside the range; otherwise a randomly generated Signed
		Integer value.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- When a value is passed to the RNG, the appropriate overloaded function will be called.
		  Because of this, a value outside of an Unsigned Integer becomes a larger unit depending on the
		  value.  To ensure the RESULTS are not outside the range, the calling process needs to
		  validate the values PRIOR to calling.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			ushort MinValue = ushort.MinValue;
			ushort MaxValue = ushort.MaxValue;
			bool IsValid = true;  // Assume the value is valid

			//=============
			// Variables - outside the scope of an Unsigned Integer
			//=============
			long Bad_MinValue = ushort.MinValue;
			long Bad_MaxValue = ushort.MaxValue;

			//=============
			// Setup Environment
			//=============
			// Performing this calculation at declaration causes an overflow error.
			Bad_MinValue -= 1;
			Bad_MaxValue += 1;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass values outside the range");

			// Validate the minimum value
			if (Bad_MinValue < ushort.MinValue)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED Short.", Bad_MinValue);
				IsValid = false;
			}

			// Validate the maximum value
			if (Bad_MaxValue > ushort.MaxValue)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to UNSIGNED Short.", Bad_MaxValue);
				IsValid = false;
			}

			// Perform the call if we are still valid
			if (IsValid)
			{
				Con.Write("{0}", MyRandomNumber.Generate(Bad_MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, Bad_MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(Bad_MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, Bad_MaxValue) + "\t");
				Con.WriteLine("{0}", MyRandomNumber.Generate(Bad_MinValue, Bad_MaxValue));
			}
		} // private void Unsigned_Short_Values_Outside_Range
	} // partial class Integer_Testing
} // namespace RNG_Test