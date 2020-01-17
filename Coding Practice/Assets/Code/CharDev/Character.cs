using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
	private CharacterController controller;
	public Animator animator;
	public Animation animation;
	public float charHeight;
	public float charWidth;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		controller.center = new Vector3(0, (float) 0.4,0);
		controller.height = charHeight;
		controller.radius = charWidth;
	}

	void Play()
	{
		
	}
}
	
	
