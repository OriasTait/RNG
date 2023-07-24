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
		public void Unsigned_Integer()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for a Unsigned Integer data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of an Unsigned 32-bit integer.

		- The range of possible values is 0 to 4,294,967,295
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
			Con.WriteLine(@"Testing of a Unsigned 32-bit integer");

			//=============
			// Pass values in the incorrect order
			//=============
			Unsigned_Integer_Incorect_Order();

			//=============
			// Pass Negative values
			//=============
			Unsigned_Integer_Negative_Values();

			//=============
			// Pass the same value
			//=============
			Unsigned_Integer_Same_Value();

			//=============
			// Pass values outside the range
			//=============
			Unsigned_Integer_Values_Outside_Range();

			//=============
			// Pass the values in the correct order
			//=============
			Unsigned_Integer_Correct_Order();

			//=============
			// Do a loop
			//=============
			Unsigned_Integer_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Signed_Integer
	} // partial class Integer_Testing
} // namespace RNG_Test
