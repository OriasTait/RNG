using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        private static bool IsFair(byte Number, int Selections)
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
        ===============================================================================================
        */
        {
            //=============
            // Setup Environment
            //=============
            // There are MaxValue / numSides full sets of numbers that can come up in a single byte.
            int FullSetsOfValues = Byte.MaxValue / Selections;

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
} // namespace MyRNG
