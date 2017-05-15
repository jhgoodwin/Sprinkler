using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sprinkler.Controller.Tests
{
    [TestClass]
    public class ValveTests
    {
        [TestMethod]
        public void Valve_SetTrue_Success()
        {
            var valve = GetValve(false);
            valve.Set(true);
            Assert.IsTrue(valve.IsOpen(), "Expected valve to be open after setting it to open");
        }

        [TestMethod]
        public void Valve_SetFalse_Success()
        {
            var valve = GetValve(true);
            valve.Set(false);
            Assert.IsFalse(valve.IsOpen(), "Expected valve to be closed after setting it to closed");
        }

        #region Private Helper Methods
        private IValve GetValve(bool isInitiallyOpen)
        {
            return new TestValve(isInitiallyOpen);
        }
#endregion
    }
}
