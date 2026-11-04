using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        private void Verify_MaxMin_Parameters(ref decimal MinValue, ref decimal MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the parameters of MinValue and MaxValue and re-assign them if they were given in the
        incorrect order.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        The MinValue will be less then or equal to the MaxValue
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            decimal Min;
            decimal Max;

            //=============
            // Body
            //=============
            if (MinValue < MaxValue)
            {
                Min = MinValue;
                Max = MaxValue;
            }
            else
            {
                Min = MaxValue;
                Max = MinValue;
            }

            //=============
            // Cleanup Environment
            //=============
            MinValue = Min;
            MaxValue = Max;
        } // private void Verify_MaxMin_Parameters

        private void Verify_MaxMin_Parameters(ref long MinValue, ref long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Ensure that the minimum and maximum values are in the correct order.  If they are not, re-assign
        them to be in the correct order.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        The MinValue will be less then or equal to the MaxValue
        -----------------------------------------------------------------------------------------------
        NOTES:
        - Because the core functionality of the RNG class uses long, this method is used to ensure that
          the values are within the valid range for long.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Min;
            long Max;

            //=============
            // Body
            //=============
            if (MinValue < MaxValue)
            {
                Min = MinValue;
                Max = MaxValue;
            }
            else
            {
                Min = MaxValue;
                Max = MinValue;
            }

            //=============
            // Cleanup Environment
            //=============
            // Re-assign the values to be in the correct order
            MinValue = Min;
            MaxValue = Max;

            // Ensure the values are within the valid range for long
            if (MinValue < Long_Min_Value)
            {
                throw new ArgumentOutOfRangeException(nameof(MinValue), $"MinValue must be between {Long_Min_Value:N0} and {Long_Max_Value:N0}.");
            }
            if (MaxValue > Long_Max_Value)
            {
                throw new ArgumentOutOfRangeException(nameof(MaxValue), $"MaxValue must be between {Long_Min_Value:N0} and {Long_Max_Value:N0}.");
            }
        } // private void Verify_MaxMin_Parameters
    } // public partial class RNG
} // namespace Orias_RNG
