using EasyCalc.Contracts;
using NUnit.Framework;

namespace EasyCalc.Test
{
    [TestFixture]
    public class TemperatureTestFixture
    {
        ITemperature _testee;

        [SetUp]
        public void SetUp()
        {
            _testee = new Temperature();
        }

        [Test]
        public void CelsiusToFarenheit_ConvertsTemperatureCorrectly()
        {
            var temperatureInFarenheit = _testee.CelsiusToFarenheit(25.5);

            Assert.AreEqual(77.9, temperatureInFarenheit, "Conversion with error.");
        }
    }
}