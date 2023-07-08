using UnityEngine;

namespace HorseRacing.CodeBase.Logic.CameraLogic
{
    public class CameraFollowHorse : MonoBehaviour
    {
        [SerializeField] private Transform[] targets;

        private Transform targetToFollow;

        private void Start()
        {
            targetToFollow = targets[0];
        }

        private void Update() => 
            CameraFollow();

        private void CameraFollow()
        {
            for (int i = 1; i < targets.Length; i++)
            {
                if (targets[i].position.y > targetToFollow.position.y)
                    targetToFollow = targets[i];
            }

            Vector3 cameraPosition = transform.position;
            cameraPosition.y = targetToFollow.position.y;

            transform.position = cameraPosition;
        }
    }
}