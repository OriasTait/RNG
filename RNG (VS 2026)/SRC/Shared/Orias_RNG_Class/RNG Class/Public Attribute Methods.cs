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
        // Public Attribute Methods
        //=============
        public RNG_Status Status { get; set; }
        public string RNG_Message { get; set; }

    } // public partial class RNG
} // namespace Orias_RNG
