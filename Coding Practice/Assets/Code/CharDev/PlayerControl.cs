using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{

	public Rigidbody rBody;
	public float moveSpeed = 1f;
	void Start () {
		
	}
	
	
	void Update () {
		rBody.velocity = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")) * moveSpeed;
	}
}
