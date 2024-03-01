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
        private void Verify_Percentage_Min_Value(decimal MinValue)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the given minimum value
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue => The minimum value
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - The status is set to success if valid; otherwise it is set to failure with a message
          indicating why.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            int MinValueSize = MinValue.ToString().Length;

            //=============
            // Body
            //=============
            // Verify the value
            if ((MinValue < Percentage_Min_Value) || (MinValue > Percentage_Max_Value))
            {
                Status = RNG_Status.Failure;
                RNG_Message =
                    "The minimum value must be a value " + Percentage_Min_Value 
                    + " to " + Percentage_Max_Value 
                    + ". The given value " + MinValue + " is outside this range.";
            }

            // Verify the size
            else if (MinValueSize > Percentage_Max_Length)
            {
                Status = RNG_Status.Failure;
                RNG_Message =
                    "The maximum number of digits is " + Percentage_Max_Length
                    + ". The given value has " + MinValueSize + " digits.";
            }

            // All is good
            else
            {
                Status = RNG_Status.Success;
                RNG_Message = RNG_Status.Success.ToString();
            }
        } // private void Verify_Percentage_Min_Value
    } // namespace Orias_RNG
} // namespace Orias_RNG
