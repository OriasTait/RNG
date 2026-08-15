using System;
using Orias_RNG;

//=============
// Aliases
//=============
using Con = System.Console;

namespace Testing_NS21
{
    static partial class Program
    {
        static void Main(/*string[] args*/)
        /*
        ===========================================================================================
        PURPOSE:
        Test the NETSTANDARD 2.1 build of the RNG class.
        ===========================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            RNG My_RNG = new ();

            //=============
            // Body
            //=============
            /*

            Con.WriteLine("Testing RNG_NS21 build of RNG class.");
            Con.WriteLine("\nGenerating Boolean Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));

            byte Min_Byte = 0;
            byte Max_Byte = 255;
            Con.WriteLine("\nGenerating Byte Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Byte, Max_Byte));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Byte, Max_Byte));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Byte, Max_Byte));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Byte, Max_Byte));

            sbyte Min_SByte = -128;
            sbyte Max_SByte = 127;
            Con.WriteLine("\nGenerating SByte Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_SByte, Max_SByte));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_SByte, Max_SByte));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_SByte, Max_SByte));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_SByte, Max_SByte));

            short Min_Short = -32768;
            short Max_Short = 32767;
            Con.WriteLine("\nGenerating Short Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Short, Max_Short));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Short, Max_Short));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Short, Max_Short));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Short, Max_Short));

            ushort Min_UShort = 0;
            ushort Max_UShort = 65535;
            Con.WriteLine("\nGenerating Unsigned Short Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UShort, Max_UShort));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UShort, Max_UShort));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UShort, Max_UShort));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UShort, Max_UShort));

            int Min_Int = -2147483648;
            int Max_Int = 2147483647;
            Con.WriteLine("\nGenerating Integer Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Int, Max_Int));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Int, Max_Int));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Int, Max_Int));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Int, Max_Int));

            uint Min_UInt = 0;
            uint Max_UInt = 4294967295;
            Con.WriteLine("\nGenerating Unsigned Integer Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UInt, Max_UInt));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UInt, Max_UInt));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UInt, Max_UInt));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_UInt, Max_UInt));
             */

            //long Min_Long = -9223372036854775800;
            long Min_Long = -922337203685477580;
            long Max_Long = 922337203685477580;
            Con.WriteLine("\nGenerating Long Values");
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));
            Con.WriteLine("Random Number: " + My_RNG.Generate(Min_Long, Max_Long));

            //=============
            // Cleanup Environment
            //=============
            Con.WriteLine("\nPress any key to exit.");
            Con.ReadKey();
        } // static void Main(/*string[] args*/)
    } // static partial class Program
} // namespace Testing_NS21