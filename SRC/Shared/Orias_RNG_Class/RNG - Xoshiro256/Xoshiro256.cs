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
        private readonly Xoshiro256StarStar _engine = new Xoshiro256StarStar(Create_Crypto_Seed());

        // Your requested inclusive long range [min, max]
        public long Xoshiro256(long min, long max)
        /*
        ===============================================================================================
        PURPOSE:
        Use the xoshiro256** algorithm to generate a random number from the given MinValue up to (and
        including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            return _engine.Next_Int64_Inclusive(min, max);
        } // public long Xoshiro256(long min, long max)
    } // public partial class RNG
} // namespace Orias_RNG
