using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
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
            int RNGProcess = 0;
            bool UsableProcess = false;

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            // Choose the process to use
            while (!UsableProcess)
			{
                // Choose a process
                RNGProcess = Choose_Process();

                // Assume the process can be used
                UsableProcess = true;

                // Validate if that process can be used based on the parameters
                if (RNGProcess == (int)RNGTypes.Class_RNG_CSP)
                {
                    if (MinValue < 0)
                    { UsableProcess = false; }

                    if (MaxValue > 255)
                    { UsableProcess = false; }
                }
            }

            //=============
            // Body
            //=============
            //=============
            // DEBUG => Ensure the selection I want
            //=============
            //RNGProcess = (int)RNGTypes.Class_Random;
            //RNGProcess = (int)RNGTypes.Class_RNG_CSP;

            // Execute the chosen method
            switch (RNGProcess)
			{
                case (int)RNGTypes.Class_Random:
                    Results = MS_Random(MinValue, MaxValue);
                    break;

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
