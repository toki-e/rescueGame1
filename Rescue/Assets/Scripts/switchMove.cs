using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMove : MonoBehaviour {

	public GameObject playerbody;
	public GameObject cageFront;
	public GameObject cageBack;
	public GameObject cageLeft;
	public GameObject cageRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (1f, 1f, 1f);
	}

	private void OnTriggerEnter(Collider _col){
		
		if (_col.name == "playerbody") {
			Debug.Log ("collide");
			cageFront.GetComponent<Rigidbody> ().AddForce (new Vector3(0, 400, -400));
			cageBack.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 400, 400));
			cageLeft.GetComponent<Rigidbody> ().AddForce (new Vector3 (-400, 400, 0));
			cageRight.GetComponent<Rigidbody> ().AddForce (new Vector3 (400, 400, 0));
		}
	}

}
