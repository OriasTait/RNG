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
			byte MinValue = 0;
			byte MaxValue = 255;

			//=============
			// Setup Environment
			//=============
			Con.Clear();

			//=============
			// Body
			//=============

			//=============
			// Test the Byte
			//=============
			Con.WriteLine("Byte => Pass the values in the incorrect order (MaxValue, MinValue)");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.Write("{0}", MyRandomNumber.Generate(MaxValue, MinValue) + "\t");
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));

			// Pass Negative values
			//Con.WriteLine("\nByte => Pass negative values");

			// Pass the same value
			//Con.WriteLine("\nByte => Pass the same value");
			//Con.WriteLine("{0}", MyRandomNumber.Generate((byte)MaxValue, (byte)MaxValue));

			// Pass values outside the range
			//Con.WriteLine("\nByte => Pass values outside the range");

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
