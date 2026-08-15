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
            private sealed partial class SplitMix64
            {
                public ulong Next_UInt64()
                /*
                ===============================================================================================
                PURPOSE:
                This method generates the next 64-bit unsigned integer in the sequence.
                ===============================================================================================
                */
                {
                    //=============
                    // Body
                    //=============
                    // Increment the state by a large constant to ensure a good distribution of values
                    ulong z = (state += 0x9E3779B97F4A7C15UL);

                    // Apply a series of bitwise operations and multiplications to produce a well-distributed random value
                    z = (z ^ (z >> 30)) * 0xBF58476D1CE4E5B9UL;

                    // Further mix the bits to enhance randomness
                    z = (z ^ (z >> 27)) * 0x94D049BB133111EBUL;

                    //=============
                    // Cleanup Environment
                    //=============
                    // Final mixing step to produce the output value
                    return z ^ (z >> 31);
                } // public ulong Next_UInt64()
            } // private sealed partial class SplitMix64
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
