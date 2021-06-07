using UnityEngine;
using System.Collections;
using Blip.Controller;
using System;

namespace Blip.State
{
    public class Context
    {
        private MainMenuController MainMenuController { get; set; }

        public Context(MainMenuController mainMenuController)
        {
            MainMenuController = mainMenuController;
        }

        internal void MainMenuSelect()
        {
            Debug.Log("Selected");
        }
    }
}