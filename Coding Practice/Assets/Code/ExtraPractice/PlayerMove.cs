using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
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
	}
}
