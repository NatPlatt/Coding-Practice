using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	[SerializeField] private float minX = -5.5f;
	[SerializeField] private float maxX = 5.5f;
	[SerializeField] private float screenWidth;
	
	void Update () {
		float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidth;
		Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
		paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
		transform.position = paddlePos;
	}
}
