namespace RomanNumerals.Kata
{
    public class RomanNumerals
    {
        public static string IntToRoman(int num)
        {
            if(num < 1 || num > 3999)
            {
                return "";
            }
            return "I";
        }
    }
}
