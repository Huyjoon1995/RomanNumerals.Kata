using System;
using System.Collections.Generic;
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
            while (num >= 1000)
            {
                sb.Append("M");
                num -= 1000;
            }
            while (num >= 900)
            {
                sb.Append("CM");
                num -= 900;
            }
            while (num >= 500)
            {
                sb.Append("D");
                num -= 500;
            }
            while (num >= 400)
            {
                sb.Append("CD");
                num -= 400;
            }
            while (num >= 100)
            {
                sb.Append("C");
                num -= 100;
            }
            while (num >= 90)
            {
                sb.Append("XC");
                num -= 90;
            }
            while (num >= 50)
            {
                sb.Append("L");
                num -= 50;
            }
            while (num >= 10)
            {
                sb.Append("X");
                num -= 10;
            }
            while (num >= 9)
            {
                sb.Append("IX");
                num -= 9;
            }
            while (num >= 5)
            {
                sb.Append("V");
                num -= 5;
            }
            while (num >= 4)
            {
                sb.Append("IV");
                num -= 4;
            }
            while (num >= 1)
            {
                sb.Append("I");
                num -= 1;
            }

            return sb.ToString();
        }
    }
}
