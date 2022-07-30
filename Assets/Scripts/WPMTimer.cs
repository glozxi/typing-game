using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPMTimer : MonoBehaviour
{
    private float _timer = 0.0f;
    private int _wordNum = 0;
    public bool Started
    { get; set; } = false;

    void Update()
    {
        if (Started) _timer += Time.deltaTime;
    }

    public void AddWord()
    {
        _wordNum++;
    }

    public int GetWPM()
    {
        if (_timer == 0)
        {
            return 0;
        }
        return Mathf.RoundToInt(_wordNum / (_timer / 60));
    }
}
