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
            private static ulong ToOrdered(long x)
            /*
            ===============================================================================================
            PURPOSE:
            This method maps a signed long value to an ordered unsigned long value for uniform 
            distribution.
            ===============================================================================================
            */
            {
                // Perform a bitwise XOR with 0x8000000000000000 to map the signed long to an ordered
                // unsigned long
                return unchecked((ulong)x) ^ 0x8000_0000_0000_0000UL;
            } // private static ulong ToOrdered(long x)
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
