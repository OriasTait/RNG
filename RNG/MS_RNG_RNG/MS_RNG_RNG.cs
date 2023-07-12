using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;  // for RandomNumberGenerator
using System.Text;
using System.Threading.Tasks;

//=============
// Aliases
//=============
using App = System.Threading.Thread;

namespace Orias_RNG
{
    public partial class RNG
    {
        private long MS_RNG_RNG(long MinValue, long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Use the Microsoft RandomNumberGenerator class to generate a random number from the given
        MinValue up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Results;               // The results to return
            bool Positive = false;      // Is the Min and Max values both positive?
            bool ValidNumber = false;   // Flag to indicate if the results are valid.

            //=============
            // Variables - Random Number Generation
            //=============
            long LongRand;                                  // The long number that is randomly generated
            long Offset = MinValue;                         // Offset from 0
            byte[] RandomNumber = new byte[8];              // Long data types => 8 bytes
            RandomNumberGenerator RNG = RandomNumberGenerator.Create();
            long Selections = (MaxValue - MinValue) + 1;    // The number of selections possible

            //=============
            // Setup Environment
            //=============
            // Check if all values are expected to be positive
            if (MinValue >= 0) { Positive = true; }

            //=============
            // Body
            //=============
            do
            {
				// Fill the array with a random value.
				RNG.GetBytes(RandomNumber);

                // Convert to a long number
                LongRand = BitConverter.ToInt64(RandomNumber, 0);

                // Assign the results based on the random number
                Results = (LongRand % Selections) + Offset;

                // Check if it is fair and within the range
                if ((IsFair(LongRand, Selections)) && (IsInRange(MinValue, MaxValue, Results)))
                {
                    // If all values are expected to be positive, take the absolute value of the generated number
                    if (Positive) { Results = Math.Abs(Results); }

                    // Set the flag for valid number to true
                    ValidNumber = true;
                }
			}
			while (!ValidNumber);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private long MS_RNG_RNG(long MinValue, long MaxValue)
    } // public class RNG
} // namespace Orias_RNG
