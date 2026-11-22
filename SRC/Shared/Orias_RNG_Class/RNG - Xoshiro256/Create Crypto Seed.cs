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
        private static ulong Create_Crypto_Seed()
        /*
        ==============================================================================================
        PURPOSE: 
        Create a cryptographically secure random seed for initializing the xoshiro256** PRNG.
        ----------------------------------------------------------------------------------------------
        OUTPUT:
        - A random 64-bit unsigned integer seed.
        ==============================================================================================
        */
        {
            //=============
            // Setup Environment
            //=============
            // Allocate a stack-allocated byte array to hold 8 bytes (64 bits)
            Span<byte> b = stackalloc byte[8];

            //=============
            // Body
            //=============
            // Fill the byte array with cryptographically secure random bytes
            RandomNumberGenerator.Fill(b);

            //=============
            // Cleanup Environment
            //=============
            // Convert the byte array to a ulong using little-endian format
            return BinaryPrimitives.ReadUInt64LittleEndian(b);
        } // private static ulong Create_Crypto_Seed()
    } // public partial class RNG
} // namespace Orias_RNG
