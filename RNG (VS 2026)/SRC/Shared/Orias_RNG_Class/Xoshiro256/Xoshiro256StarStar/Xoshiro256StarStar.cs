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
        private sealed class Xoshiro256StarStar
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
                s0 = sm.NextUInt64();
                s1 = sm.NextUInt64();
                s2 = sm.NextUInt64();
                s3 = sm.NextUInt64();

                //=============
                // Body
                //=============
                // Ensure that the state is not all zeros, which would be invalid for the
                // xoshiro256** algorithm
                if ((s0 | s1 | s2 | s3) == 0)
                    s0 = 0x9E3779B97F4A7C15UL;
            } // public Xoshiro256StarStar(ulong seed)

            private ulong NextUInt64()
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
            } // public ulong NextUInt64()

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
                    return unchecked((long)NextUInt64());

                // Map the signed range to an unsigned range for uniform distribution
                ulong uMin = ToOrdered(min);
                ulong uMax = ToOrdered(max);
                ulong span = uMax - uMin + 1UL;

                // If the span is zero, it means the range is the full 64-bit range,
                // so return a random value
                if (span == 0UL)
                    return unchecked((long)NextUInt64());

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
                    r = NextUInt64();
                } while (r >= limit);

                // Map the random number to the desired range
                ulong value = uMin + (r % span);

                //=============
                // Cleanup Environment
                //=============
                // Convert the ordered unsigned value back to a signed long and return it
                return FromOrdered(value);
            } // public long Next_Int64_Inclusive(long min, long max)

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

            private sealed class SplitMix64
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

                public ulong NextUInt64()
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
                } // public ulong NextUInt64()
            } // private sealed class SplitMix64
        } // private sealed class Xoshiro256StarStar
    } // public partial class RNG
} // namespace Orias_RNG
