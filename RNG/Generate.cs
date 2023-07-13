using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orias_RNG
{
	public partial class RNG
    {
        public byte Generate(byte MinValue, byte MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for bytes
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            long GeneratedNumber = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Byte
            byte Results = Byte.Parse(GeneratedNumber.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public byte Generate(byte MinValue, byte MaxValue)

        public int Generate(int MinValue, int MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for Integers
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            long GeneratedNumber = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Integer
            int Results = int.Parse(GeneratedNumber.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate(int MinValue, int MaxValue)

        public long Generate(long MinValue, long MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for Long
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            long GeneratedNumber = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Integer
            long Results = int.Parse(GeneratedNumber.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate(int MinValue, int MaxValue)
    } // public class RNG
} // namespace Orias_RNG
