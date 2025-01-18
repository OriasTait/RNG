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
		public void Unsigned_Short()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for a Unsigned Short data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of an Unsigned 16-bit integer.

		- The range of possible values is 0 to 65,535
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
			Con.WriteLine(@"Testing of an Unsigned 16-bit integer");

			//=============
			// Pass values in the incorrect order
			//=============
			Unsigned_Short_Incorect_Order();

			//=============
			// Pass Negative values
			//=============
			Unsigned_Short_Negative_Values();

			//=============
			// Pass the same value
			//=============
			Unsigned_Short_Same_Value();

			//=============
			// Pass values outside the range
			//=============
			Unsigned_Short_Values_Outside_Range();

			//=============
			// Pass the values in the correct order
			//=============
			Unsigned_Short_Correct_Order();

			//=============
			// Do a loop
			//=============
			Unsigned_Short_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Unsigned_Short
	} // partial class Integer_Testing
} // namespace RNG_Test
