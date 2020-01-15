using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{

	public NameID nameIDObj;

	public void OnTriggerEnter(Collider other)
	{
		var otherNameId = other.GetComponent<MatchID>().nameIDObj;
		
	}
}
