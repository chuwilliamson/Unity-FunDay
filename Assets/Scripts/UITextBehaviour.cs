using System;
using System.Diagnostics;
using Tobii.Gaming;
using UnityEngine;
using UnityEngine.UI;
using Variables;

public class UITextBehaviour : MonoBehaviour
{
    [SerializeField] private Variable displayVariable;

    [SerializeField] private Text _textComponent;

    private void Awake()
    {
        if (_textComponent == null)
            _textComponent = GetComponent<Text>();
    }

    private void Update()
    {
        _textComponent.text = displayVariable.Value.ToString();
    }
}