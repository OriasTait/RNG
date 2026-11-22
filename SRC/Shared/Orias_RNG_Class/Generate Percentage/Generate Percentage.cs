using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public decimal Generate_Percentage(decimal MinValue, decimal MaxValue, byte Precision)
        /*
        ===============================================================================================
        PURPOSE:
        Randomly generate a method to use in order to generate a random number from the given MinValue
        up to (and including) the MaxValue.
        -----------------------------------------------------------------------------------------------
        PARAMETERS:
        - MinValue  => The minimum value to return
        - MaxValue  => The maximum value to return
        - Precision => The number of decimal places to return
        -----------------------------------------------------------------------------------------------
        NOTES:
        - This method is for percentages; range 0 to 100.
        - If the value does not have a whole number, C# will add a zero (0).
        - The Precision parameter is used to determine how many decimal places to return. For example,
          if Precision is 2, then the result will be rounded to 2 decimal places.
        ===============================================================================================
        */
        {
            //=============
            // Veriables - Standard
            //=============
            decimal Results = 0M;
            string ResultsStr;
            string MinValueStr = string.Empty;
            string MaxValueStr = string.Empty;
            int Decmal_Location = -1;

            //=============
            // Variables - Decimal Parts
            //=============
            //int MinValueStrDecmal = 0;
            //int MaxValueStrDecmal = 0;

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
                int MinValueStrDecmal = MinValueStr.IndexOf('.');
                if (MinValueStrDecmal < 0)
                {
                    MinValueStr = MinValueStr.Insert(MinValueStr.Length, ".");
                    MinValueStrDecmal = MinValueStr.IndexOf('.');
                }

                int MaxValueStrDecmal = MaxValueStr.IndexOf('.');
                if (MaxValueStrDecmal < 0)
                {
                    MaxValueStr = MaxValueStr.Insert(MaxValueStr.Length, ".");
                    MaxValueStrDecmal = MaxValueStr.IndexOf('.');
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
                    // Calculate the differences between the decimal places
                    int The_Decimal = MaxValueStrDecmal - MinValueStrDecmal;

                    // Left Pad the min value with zeros
                    MinValueStr = MinValueStr.PadLeft(MinValueStr.Length + The_Decimal, '0');

                    // Decimals are in the same location, right pad to precision
                    MinValueStr = MinValueStr.PadRight(Precision, '0');
                    MaxValueStr = MaxValueStr.PadRight(Precision, '0');

                    // Save the decmal location
                    Decmal_Location = MaxValueStrDecmal;
                } // else decimals are in different locations

                // Ensure Precision
                if (Precision > 0)
                {
                    // Define the total length of the string to be returned
                    int The_Precision = Precision + Decmal_Location + 1; // +1 is for the decimal point

                    // If the string is longer than the total length, truncate it
                    if (MinValueStr.Length > The_Precision) { MinValueStr = MinValueStr[..The_Precision]; }
                    if (MaxValueStr.Length > The_Precision) { MaxValueStr = MaxValueStr[..The_Precision]; }

                    // If the string is shorter than the total length, pad it with zeros
                    if (MinValueStr.Length < The_Precision) { MinValueStr = MinValueStr.PadRight(The_Precision, '0'); }
                    if (MaxValueStr.Length < The_Precision) { MaxValueStr = MaxValueStr.PadRight(The_Precision, '0'); }
                }

                // Remove Decimal
                MinValueStr = MinValueStr.Replace(".", string.Empty);
                MaxValueStr = MaxValueStr.Replace(".", string.Empty);
            } // if (Status == RNG_Status.Success)

            //=============
            // Body
            //=============
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
                    ResultsStr = ResultsStr.PadLeft(MaxValueStr.Length, '0');

                    // Replace the Decimal Point
                    ResultsStr = ResultsStr.Insert(Decmal_Location, ".");
                }

                // Save the results
                Results = decimal.Parse(ResultsStr);
            } // if (Status == RNG_Status.Success)

            //=============
            // Cleanup Environment
            //=============
            return Results;
        } // public decimal Generate_Percentage(decimal MinValue, decimal MaxValue, byte Precision)
    } // public partial class RNG
} // namespace Orias_RNG
