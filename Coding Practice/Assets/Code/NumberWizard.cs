using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

	[SerializeField]public int largeNum = 1000;

	[SerializeField]public int smallNum = 1;

	[SerializeField]public int myGuess = 500;
	
	void Start () 
	{
		StartGame();
	}

	void StartGame()
	{
		largeNum = largeNum + 1;
	}
	

	void OnPressHigher()
	{
		
		smallNum = myGuess;
		NextGuess();
	}

	void OnPressLower()
	{
		largeNum = myGuess;
		NextGuess();
	}
	void NextGuess()
	{
		myGuess = (largeNum + smallNum) / 2;
	}
}
