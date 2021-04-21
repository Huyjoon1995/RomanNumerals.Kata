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
    }
}
