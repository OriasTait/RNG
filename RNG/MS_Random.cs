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
