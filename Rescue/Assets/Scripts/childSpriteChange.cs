using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

[ExecuteInEditMode]

public class childSpriteChange : MonoBehaviour {

	public Sprite childCautious;
	public Sprite childStartled;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == childCautious){
				
		   	   this.gameObject.GetComponent<SpriteRenderer>().sprite = childStartled;
	     	
			}
	     }
     }
}
