using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S2325:Methods and properties that don't access instance data should be static", Justification = "<Pending>")]
        private void Verify_MaxMin_Parameters(ref long MinValue, ref long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Ensure that the minimum and maximum values are in the correct order.  If they are not, re-assign
        them to be in the correct order.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        The MinValue will be less then or equal to the MaxValue
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This is the core functionality, using the largest numeric value: long.  Each numeric data
          type calls this, then converts the results back to the calling data type.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Min;
            long Max;

            //=============
            // Body
            //=============
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

            //=============
            // Cleanup Environment
            //=============
            MinValue = Min;
            MaxValue = Max;
        } // private void Verify_MaxMin_Parameters
    } // public partial class RNG
} // namespace Orias_RNG
