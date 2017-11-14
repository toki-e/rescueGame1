using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

	public GameObject playerbody;
	public bool pressed = false;
	// Use this for initialization
	void Start () {
		playerbody = GameObject.Find ("playerbody");
	}
	
	// Update is called once per frame
	void Update () {
		if(pressed == true){

			transform.Rotate(3, 3, 3);

			if (Input.GetKeyUp (KeyCode.Q)) {
				playerbody.transform.position = this.gameObject.transform.position;
			}
		}
			
	}
		
	private void OnTriggerEnter(Collider _col){
		
		if (_col.name == "playerbody") {
			pressed = true;
		}
	}
}
