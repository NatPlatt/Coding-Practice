using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharController : MonoBehaviour
{
	private CharacterController charController;
	
	public float speed = 5.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20f;
	
	private Vector3 moveDirection = Vector3.zero;
	
	void Start ()
	{
		charController = GetComponent<CharacterController>();
	}
	
	
	void Update () {
		
	}

	private void MoveIt()
	{
		if (charController.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
		}
	}
}
