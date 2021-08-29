using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRNG;

using System.Security.Cryptography;

namespace RNG_Test
{
	class Program
	{
		static void Main(/*string[] args*/)
		{
			//=============
			// Variables - Standard
			//=============
			RNG MyRandomNumber = new RNG();
			int MinValue = -5;
			int MaxValue = 5;

			//=============
			// Body
			//=============
			// Pass the values in the incorrect order
			Console.WriteLine("Pass the values in the incorrect order");
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));

			// Pass the same value
			Console.WriteLine("");
			Console.WriteLine("Pass the same value:");
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));

			// Pass the values in the correct order
			Console.WriteLine("");
			Console.WriteLine("Pass the values in the correct order");
			Console.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));

			Console.ReadKey();
		} // static void Main(string[] args)
	}
}
