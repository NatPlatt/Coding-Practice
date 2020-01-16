using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{

	public NameID nameIDObj; //moved to DoWork script
	public List<NameID> IDList;

	public void OnTriggerEnter(Collider other)
	{
		
		var doWorkObj = other.GetComponent<DoWork>();
		var otherNameId = doWorkObj.nameIdObj;

		if (nameIDObj == null) return;
		
		
		foreach (var ID in IDList)
		{
			if (nameIDObj == otherNameId) //my version
			{
				IDList.Add(new NameID(nameIDObj));
			}

			if (nameIDObj == otherNameId) //anthonys version
			{
					doWorkObj.Work();
			} 
		}

		//moved to DoWork script
		/*foreach (NameID nameid in IDList)
		{
			print(nameid.name + " " + nameid);
		}*/
		
		/*otherNameId = nameIDObj;

		if (nameIDObj == otherNameId)
		{
			//do something
		}*/
	}
}
