using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
	public float hitNum;
	public GameObject block;
	private void OnTriggerEnter(Collider other)
	{
		hitNum -= 1;
	}

	private void TurnOff()
	{
		if (hitNum == 0)
		{
			block.gameObject.SetActive(false);
		}
	}

	private void Update()
	{
		TurnOff();
	}
}
