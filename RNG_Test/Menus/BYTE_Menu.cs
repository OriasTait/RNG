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
		public void BYTE_Menu()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for the BYTE data type.
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

			BYTE_Testing BYTE_Test = new BYTE_Testing();

			//=============
			// Body
			//=============
			do
			{
				// Display the options
				Con.Clear();
				Con.WriteLine(@"Select an option:");
				Con.WriteLine(@"");
				Con.WriteLine(@"  1 => Signed 8-bit integer   (datatype: sbyte)");
				Con.WriteLine(@"  2 => Unsigned 8-bit integer (datatype: byte)");
				Con.WriteLine(@"");
				Con.WriteLine(@"  X => Exit this menu");
				Con.WriteLine(@"");
				Con.WriteLine(@"Press any key to continue...");
				Key_Pressed = Con.ReadKey().KeyChar;

				// Check the key that was pressed
				switch (Key_Pressed)
				{
					// Signed BYTE
					case '1':
						BYTE_Test.Signed_BYTE();
						break;

					// Unsigned BYTE
					case '2':
						BYTE_Test.Unsigned_BYTE();
						break;

					// Exit the Main loop
					case 'x':
					case 'X':
						break;
				}
			} while ((Key_Pressed != 'x') && (Key_Pressed != 'X'));
		} // public void BYTE_Menu
	} // partial class Menus
} // namespace RNG_Test
