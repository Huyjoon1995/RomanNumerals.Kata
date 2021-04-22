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

        [Fact]
        public void ConvertNinetyToRoman()
        {
            Assert.Equal("XC", RomanNumerals.IntToRoman(90));
        }

        [Fact]
        public void ConvertOneHundredToRoman() {
            Assert.Equal("C", RomanNumerals.IntToRoman(100));
        }

        [Fact]
        public void ConvertFourHundredToRoman()
        {
            Assert.Equal("400", RomanNumerals.IntToRoman(400));
        }

        [Fact]
        public void ConvertFiveHundredToRoman()
        {
            Assert.Equal("D", RomanNumerals.IntToRoman(500));
        }

        [Fact]
        public void ConvertNineHundredToRoman()
        {
            Assert.Equal("CM", RomanNumerals.IntToRoman(900));
        }

        [Fact]
        public void ConvertOneThousandToRoman()
        {
            Assert.Equal("M", RomanNumerals.IntToRoman(1000));
        }
    }
}
