using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orias_RNG
{
    public partial class RNG
    {
        private static bool IsFair(long Number, long Selections)
        /*
        ===============================================================================================
        PURPOSE:
        Validates that the random number is a fair selection for the RandomNumberGenerator class.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - Number        => The random number that was generated
        - Selections    => The number of selections available
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - If the provided number is fair based on the number of selections, true; otherwise, false.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - A fair selection is considered to be from a full sequence of values.  For example:
          
          If the number of selections is 6, every 6th selection would represent a new sequence:
            - 1 = 1, 2 = 2, 3 = 3, 4 = 4, 5 = 5, 6 = 6
            - 7 = 1, 8 = 2, 9 = 3, 10 = 4, 11 = 5, 12 = 6
            - ...
            - 252 = 1, 253 = 2, 254 = 3, 255 = 4
          A selection of 1 - 12 would be fair because all 6 numbers are potentially available.

          If the number selected is 253, this is NOT fair because not all numbers are potentially
          available, only 1 - 4 are available.
        ===============================================================================================
        */
        {
            //=============
            // Setup Environment
            //=============
            // There are MaxValue / numSides full sets of numbers that can come up in a single byte.
            long FullSetsOfValues = long.MaxValue / Selections;

            //=============
            // Body
            //=============
            // Calculate the results
            bool Results = (Number < Selections * FullSetsOfValues);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private static bool IsFair(byte Number, int Selections)
    } // public class RNG
} // namespace Orias_RNG
