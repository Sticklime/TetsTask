using UnityEngine;

namespace CodeBase.Logic
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private KeyCode _buttonInput;

        public bool _isButtonActive { get; private set; } = false;

        private void Update() => 
            _isButtonActive = Input.GetKey(_buttonInput);
    }
}