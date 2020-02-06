using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{

	public Rigidbody rBody;
	public float moveSpeed = 1f;
	void Start () {
		
	}
	
	
	void Update () {
		ControlThePlayer();
		//rBody.velocity = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")) * moveSpeed;
	}

	void ControlThePlayer()
	{
		float verticalMove = Input.GetAxisRaw("Vertical");
		float horizontalMove = Input.GetAxisRaw("Horizontal");
		
		Vector3 move = new Vector3(horizontalMove, 0,verticalMove);
		transform.rotation = Quaternion.LookRotation(move);
		
		transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
	}
}
