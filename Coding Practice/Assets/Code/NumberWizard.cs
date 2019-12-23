using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class NumberWizard : MonoBehaviour
{

	[SerializeField]public int largeNum;

	[SerializeField]public int smallNum;

	[SerializeField]public int myGuess;
	
	//[SerializeField] TextMeshProUGUI guessText;
	
	void Start () 
	{
		StartGame();
	}

	void StartGame()
	{
		NextGuess();
		//guessText.text = guess.ToString();
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
		largeNum = largeNum + 1;
		myGuess = (largeNum + smallNum) / 2;
	}
}
