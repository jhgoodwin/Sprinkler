namespace Sprinkler.Controller.Tests
{
    internal class TestValve : IValve
    {
        private bool isOpen;

        public TestValve(bool isInitiallyOpen)
        {
            isOpen = isInitiallyOpen;
        }

        public bool IsOpen() => isOpen;

        public void Set(bool valveOpen) => isOpen = valveOpen;
    }
}