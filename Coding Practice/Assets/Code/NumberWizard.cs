using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	public int largeNum = 1000;

	public int smallNum = 1;

	public int myGuess = 500;
	
	void Start () {
		Debug.Log("Welcome to the Number Wizard.");
		Debug.Log("Pick a number, but don't tell me what it is");
		Debug.Log("The Highest number you can pick is: " + largeNum);
		Debug.Log("The lowest number you can pick is: " + smallNum);
		Debug.Log("Tell me if your number is higher or lower than " +  myGuess);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
