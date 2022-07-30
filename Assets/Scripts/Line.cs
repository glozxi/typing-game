using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line
{
    private string _line;
    private int _typeIndex;
    private LineDisplay _display;

    public Line(string line, LineDisplay display)
    {
        _line = line;
        _display = display;
		_typeIndex = 0;
		display.SetLine(line);
    }
	public char GetNextLetter()
	{
		return _line[_typeIndex];
	}

	public void TypeLetter()
	{
		_typeIndex++;
		_display.RemoveLetter();
	}

	public bool LineTyped()
	{
		bool linetyped = (_typeIndex >= _line.Length);
		return linetyped;
	}
}
