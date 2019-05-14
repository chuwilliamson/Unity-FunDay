using Tobii.Gaming;
using UnityEngine;
using UnityEngine.UI;

public class UITextBehaviour : MonoBehaviour
{
    [SerializeField] private Vector2Variable _eyePosition;

    [SerializeField] private Text _textComponent;

    private void Awake()
    {
        if (_textComponent == null)
            _textComponent = GetComponent<Text>();
    }

    private void Update()
    {
        _eyePosition.value = TobiiAPI.GetGazePoint().Screen;
        _textComponent.text = _eyePosition.value.ToString();
    }
}