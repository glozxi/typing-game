using Ink.Runtime;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InkManager : MonoBehaviour
{
    private Story _story;
    [SerializeField]
    private TextAsset _inkJsonAsset;
    [SerializeField]
    private LineManager _lineManager;

    private void Awake()
    {
        StartStory();
    }

    private void StartStory()
    {
        _story = new Story(_inkJsonAsset.text);
        DisplayNextLine();
    }

    public void NextLine()
    {
        if (_story.canContinue)
        {
            DisplayNextLine();
        }
        else
        {
            EndGame();
        }
        
    }

    private void DisplayNextLine()
    {
        _story.Continue();
        DisplayThisLine();
    }

    private void EndGame()
    {
        if (_story.state.VisitCountAtPathString("Good") > 0)
        {
            SceneManager.LoadScene("GoodEnding");
        }
        else
        {
            SceneManager.LoadScene("BadEnding");
        }
    }

    private void DisplayThisLine()
    {
        string text = _story.currentText.Trim();
        _lineManager.NewLine(text);
    }

    public void SetWPM(int wpm)
    {
        _story.variablesState["wpm"] = wpm;
    }
}
