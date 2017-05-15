using System;
using System.Collections.Generic;
using System.Text;

namespace Sprinkler.Controller.Sensors
{
    public interface IHumiditySensor
    {
        int Read();
    }
}
