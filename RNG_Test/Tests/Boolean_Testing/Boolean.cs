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
	partial class Boolean_Testing
	{
		public void Boolean()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for a boolean data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of a boolean.

		- The range of possible values is "true" or "false".

		- Because the boolean can only have 2 values, the following tests are invalid:
		  - Pass Negative values
		  - Pass values outside the range
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
			Con.WriteLine(@"Testing of a boolean");

			//=============
			// Pass values in the incorrect order
			//=============
			Boolean_Incorect_Order();

			//=============
			// Pass the same value
			//=============
			Boolean_Same_Value();

			//=============
			// Pass the values in the correct order
			//=============
			Boolean_Correct_Order();

			//=============
			// Do a loop
			//=============
			Boolean_Loop();

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
		} // public void Signed_Integer
	} // partial class Integer_Testing
} // namespace RNG_Test
