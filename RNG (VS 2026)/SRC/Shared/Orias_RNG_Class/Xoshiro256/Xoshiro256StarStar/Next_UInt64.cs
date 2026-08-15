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
            private ulong Next_UInt64()
            /*
            ===============================================================================================
            PURPOSE:
            This method generates the next 64-bit unsigned integer in the xoshiro256** PRNG sequence.
            ===============================================================================================
            */
            {
                //=============
                // Body
                //=============
                // Calculate the next output value using the xoshiro256** algorithm
                ulong Result = RotL(s1 * 5, 7) * 9;
                ulong t = s1 << 17;

                // Update the internal state using bitwise operations
                s2 ^= s0;
                s3 ^= s1;
                s1 ^= s2;
                s0 ^= s3;

                // Update s2 and s3 with the temporary value t and a rotation
                s2 ^= t;
                s3 = RotL(s3, 45);

                //=============
                // Cleanup Environment
                //=============
                return Result;
            } // private ulong Next_UInt64()
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
