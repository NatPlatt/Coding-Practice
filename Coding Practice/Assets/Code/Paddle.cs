using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	[SerializeField] private float minX = 1f;
	[SerializeField] private float maxX = 15f;
	[SerializeField] private float screenWidth;
	
	void Update () {
		float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidth;
		Vector3 paddlePos = new Vector3(mousePosInUnits, transform.position.y);
		paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
		transform.position = paddlePos;
	}
}
