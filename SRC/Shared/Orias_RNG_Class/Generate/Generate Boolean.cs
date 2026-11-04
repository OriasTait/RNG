using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public bool Generate(bool MinValue, bool MaxValue, bool Show_RNG_Engine )
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a boolean value (true or false).
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        - Show_RNG_Engine => If true, the RNG Engine will be displayed in the console
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for a boolean; range is limited to 0 and 1.
        ===============================================================================================
        */
        {
            //=============
            // Setup Environment
            //=============
            // Convert True/False to numberic values
            sbyte Generate_Min = MinValue ? sbyte.Parse("1") : sbyte.Parse("0");
            sbyte Generate_Max = MaxValue ? sbyte.Parse("1") : sbyte.Parse("0");

            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(Generate_Min, Generate_Max, Show_RNG_Engine);

            // Convert the number back to a boolean
            bool Results = (Generated_Number == 1);

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public bool Generate()
    } // public partial class RNG
} // namespace Orias_RNG
