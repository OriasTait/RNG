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
        private void Verify_Precision_Value(byte Precision)
        /*
        ===============================================================================================
        PURPOSE:
        Validate the given precision value
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - Precision => How many decimal digits to return
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
            if ((Precision < 0) || (Precision > 18))
            {
                Status = RNG_Status.Failure;
                RNG_Message = "Precision must be a value of 0 - 18. The given value " + Precision + " is outside this range.";
            }
            else
            {
                Status = RNG_Status.Success;
                RNG_Message = RNG_Status.Success.ToString();
            }
        } // private void Verify_Precision_Value
    } // namespace Orias_RNG
} // namespace Orias_RNG
