using CodeBase.Logic;
using UnityEngine;

namespace HorseRacing.CodeBase
{
    public class HorseMove : MonoBehaviour
    {
        [SerializeField] private float _forceGallop;

        private PlayerInput _playerInput;
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _playerInput = GetComponent<PlayerInput>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update() =>
            Move();

        private void Move()
        {
            if (_playerInput._isButtonActive)
                MoveAndStopAction();
            else if (_rigidbody2D.velocity.y > 0)
                ApplyStopForce();
        }

        private void MoveAndStopAction() =>
            _rigidbody2D.AddForce(new Vector2(0f, _forceGallop) * Time.deltaTime, ForceMode2D.Impulse);

        private void ApplyStopForce() =>
            _rigidbody2D.AddForce(new Vector2(0f, -_forceGallop) * Time.deltaTime, ForceMode2D.Impulse);
    }
}