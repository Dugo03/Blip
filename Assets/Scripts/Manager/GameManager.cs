using Blip.Controller;
using Blip.State;
using UnityEngine;


namespace Blip.Manager
{
    public class GameManager : MonoBehaviour
    {
        [Header("References")]
        [SerializeField]
        MainMenuController _mainMenuController;


        public static GameManager Instance { get; private set; }

        public InputManager InputManager { get; private set; }

        private StateManager StateManager { get; set; }


        public void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            Screen.SetResolution(800, 600, false);

            InputManager = GetComponent<InputManager>();

            var context = new Context(_mainMenuController);
            var initialState = new MainMenuState(context);
            StateManager = new StateManager(initialState);
        }
    }

}
