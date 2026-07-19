using System;
using Orias_RNG;

namespace Testing_NS21
{
    class Program
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
            RNG My_RNG = new RNG();

            //=============
            // Body
            //=============
            Console.WriteLine("Hello, World!");
        } // static void Main(/*string[] args*/)
    } // class Program
} // namespace Testing_NS21