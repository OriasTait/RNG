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
        private long Generate_Number(long MinValue, long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate the number.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated number.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This is the core of the number generation.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            long Results = 0;

            //=============
            // Setup Environment
            //=============
            
            Verify_MaxMin_Parameters(ref MinValue, ref MaxValue);

			//=============
			// Body
			//=============
			// Choose a process
			int RNGProcess = Choose_Process();

            // Use the chosen method
			switch (RNGProcess)
			{
				case (int)RNGTypes.Class_Random:
					Results = MS_Random(MinValue, MaxValue);
					break;

				case (int)RNGTypes.Class_RNG_CSP:
					Results = MS_RNG_CSP(MinValue, MaxValue);
					break;
			}

			//=============
			// Cleanup Environment
			//=============
			return Results;
        } // private int Generate_Number()
    } // public class RNG
} // namespace Orias_RNG
