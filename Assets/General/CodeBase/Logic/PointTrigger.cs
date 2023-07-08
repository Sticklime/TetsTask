using CodeBase.Logic;
using General.CodeBase.UI;
using UnityEngine;
using Zenject;

namespace General.CodeBase.Logic
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class PointTrigger : MonoBehaviour
    {
        [SerializeField] private PlayerType _pointForPlayer;
        [SerializeField] private int _countPointWinning;
        [SerializeField] private int _countPointForWin;

        private ScorePointUI _scorePointUI;

        [Inject]
        public void Construct(ScorePointUI scorePointUI)
        {
            _scorePointUI = scorePointUI;
        }

        private void OnTriggerEnter2D(Collider2D trigger)
        {
            if (trigger.TryGetComponent(out IRestartable restartable))
            {
                restartable.Restart();
                _scorePointUI.AddPoint(_pointForPlayer, _countPointWinning);
                _scorePointUI.CheckWinner(_countPointForWin);
            }
        }
    }
}