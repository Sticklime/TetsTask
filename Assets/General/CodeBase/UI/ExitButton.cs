using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace General.CodeBase.UI
{
    public class ExitButton : MonoBehaviour
    {
        [SerializeField] private Button _mainMenuButton;

        public void AddListener(UnityAction action) => 
            _mainMenuButton.onClick.AddListener(action);
    }
}