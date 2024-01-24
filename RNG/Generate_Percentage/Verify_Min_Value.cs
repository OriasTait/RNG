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
        private void Verify_Min_Value(decimal MinValue)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the given minimum value
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue => The minimum value
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
            if ((MinValue < 0) || (MinValue > 180))
            {
                Status = RNG_Status.Failure;
                RNG_Message = "The minimum value must be a value 0 to 100. The given value " + MinValue + " is outside this range.";
            }
            else
            {
                Status = RNG_Status.Success;
                RNG_Message = RNG_Status.Success.ToString();
            }
        } // private void Verify_Min_Value
    } // namespace Orias_RNG
} // namespace Orias_RNG
