using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orias_RNG;

namespace RNG_Test
{
	internal static class Program
	{
		static void Main(/*string[] args*/)
		{
			//=============
			// Variables - Standard
			//=============
			//Menus Main_Menu = new Menus();

			//=============
			// Body
			//=============
			//Main_Menu.Main_Menu();

			float Whole_Number;

			//=============
			// Float
			//=============
			// 7 total numeric places
			// Last decimal is rounded; substring to 7 places removes the rounding issue
			float f;
			float Float_Min = -9999999;
			float Float_Max = 9999999;
			float f_base = 0.88888888888888888888f;

			// -9999999 + base
			// !!! Exponent !!!!
			Whole_Number = -9999999;
			f = Whole_Number - f_base;
			if (f.CompareTo(Float_Min) < 0) { Console.WriteLine(@"Float value {0} cannot be used.", f); }
			else 
			{
				Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded
			}

			// -9999999
			Whole_Number = -9999999;
			f = Whole_Number;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// -123456 + base
			Whole_Number = -123456;
			f = Whole_Number - f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// -123 + base
			Whole_Number = -123;
			f = Whole_Number - f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// -1 + base
			Whole_Number = -1;
			f = Whole_Number - f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			Whole_Number = -1;
			f = Whole_Number;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			Whole_Number = 0;
			f = Whole_Number;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// 0 + base
			Whole_Number = 0;
			f = Whole_Number + f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: 0.1234568  <== Last value rounded

			// 1
			Whole_Number = 1;
			f = Whole_Number;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// 1 + base
			Whole_Number = 1;
			f = Whole_Number + f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// 123 + base
			Whole_Number = 123;
			f = Whole_Number + f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// 123456 + base
			Whole_Number = 123456;
			f = Whole_Number + f_base;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// 9999999 (max value)
			Whole_Number = 9999999;
			f = Whole_Number;
			Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded

			// 9999999 (max value) + base
			// !!! Exponent !!!!
			Whole_Number = 9999999;
			f = Whole_Number + f_base;
			if (f.CompareTo(Float_Max) > 0) { Console.WriteLine(@"Float value {0} cannot be used.", f); }
			else 
			{
				Console.WriteLine(@"Float value: " + "\t\t" + @"{0}", f);  // output: -0.1234568  <== Last value rounded
			}

			//=============
			// Double
			//=============
			// 15 total numeric places
			// Last decimal is rounded; substring to 16 places removes the rounding issue
			// uses exponents
			//Console.WriteLine();
			//double d = double.MaxValue;
			//Console.WriteLine(@"Double Min Value: {0}", d);  // output: 1.79769313486232E+308
			//d = double.MinValue;
			//Console.WriteLine(@"Double Max Value: {0}", d);  // output: -1.79769313486232E+308
			//d = 0.1234567890123456D;
			//Console.WriteLine(@"Double Value: {0}", d);  // output: 0.123456789012346 <== Last value rounded
			//Console.WriteLine(@"Double Value: {0}", d.ToString().Substring(0, 16));  // output: 0.12345678901234  <== Last value NOT rounded
			//Whole_Number = 9;
			//d = Whole_Number + 0.1234567890123456D;
			//Console.WriteLine(@"Double Value: {0}", d);  // output: 1.84467440737096E+19 <== Last value rounded with exponent
			//Console.WriteLine(@"Double Value: {0}", d.ToString().Substring(0, 15));  // output: 1.84467440737096  <== Last value NOT rounded WITHOUT exponent
			//Whole_Number = 98;
			//d = Whole_Number + 0.1234567890123456D;
			//Console.WriteLine(@"Double Value: {0}", d);  // output: 1.84467440737096E+19 <== Last value rounded with exponent
			//Console.WriteLine(@"Double Value: {0}", d.ToString().Substring(0, 15));  // output: 1.84467440737096  <== Last value NOT rounded WITHOUT exponent

			//=============
			// Decimal
			//=============
			// 29 total numeric places
			// Integers take precidence
			// Last decimal is rounded; substring to 28 places removes the rounding issue
			//Console.WriteLine();
			//decimal dec = decimal.MaxValue;
			//Console.WriteLine(@"Decimal Min Value: {0}", dec);  // output: 79228162514264337593543950335
			//dec = decimal.MinValue;
			//Console.WriteLine(@"Decimal Max Value: {0}", dec);  // output: -79228162514264337593543950335
			//dec = 0.123456789012345678901234567890M;
			//Console.WriteLine(@"Decimal Value: {0}", dec);  // output: 0.123456789012346  <== Last value rounded
			//Console.WriteLine(@"Decimal Value: {0}", dec.ToString().Substring(0, 29));  // output: 0.123456789012345678901234567 <== Last value rounded
			//Whole_Number = 5;
			//dec = Whole_Number + 0.123456789012345678901234567890M;
			//Console.WriteLine(@"Decimal Value: {0}", dec);  // output: 5.1234567890123456789012345679  <== Last value rounded
			//Console.WriteLine(@"Decimal Value: {0}", dec.ToString().Substring(0, 28));  // output: 98.1234567890123456789012345  <== Last value NOT rounded
			//Whole_Number = 98;
			//dec = Whole_Number + 0.123456789012345678901234567890M;
			//Console.WriteLine(@"Decimal Value: {0}", dec);  // output: 98.12345678901234567890123457  <== Last value rounded
			//Console.WriteLine(@"Decimal Value: {0}", dec.ToString().Substring(0, 28));  // output: 98.1234567890123456789012345  <== Last value NOT rounded
			//Whole_Number = ulong.MaxValue;
			//dec = Whole_Number + 0.123456789012345678901234567890M;
			//Console.WriteLine(@"Decimal Value: {0}", dec);  // output: 18446744073709551615.123456789 <== Last value rounded
			//Console.WriteLine(@"Decimal Value: {0}", dec.ToString().Substring(0,29));  // output: 18446744073709551615.123456789 <== Last value rounded
			//dec += dec;
			//Console.WriteLine(@"Decimal Value: {0}", dec);  // output: 18446744073709551615.123456789 <== Last value rounded
			//Console.WriteLine(@"Decimal Value: {0}", dec.ToString().Substring(0, 29));  // output: 18446744073709551615.123456789 <== Last value rounded

			//int a = 3;

			//decimal m = 1.5E6m;
			//Console.WriteLine(m);  // output: 1500000

			Console.ReadKey();
		} // static void Main
	} // class Program
} // namespace RNG_Test
