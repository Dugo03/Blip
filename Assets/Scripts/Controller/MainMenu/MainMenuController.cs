using System;
using UnityEngine;


namespace Blip.Controller
{
    public class MainMenuController : MonoBehaviour
    {
        private const int OPTION_OFFSET = 100;
        private const int OPTION_COUNT = 3;

        [Header("References")]
        [SerializeField]
        RectTransform _cursorTransform;

        private int SelectedOption { get; set; }

        public void Init()
        {
            SelectedOption = 0;
            SetCursorPosition();   
        }

        public void MoveMenu(int direction)
        {
            SelectedOption -= direction;

            if (SelectedOption < 0)
                SelectedOption = OPTION_COUNT - 1;
            else
                SelectedOption %= OPTION_COUNT;

            SetCursorPosition();
        }

        private void SetCursorPosition()
        {
            _cursorTransform.anchoredPosition = new Vector2(
                _cursorTransform.anchoredPosition.x,
                OPTION_OFFSET - (SelectedOption * (OPTION_OFFSET / (OPTION_COUNT - 1)))
            );
        }
    }
}
