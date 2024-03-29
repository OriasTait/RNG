﻿using System;
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
		public void Boolean_Menu()
		/*
		===============================================================================================
		PURPOSE:
		Loop through the tests for the boolean data type.
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

			Boolean_Testing Boolean_Test = new Boolean_Testing();

			//=============
			// Body
			//=============
			do
			{
				// Display the options
				Con.Clear();
				Con.WriteLine(@"Select an option:");
				Con.WriteLine(@"");
				Con.WriteLine(@"  1 => Boolean (datatype: bool)");
				Con.WriteLine(@"");
				Con.WriteLine(@"  X => Exit this menu");
				Con.WriteLine(@"");
				Con.WriteLine(@"Press any key to continue...");
				Key_Pressed = Con.ReadKey().KeyChar;

				// Check the key that was pressed
				switch (Key_Pressed)
				{
					// Boolean
					case '1':
						Boolean_Test.Boolean();
						break;

					// Exit the Main loop
					case 'x':
					case 'X':
						break;
				}
			} while ((Key_Pressed != 'x') && (Key_Pressed != 'X'));
		} // public void Boolean_Menu
	} // partial class Menus
} // namespace RNG_Test
