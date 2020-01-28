using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float turnSpeed = 20f;
	private Animator _animator;
	private Rigidbody _myRigidbody;
	private Vector3 _movement;
	Quaternion _myRotation = Quaternion.identity; //giving it a value of no rotation instead of a 0 vector
	
	void Start ()
	{
		_animator = GetComponent<Animator>();
		_myRigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () //fixedUpdate runs physics operations, so in this case it makes more sense to use instead of update
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		_movement.Set(horizontal, 0f, vertical);
		_movement.Normalize();

		bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
		bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
		bool isWalking = hasHorizontalInput || hasVerticalInput;
		
		_animator.SetBool("IsWalking", isWalking);

		Vector3 desiredForward = Vector3.RotateTowards(transform.forward, _movement
			, turnSpeed * Time.deltaTime, 0f);
		//RotateTowards is a static method from the Vector3 class which takes 4 params:
		//the vectors being rotated from and towards

		_myRotation = Quaternion.LookRotation(desiredForward);
	}

	private void OnAnimatorMove()
	{
		_myRigidbody.MovePosition(_myRigidbody.position + _movement * _animator.deltaPosition.magnitude);
		//deltaPosition is the change in position due to root motion, magnitude is the length
		
		_myRigidbody.MoveRotation(_myRotation); //setting the rotation
	}
}
