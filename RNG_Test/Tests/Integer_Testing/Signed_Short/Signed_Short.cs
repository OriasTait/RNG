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
		public void Signed_Short()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for a Signed Short data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of a Signed 16-bit integer.

		- The range of possible values is -32,768 to 32,767
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
			Con.WriteLine(@"Testing of a Signed 16-bit integer");

			//=============
			// Pass values in the incorrect order
			//=============
			Signed_Short_Incorect_Order();

			//=============
			// Pass Negative values
			//=============
			Signed_Short_Negative_Values();

			//=============
			// Pass the same value
			//=============
			Signed_Short_Same_Value();

			//=============
			// Pass values outside the range
			//=============
			Signed_Short_Values_Outside_Range();

			//=============
			// Pass the values in the correct order
			//=============
			Signed_Short_Correct_Order();

			//=============
			// Do a loop
			//=============
			Signed_Short_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Signed_Short
	} // partial class Integer_Testing
} // namespace RNG_Test
