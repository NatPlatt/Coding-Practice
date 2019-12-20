﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	[SerializeField] Text textComponent;
	[SerializeField] private States startingState;
	
	
	private States state;
	void Start ()
	{
		state = startingState;
		textComponent.text = state.GetStateStory();
	}
	
	void Update ()
	{
		ManageState();
	}

	private void ManageState()
	{
		var nextStates = state.GetNextStates(); //Get next states in States scriptable object
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			state = nextStates[0];
		}
	}
}
