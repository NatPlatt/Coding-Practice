using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

	public int largeNum = 1000;

	public int smallNum = 1;

	public int myGuess = 500;
	
	void Start () 
	{
		StartGame();
	}

	void StartGame()
	{
		largeNum = 1000;
        
		smallNum = 1;
        
		myGuess = 500;
		
		Debug.Log("Welcome to the Number Wizard.");
		Debug.Log("Pick a number, but don't tell me what it is");
		Debug.Log("The Highest number you can pick is: " + largeNum);
		Debug.Log("The lowest number you can pick is: " + smallNum);
		Debug.Log("Tell me if your number is higher or lower than " +  myGuess);
		Debug.Log("Press up arrow if higher, down arrow if lower, then press Enter");
		largeNum = largeNum + 1;
	}
	
	void Update ()
	{

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			smallNum = myGuess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			largeNum = myGuess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("User pressed enter");
		}
	}

	void NextGuess()
	{
		myGuess = (largeNum + smallNum) / 2;
		Debug.Log("Is it higher or lower than..." + myGuess);
	}
}
