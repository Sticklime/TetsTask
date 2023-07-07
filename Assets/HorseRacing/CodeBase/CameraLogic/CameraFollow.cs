using UnityEngine;

namespace HorseRacing.CodeBase.CameraLogic
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 0.125f;
        [SerializeField] private Transform[] _targets;
        [SerializeField] private float _offsetY;

        private Transform _currentTarget;
        private Vector3 _velocity;

        void LateUpdate()
        {
            if (_targets.Length == 0)
                return;

            OnMove();
        }

        private void OnMove()
        {
            float averageY = GetAverageYPosition();
            
            Vector3 position = new Vector3(transform.position.x, averageY + _offsetY, transform.position.z);
            Vector3 smoothedPosition = 
                Vector3.SmoothDamp(transform.position, position, ref _velocity, _moveSpeed);
            
            transform.position = smoothedPosition;
        }

        float GetAverageYPosition()
        {
            float totalY = 0f;

            foreach (Transform target in _targets) 
                totalY += target.position.y;

            return totalY / _targets.Length;
        }
    }
}