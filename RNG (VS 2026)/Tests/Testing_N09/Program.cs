using System;
using Orias_RNG;

//=============
// Aliases
//=============
using Con = System.Console;

namespace Testing_N09
{
    class Program
    {
        static void Main(/*string[] args*/)
        /*
        ===========================================================================================
        PURPOSE:
        Test the NET 9.0 build of the RNG class.
        ===========================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            RNG My_RNG = new();

            //=============
            // Setup Environment
            //=============
            Con.WriteLine("Testing RNG_NS21 build of RNG class.");
            Con.WriteLine("Random Number: " + My_RNG.Generate(false, true));

            //=============
            // Body
            //=============

            //=============
            // Cleanup Environment
            //=============
            Con.WriteLine("\nPress any key to exit.");
            Con.ReadKey();
        } // static void Main(/*string[] args*/)
    } // class Program
} // namespace Testing_N09