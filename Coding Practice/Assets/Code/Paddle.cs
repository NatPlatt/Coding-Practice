using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInUnits = Input.mousePosition.x / Screen.width;
		Vector3 paddlePos = new Vector3(mousePosInUnits, transform.position.y);
		transform.position = paddlePos;
	}
}
