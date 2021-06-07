using Blip.Manager.Interface;
using System;
using UnityEngine;


namespace Blip.Manager
{
    public class InputManager : MonoBehaviour
    {
        public delegate void ActionButtonEvent(bool down);
        private static event ActionButtonEvent OnActionButtonEvent;

        public delegate void YAxisEvent(int direction);
        private static event YAxisEvent OnYAxisEvent;

        public delegate void XAxisEvent(int direction);
        private static event XAxisEvent OnXAxisEvent;

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
            
            if (Input.GetButtonDown("Up"))
            {
                OnYAxisEvent?.Invoke(1);
            }
            else if (Input.GetButtonDown("Down"))
            {
                OnYAxisEvent?.Invoke(-1);
            }
            else if (Input.GetButtonUp("Down") || Input.GetButtonUp("Up"))
            {
                OnYAxisEvent?.Invoke(0);
            }

            if (Input.GetButtonDown("Left"))
            {
                OnXAxisEvent?.Invoke(1);
            }
            else if (Input.GetButtonDown("Right"))
            {
                OnXAxisEvent?.Invoke(-1);
            }
            else if (Input.GetButtonUp("Left") || Input.GetButtonUp("Right"))
            {
                OnXAxisEvent?.Invoke(0);
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

        public void SubscribeToXAxis(IInputListener inputHandler)
        {
            OnXAxisEvent += inputHandler.XAxisEvent;
        }

        public void UnsubscribeToXAxis(IInputListener inputHandler)
        {
            OnXAxisEvent -= inputHandler.XAxisEvent;
        }

        public void SubscribeToYAxis(IInputListener inputHandler)
        {
            OnYAxisEvent += inputHandler.YAxisEvent;
        }

        public void UnsubscribeToYAxis(IInputListener inputHandler)
        {
            OnYAxisEvent -= inputHandler.YAxisEvent;
        }
    }
}
