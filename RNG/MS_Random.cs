using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//=============
// Aliases
//=============
using App = System.Threading.Thread;

namespace MyRNG
{
    public partial class RNG
    {
        private int MS_Random(int MinValue, int MaxValue)
        /*
        ===============================================================================================
        PURPOSE:
        Use the Microsoft Random class to generate a random number from the given MinValue up to
        (and including) the MaxValue.
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
            // Variables - Standard
            //=============
            Random RandomNumber = new Random();

            //=============
            // Body
            //=============
            int Results = RandomNumber.Next(MinValue, MaxValue + 1);  // MaxValue is incremented to include it as a potential result

            //=============
            // Cleanup Environment
            //=============
            // Wait a random bit of time to ensure a new seed
            App.Sleep(RandomNumber.Next(1, 21));  // wait up to 20 miliseconds (1000 => 1 second)

            // Return the results
            return Results;
        } // private int MS_Random(int MinValue, int MaxValue)
    } // public class RNG
}
