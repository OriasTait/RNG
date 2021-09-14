using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;  // for RNGCryptoServiceProvider
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        private int Choose_Process()
        /*
        ===============================================================================================
        PURPOSE:
        Randomly chose which random number generator to use.
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated selection for the process to use.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - It is expected to have no more than 2,147,483,647 possible methods.
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            int Results;

            //=============
            // Variables - Random Number Generation
            //=============
            // Obtain the maximum Enumeration value of all possible methods
            int RNGCount = (int)RNGTypes.END - 1;

            //=============
            // Body
            //=============
            // Use the MS_RNG_CSP method to randomly choose the method to use
            Results = int.Parse(MS_RNG_CSP(0, RNGCount).ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Choose_Process()
    } // public class RNG
} // namespace MyRNG
