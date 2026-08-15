using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public int Generate(int MinValue, int MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate an integer value based on the specified minimum and maximum values.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for an integer value.
        ===============================================================================================
        */
        {
            //=============
            // Setup Environment
            //=============
            // Convert True/False to numberic values
            //sbyte Generate_Min = MinValue ? sbyte.Parse("1") : sbyte.Parse("0");
            //sbyte Generate_Max = MaxValue ? sbyte.Parse("1") : sbyte.Parse("0");

            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a boolean
            int Results = (int)Generated_Number;

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate()
    } // public partial class RNG
} // namespace Orias_RNG
