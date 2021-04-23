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

            StringBuilder sb = new StringBuilder();
            var valueMap = new SortedDictionary<int, string>
                               {
                                   { 1, "I" },
                                   { 4, "IV" },
                                   { 5, "V" },
                                   { 9, "IX" },
                                   { 10, "X" },
                                   { 40, "XL" },
                                   { 50, "L" },
                                   { 90, "XC" },
                                   { 100, "C" },
                                   { 400, "CD" },
                                   { 500, "D" },
                                   { 900, "CM" },
                                   { 1000, "M" },
                               };

            foreach (var kvp in valueMap.Reverse())
            {
                while (num >= kvp.Key)
                {
                    num -= kvp.Key;
                    sb.Append(kvp.Value);
                }
            }

            return sb.ToString();
        }
    }
}
