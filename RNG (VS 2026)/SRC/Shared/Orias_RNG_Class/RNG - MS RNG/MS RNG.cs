using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        private long MS_RNG(long MinValue, long MaxValue)
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

            //=============
            // Variables - Random Number Generation
            //=============
            long Offset = MinValue;                         // Offset from 0
            byte[] RandomNumber = new byte[8];              // Long data types => 8 bytes
            long Selections = (MaxValue - MinValue) + 1;    // The number of selections possible

            //=============
            // Setup Environment
            //=============
            // Create a new instance of the RandomNumberGenerator class
            RandomNumberGenerator RNG = RandomNumberGenerator.Create();

            // Start by assuming the number is not valid
            Valid_Number = false;   

            //=============
            // Body
            //=============
            do
            {
                // Fill the array with a random value.
                RNG.GetBytes(RandomNumber);

                // Convert to a long number
                Long_Rand = BitConverter.ToInt64(RandomNumber, 0);

                // Assign the results based on the random number
                Results = (Long_Rand % Selections) + Offset;

                // Check if it is fair and within the range
                if ((Is_Fair(Long_Rand, Selections)) && (Is_In_Range(MinValue, MaxValue, Results)))
                {
                    // If all values are expected to be positive, take the absolute value of the generated number
                    if (Positive_Only) { Results = Math.Abs(Results); }

                    // Set the flag for valid number to true
                    Valid_Number = true;
                }
            }
            while (!Valid_Number);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private long MS_RNG(long MinValue, long MaxValue)
    } // public partial class RNG
} // namespace Orias_RNG
