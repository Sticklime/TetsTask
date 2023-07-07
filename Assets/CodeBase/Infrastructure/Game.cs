using CodeBase.Logic;
using CodeBase.UI;

namespace CodeBase.Infrastructure
{
    public class Game : IGame
    {
        private readonly MainMenu _mainMenu;
        private readonly SceneLoader _sceneLoader;

        public Game(MainMenu mainMenu, SceneLoader sceneLoader)
        {
            _mainMenu = mainMenu;
            _sceneLoader = sceneLoader;
        }

        public void StartGame(string name)
        {
            InitializerLevel initializerLevel = new InitializerLevel(this, _sceneLoader);
            _mainMenu.gameObject.SetActive(false);

            initializerLevel.LoadLevel(name);
        }

        public void EndGame(PlayerType winner)
        {
            _mainMenu.gameObject.SetActive(true);
            _sceneLoader.Load("Menu");
        }

        public void ExitMainMenu()
        {
            EndGame(PlayerType.Default);
        }
    }
}