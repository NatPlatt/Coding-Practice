﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{

	public Rigidbody rBody;
	void Start () {
		
	}
	
	
	void Update () {
		rBody.velocity = new Vector3(1,1,0);
	}
}
