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
	partial class BYTE_Testing
	{
		public void Unsigned_BYTE()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for an Unsigned BYTE data type.
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
			// Setup Environment
			//=============
			Con.Clear();

			//=============
			// Body
			//=============
			Con.WriteLine(@"Testing of an Unsigned 8-bit integer");

			//=============
			// Pass values in the incorrect order
			//=============
			Unsigned_BYTE_Incorect_Order();

			//=============
			// Pass Negative values
			//=============
			Unsigned_BYTE_Negative_Values();

			//=============
			// Pass the same value
			//=============
			Unsigned_BYTE_Same_Value();

			//=============
			// Pass values outside the range
			//=============
			Unsigned_BYTE_Values_Outside_Range();

			//=============
			// Pass the values in the correct order
			//=============
			Unsigned_BYTE_Correct_Order();

			//=============
			// Do a loop
			//=============
			Unsigned_BYTE_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Unsigned_BYTE
	} // partial class BYTE_Testing
} // namespace RNG_Test
