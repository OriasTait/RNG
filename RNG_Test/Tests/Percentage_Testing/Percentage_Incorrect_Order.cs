using Orias_RNG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//=============
// Aliases
//=============
using Con = System.Console;

namespace RNG_Test
{
	partial class Percentage_Testing
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2234:Arguments should be passed in the same order as the method parameters", Justification = "<Pending>")]
		private void Percentage_Incorrect_Order()
        /*
		===============================================================================================
		PURPOSE:
		Test the Random Number Generator for the percentage when the parameters are provided in the
		incorrect order => Maximum value, Minimum value
		-----------------------------------------------------------------------------------------------
		OUTPUT:
		Randomly generated Percentage vaules
		===============================================================================================
		*/
        {
            //=============
            // Variables - Standard
            //=============
            RNG MyRandomNumber = new RNG();
            decimal MinValue = 100M;
            decimal MaxValue = 0M;
            byte Precision = 18;
            decimal Results;

            //=============
            // Setup Environment
            //=============
            Con.WriteLine();
            Con.WriteLine(@"Pass the values in the incorrect order (MaxValue, MinValue)");

            //=============
            // Body
            //=============
            for (int i = 0; i < 5; i++)
            {
                // Generate the percentage
                Results = MyRandomNumber.Generate_Percentage(MaxValue, MinValue, Precision);

                // Validate the results
                if (MyRandomNumber.Status == RNG.RNG_Status.Success)
                {
                    if (i < 4)
                    {
                        Con.Write("{0}", Results + "\t");
                    }
                    else
                    {
                        Con.WriteLine("{0}", Results + "\t");
                    }
                }
                else
                {
                    Con.WriteLine();
                    Con.WriteLine(MyRandomNumber.RNG_Message);
                }
            }
        } // Percentage_Incorrect_Order()
    } // partial class Percentage_Testing
} // namespace RNG_Test
