using System;
using UnityEngine;

namespace Painting.CodeBase.Logic
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private int _speedMove;
        [SerializeField] private Rigidbody2D _rigidbody;

        private void Update()
        {
            Vector3 direction = _playerController.PlayerInput();
            Move(direction);
        }

        private void Move(Vector3 direction)
        {
            float scaleSpeed = _speedMove * Time.deltaTime;
            transform.position += direction * scaleSpeed;
        }
    }
}