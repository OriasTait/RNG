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
            public long Next_Int64_Inclusive(long min, long max)
            /*
            ===============================================================================================
            PURPOSE:
            This method generates the next 64-bit signed integer in the xoshiro256** PRNG sequence within
            the specified range.
            -----------------------------------------------------------------------------------------------
            PARAMETERS:
            - min => The minimum value (inclusive) of the range
            - max => The maximum value (inclusive) of the range
            -----------------------------------------------------------------------------------------------
            OUTPUT:
            - A randomly generated 64-bit signed integer within the specified range.
            ===============================================================================================
            */
            {
                //=============
                // Setup Environment
                //=============
                // Handle the full range of long values as a special case
                if (min == long.MinValue && max == long.MaxValue)
                    return unchecked((long)Next_UInt64());

                // Map the signed range to an unsigned range for uniform distribution
                ulong uMin = ToOrdered(min);
                ulong uMax = ToOrdered(max);
                ulong span = uMax - uMin + 1UL;

                // If the span is zero, it means the range is the full 64-bit range,
                // so return a random value
                if (span == 0UL)
                    return unchecked((long)Next_UInt64());

                // Calculate the limit to avoid modulo bias when generating random numbers
                ulong limit = ulong.MaxValue - (ulong.MaxValue % span);

                //=============
                // Body
                //=============
                // Use rejection sampling to generate a random number within the specified range
                ulong r;

                // Keep generating random numbers until one falls within the acceptable limit
                do
                {
                    r = Next_UInt64();
                } while (r >= limit);

                // Map the random number to the desired range
                ulong value = uMin + (r % span);

                //=============
                // Cleanup Environment
                //=============
                // Convert the ordered unsigned value back to a signed long and return it
                return FromOrdered(value);
            } // public long Next_Int64_Inclusive(long min, long max)
        } // private sealed partial class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
