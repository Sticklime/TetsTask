using General.CodeBase.UI;
using UnityEngine;
using Zenject;

namespace General.CodeBase.Installers
{
    public class LocalInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _hudPrefab;
        
        public override void InstallBindings()
        {
            BindScorePoint();
        }

        private void BindScorePoint()
        {
            ScorePointUI scorePoint = Container
                .InstantiatePrefabForComponent<ScorePointUI>(_hudPrefab);

            Container
                .Bind<ScorePointUI>()
                .FromInstance(scorePoint)
                .AsSingle();
        }
    }
}