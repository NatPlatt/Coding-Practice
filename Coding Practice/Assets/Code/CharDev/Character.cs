using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
	private CharacterController _controller;
	public Animator animator;
	public Animation animation;
	public float charHeight;
	public float charWidth;

	void Start()
	{
		_controller = GetComponent<CharacterController>();
		_controller.center = new Vector3(0, (float) 0.4,0);
		_controller.height = charHeight;
		_controller.radius = charWidth;
	}

	void Play()
	{
		
	}
}
	
	
