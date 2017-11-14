using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainCharacter : MonoBehaviour {

	Animator characterAnimator;
	Rigidbody rb;
	SpriteRenderer sr; 

	/*public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround; */

	public bool grounded = true;

	Vector3 beforeJumpPos;

	[SerializeField]

	float moveSpeed = 20f;

	Vector3 forward, right;

	// Use this for initialization
	void Start () {
		
		characterAnimator = GetComponentInChildren<Animator> ();
		rb = GetComponent<Rigidbody> ();
		sr = GetComponentInChildren<SpriteRenderer> ();

		forward = Camera.main.transform.forward;
		forward.y = 0;
		forward = Vector3.Normalize(forward);
		right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey) {
			Move ();
		} else { 
			characterAnimator.SetBool ("isRunning", false);
		}
			
		//test jumping anim
		/*if (Input.GetKeyDown (KeyCode.Space)) {
			characterAnimator.SetBool ("isJumping", true);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			characterAnimator.SetBool ("isJumping", false);
		}*/

		if (rb.velocity.y == 0f) {
			grounded = true;
		}

		if (grounded == true) {

			//try to get him to jump by resetting his pos back to starting pos when key is up???
			if (Input.GetKeyDown (KeyCode.Space)) {
				characterAnimator.SetBool ("isJumping", true);
				characterAnimator.SetBool ("isRunning", false);
				rb.velocity = new Vector3 (0, 7.5f, 0);
				grounded = false;
				//beforeJumpPos = transform.position;
				//characterAnimator.SetBool ("isRunning", false);
			}
				
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			characterAnimator.SetBool ("isJumping", false);
			//rb.velocity = new Vector3 (0, -10f, 0);
			//transform.position = beforeJumpPos;
			//characterAnimator.SetBool ("isRunning", false);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			sr.flipX = true;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			sr.flipX = false;
		}
		/*
		//handle Em's running velocity and animations
		if (Input.GetKeyDown (KeyCode.D)) {
			rb.velocity = new Vector3 (4f, 0, 0);
			characterAnimator.SetBool ("isRunning", true);
			sr.flipX = false;
		}

		else if (Input.GetKeyUp (KeyCode.D)) {
			rb.velocity = new Vector3 (0, 0, 0);
			characterAnimator.SetBool ("isRunning", false);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			rb.velocity = new Vector3 (-4f, 0, 0);
			characterAnimator.SetBool ("isRunning", true);
			sr.flipX = true;

		} else if (Input.GetKeyUp (KeyCode.A)) {
			rb.velocity = new Vector3 (0, 0, 0);
			characterAnimator.SetBool ("isRunning", false);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			rb.velocity = new Vector3 (0, 4f, 0);
			characterAnimator.SetBool ("isRunning", true);
		}

		else if (Input.GetKeyUp (KeyCode.W)) {
			rb.velocity = new Vector3 (0, 0, 0);
			characterAnimator.SetBool ("isRunning", false);
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			rb.velocity = new Vector3 (0, -4f, 0);
			characterAnimator.SetBool ("isRunning", true);

		} else if (Input.GetKeyUp (KeyCode.S)) {
			rb.velocity = new Vector3 (0, 0, 0);
			characterAnimator.SetBool ("isRunning", false);
		}*/
	}

	void Move()
	{
		Vector3 direction = new Vector3(Input.GetAxis ("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
		Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis ("HorizontalKey"); //smoothermovement
		Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey"); //handle up and down movement

		Vector3 heading = Vector3.Normalize(rightMovement + upMovement); //creating a direction our character can point to when moving around

		//transform.forward = heading; //telling the forward vector to equal heading which is diagonal - makes the rotation happen
		transform.position += rightMovement;
		transform.position += upMovement; //make the movement happen

		characterAnimator.SetBool ("isRunning", true); //change anim to running
	} 
}
