using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S2325:Methods and properties that don't access instance data should be static", Justification = "<Pending>")]
        private bool Is_In_Range(long MinValue, long MaxValue, long Number)
        /*
        ===============================================================================================
        PURPOSE:
        Validate that the given number is within the given range
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        - Number    => The number to validate
        -----------------------------------------------------------------------------------------------
        NOTES:
        - True if the number is within the range; otherwise false
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            bool Results = false;

            //=============
            // Body
            //=============
            if ((Number >= MinValue) && (Number <= MaxValue))
            { Results = true; }

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private bool Is_In_Range(long MinValue, long MaxValue, long Number)
    } // public partial class RNG
} // namespace Orias_RNG
