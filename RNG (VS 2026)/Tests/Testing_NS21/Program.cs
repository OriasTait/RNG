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
            // Setup Environment
            //=============
            Con.WriteLine("Testing RNG_NS21 build of RNG class.");
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));
            Con.WriteLine("Random Number: " + My_RNG.Generate(true, false));

            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));
            Con.WriteLine("Random Number: " + My_RNG.Generate(-10, 10));

            //=============
            // Body
            //=============

            //=============
            // Cleanup Environment
            //=============
            Con.WriteLine("\nPress any key to exit.");
            Con.ReadKey();
        } // static void Main(/*string[] args*/)
    } // static partial class Program
} // namespace Testing_NS21