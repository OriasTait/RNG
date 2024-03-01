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
        public decimal Generate_Percentage(decimal MinValue, decimal MaxValue, byte Precision)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a percentage.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum Whole Number to return
        - MaxValue  => The maximum Whole Number to return
        - Precision => How many total digits to return, including decimal
        -----------------------------------------------------------------------------------------------
        OUTPUT:
        - A randomly generated decimal.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - All values will be positive

        - If the value does not have a whole number, C# will add a zero (0).
        -----------------------------------------------------------------------------------------------
        - A percentage data type is broken into 2 parts:
          - Whole Number    => The digits to the left of the decimal point
          - Decimal         => The digits to the right of the decimal point
        ===============================================================================================
        */
        {
            //=============
            // Variables - Standard
            //=============
            decimal Results = 0M;
             string ResultsStr = string.Empty;
            string MinValueStr = string.Empty;
            string MaxValueStr = string.Empty;
            int Decmal_Location = -1;

            //=============
            // Variables - Decimal Parts
            //=============
            int MinValueStrDecmal = 0;
            int MaxValueStrDecmal = 0;

            //=============
            // Setup Environment
            //=============
            // Verify the given information
            if (Status == RNG_Status.Success) { Verify_MaxMin_Parameters(ref MinValue, ref MaxValue); }
            if (Status == RNG_Status.Success) { Verify_Percentage_Min_Value(MinValue); }
            if (Status == RNG_Status.Success) { Verify_Percentage_Max_Value(MaxValue); }
            if (Status == RNG_Status.Success) { Verify_Precision_Value(Precision); }

            // Prepare the numbers for generation
            if (Status == RNG_Status.Success)
            {
                // Convert to string
                MinValueStr = MinValue.ToString();
                MaxValueStr = MaxValue.ToString();

                //=============
                // Make the strings the same size
                //=============
                // Ensure each value has a decimal point
                MinValueStrDecmal = MinValueStr.IndexOf(".");
                if (MinValueStrDecmal < 0) 
                { 
                    MinValueStr = MinValueStr.Insert(MinValueStr.Length, ".");
                    MinValueStrDecmal = MinValueStr.IndexOf(".");
                }

                MaxValueStrDecmal = MaxValueStr.IndexOf(".");
                if (MaxValueStrDecmal < 0)
                {
                    MaxValueStr = MaxValueStr.Insert(MaxValueStr.Length, ".");
                    MaxValueStrDecmal = MaxValueStr.IndexOf(".");
                }

                // If both have decimals in the same place
                if (MinValueStrDecmal == MaxValueStrDecmal)
                {
                    // Whole number values will be the same, so no padding required
                    MinValueStr = MinValueStr.PadRight(Precision, '0');
                    MaxValueStr = MaxValueStr.PadRight(Precision, '0');

                    // Save the decmal location
                    Decmal_Location = MaxValueStrDecmal;
                }

                // else decimals are in different locations
                else
                {
                    // Place to hold the decimal location
                    int The_Decimal = 0;

                    // Calculate the differences between the decimal places
                    The_Decimal = MaxValueStrDecmal - MinValueStrDecmal;

                    // Left Pad the min value with zeros
                    MinValueStr = MinValueStr.PadLeft(MinValueStr.Length + The_Decimal, '0');

                    // Decimals are in the same location, right pad to precision
                    MinValueStr = MinValueStr.PadRight(Precision, '0');
                    MaxValueStr = MaxValueStr.PadRight(Precision, '0');

                    // Save the decmal location
                    Decmal_Location = MaxValueStrDecmal;
                }

                // Ensure Precision
                if (Precision > 0)
                {
                    if (MinValueStr.Length > Precision) { MinValueStr = MinValueStr.Substring(0, Precision); }
                    if (MaxValueStr.Length > Precision) { MaxValueStr = MaxValueStr.Substring(0, Precision); }
                }

                // Remove Decimal
                MinValueStr = MinValueStr.Replace(".", string.Empty);
                MaxValueStr = MaxValueStr.Replace(".", string.Empty);
            }

            // Generate the number
            if (Status == RNG_Status.Success)
            {
                long MinValue_long = long.Parse(MinValueStr);
                long MaxValue_long = long.Parse(MaxValueStr);

                Results = Generate(MinValue_long, MaxValue_long);
            }

            // Prepare Results to be returned
            if (Status == RNG_Status.Success)
            {
                // Convert Results to a string
                ResultsStr = Results.ToString();

                if (Precision > 0)
                {
                    // Left pad the results with 0
                    ResultsStr = ResultsStr.PadLeft(Precision - 1, '0');

                    // Replace the Decimal Point
                    ResultsStr = ResultsStr.Insert(Decmal_Location, ".");
                }

                // Save the results
                Results = decimal.Parse(ResultsStr);
            }

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // private int Generate_Percentage()
    } // namespace Orias_RNG
} // namespace Orias_RNG
