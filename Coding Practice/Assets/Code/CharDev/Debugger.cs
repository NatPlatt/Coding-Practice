using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Debugger : ScriptableObject {
//NEED TO MAKE THESE SEPARATE CLASSES
	public void OnDebug(string message)
	{
		Debug.Log("");
	}
}

[CreateAssetMenu]

public class GameAction : ScriptableObject
{
	public UnityAction action;

	public void Raise()
	{
		if (action != null) action.Invoke();
	}
}

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
	public float value = 1f;
}