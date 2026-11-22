using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public ushort Generate(ushort MinValue, ushort MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for unsigned short integers; range 0 to 65,535
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Integer
            ushort Results = ushort.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public ushort Generate(ushort MinValue, ushort MaxValue)
    } // public partial class RNG
} // namespace Orias_RNG
