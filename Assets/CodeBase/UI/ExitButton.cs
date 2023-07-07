using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;

    public void AddListener(UnityAction action)
    {
        _mainMenuButton.onClick.AddListener(action);
    }

    public void RemoveListener(UnityAction action)
    {
        _mainMenuButton.onClick.RemoveListener(action);
    }
}
