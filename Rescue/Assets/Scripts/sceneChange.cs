﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.Q)) {
			SceneManager.LoadScene(1);
		}*/
	}

	private void OnTriggerEnter(Collider _col){
		Debug.Log (_col.name);

		if(_col.name == "playerbody"){
			SceneManager.LoadScene(3);
		}
	}
}
