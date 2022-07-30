using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LineDisplay : MonoBehaviour
{

    private float _delay = 0.5f;
    private string _text;
    private bool _isCursorOn;

    [SerializeField]
    private TMP_Text _dialogueTextField;

    private void Start()
    {
        InvokeRepeating("FlashCursor", 0, _delay);
    }

    private void FlashCursor()
    {
        if (_isCursorOn)
        {
            _dialogueTextField.text = "<color=#00000000>|</color>" + _text;
        }
        else
        {
            _dialogueTextField.text = "|" + _text;
        }
        _isCursorOn = !_isCursorOn;
    }

    public void SetLine(string text)
    {
        _text = text;
        if (!_isCursorOn)
        {
            _dialogueTextField.text = "<color=#00000000>|</color>" + _text;
        }
        else
        {
            _dialogueTextField.text = "|" + _text;
        }
    }

    public void RemoveLetter()
    {
        _text = _text.Substring(1);
        SetLine(_text);

    }

}
