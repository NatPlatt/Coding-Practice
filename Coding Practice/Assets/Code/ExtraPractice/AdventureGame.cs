using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	[SerializeField] Text textComponent;
	[SerializeField] private States startingState;
	
	
	private States _state;
	void Start ()
	{
		_state = startingState;
		textComponent.text = _state.GetStateStory();
	}
	
	void Update ()
	{
		ManageState();
	}

	private void ManageState()
	{
		var nextStates = _state.GetNextStates(); //Get next states in States scriptable object
		for (int index = 0; index < nextStates.Length; index++)
		{
			if (Input.GetKeyDown(KeyCode.Alpha1 + index))
			{
				_state = nextStates[index];
			}
		}
		
		/*if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			state = nextStates[0];
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			state = nextStates[1];
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			state = nextStates[2];
		}*/

		textComponent.text = _state.GetStateStory();
	}
}
