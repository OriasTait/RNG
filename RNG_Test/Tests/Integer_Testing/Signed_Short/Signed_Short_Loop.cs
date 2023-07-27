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
		private void Signed_Short_Loop()
		/*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for a Signed Short within a loop.
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Signed Short values.
		===============================================================================================
		*/
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			short MinValue = short.MinValue;
			short MaxValue = short.MaxValue;

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
		} // private void Signed_Short_Loop
	} // partial class Integer_Testing
} // namespace RNG_Test
