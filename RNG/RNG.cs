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
        Enumerate the differrnt processes used in generating a random number.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - The selection "END" is used to dynamically identify how many selections we have.
        ===============================================================================================
        */
        private enum RNGTypes 
        {
            Class_Random,   // Microsoft Class Random
            END             // End of the selections
        }
    } // public class RNG
}
