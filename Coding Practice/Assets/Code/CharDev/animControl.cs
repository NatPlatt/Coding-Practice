using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
	private Animator myAnimator;
	private bool jumpBool;
	void Start ()
	{
		myAnimator = GetComponent<Animator>();
		jumpBool = false;
	}
	
	
	void Update () 
	{
		if (Input.GetKeyDown("space"))
		{
			jumpBool = true;
		}
		else
		{
			jumpBool = false;
		}

		if (jumpBool == false)
		{
			myAnimator.SetBool("jumpBool", false);
		}

		if (jumpBool == true)
		{
			myAnimator.SetBool("jumpBool", true);
		}
	}
}
