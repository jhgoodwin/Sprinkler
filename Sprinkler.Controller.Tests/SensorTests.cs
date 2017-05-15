using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprinkler.Controller.Sensors;
using Sprinkler.Controller.Tests.Fascades;
using System;

namespace Sprinkler.Controller.Tests
{
    [TestClass]
    public class SensorTests
    {
        [TestMethod]
        public void HumiditySensor_Read_ReturnsCorrectValue()
        {
            var humidity = 0;
            Func<int> getHumidity = () => humidity;
            var humiditySensor = GetHumiditySensor(getHumidity);

            Assert.AreEqual(humidity, humiditySensor.Read(), "Expected the humidity sensor to return the mocked humidity");
        }

        private IHumiditySensor GetHumiditySensor(Func<int> getHumidity)
        {
            return new TestHumiditySensor(getHumidity);
        }
    }
}
