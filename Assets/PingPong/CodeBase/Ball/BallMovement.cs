using UnityEngine;
using Random = UnityEngine.Random;

namespace PingPong.CodeBase.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    public class BallMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _moveSpeed;

        private Vector2 _direction;

        public void Start() =>
            ChoosingSides();

        public void ChoosingSides()
        {
            float x = Random.Range(0, 2) == 0 ? -1 : 1;
            float y = Random.Range(0, 2) == 0 ? -1 : 1;

            _rigidbody.velocity = new Vector2(_moveSpeed * x, _moveSpeed * y);
            
        }
    }
}