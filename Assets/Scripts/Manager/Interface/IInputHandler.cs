namespace Blip.Manager.Interface
{
    public interface IInputHandler
    {
        void OnActionButton (bool down);
        void OnXAxis(int direction);
        void OnYAxis(int direction);
        void OnRestartButton();
    }
}

