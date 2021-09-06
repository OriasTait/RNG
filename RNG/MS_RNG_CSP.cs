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
        private byte MS_RNG_CSP(byte MinValue, byte MaxValue)
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
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Min = MinValue;
            long Max = MaxValue;

            //=============
            // Body
            //=============
            byte Results = (byte)MS_RNG_CSP(Min, Max);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private byte MS_RNG_CSP(byte MinValue, byte MaxValue)

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
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Min = MinValue;
            long Max = MaxValue;

            //=============
            // Body
            //=============
            int Results = (int)MS_RNG_CSP(Min, Max);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int MS_Random(int MinValue, int MaxValue)

        private long MS_RNG_CSP(long MinValue, long MaxValue)
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
        - This is the core method that performs the random generation.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Results;
            bool ValidNumber = false;

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            //=============
            // Variables - Random Number Generation
            //=============
            long LongRand; // The long number that is randomly generated
            long Offset = MinValue;  // Offset from 0
            byte[] RandomNumber = new byte[8];  // Long data types => 8 bytes
            RNGCryptoServiceProvider RNGCSP = new RNGCryptoServiceProvider();
            long Selections = (MaxValue - MinValue) + 1;  // The number of selections possible

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

                // Check if it is fair and within the range
                if((IsFair(LongRand, Selections)) && (IsInRange(MinValue, MaxValue, Results)))
                { ValidNumber = true; }
			}
			while (!ValidNumber);

			//=============
			// Cleanup Environment
			//=============
			return Results;
        } // private long MS_RNG_CSP(long MinValue, long MaxValue)
    } // public class RNG
} // namespace MyRNG
