using NUnit.Framework;
using Leap_Year_Kata;

namespace Leap_Year_Kata_Test
{
    //Leap years are years divisible by 4, except they are divisible by 100 unless divisible by 400

    public class LeapYearShould
    {
        [SetUp]
        public void Setup() {
        }

        [TestCase(0, true)]
        [TestCase(400, true)]
        [TestCase(800, true)]
        [TestCase(100, false)]
        [TestCase(505, false)]
        public void BeDivisibleBy400(int year, bool result) {
            Assert.AreEqual(LeapYear.IsLeapYear(year), result);
        }

        [TestCase(100, false)]
        [TestCase(200, false)]
        [TestCase(300, false)]
        [TestCase(400, true)]
        [TestCase(800, true)]
        [TestCase(1200, true)]
        public void NotBeDivisibleBy100IfNotDivisibleBy400(int year, bool result) {
            Assert.AreEqual(LeapYear.IsLeapYear(year), result);
        }

        [TestCase(1, false)]
        [TestCase(102, false)]
        [TestCase(303, false)]
        [TestCase(4, true)]
        [TestCase(24, true)]
        [TestCase(104, true)]
        public void BeDivisibleBy4AndNotDivisibleBy100UnlessDivisibleBy400(int year, bool result) {
            Assert.AreEqual(LeapYear.IsLeapYear(year), result);
        }
    }
}