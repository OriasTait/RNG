using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        private long Generate_Number(long MinValue, long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a number between the minimum and maximum values.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated number.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This is the core of the number generation.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Results = 0;

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            // Check if all values are expected to be positive
            Positive_Only = (MinValue >= 0);

            //=============
            // Body
            //=============
            // Choose a process
            int RNGProcess = Choose_Process();

            // Use the chosen method
            switch (RNGProcess)
            {
                case (int)RNG_Types.Class_Random:
                    Results = MS_RNG(MinValue, MaxValue);
                    break;

                case (int)RNG_Types.Class_RNG_CSP:
                    //Results = MS_RNG_CSP(MinValue, MaxValue);
                    break;

                case (int)RNG_Types.Class_RNG_RNG:
                    //Results = MS_RNG_RNG(MinValue, MaxValue);
                    break;
            }

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Generate_Number()
    } // public partial class RNG
} // namespace Orias_RNG
