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
		public void Main_Menu()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the main menu until exit has been chosen
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Presentation of the chosen option.
		-----------------------------------------------------------------------------------------------
		NOTES:
		- Note 1
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			char Key_Pressed;

			//=============
			// Body
			//=============
			do
			{
				// Display the options
				Con.Clear();
				Con.WriteLine(@"Select an option:");
				Con.WriteLine(@"");
				Con.WriteLine(@"  1 => Test Boolean");
				Con.WriteLine(@"  2 => Test Integer");
                Con.WriteLine(@"  3 => Test Percentage");
                Con.WriteLine(@"");
				Con.WriteLine(@"  X => Exit the this menu");
				Con.WriteLine(@"");
				Con.Write(@"Press any key to continue...");
				Con.WriteLine(@"");
				Key_Pressed = Con.ReadKey().KeyChar;

				// Check the key that was pressed
				switch (Key_Pressed)
				{
					// Boolean
					case '1':
						Boolean_Menu();
						break;

					// Integers
					case '2':
						Integer_Menu();
						break;

                    // Percentages
                    case '3':
                        Percentage_Menu();
                        break;

                    // Exit the Main loop
                    case 'x':
					case 'X':
						break;
				}
			} while ((Key_Pressed != 'x') && (Key_Pressed != 'X'));
		} // public void Main_Menu
	} // partial class Menus
} // namespace RNG_Test
