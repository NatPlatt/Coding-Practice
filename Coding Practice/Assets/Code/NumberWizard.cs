using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	public float largeNum = 1000;

	public float smallNum = 1;
	
	void Start () {
		Debug.Log("Welcome to the Number Wizard.");
		Debug.Log("Pick a number, but don't tell me what it is");
		Debug.Log("The Highest number you can pick is": largeNum);
		Debug.Log("The lowest number you can pick is ", smallNum);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
