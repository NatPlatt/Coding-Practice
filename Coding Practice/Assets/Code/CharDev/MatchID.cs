using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{

	public NameID nameIDObj;
	public List<NameID> IDList;

	public void OnTriggerEnter(Collider other)
	{
		var otherNameId = other.GetComponent<MatchID>().nameIDObj;
		if (nameIDObj == otherNameId)
		{
			//do something
		}

		if (nameIDObj == null) return;

		foreach (var ID in IDList)
		{
			IDList.Add(new NameID(nameIDObj));
		}

		foreach (NameID nameid in IDList)
		{
			print(nameid.name + " " + nameid.ToString();
		}
		
		/*otherNameId = nameIDObj;

		if (nameIDObj == otherNameId)
		{
			//do something
		}*/
	}
}
