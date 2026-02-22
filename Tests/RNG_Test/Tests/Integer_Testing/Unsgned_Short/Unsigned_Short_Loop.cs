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
	partial class Integer_Testing
	{
		private void Unsigned_Short_Loop()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for an Unsigned Short within a loop.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Unsigned Short values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			ushort MinValue = ushort.MinValue;
			ushort MaxValue = ushort.MaxValue;

			//=============
			// Body
			//=============
			Con.WriteLine();
			Con.WriteLine(@"Generate 5 random numbers 3 times");
			for (int i = 0; i < 3; i++)
			{
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.Write("{0}", MyRandomNumber.Generate(MinValue, MaxValue) + "\t");
				Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			}
		} // private void Unsigned_Short_Loop
	} // partial class Integer_Testing
} // namespace RNG_Test
