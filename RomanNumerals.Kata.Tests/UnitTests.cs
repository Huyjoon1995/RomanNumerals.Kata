using System;
using Xunit;

namespace RomanNumerals.Kata.Tests
{
    public class UnitTests
    {
        [Fact]
        public void ConvertZeroToRoman()
        {
            var ex = Assert.Throws<Exception>(() => RomanNumerals.IntToRoman(0));
            Assert.Contains("Number must be between 1 & 3999.", ex.Message);

        }

        [Fact]
        public void ConvertFourThousandToRoman()
        {
            var ex = Assert.Throws<Exception>(() => RomanNumerals.IntToRoman(4000));
            Assert.Contains("Number must be between 1 & 3999.", ex.Message);
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

        [Fact]
        public void ConvertOneThousandNineHundredNinetyFour()
        {
            Assert.Equal("MCMXCIV", RomanNumerals.IntToRoman(1994));
        }

        [Fact]
        public void ConvertFiftyEightToRoman()
        {
            Assert.Equal("LVIII", RomanNumerals.IntToRoman(58));
        }

        [Fact]
        public void ConvertThreeThousandFiveHundredFortyNineToRoman()
        {
            Assert.Equal("MMMDXLIX", RomanNumerals.IntToRoman(3549));
        }
    }
}
