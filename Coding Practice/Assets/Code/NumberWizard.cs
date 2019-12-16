using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	public float largeNum = 1000;

	public float smallNum = 1;
	
	void Start () {
		Debug.Log("Welcome to the Number Wizard.");
		Debug.Log("The Highest number is": largeNum);
		Debug.Log("The lowester number is ", smallNum);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
