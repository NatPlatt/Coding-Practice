using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHit : MonoBehaviour
{
	public float hitNum;
	public GameObject block;
	public Color blockActive;
	private void OnTriggerEnter(Collider other)
	{
		hitNum -= 1;
		blockActive = Color.black;
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
