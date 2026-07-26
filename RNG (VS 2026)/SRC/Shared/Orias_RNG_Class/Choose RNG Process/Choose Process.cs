using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        private int Choose_Process()
        /*
        ===============================================================================================
        PURPOSE:
        By using the Microsoft random generator, this method will randomly choose which random number
        generator to use for generating the desired random values.
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated selection for the process to use.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - It is expected to have no more than 2,147,483,647 possible methods to choose from.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            int Results;

            //=============
            // Variables - Random Number Generation
            //=============
            // Obtain the maximum Enumeration value of all possible methods
            int RNG_Count = (int)RNG_Types.END - 1;

            //=============
            // Body
            //=============
            // Use the MS_RNG method to randomly choose the method to use
            Results = int.Parse(MS_RNG(0, RNG_Count).ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Choose_Process()
    } // public partial class RNG
} // namespace Orias_RNG
