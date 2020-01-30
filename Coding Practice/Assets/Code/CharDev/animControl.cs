using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
	private Animator myAnimator;
	private bool jumpBool;
	private bool runBool;
	private bool spellBool;
	
	void Start ()
	{
		myAnimator = GetComponent<Animator>();
		jumpBool = false;
		runBool = false;
		spellBool = false;
	}
	
	
	void Update () 
	{
		Jump();
		Run();
		CastSpell();
	}

	void Jump()
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

	void Run()
	{
		if (Input.GetKeyDown("1"))
		{
			runBool = true;
		}
		else
		{
			runBool = false;
		}


		if (runBool == false)
		{
			myAnimator.SetBool("runBool", false);
		}

		if (runBool == true)
		{
			myAnimator.SetBool("runBool", true);
		}
	}

	void CastSpell()
	{
		if (Input.GetKeyDown("2"))
		{
			spellBool = true;
		}
		else
		{
			spellBool = false;
		}

		if (spellBool == false)
		{
			myAnimator.SetBool("spellBool", false);
		}

		if (spellBool == true)
		{
			myAnimator.SetBool("spellBool", true);
		}
	}
}
