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
        - It is expected to have no more than 255 possible methods.
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
    } // public class RNG
} // namespace MyRNG
