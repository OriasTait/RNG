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
		private void Signed_Integer_Loop()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for and Signed Integer within a loop.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Signed Integer values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			int MinValue = int.MinValue;
			int MaxValue = int.MaxValue;

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
		} // private void Signed_Integer_Loop
	} // partial class Integer_Testing
} // namespace RNG_Test
