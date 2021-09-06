using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        private bool IsInRange(long MinValue, long MaxValue, long Number)
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
        } // private bool IsInRange(long MinValue, long MaxValue, long LongRand)
    } // public class RNG
} // namespace MyRNG
