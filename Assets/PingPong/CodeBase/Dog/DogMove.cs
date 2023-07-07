using CodeBase.Logic;
using UnityEngine;

namespace PingPong.CodeBase.Dog
{
    public class DogMove : MonoBehaviour
    {
        [SerializeField] private float _speedMove;

        private PlayerInput _playerInput;

        private void Start() => 
            _playerInput = GetComponent<PlayerInput>();

        private void Update() => 
            Move();

        private void Move() =>
            OnMove(_playerInput._isButtonActive ? Vector2.up : Vector2.down, _speedMove);

        private void OnMove(Vector2 direction, float speedMove)
        {
            float scaleSpeed = speedMove * Time.deltaTime;
            transform.Translate(direction * scaleSpeed);
        }
    }
}