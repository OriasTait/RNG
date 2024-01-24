using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;  // for RNGCryptoServiceProvider
using System.Text;
using System.Threading.Tasks;

namespace Orias_RNG
{
    public partial class RNG
    {
        public decimal Generate_Percentage(decimal MinValue, decimal MaxValue, byte Precision)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a percentage.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum Whole Number to return
        - MaxValue  => The maximum Whole Number to return
        - Precision => How many decimal digits to return
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated decimal.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - A percentage data type is broken into 2 parts:
          - Whole Number    => The digits to the left of the decimal
          - Percision       => The digits to the right of the decimal

        - All values will be positive
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            decimal Results = 0;

            //=============
            // Setup Environment
            //=============
            // Verify the given information
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

            /*
            Verify Max Value
            Verify Min Value
             */
            Verify_Precision_Value(Precision);

            /*
            //=============
            // Variables - Standard
            //=============
            uint Whole_Number = 0;
            ulong Precision = 0;
            long Min_Value = MinValue;
            long Max_Value = MaxValue;

            // Precision range
            long Precision_Min = 0;
            long Precision_Max = 999999999999999999;  // 18 digits

            //=============
            // Setup Environment
            //=============
            Verify_MaxMin_Parameters(ref Min_Value, ref Max_Value);

            // Indicate all values will be positive
            Positive_Only = true;

            //=============
            // Body
            //=============
            // Generate the Whole Number
            Whole_Number = Generate(MinValue, MaxValue);

            // Generate the Precision
            Precision = Generate(Precision_Min, Precision_Max);

            // Create the Percentage
            Results = decimal.Parse(Whole_Number.ToString() + "." + Precision.ToString());

            // Ensure the maximum has not been exceeded
            if (Results > 100) { Results = decimal.Parse("100.000000000000000000"); }
             */

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Generate_Percentage()
    } // namespace Orias_RNG
} // namespace Orias_RNG
