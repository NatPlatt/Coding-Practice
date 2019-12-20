using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	[SerializeField] Text textComponent;
	
	void Start ()
	{
		textComponent.text = ("This is the game where you choose your own adventure. P.S. I added this text" +
		                      "programmatically!");
	}
	
	void Update () {
		
	}
}
