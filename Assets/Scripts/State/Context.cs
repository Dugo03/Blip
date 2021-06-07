using UnityEngine;
using System.Collections;
using Blip.Controller;
using System;

namespace Blip.State
{
    public class Context
    {
        public MainMenuController MainMenuController { get; private set; }

        public Context(MainMenuController mainMenuController)
        {
            MainMenuController = mainMenuController;
        }
    }
}