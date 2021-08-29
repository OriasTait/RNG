using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;  // for RNGCryptoServiceProvider
using System.Text;
using System.Threading.Tasks;

//=============
// Aliases
//=============
using App = System.Threading.Thread;

namespace MyRNG
{
    public partial class RNG
    {
        private int MS_RNG_CSP(int MinValue, int MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Use the Microsoft Random class to generate a random number from the given MinValue up to
        (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for Integers
        - Because this is based on a byte, this is limited to values of 0 - 255.
        - It is assumed that the MinValue and MaxValue have been verified to work for this process
          prior to it being called.
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
            int Offset = MinValue;  // Offset from 0
            byte[] RandomNumber = new byte[1];  // Place to store the random number
            RNGCryptoServiceProvider RNGCSP = new RNGCryptoServiceProvider();
            int Selections = (MaxValue - MinValue) + 1;  // The number of selections possible

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            //=============
            // Body
            //=============
            // Fill the array with a random value.
            do
            {
                // Fill the array with a random value.
                RNGCSP.GetBytes(RandomNumber);

                // Assign the results based on the random number
                Results = (RandomNumber[0] % Selections) + Offset;
            }
            while (!IsFair(RandomNumber[0], Selections));

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int MS_Random(int MinValue, int MaxValue)
    } // public class RNG
}
