using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public sbyte Generate(sbyte MinValue, sbyte MaxValue, bool Show_RNG_Engine)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        - Show_RNG_Engine => If true, the RNG Engine will be displayed in the console
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for an Unsigned 8-bit integer; range -128 to 127
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue, Show_RNG_Engine);

            // Convert the number back to a Byte
            sbyte Results = SByte.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public sbyte Generate(byte MinValue, byte MaxValue)
    } // public partial class RNG
} // namespace Orias_RNG
