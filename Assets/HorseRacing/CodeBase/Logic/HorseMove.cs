using CodeBase.Logic;
using General.CodeBase.Logic;
using UnityEngine;

namespace HorseRacing.CodeBase
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(PlayerInput))]
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
            if (_playerInput._isButtonUP)
                MoveAndStopAction();
        }

        private void MoveAndStopAction() =>
            _rigidbody2D.velocity += new Vector2(0f, _forceGallop) * Time.deltaTime;
    }
}