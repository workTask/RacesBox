using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody rb;


	void Start () {
		Debug.Log("Start Player ");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	     //rb.AddForce(0,0,200);
		 MovePlayer();
	}

	void MovePlayer()
	{
		if(Input.GetKey("up")){
			transform.Translate(0,0,0.1f);
		}
		if(Input.GetKey("down")){
			transform.Translate(0,0,-0.1f);
		}
		if(Input.GetKey("right")){
			transform.Translate(0.1f,0,0);
		}
		if(Input.GetKey("left")){
			transform.Translate(-0.1f,0,0);
		}
	}
}
