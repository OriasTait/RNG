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
            // =============
            // Fields - Standard
            // =============
            private ulong s0, s1, s2, s3;

            public Xoshiro256StarStar(ulong seed)
            /*
            ===============================================================================================
            PURPOSE:
            This constructor initializes the xoshiro256** PRNG with a given seed value. It uses the
            SplitMix64 algorithm to generate the initial state of the PRNG.
            -----------------------------------------------------------------------------------------------
            PARAMETERS:
            - seed => The seed value to initialize the PRNG
            ===============================================================================================
            */
            {
                //=============
                // Variables - Standard
                //=============
                // Use SplitMix64 to generate the initial state from the seed
                var sm = new SplitMix64(seed);

                //=============
                // Setup Environment
                //=============
                // Generate four 64-bit unsigned integers for the state
                s0 = sm.Next_UInt64();
                s1 = sm.Next_UInt64();
                s2 = sm.Next_UInt64();
                s3 = sm.Next_UInt64();

                //=============
                // Body
                //=============
                // Ensure that the state is not all zeros, which would be invalid for the
                // xoshiro256** algorithm
                if ((s0 | s1 | s2 | s3) == 0)
                    s0 = 0x9E3779B97F4A7C15UL;
            } // public Xoshiro256StarStar(ulong seed)
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
