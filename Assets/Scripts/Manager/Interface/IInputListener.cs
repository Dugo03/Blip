namespace Blip.Manager.Interface
{
    public interface IInputListener
    {
        void ActionButtonEvent (bool down);
        void XAxisEvent(float intensity);
        void YAxisEvent(float intensity);
        void RestartButtonEvent();
    }
}

