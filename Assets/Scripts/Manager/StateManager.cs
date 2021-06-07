using Blip.State;
using Blip.Manager.Interface;
using System.Collections.Generic;

namespace Blip.Manager
{
    public class StateManager : IInputListener
    {
        private Stack<BaseState> Stack { get; set; }

        public StateManager(BaseState initialState)
        {
            Stack = new Stack<BaseState>();

            GameManager.Instance.InputManager.SubscribeToActionButton(this);
            GameManager.Instance.InputManager.SubscribeToXAxis(this);
            GameManager.Instance.InputManager.SubscribeToYAxis(this);

            Stack.Push(initialState);
            initialState.Initialize(this);
        }

        private BaseState CurrentState()
        {
            return Stack.Peek();
        }

        public void PushState(BaseState state)
        {
            CurrentState().CleanUp();
            Stack.Push(state);
            state.Initialize(this);
        }

        public void PopState()
        {
            CurrentState().CleanUp();
            Stack.Pop();
            CurrentState().Initialize(this);
        }

        #region IInputListener
        public void ActionButtonEvent(bool down)
        {
            CurrentState().OnActionButton(down);
        }

        public void XAxisEvent(int direction)
        {
            CurrentState().OnXAxis(direction);
        }

        public void YAxisEvent(int direction)
        {
            CurrentState().OnYAxis(direction);
        }

        public void RestartButtonEvent()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
