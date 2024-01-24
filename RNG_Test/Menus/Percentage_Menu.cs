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
	partial class Menus
	{
		public void Percentage_Menu()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for the Integer data type.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			char Key_Pressed;

            Percentage_Testing Percentage_Test = new Percentage_Testing();

			//=============
			// Body
			//=============
			do
			{
				// Display the options
				Con.Clear();
				Con.WriteLine(@"Select an option:");
                Con.WriteLine(@"");
                Con.WriteLine(@"  1 => Percentage");
                Con.WriteLine(@"");
                Con.WriteLine(@"  X => Exit this menu");
                Con.WriteLine(@"");
				Con.WriteLine(@"Press any key to continue...");
				Key_Pressed = Con.ReadKey().KeyChar;

                // Check the key that was pressed
				switch (Key_Pressed)
				{
					// Signed Byte
					case '1':
                        Percentage_Test.Percentage_Test();
						break;
                }
            } while ((Key_Pressed != 'x') && (Key_Pressed != 'X'));
        } // public void Percentage_Menu
    } // partial class Menus
} // namespace RNG_Test
