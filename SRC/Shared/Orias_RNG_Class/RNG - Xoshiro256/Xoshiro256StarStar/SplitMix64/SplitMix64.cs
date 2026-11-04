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
                // =============
                // Fields - Standard
                // =============
                private ulong state;

                // =============
                // Constructors - Standard
                // =============
                public SplitMix64(ulong seed)
                /*
                ===============================================================================================
                PURPOSE:
                This constructor initializes the SplitMix64 instance with a given seed.
                -----------------------------------------------------------------------------------------------
                PARAMETERS:
                - seed => The initial seed value for the random number generator
                ===============================================================================================
                */
                {
                    //=============
                    // Body
                    //=============
                    state = seed;
                } // public SplitMix64(ulong seed)
            } // private sealed partial class SplitMix64
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
