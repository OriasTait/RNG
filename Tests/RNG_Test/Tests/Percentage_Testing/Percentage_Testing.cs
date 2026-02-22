using Orias_RNG;
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
	partial class Percentage_Testing
	{
        public void Percentage_Test()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for the percentage data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- This tests the generation of the user defined data type percentage specific to the RNG

		- The range of possible values is 0 to 100 with a precision of 18.
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
            Con.WriteLine(@"Testing of a Percentage");

            //=============
            // Pass values in the incorrect order
            //=============
            Percentage_Incorrect_Order();

            /*
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

			 */
            //=============
            // Cleanup Environment
            //=============
            Con.WriteLine();
			Con.WriteLine(@"Press any key to continue...");
			_ = Con.ReadKey().KeyChar;
        } // public void Percentage_Test
    } // partial class Percentage_Testing
} // namespace RNG_Test
