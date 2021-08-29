using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;  // for RNGCryptoServiceProvider
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        private int Choose_Process()
        /*
        ===============================================================================================
        PURPOSE:
        Randomly chose which random number generator to use.
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated selection for the process to use.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This uses the Crypto Service Provider and therefore is limited to 255 selections.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            int Results;

            //=============
            // Variables - Random Number Generation
            //=============
            byte[] RandomNumber = new byte[1];  // Place to store the random number
            int RNGCount = (int)RNGTypes.END;  // Obtain the count of different types to use
            RNGCryptoServiceProvider RNGCSP = new RNGCryptoServiceProvider();

            //=============
            // Body
            //=============
            // Fill the array with a random value.
            do
            {
                // Fill the array with a random value.
                RNGCSP.GetBytes(RandomNumber);

                // Assign the results based on the random number
                Results = (RandomNumber[0] % RNGCount);
            }
            while (!IsFair(RandomNumber[0], RNGCount));

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Choose_Process()

        private static bool IsFair(byte Number, int Selections)
        /*
        ===============================================================================================
        PURPOSE:
        Validates that the random number is a fair selection.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - Number        => The random number that was generated
        - Selections    => The number of selections available
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - If the provided number is fair based on the number of selections, true; otherwise, false.
        ===============================================================================================
        */
        {
            //=============
            // Setup Environment
            //=============
            // There are MaxValue / numSides full sets of numbers that can come up in a single byte.
            int FullSetsOfValues = Byte.MaxValue / Selections;

            //=============
            // Body
            //=============
            // Calculate the results
            bool Results = (Number < Selections * FullSetsOfValues);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private static bool IsFair(byte Number, int Selections)
    } // public class RNG
}
