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
        // Constants
        //=============
        private const byte Percentage_Max_Length = 18;  // Maximum string length of a percentage value
        private const byte Percentage_Min_Value = 0;    // Minimum value of a percentage value
        private const byte Percentage_Max_Value = 100;  // Maximum value of a percentage value
    } // public partial class RNG
} // namespace Orias_RNG
