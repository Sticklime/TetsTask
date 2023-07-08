using System.Runtime.InteropServices;
using CodeBase.Infrastructure;
using General.CodeBase.UI;
using UnityEngine;
using Zenject;

namespace General.CodeBase.Infrastructure
{
    public class Bootstrapper : MonoBehaviour, ICoroutineRunner
    {
        [DllImport("__Internal")]
        private static extern void Hello();

        private MainMenu _mainMenu;
        private IGame _game;

        [Inject]
        public void Construct(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }

        public void Start()
        {
            Hello();
        }

        public void Awake()
        {
            _game = new Game(_mainMenu, new SceneLoader(this));
            _mainMenu.Construct(_game);
        }
    }
}