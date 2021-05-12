using RomanNumService;
using Xunit;
using FluentAssertions;

namespace RomanNumService.Tests.NumeralTests {
    public class NumeralTest_Constructor {
        [Fact]
        public void TestName() {
            Numeral num = new Numeral("I", 1);
            num.RomanNumeral.Should().Be("I");
            num.Value.Should().Be(1);
        }
    }
}