using Blip.Manager;

namespace Blip.State
{
    public class MainMenuState : BaseState
    {
        public MainMenuState(Context context) : base(context) { }

        public override void Initialize(StateManager manager)
        {
            base.Initialize(manager);

            Context.MainMenuController.Init();
        }

        public override void OnActionButton(bool down)
        {
            //if (down)
            //    Context.MainMenuSelect();
        }

        public override void OnYAxis(int direction)
        {
            Context.MainMenuController.MoveMenu(direction);
        }
    }
}