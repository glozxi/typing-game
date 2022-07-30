using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
	public Line Line
	{ get; set; }
	[SerializeField]
	private LineDisplay _display;
	[SerializeField]
	private InkManager _inkManager;
	[SerializeField]
	private WPMTimer _wpmTimer;

	public void TypeLetter(char letter)
	{
		if (!_wpmTimer.Started) _wpmTimer.Started = true;
		
		if (letter == Line.GetNextLetter())
        {
			Line.TypeLetter();
			if (letter == ' ')
            {
				_wpmTimer.AddWord();

			}
		}

		if (Line.LineTyped())
		{
			_wpmTimer.AddWord();
			_inkManager.SetWPM(_wpmTimer.GetWPM());
			_inkManager.NextLine();

			return;
		}
	}

	public void NewLine(string text)
    {
		Line = new Line(text, _display);
    }
}
