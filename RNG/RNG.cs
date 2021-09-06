using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRNG
{
    public partial class RNG
    {
        /*
        ===============================================================================================
        PURPOSE:
        Enumerate the different data types being generated.
        ===============================================================================================
        */
        private enum DataTypes
        {
            Byte,
            Integer,
            Long
        }

        /*
        ===============================================================================================
        PURPOSE:
        Enumerate the different processes used in generating a random number.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - The selection "END" is used to dynamically identify how many selections we have.
        - It is assumed that the return value, MinValue and MaxValue of a generated number will all be
          the same.
        ===============================================================================================
        */
        private enum RNGTypes 
        {
            Class_Random,   // Microsoft Class Random
            Class_RNG_CSP,  // Microsoft RNGCryptoServiceProvider Class
            END             // End of the selections
        }
    } // public class RNG
}
