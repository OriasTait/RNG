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
            private static ulong RotL(ulong x, int k)
            /*
            ===============================================================================================
            PURPOSE:
            This method performs a left rotation on a 64-bit unsigned integer.
            -----------------------------------------------------------------------------------------------
            PARAMETERS:
            - x => The 64-bit unsigned integer to be rotated
            - k => The number of bits to rotate to the left
            ===============================================================================================
            */
            {
                // Perform a left rotation by shifting left and wrapping around the bits that overflow
                return (x << k) | (x >> (64 - k));
            } // private static ulong RotL(ulong x, int k)
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
