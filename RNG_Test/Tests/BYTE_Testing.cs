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
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2234:Arguments should be passed in the same order as the method parameters", Justification = "<Pending>")]
		public void Unsigned_BYTE()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for the BYTE data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of an Unsigned 8-bit integer.
		- The range of possible values is 0 to 255
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			byte MinValue = byte.MinValue;
			byte MaxValue = byte.MaxValue;

			//=============
			// Setup Environment
			//=============
			Con.Clear();

			//=============
			// Body
			//=============
			Con.WriteLine(@"Testing of an Unsigned 8-bit integer");

			//=============
			// Test the Byte
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass the values in the incorrect order (MaxValue, MinValue)");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));

			//=============
			// Pass Negative values
			// => Passing a negative value to a BYTE causes it to cycle to maxvalue. For example
			//    -1 becomes 255.
			//=============
			//Con.WriteLine("\nByte => Pass negative values");

			//=============
			// Pass the same value
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass the same value");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MaxValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));

			//=============
			// Pass values outside the range
			// => This automatically converts the call to an int.  Since this call is overloaded with the differnt
			//    types, the call to generate MUST validate the values before calling.
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass values outside the range");

			int Bad_MinValue = byte.MinValue - 1;
			int Bad_MaxValue = byte.MaxValue + 1;
			bool IsValid = true;  // Assume the value is valid

			if(Bad_MinValue < byte.MinValue)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to BYTE.", Bad_MinValue);
				IsValid = false;
			}

			if (Bad_MaxValue > byte.MaxValue)
			{
				Con.WriteLine(@"Intended value ({0}) cannot be converted to BYTE.", Bad_MaxValue);
				IsValid = false;
			}

			if (IsValid)
			{
				Con.Write("{0}", MyRandomNumber.Generate(Bad_MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, Bad_MaxValue) + "\t");
				Con.WriteLine("{0}", MyRandomNumber.Generate(Bad_MinValue, Bad_MaxValue));
			}

			//=============
			// Pass the values in the correct order
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Pass the valid values in the correct order (MinValue, MaxValue)");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));

			//=============
			// Do a loop
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Generate 3 random numbers 10 times");
			for (int i = 0; i < 10; i++)
			{
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			}

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Unsigned_BYTE
	} // partial class BYTE_Testing
} // namespace RNG_Test
