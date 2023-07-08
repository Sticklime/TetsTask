using UnityEngine;

namespace Painting.CodeBase.Logic
{
    public class PlayerController : MonoBehaviour
    {
        public KeyCode UpKey;
        public KeyCode DownKey;
        public KeyCode LeftKey;
        public KeyCode RightKey;

        public Vector3 PlayerInput()
        {
            Vector3 moveDirection = Vector2.zero;

            if (Input.GetKey(UpKey))
                moveDirection = Vector2.up;
            else if (Input.GetKey(DownKey))
                moveDirection = Vector2.down;
            else if (Input.GetKey(LeftKey))
                moveDirection = Vector2.left;
            else if (Input.GetKey(RightKey))
                moveDirection = Vector2.right;

            return moveDirection;
        }
    }
}