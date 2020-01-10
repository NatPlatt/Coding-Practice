using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
	private CharacterController controller;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		controller.center = new Vector3((float) -0.25, 1,1);
	}
}
	
	
