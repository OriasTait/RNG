using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
	{
        /*
        ===============================================================================================
        PURPOSE:
        Enumerate the different processes used in generating a random number.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - The selection "END" is used to dynamically identify how many selections we have.
        - It is assumed that the return value, MinValue and MaxValue of a generated number will all be
          the same type.
        ===============================================================================================
        */
        //=============
        // Enumerations
        //=============
        private enum RNGTypes 
        {
            Class_Random,   // Microsoft Class Random
            Class_RNG_CSP,  // Microsoft RNGCryptoServiceProvider Class
            //Class_RNG_RNG,  // Microsoft RandomNumberGenerator Class
            END             // End of the selections
        }

        //=============
        // Private Fields
        //=============
        private bool Positive = false;
    } // public class RNG
} // Orias_RNG
