using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public short Generate(short MinValue, short MaxValue, bool Show_RNG_Engine)
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
        - This method is for short integers; range -32,768 to 32,767
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue, Show_RNG_Engine);

            // Convert the number back to a Integer
            short Results = short.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public short Generate(short MinValue, short MaxValue, bool Show_RNG_Engine)
    } // public partial class RNG
} // namespace Orias_RNG
