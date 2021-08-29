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
            int RNGProcess;
            int Max;
            int Min;

            //=============
            // Setup Environment
            //=============
            // Verify the parameters
            if (MinValue < MaxValue)
			{
                Min = MinValue;
                Max = MaxValue;
            }
            else
            {
                Min = MaxValue;
                Max = MinValue;
            }

            // Chose the process to use
            RNGProcess = Choose_Process();

            //=============
            // Body
            //=============
            // Execute the chosen method
            switch (RNGProcess)
			{
                case (int)RNGTypes.Class_Random:
                    Results = MS_Random(Min, Max);
                    break;
			}

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate(int MinValue, int MaxValue)
    } // public class RNG
}
