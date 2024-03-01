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
        private void Verify_Percentage_Max_Value(decimal MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the given maximum value
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue => The maximum value
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
            int MaxValueSize = MaxValue.ToString().Length;

            //=============
            // Body
            //=============
            // Verify the value
            if ((MaxValue < Percentage_Min_Value) || (MaxValue > Percentage_Max_Value))
            {
                Status = RNG_Status.Failure;
                RNG_Message =
                    "The minimum value must be a value " + Percentage_Min_Value + " to " + Percentage_Max_Value 
                    + ". The given value " + MaxValue + " is outside this range.";
            }
            
            // Verify the size
            else if (MaxValueSize > Percentage_Max_Length)
            {
                Status = RNG_Status.Failure;
                RNG_Message = 
                    "The maximum number of digits is " + Percentage_Max_Length 
                    + ". The given value has " + MaxValueSize + " digits.";
            }

            // All is good
            else
            {
                Status = RNG_Status.Success;
                RNG_Message = RNG_Status.Success.ToString();
            }
        } // private void Verify_Percentage_Max_Value
    } // namespace Orias_RNG
} // namespace Orias_RNG
