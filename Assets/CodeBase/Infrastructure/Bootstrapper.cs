using System.Runtime.InteropServices;
using CodeBase.UI;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class Bootstrapper : MonoBehaviour, ICoroutineRunner
    {
        [DllImport("__Internal")] private static extern void Hello();
        
        private IGame _game;
        private MainMenu _mainMenu;

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
            _game = new Game( _mainMenu, new SceneLoader(this));
            _mainMenu.Construct(_game);
        }
    }
}