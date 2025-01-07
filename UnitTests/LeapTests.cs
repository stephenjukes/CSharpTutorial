using CSharp.Exercism;
using FluentAssertions;

namespace UnitTests
{
    public class LeapTests
    {
        [Fact]
        public void Leap_WhenYearIsMultipleOf400_ReturnsTrue()
        {
            var isLeap = Leap.Run(2000);

            isLeap.Should().BeTrue();
        }

        [Fact]
        public void Leap_WhenYearIsMultipleOf100_ReturnsFalse()
        {
            var isLeap = Leap.Run(1900);

            isLeap.Should().BeFalse();
        }

        [Fact]
        public void Leap_WhenYearIsMultipleOf4_ReturnsTrue()
        {
            var isLeap = Leap.Run(2004);

            isLeap.Should().BeTrue();
        }
    }
}