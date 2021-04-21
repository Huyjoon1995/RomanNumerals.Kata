using Xunit;

namespace RomanNumerals.Kata.Tests
{
    public class UnitTests
    {
        [Fact]
        public void ConvertZeroToRoman()
        {
            Assert.Equal("", RomanNumerals.IntToRoman(0));
        }

        [Fact]
        public void ConvertFourThousandToRoman()
        {
            Assert.Equal("", RomanNumerals.IntToRoman(4000));
        }

        [Fact]
        public void ConvertOneToRoman()
        {
            Assert.Equal("I", RomanNumerals.IntToRoman(1));
        }

        [Fact]
        public void ConvertFourToRoman()
        {
            Assert.Equal("IV", RomanNumerals.IntToRoman(4));
        }

        [Fact]
        public void ConvertFiveToRoman()
        {
            Assert.Equal("V", RomanNumerals.IntToRoman(5));
        }

        [Fact]
        public void ConvertNineToRoman()
        {
            Assert.Equal("IX", RomanNumerals.IntToRoman(9));
        }

        [Fact]
        public void ConvertTenToRoman()
        {
            Assert.Equal("X", RomanNumerals.IntToRoman(10));
        }

        [Fact]
        public void ConvertFortyToRoman()
        {
            Assert.Equal("XL", RomanNumerals.IntToRoman(40));
        }

        [Fact]
        public void ConvertFiftyToRoman()
        {
            Assert.Equal("L", RomanNumerals.IntToRoman(50));
        }
    }
}
