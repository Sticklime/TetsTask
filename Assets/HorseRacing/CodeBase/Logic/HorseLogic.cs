using CodeBase.Logic;
using UnityEngine;

namespace HorseRacing.CodeBase.Logic
{
    public class HorseLogic : MonoBehaviour, IRestartable
    {
        private Vector2 _startPosition;

        private void Awake() =>
            _startPosition = transform.position;

        public void Restart() => 
            transform.position = _startPosition;
    }
}