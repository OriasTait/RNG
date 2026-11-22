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
        - Min_Value  => The minimum value to return
        - Max_Value  => The maximum value to return
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

            // miliseconds to wait before returning a value
            int Wait_Min = 1;
            int Wait_Max = 10;

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
                case (int)RNG_Types.MS_Random:
                    Results = MS_Random(Min_Value, Max_Value);

                    // Use the same engine to wait a random amount of time
                    App.Sleep((int)MS_Random(Wait_Min, Wait_Max));
                    break;

                case (int)RNG_Types.MS_Random_Number_Generator:
                    Results = MS_Random_Number_Generator(Min_Value, Max_Value);

                    // Use the same engine to wait a random amount of time
                    App.Sleep((int)MS_Random_Number_Generator(Wait_Min, Wait_Max));
                    break;

                case (int)RNG_Types.Xoshiro256:
                    Results = Xoshiro256(Min_Value, Max_Value);

                    // Use the same engine to wait a random amount of time
                    App.Sleep((int)Xoshiro256(Wait_Min, Wait_Max));
                    break;
            }

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private long Generate_Number(long Min_Value, long Max_Value)
    } // public partial class RNG
} // namespace Orias_RNG
