namespace Blip.Manager.Interface
{
    public interface IInputHandler
    {
        void OnActionButton (bool down);
        void OnXAxis(float intensity);
        void OnYAxis(float intensity);
        void OnRestartButton();
    }
}

