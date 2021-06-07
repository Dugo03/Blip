namespace Blip.State
{
    public class MainMenuState : BaseState
    {
        public MainMenuState(Context context) : base(context) { }

        public override void OnActionButton(bool down)
        {
            if (down)
                Context.MainMenuSelect();
        }
    }
}