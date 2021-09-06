using System;
using System.Collections.Generic;
using System.Linq;
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
        private long MS_Random(long MinValue, long MaxValue, DataTypes DType)
        /*
        ===============================================================================================
        PURPOSE:
        Use the Microsoft Random class to generate a random number from the given MinValue up to
        (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        - DType     => Data type being generated
        -----------------------------------------------------------------------------------------------
        NOTES:
        - To ensure the next call is different from this one, after the number is generated the
          process waits a random amount of time before returning the results.
        - The .Next method is based on the data type used in the random generation.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Results = 0;
            Random RandomNumber = new Random();

			//=============
			// Body
			//=============
			// Generate a byte
			if (DType == DataTypes.Byte)
			{
				byte Min = (byte)MinValue;
				byte Max = (byte)MaxValue;

				Results = RandomNumber.Next(Min, Max + 1);  // MaxValue is incremented to include it as a potential result
			}

			// Generate an integer
			if (DType == DataTypes.Integer)
			{
				int Min = (int)MinValue;
				int Max = (int)MaxValue;

				Results = RandomNumber.Next(Min, Max + 1);  // MaxValue is incremented to include it as a potential result
			}

            // Generate an long
            if (DType == DataTypes.Long)
			{
                byte[] Buffer = new byte[8];  // Long data types => 8 bytes
                long LongRand; // The long number that is randomly generated
                long Offset = MinValue;  // Offset from 0
                long Selections = (MaxValue - MinValue) + 1;  // The number of selections possible
                bool ValidNumber = false;

                do
                {
                    // Fill the array with a random value.
                    RandomNumber.NextBytes(Buffer);

                    // Convert to a long number
                    LongRand = (long)BitConverter.ToInt64(Buffer, 0);

                    // Assign the results based on the random number
                    Results = (LongRand % Selections) + Offset;

                    // Check if it is fair and within the range
                    if ((IsFair(LongRand, Selections)) && (IsInRange(MinValue, MaxValue, Results)))
                    { ValidNumber = true; }
                }
                while (!ValidNumber);
            }

            //=============
            // Cleanup Environment
            //=============
            // Wait a random bit of time to ensure a new seed
            App.Sleep(RandomNumber.Next(1, 21));  // wait up to 20 miliseconds (1000 => 1 second)

            // Return the results
            return Results;
        } // private long MS_Random(long MinValue, long MaxValue, DataTypes DType)
    } // public class RNG
}
