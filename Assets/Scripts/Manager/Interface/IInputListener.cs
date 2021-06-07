namespace Blip.Manager.Interface
{
    public interface IInputListener
    {
        void ActionButtonEvent (bool down);
        void XAxisEvent(int direction);
        void YAxisEvent(int direction);
        void RestartButtonEvent();
    }
}

