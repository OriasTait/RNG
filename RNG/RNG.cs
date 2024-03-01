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
        // Constants
        //=============
        private const byte Percentage_Max_Length = 18;  // Maximum string length of a percentage value
        private const byte Percentage_Min_Value = 0;
        private const byte Percentage_Max_Value = 100;

        //=============
        // Enumerations
        //=============
        private enum RNGTypes 
        {
            Class_Random,   // Microsoft Class Random
            Class_RNG_CSP,  // Microsoft RNGCryptoServiceProvider Class
            Class_RNG_RNG,  // Microsoft RandomNumberGenerator Class
            END             // End of the selections
        }

        public enum RNG_Status
        {
            Success,    // The RNG was successfully generated
            Failure     // The RNG could not be generated
        }

        //=============
        // Private Fields
        //=============
        private long Generated_Number;      // The results of the Random Number Generation
        private long Long_Rand;             // The long number that is randomly generated
        private bool Positive_Only = false; // Flag indicating the results contain only positive values
        private bool Valid_Number = false;  // Flag to indicate if the results are valid

        //=============
        // Public Attribute Methods
        //=============
        public RNG_Status Status  { get; set; }
        public string RNG_Message { get; set; }

        //=============
        // Constructor
        //=============
        public RNG()
        /*
        ===============================================================================================
        PURPOSE:
        Ensure the class is in a known state upon creation.
        ===============================================================================================
        */
        {
            Status = RNG_Status.Success;
            RNG_Message = RNG_Status.Success.ToString();
        } // public RNG

        //=============
        // Destructor
        //=============
        ~RNG()
        /*
        ===============================================================================================
        PURPOSE:
        Ensure the class is removed efficiently
        ===============================================================================================
        */
        {
            // Ensure the message is empty
            RNG_Message = string.Empty;
        } // public RNG
    } // public class RNG
} // Orias_RNG
