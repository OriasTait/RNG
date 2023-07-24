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
        - This method is for an Unsigned 8-bit integer; range 0 to 255
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Byte
            byte Results = Byte.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public byte Generate(byte MinValue, byte MaxValue)

        public sbyte Generate(sbyte MinValue, sbyte MaxValue)
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
        - This method is for an Unsigned 8-bit integer; range -128 to 127
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Byte
            sbyte Results = SByte.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public sbyte Generate(byte MinValue, byte MaxValue)

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
        - This method is for Signed Integers
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Integer
            int Results = int.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate(int MinValue, int MaxValue)

        public uint Generate(uint MinValue, uint MaxValue)
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
        - This method is for Unsigned Integers
        ===============================================================================================
        */
        {
            //=============
            // Body
            //=============
            // Generate the number
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Integer
            uint Results = uint.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public uint Generate(int MinValue, int MaxValue)

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
            Generated_Number = Generate_Number(MinValue, MaxValue);

            // Convert the number back to a Integer
            long Results = int.Parse(Generated_Number.ToString());

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public int Generate(int MinValue, int MaxValue)
    } // public class RNG
} // namespace Orias_RNG
