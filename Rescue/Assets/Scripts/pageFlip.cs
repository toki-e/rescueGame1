using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]

public class pageFlip : MonoBehaviour {

	//all visual novel sprites

	public Sprite end1;
	public Sprite end2;
	public Sprite end3;
	public Sprite end4;
	public Sprite end5;
	public Sprite end6;
	public Sprite end7;
	public Sprite end8;
	public Sprite end9;
	public Sprite end10;
	public Sprite end11;
	public Sprite end12;
	public Sprite end13;
	public Sprite end14;
	public Sprite end15;
	public Sprite end16;

	//var to keep page number
	public float pageNum = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//add to page number when space is pressed
		if (Input.GetKeyDown (KeyCode.Space)) {
			pageNum++;
		}

		if (pageNum == 1) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end1){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end2;

			}
		}

		if (pageNum == 2) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end2){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end3;
			}
		}

		if (pageNum == 3) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end3){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end4;
			}

		}

		if (pageNum == 4) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end4){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end5;
			}

		}

		if (pageNum == 5) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end5){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end6;
			}

		}

		if (pageNum == 6) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end6){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end7;
			}

		}

		if (pageNum == 7) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end7){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end8;
			}

		}

		if (pageNum == 8) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end8){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end9;
			}

		}

		if (pageNum == 9) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end9){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end10;
			}

		}

		if (pageNum == 10) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end10){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end11;
			}

		}

		if (pageNum == 11) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end11){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end12;
			}

		}

		if (pageNum == 12) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end12){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end13;
			}

		}

		if (pageNum == 13) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end13){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end14;
			}

		}

		if (pageNum == 14) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end14){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end15;
			}

		}

		if (pageNum == 15) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == end15){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = end16;
			}

		}

		if (pageNum >= 15 && Input.GetKeyDown (KeyCode.Q)) {
			SceneManager.LoadScene (2); //load main game

		}

		if (pageNum >= 15 && Input.GetKeyDown (KeyCode.E)) {
			SceneManager.LoadScene (0); //load map
		}
			
	}
}
