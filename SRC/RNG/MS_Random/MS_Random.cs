using System;
using System.Collections.Generic;
using System.Linq;
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
        private long MS_Random(long MinValue, long MaxValue)
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
        - To ensure the next call is different from this one, after the number is generated the
          process waits a random amount of time before returning the results.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Results;
            Random RandomNumber = new Random();

            //=============
            // Variables - Random Number Generation
            //=============
            byte[] Buffer = new byte[8];                    // Long data types => 8 bytes
            long Offset = MinValue;                         // Offset from 0
            long Selections = (MaxValue - MinValue) + 1;    // The number of selections possible

            //=============
            // Setup Environment
            //=============
            Valid_Number = false;   // Start by assuming the number is not valid

            //=============
            // Body
            //=============
            // Generate a long
            do
            {
                // Fill the array with a random value.
                RandomNumber.NextBytes(Buffer);

                // Convert to a long number
                Long_Rand = BitConverter.ToInt64(Buffer, 0);

                // Assign the results based on the random number
                Results = (Long_Rand % Selections) + Offset;

                // If all values are expected to be positive, take the absolute value of the generated number
                if (Positive_Only)
				{ Results = Math.Abs(Results); }

                // Check if it is fair and within the range
                if ((IsFair(Long_Rand, Selections)) && (IsInRange(MinValue, MaxValue, Results)))
                { Valid_Number = true; }
            }
            while (!Valid_Number);

            //=============
            // Cleanup Environment
            //=============
            // Wait a random bit of time to ensure a new seed
            App.Sleep(RandomNumber.Next(1, 21));  // wait up to 20 miliseconds (1000 => 1 second)

            // Return the results
            return Results;
        } // private long MS_Random(long MinValue, long MaxValue)
    } // public class RNG
} // namespace Orias_RNG
