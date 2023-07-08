using CodeBase.Logic;
using General.CodeBase.Logic;
using UnityEngine;

namespace PingPong.CodeBase.Dog
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(PlayerInput))]
    public class DogMove : MonoBehaviour
    {
        [SerializeField] private float _speedMove;

        private PlayerInput _playerInput;

        public float minY = -3f;
        public float maxY = 3f;

        private void Start() =>
            _playerInput = GetComponent<PlayerInput>();

        private void Update()
        {
            Vector2 direction = _playerInput._isButtonDown ? Vector2.up : Vector2.down;

            if (_playerInput._isButtonDown && transform.position.y < maxY)
                OnMove(direction, _speedMove);
            else if (!_playerInput._isButtonDown && transform.position.y > minY)
                OnMove(direction, _speedMove);
            else
                OnMove(Vector2.zero, _speedMove);

            LockPositionY();
        }

        private void OnMove(Vector3 direction, float speedMove)
        {
            float scaleSpeed = speedMove * Time.deltaTime;
            transform.position += direction * scaleSpeed;
        }

        private void LockPositionY()
        {
            Vector3 position = transform.position;
            position.y = Mathf.Clamp(position.y, minY, maxY);
            transform.position = position;
        }
    }
}