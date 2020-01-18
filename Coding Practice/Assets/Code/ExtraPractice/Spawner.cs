using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Spawner : MonoBehaviour
{

	public GameObject spawnObj;
	private int angle = 15;
	public int num = 1;

	private void Start()
	{
		//private Vector3 spawnPosition = transform.position;
		if (num <= 5)
		{
			num = num + 1;
			
		}
		Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
		var spawnPosition = transform.position + direction * 2;
		Instantiate(spawnObj, spawnPosition, Quaternion.identity);
	}
}
