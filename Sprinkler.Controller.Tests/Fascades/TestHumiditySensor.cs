using System;
using Sprinkler.Controller.Sensors;

namespace Sprinkler.Controller.Tests.Fascades
{
    internal class TestHumiditySensor : IHumiditySensor
    {
        private Func<int> getHumidity;

        public TestHumiditySensor(Func<int> getHumidity)
        {
            this.getHumidity = getHumidity;
        }

        public int Read() => getHumidity();
    }
}