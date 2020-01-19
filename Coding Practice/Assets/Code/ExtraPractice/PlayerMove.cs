using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private Vector3 movement;
	
	void Start () 
	{
		
	}
	
	
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		movement.Set(horizontal, 0f, vertical);
		movement.Normalize();
	}
}
