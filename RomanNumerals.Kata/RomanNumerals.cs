using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        public static string IntToRoman(int num)
        {
            if(num < 1 || num > 3999)
            {
                throw new Exception("Number must be between 1 & 3999.");
            }

            string[] M = { "", "M", "MM", "MMM" }; // Thousands
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; // Hundreds
            string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }; // Tens
            string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }; // Ones

            return M[num / 1000] + C[num % 1000 / 100] + X[num % 100 / 10] + I[num % 10];
        }
    }
}
