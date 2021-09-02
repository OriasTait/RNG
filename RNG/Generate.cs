using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        public byte Generate(byte MinValue, byte MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for bytes
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            byte Results = 0;

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            //=============
            // Body
            //=============
            // Choose a process
            int RNGProcess = Choose_Process();

            //=============
            // DEBUG => Ensure the selection I want
            //=============
            //RNGProcess = (int)RNGTypes.Class_Random;
            //int RNGProcess = (int)RNGTypes.Class_RNG_CSP;

            switch (RNGProcess)
            {
                case (int)RNGTypes.Class_Random:
                    Results = (byte)MS_Random(MinValue, MaxValue, DataTypes.Byte);
                    break;

				case (int)RNGTypes.Class_RNG_CSP:
					Results = MS_RNG_CSP(MinValue, MaxValue);
					break;
			}

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public byte Generate(byte MinValue, byte MaxValue)

        public int Generate(int MinValue, int MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
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
            int Results = 0;

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            //=============
            // Body
            //=============
            // Choose a process
            int RNGProcess = Choose_Process();

            //=============
            // DEBUG => Ensure the selection I want
            //=============
            //RNGProcess = (int)RNGTypes.Class_Random;
            //int RNGProcess = (int)RNGTypes.Class_RNG_CSP;

            // Execute the chosen method
            switch (RNGProcess)
			{
                case (int)RNGTypes.Class_Random:
                    Results = (int)MS_Random(MinValue, MaxValue, DataTypes.Integer);
                    break;

                    // How to standardize?
				case (int)RNGTypes.Class_RNG_CSP:
					Results = MS_RNG_CSP(MinValue, MaxValue);
					break;
			}

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate(int MinValue, int MaxValue)
    } // public class RNG
}
