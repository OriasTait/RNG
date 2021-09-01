using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        private void Verify_MaxMin_Parameters(ref byte MinValue, ref byte MaxValue)
        {
            //=============
            // Variables - Standard
            //=============
            long Min = MinValue;
            long Max = MaxValue;

            //=============
            // Body
            //=============
            Verify_MaxMin_Parameters(ref Min, ref Max);

            //=============
            // Cleanup Environment
            //=============
            MinValue = (byte)Min;
            MaxValue = (byte)Max;
        }

        private void Verify_MaxMin_Parameters(ref int MinValue, ref int MaxValue)
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
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This converts the given integers to long and calls the main process, then converts the
          results back to an integers.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Min = MinValue;
            long Max = MaxValue;

            //=============
            // Body
            //=============
            Verify_MaxMin_Parameters(ref Min, ref Max);

            //=============
            // Cleanup Environment
            //=============
            MinValue = (int)Min;
            MaxValue = (int)Max;
        } // private void Verify_MaxMin_Parameters(ref int MinValue, ref int MaxValue)

        private void Verify_MaxMin_Parameters(ref long MinValue, ref long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the parameters of MinValue and MaxValue and re-assign them if they were given in the
        incorrect order.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        - ParamType => The data type provided in the parameter
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        The MinValue will be less then or equal to the MaxValue
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This is the core functionality, using the largest numeric value: long.  Each numeric data
          type calls this, then converts the results back to the calling data type.
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
            MinValue = Min;
            MaxValue = Max;
        } // private void Verify_MaxMin_Parameters(ref int MinValue, ref int MaxValue)
    } // public class RNG
}
