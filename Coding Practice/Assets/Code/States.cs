using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class States : ScriptableObject
{

	[TextArea(10,14)][SerializeField] private string storyText;
	[SerializeField] private States[] nextStates;
	
	public string GetStateStory()
	{
		return storyText;
	}

	public States[] GetNextStates()
	{
		return nextStates;
	}
}
