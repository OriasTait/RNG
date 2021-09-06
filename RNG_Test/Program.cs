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
			int MinValue = 0;
			int MaxValue = 10;

			//=============
			// Body
			//=============
			// Pass the values in the incorrect order
			Console.WriteLine("Pass the values in the incorrect order");
			Console.WriteLine("{0}", MyRandomNumber.Generate((byte)MinValue, (byte)MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MinValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate((long)MinValue, (long)MaxValue));

			// Pass the same value
			Console.WriteLine("");
			Console.WriteLine("Pass the same value:");
			Console.WriteLine("{0}", MyRandomNumber.Generate((byte)MaxValue, (byte)MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MaxValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate((long)MaxValue, (long)MaxValue));

			// Pass the values in the correct order
			Console.WriteLine("");
			Console.WriteLine("Pass the values in the correct order");
			Console.WriteLine("{0}", MyRandomNumber.Generate((byte)MinValue, (byte)MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			Console.WriteLine("{0}", MyRandomNumber.Generate((long)MinValue, (long)MaxValue));

			// DEBUG => Generate a lot that are giving issues
			//for (int i = 0; i < 50; i++)
			//{
			//	//Console.WriteLine("{0}", MyRandomNumber.Generate(MinValue, MaxValue));
			//	Console.WriteLine("{0}", MyRandomNumber.Generate((long)MinValue, (byte)MaxValue));
			//}

			//=============
			// Cleanup Environment
			//=============
			Console.WriteLine("");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		} // static void Main(string[] args)
	} // class Program
} // namespace RNG_Test
