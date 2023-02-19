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
	internal static class Program
	{
		static void Main(/*string[] args*/)
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			int MinValue = 0;
			int MaxValue = 10;

			//=============
			// Body
			//=============
			// Pass the values in the incorrect order
			Con.WriteLine("Pass the values in the incorrect order");
			Con.WriteLine("{0}", MyRandomNumber.Generate((byte)MinValue, (byte)MaxValue));
#pragma warning disable S2234 // Parameters should be passed in the correct order
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));
#pragma warning restore S2234 // Parameters should be passed in the correct order
			Con.WriteLine("{0}", MyRandomNumber.Generate((long)MinValue, (long)MaxValue));

			// Pass the same value
			Con.WriteLine("\nPass the same value:");
			Con.WriteLine("{0}", MyRandomNumber.Generate((byte)MaxValue, (byte)MaxValue));
			Con.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
			Con.WriteLine("{0}", MyRandomNumber.Generate((long)MaxValue, (long)MaxValue));

			// Pass the values in the correct order
			Con.WriteLine("\nPass the values in the correct order");
			Con.WriteLine("{0}", MyRandomNumber.Generate((byte)MinValue, (byte)MaxValue));
			Con.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			Con.WriteLine("{0}", MyRandomNumber.Generate((long)MinValue, (long)MaxValue));

			// DEBUG => Generate a lot that are giving issues
			Con.WriteLine("\nInteger and Long Random Numbers 50 times");
			for (int i = 0; i < 50; i++)
			{
				Con.Write("Int: {0}", MyRandomNumber.Generate(MinValue, MaxValue).ToString() + " ");
				Con.WriteLine("Long: {0}", MyRandomNumber.Generate((long)MinValue, (byte)MaxValue));
			}

			//=============
			// Cleanup Environment
			//=============
			Con.WriteLine("\nPress any key to continue...");
			Con.ReadKey();
		} // static void Main(string[] args)
	} // class Program
} // namespace RNG_Test
