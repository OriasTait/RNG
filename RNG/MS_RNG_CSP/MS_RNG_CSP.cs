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

namespace Orias_RNG
{
    public partial class RNG
    {
        private long MS_RNG_CSP(long MinValue, long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Use the Microsoft RNGCryptoServiceProvider class to generate a random number from the given
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
            long Results;
            bool ValidNumber = false;

            //=============
            // Variables - Random Number Generation
            //=============
            long LongRand;                                  // The long number that is randomly generated
            long Offset = MinValue;                         // Offset from 0
            byte[] RandomNumber = new byte[8];              // Long data types => 8 bytes
            RNGCryptoServiceProvider RNGCSP = new RNGCryptoServiceProvider();
            long Selections = (MaxValue - MinValue) + 1;    // The number of selections possible

            //=============
            // Setup Environment
            //=============
            bool Positive = false;  // Is the Min and Max values both positive?

            // Check if all values are expected to be positive
            if (MinValue >= 0)
            { Positive = true; }

            //=============
            // Body
            //=============
            do
            {
				// Fill the array with a random value.
				RNGCSP.GetBytes(RandomNumber);

                // Convert to a long number
                LongRand = (long)BitConverter.ToInt64(RandomNumber, 0);

                // Assign the results based on the random number
                Results = (LongRand % Selections) + Offset;

                // If all values are expected to be positive, take the absolute value of the generated number
                if (Positive)
                { Results = Math.Abs(Results); }

                // Check if it is fair and within the range
                if ((IsFair(LongRand, Selections)) && (IsInRange(MinValue, MaxValue, Results)))
                { ValidNumber = true; }
			}
			while (!ValidNumber);

			//=============
			// Cleanup Environment
			//=============
			return Results;
        } // private long MS_RNG_CSP(long MinValue, long MaxValue)
    } // public class RNG
} // namespace Orias_RNG
