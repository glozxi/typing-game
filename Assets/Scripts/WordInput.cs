using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
	public LineManager _lineManager;

	// Update is called once per frame
	void Update()
	{
		foreach (char letter in Input.inputString)
		{
			_lineManager.TypeLetter(letter);
		}
	}
}
