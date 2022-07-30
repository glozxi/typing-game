using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WPMDisplay : MonoBehaviour
{
    [SerializeField]
    TMP_Text _text;
    [SerializeField]
    WPMTimer _wpmTimer;

    // Update is called once per frame
    void Update()
    {
        _text.text = _wpmTimer.GetWPM().ToString();
    }
}
