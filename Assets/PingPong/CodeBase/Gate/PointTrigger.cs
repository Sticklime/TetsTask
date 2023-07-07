using CodeBase.Logic;
using CodeBase.UI;
using PingPong.CodeBase.Ball;
using UnityEngine;
using Zenject;

namespace PingPong.CodeBase.Gate
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class PointTrigger : MonoBehaviour
    {
        [SerializeField] private PlayerType _pointForPlayer;
        [SerializeField] private int CountPointWinning;

        private ScorePointUI _score;

        [Inject]
        public void Construct(ScorePointUI scorePointUI)
        {
            _score = scorePointUI;
        }

        private void OnTriggerEnter2D(Collider2D trigger)
        {
            if (trigger.TryGetComponent(out BallLogic ballLogic))
            {
                ballLogic.Reset();
                _score.RefreshData(_pointForPlayer, CountPointWinning);
            }
        }
    }
}