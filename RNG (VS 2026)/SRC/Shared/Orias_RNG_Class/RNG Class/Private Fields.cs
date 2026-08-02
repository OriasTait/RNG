using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    /*
    ===============================================================================================
    PURPOSE:
    Generate a random number.
    -----------------------------------------------------------------------------------------------
    NOTES:
    - It is assumed that the return value, MinValue and MaxValue of a generated number will all be
      the same type.
    ===============================================================================================
    */
    {
        //=============
        // Private Fields
        //=============
        private long Generated_Number;      // The results of the Random Number Generation
        private long Long_Rand;             // The long number that is randomly generated
        private bool Positive_Only = false; // Flag indicating the results contain only positive values
        private bool Valid_Number = false;  // Flag to indicate if the results are valid
    } // public partial class RNG
} // namespace Orias_RNG
