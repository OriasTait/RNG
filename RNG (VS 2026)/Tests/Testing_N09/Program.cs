using System;
using Orias_RNG;

//=============
// Aliases
//=============
using Con = System.Console;

namespace RNG_N09
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
            RNG My_RNG = new RNG();

            //=============
            // Setup Environment
            //=============
            Con.WriteLine("Testing RNG_NS21 build of RNG class.");
            Con.WriteLine("Random Number: " + My_RNG.Generate());

            //=============
            // Body
            //=============

            //=============
            // Cleanup Environment
            //=============
            Con.ReadKey();
        } // static void Main(/*string[] args*/)
    } // class Program
} // namespace RNG_N09
