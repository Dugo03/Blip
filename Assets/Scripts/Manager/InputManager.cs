using Blip.Manager.Interface;
using UnityEngine;


namespace Blip.Manager
{
    public class InputManager : MonoBehaviour
    {
        public delegate void ActionButtonEvent(bool down);
        private static event ActionButtonEvent OnActionButtonEvent;

        public void Update()
        {
            if (Input.GetButtonDown("Action"))
            {
                OnActionButtonEvent?.Invoke(true);
            }
            else if (Input.GetButtonUp("Action"))
            {
                OnActionButtonEvent?.Invoke(false);
            }


        }

        public void SubscribeToActionButton(IInputListener inputHandler)
        {
            OnActionButtonEvent += inputHandler.ActionButtonEvent;
        }

        public void UnsubscribeToActionButton(IInputListener inputHandler)
        {
            OnActionButtonEvent -= inputHandler.ActionButtonEvent;
        }
    }
}
