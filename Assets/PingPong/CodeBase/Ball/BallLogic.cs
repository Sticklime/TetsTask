using CodeBase.Logic;
using UnityEngine;

namespace PingPong.CodeBase.Ball
{
    [RequireComponent(typeof(BallMovement))]
    public class BallLogic : MonoBehaviour, IRestartable
    {
        [SerializeField] private BallMovement _ballMovement;

        public void Restart()
        {
            transform.position = Vector2.zero;
            _ballMovement.ChoosingSides();
        }
    }
}