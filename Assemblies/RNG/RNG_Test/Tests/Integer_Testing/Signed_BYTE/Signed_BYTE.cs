using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//=============
// Aliases
//=============
using Con = System.Console;

namespace RNG_Test
{
	partial class Integer_Testing
	{
		public void Signed_BYTE()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for a Signed BYTE data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of an Signed 8-bit integer.

		- The range of possible values is -128 to 127
		===============================================================================================
		*/
		{
			//=============
			// Setup Environment
			//=============
			Con.Clear();

			//=============
			// Body
			//=============
			Con.WriteLine(@"Testing of a Signed 8-bit integer");

			//=============
			// Pass values in the incorrect order
			//=============
			Signed_BYTE_Incorect_Order();

			//=============
			// Pass Negative values
			//=============
			Signed_BYTE_Negative_Values();

			//=============
			// Pass the same value
			//=============
			Signed_BYTE_Same_Value();

			//=============
			// Pass values outside the range
			//=============
			Signed_BYTE_Values_Outside_Range();

			//=============
			// Pass the values in the correct order
			//=============
			Signed_BYTE_Correct_Order();

			//=============
			// Do a loop
			//=============
			Signed_BYTE_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Integer_Testing
	} // partial class BYTE_Testing
} // namespace RNG_Test
