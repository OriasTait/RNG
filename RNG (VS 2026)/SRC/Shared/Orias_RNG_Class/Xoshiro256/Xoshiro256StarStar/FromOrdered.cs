using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

//=============
// Aliases
//=============
using App = System.Threading.Thread;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        private sealed partial class Xoshiro256StarStar
        /*
        ===============================================================================================
        PURPOSE:
        Nested private class implementing the xoshiro256** pseudorandom number generator (PRNG).
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This class is sealed and cannot be inherited and prevents overriding of its methods.
        ===============================================================================================
         */
        {
            private static long FromOrdered(ulong x)
            /*
            ===============================================================================================
            PURPOSE:
            This method maps an ordered unsigned long value back to a signed long value.
            -----------------------------------------------------------------------------------------------
            PARAMETERS:
            - x => The ordered unsigned long value to be mapped back to a signed long value
            ===============================================================================================
            */
            {
                // Perform the inverse operation of ToOrdered to retrieve the original signed long value
                return unchecked((long)(x ^ 0x8000_0000_0000_0000UL));
            } // private static long FromOrdered(ulong x)
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
