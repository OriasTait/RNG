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
		public void Signed_Integer()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for a Signed BYTE data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of an Signed 32-bit integer.

		- The range of possible values is -2,147,483,648 to 2,147,483,647
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
			Con.WriteLine(@"Testing of a Signed 32-bit integer");

			//=============
			// Pass values in the incorrect order
			//=============
			Signed_Integer_Incorect_Order();

			//=============
			// Pass Negative values
			//=============
			Signed_Integer_Negative_Values();

			//=============
			// Pass the same value
			//=============
			Signed_Integer_Same_Value();

			//=============
			// Pass values outside the range
			//=============
			Signed_Integer_Values_Outside_Range();

			//=============
			// Pass the values in the correct order
			//=============
			Signed_Integer_Correct_Order();

			//=============
			// Do a loop
			//=============
			Signed_Integer_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Signed_Integer
	} // partial class Integer_Testing
} // namespace RNG_Test
