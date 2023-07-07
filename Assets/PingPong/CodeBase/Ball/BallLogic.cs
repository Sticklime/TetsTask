using UnityEngine;

namespace PingPong.CodeBase.Ball
{
    [RequireComponent(typeof(BallMovement))]
    public class BallLogic : MonoBehaviour
    {
        [SerializeField] private BallMovement _ballMovement;

        public void Reset()
        {
            transform.position = Vector2.zero;
            _ballMovement.ChoosingSides();
        }
    }
}