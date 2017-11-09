﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

	[SerializeField]

	float moveSpeed = 4f;

	Vector3 forward, right;

	// Use this for initialization
	void Start () {
		
		forward = Camera.main.transform.forward;
		forward.y = 0;
		forward = Vector3.Normalize(forward);
		right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey)
			Move ();
	}

	void Move()
	{
		Vector3 direction = new Vector3(Input.GetAxis ("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
		Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis ("HorizontalKey"); //smoothermovement
		Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey"); //handle up and down movement

		Vector3 heading = Vector3.Normalize(rightMovement + upMovement); //creating a direction our character can point to when moving around

		transform.forward = heading; //telling the forward vector to equal heading which is diagonal - makes the rotation happen
		transform.position += rightMovement;
		transform.position += upMovement; //make the movement happen
	}

}
