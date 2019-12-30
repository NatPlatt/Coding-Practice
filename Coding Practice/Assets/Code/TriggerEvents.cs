using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
	public float hitNum;
	
	private void OnTriggerEnter(Collider other)
	{
		hitNum -= 1;
	}
}
