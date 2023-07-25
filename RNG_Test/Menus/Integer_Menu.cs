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
		public void Integer_Menu()
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

			Integer_Testing Integer_Test = new Integer_Testing();

			//=============
			// Body
			//=============
			do
			{
				// Display the options
				Con.Clear();
				Con.WriteLine(@"Select an option:");
				Con.WriteLine(@"");
				Con.WriteLine(@"  1 => Signed 16-bit integer");
				Con.WriteLine(@"  2 => Unsigned 16-bit integer");
				Con.WriteLine(@"  3 => Signed 32-bit integer");
				Con.WriteLine(@"  4 => Unsigned 32-bit integer");
				Con.WriteLine(@"");
				Con.WriteLine(@"  X => Exit this menu");
				Con.WriteLine(@"");
				Con.WriteLine(@"Press any key to continue...");
				Key_Pressed = Con.ReadKey().KeyChar;

				// Check the key that was pressed
				switch (Key_Pressed)
				{
					// Signed Short
					// Unsigned Short

					// Signed Integer
					case '3':
						Integer_Test.Signed_Integer();
						break;

					// Unsigned Integer
					case '4':
						Integer_Test.Unsigned_Integer();
						break;

					// Exit the Main loop
					case 'x':
					case 'X':
						break;
				}
			} while ((Key_Pressed != 'x') && (Key_Pressed != 'X'));
		} // public void Integer_Menu
	} // partial class Menus
} // namespace RNG_Test
