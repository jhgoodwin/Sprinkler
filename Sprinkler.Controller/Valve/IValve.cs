namespace Sprinkler.Controller
{
    public interface IValve
    {
        bool IsOpen();
        void Set(bool valveOpen);
    }
}