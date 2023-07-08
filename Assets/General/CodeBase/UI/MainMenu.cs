using CodeBase.Infrastructure;
using General.CodeBase.Infrastructure;
using UnityEngine;

namespace General.CodeBase.UI
{
    public class MainMenu : MonoBehaviour
    {
        private IGame _game;
        
        public void Construct(IGame game)
        {
            _game = game;
        }

        public void SelectGame(string nameScene) => 
            _game.StartGame(nameScene);
    }
}