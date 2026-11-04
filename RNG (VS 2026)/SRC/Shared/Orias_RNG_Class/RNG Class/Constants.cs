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
    Define constants used in the RNG class.
    ===============================================================================================
    */
    {
        //=============
        // Constants
        //=============
        // Long Constants
        private const long Long_Min_Value = -922337203685477580; // Minimum long value
        private const long Long_Max_Value = 922337203685477580;  // Maximum long value

        // Percentage Constants
        private const byte Percentage_Max_Length = 18;  // Maximum string length of a percentage value
        private const byte Percentage_Min_Value = 0;    // Minimum value of a percentage value
        private const byte Percentage_Max_Value = 100;  // Maximum value of a percentage value
    } // public partial class RNG
} // namespace Orias_RNG
