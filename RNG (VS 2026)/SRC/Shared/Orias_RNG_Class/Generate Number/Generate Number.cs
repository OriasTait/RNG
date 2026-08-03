using System;
using System.Collections.Generic;
using System.Text;

//=============
// Aliases
//=============
using App = System.Threading.Thread;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        private long Generate_Number(long Min_Value, long Max_Value)
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
            byte Min_Value_Wait = 1;
            byte Max_Value_Wait = 21;

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref Min_Value, ref Max_Value);

            // Check if all values are expected to be positive
            Positive_Only = (Min_Value >= 0);

            //=============
            // Body
            //=============
            // Choose a process
            int RNGProcess = Choose_Process();

            // Use the chosen method
            switch (RNGProcess)
            {
                case (int)RNG_Types.Class_Random:
                    Results = MS_RNG(Min_Value, Max_Value);

                    // wait up to 20 miliseconds (1000 => 1 second) using the same generator to avoid duplicate numbers
                    App.Sleep((int)MS_RNG(Min_Value_Wait, Max_Value_Wait));
                    break;

                case (int)RNG_Types.Class_RNG_RNG:
                    Results = MS_Random(Min_Value, Max_Value);

                    // wait up to 20 miliseconds (1000 => 1 second) using the same generator to avoid duplicate numbers
                    App.Sleep((int)MS_Random(Min_Value_Wait, Max_Value_Wait));
                    break;
            }

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Generate_Number()
    } // public partial class RNG
} // namespace Orias_RNG
