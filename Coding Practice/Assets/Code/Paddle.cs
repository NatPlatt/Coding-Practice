using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	[SerializeField] private float screenWidth;
	
	void Update () {
		float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidth;
		Vector3 paddlePos = new Vector3(mousePosInUnits, transform.position.y);
		transform.position = paddlePos;
	}
}
