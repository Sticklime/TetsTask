using CodeBase.Infrastructure;
using CodeBase.UI;
using UnityEngine;
using Zenject;

namespace CodeBase.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _mainMenuPrefab;
        [SerializeField] private GameObject _bootstrapperPrefab;

        public override void InstallBindings()
        {
            BindMainMenu();
            BindBootstrapper();
        }

        private void BindBootstrapper()
        {
            Bootstrapper bootstrapper = Container
                .InstantiatePrefabForComponent<Bootstrapper>(_bootstrapperPrefab);

            Container
                .Bind<Bootstrapper>()
                .FromInstance(bootstrapper)
                .AsSingle();
        }

        private void BindMainMenu()
        {
            MainMenu mainMenu = Container
                .InstantiatePrefabForComponent<MainMenu>(_mainMenuPrefab);

            Container
                .Bind<MainMenu>()
                .FromInstance(mainMenu)
                .AsSingle();
        }
    }
}