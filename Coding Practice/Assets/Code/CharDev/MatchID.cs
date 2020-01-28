using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MatchId : MonoBehaviour
{

	[FormerlySerializedAs("nameIDObj")] public NameId nameIdObj; //moved to DoWork script
	[FormerlySerializedAs("IDList")] public List<NameId> idList;

	public void OnTriggerEnter(Collider other)
	{
		
		var doWorkObj = other.GetComponent<DoWork>();
		var otherNameId = doWorkObj.nameIdObj;

		if (nameIdObj == null) return;
		
		
		foreach (var id in idList)
		{
			if (nameIdObj == otherNameId) //my version
			{
				idList.Add(new NameId(nameIdObj));
			}

			if (nameIdObj == otherNameId) //anthonys version
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
