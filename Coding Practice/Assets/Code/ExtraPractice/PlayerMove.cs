using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float turnSpeed = 20f;
	private Animator animator; 
	private Vector3 movement;
	
	void Start ()
	{
		animator = GetComponent<Animator>();
	}
	
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		movement.Set(horizontal, 0f, vertical);
		movement.Normalize();

		bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
		bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
		bool isWalking = hasHorizontalInput || hasVerticalInput;
		
		animator.SetBool("IsWalking", isWalking);

		Vector3 desiredForward = Vector3.RotateTowards(transform.forward, movement
			, turnSpeed * Time.deltaTime, 0f);
		//RotateTowards is a static method from the Vector3 class which takes 4 params:
		//the vectors being rotated from and towards
	}
}
