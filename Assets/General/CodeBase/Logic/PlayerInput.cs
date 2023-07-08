using UnityEngine;

namespace General.CodeBase.Logic
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private KeyCode _buttonInput;

        public bool _isButtonDown { get; private set; } = false;
        public bool _isButtonUP { get; private set; } = false;

        private void Update()
        {
            _isButtonDown = Input.GetKey(_buttonInput);
            _isButtonUP = Input.GetKeyUp(_buttonInput);
        }
    }
}