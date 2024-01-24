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
        private void Verify_Max_Value(decimal MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the given maximum value
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue => The maximum value
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - The status is set to success if valie; otherwise it is set to failure with a message
          indicating why.
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            if ((MaxValue < 0) || (MaxValue > 100))
            {
                Status = RNG_Status.Failure;
                RNG_Message = "The minimum value must be a value 0 to 100. The given value " + MaxValue + " is outside this range.";
            }
            else
            {
                Status = RNG_Status.Success;
                RNG_Message = RNG_Status.Success.ToString();
            }
        } // private void Verify_Max_Value
    } // namespace Orias_RNG
} // namespace Orias_RNG
