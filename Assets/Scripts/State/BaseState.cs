using Blip.Manager;
using Blip.Manager.Interface;

namespace Blip.State
{
    public abstract class BaseState : IInputHandler
    {
        protected Context Context { get; }
        protected StateManager StateManager { get; set; }

        public BaseState(Context context)
        {
            Context = context;
        }

        public virtual void Initialize(StateManager manager)
        {
            StateManager = manager;
        }

        public virtual void CleanUp()
        {

        }

        #region IInputHandler

        public virtual void OnActionButton(bool down) { }

        public virtual void OnXAxis(float intensity) { }

        public virtual void OnYAxis(float intensity) { }

        public virtual void OnRestartButton() { }


        #endregion
    }
}