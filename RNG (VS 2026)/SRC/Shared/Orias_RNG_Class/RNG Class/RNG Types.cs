using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        /*
        ===============================================================================================
        PURPOSE:
        Enumerate the different processes used in generating a random number.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - The selection "END" is used to dynamically identify how many selections we have.
        ===============================================================================================
        */

        //=============
        // Enumerations
        //=============
        private enum RNG_Types
        {
            Class_Random,   // Microsoft Class Random
            Class_RNG_RNG,  // Microsoft RandomNumberGenerator Class
            END             // End of the selections
        } // private enum RNG_Types
    } // public partial class RNG
} // namespace Orias_RNG
