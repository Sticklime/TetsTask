using CodeBase.Infrastructure;
using General.CodeBase.UI;
using UnityEngine;

namespace General.CodeBase.Infrastructure
{
    public class InitializerLevel
    {
        private readonly ISceneLoader _sceneLoader;
        private readonly Game _game;

        private GameObject _hud;

        public InitializerLevel(Game game, ISceneLoader sceneLoader)
        {
            _game = game;
            _sceneLoader = sceneLoader;
        }

        public void LoadLevel(string name) =>
            _sceneLoader.Load(name, InitLevel);

        private void InitLevel()
        {
            InitHud();
        }

        private void InitHud()
        {
            GameObject hudPrefab = Resources.Load<GameObject>(PathManager.HudPath);
            GameObject hudInstantiate = Object.Instantiate(hudPrefab);

            ExitButton exitButton = hudInstantiate.GetComponent<ExitButton>();

            exitButton.AddListener(_game.ExitMainMenu);
        }
    }
}