using CodeBase.Logic;
using General.CodeBase.UI;
using UnityEngine;
using Zenject;

namespace Painting.CodeBase.Logic
{
    public class TileLogic : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _sprite;
        [SerializeField] private int _countPoint = 5;
        [SerializeField] private int _countPointForWin;

        private ScorePointUI _scorePoint;

        [Inject]
        public void Construct(ScorePointUI scorePoint)
        {
            _scorePoint = scorePoint;
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("BluePlayer"))
            {
                _scorePoint.AddPoint(PlayerType.Blue, _countPoint);
                _sprite.color = Color.blue;
            }
            else
            {
                _scorePoint.AddPoint(PlayerType.Red, _countPoint);
                _sprite.color = Color.red;
            }
            
            _scorePoint.CheckWinner(_countPointForWin);
        }
    }
}