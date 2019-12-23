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
		largeNum = largeNum + 1;
		
	}
	

	void OnPressHigher()
	{
		smallNum = myGuess + 1;
		NextGuess();
	}

	void OnPressLower()
	{
		largeNum = myGuess - 1;
		NextGuess();
	}
	void NextGuess()
	{

		myGuess = Random.Range(smallNum, largeNum + 1);
		//myGuess = (largeNum + smallNum) / 2;
		//guessText.text = guess.ToString();
	}
}
