using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]

public class pageScript : MonoBehaviour {

	public Sprite intro1;
	public Sprite intro2;
	public Sprite intro3;
	public Sprite intro4;
	public Sprite intro5;
	public Sprite intro6;
	public Sprite intro7;
	public Sprite intro8;
	public Sprite intro9;
	public Sprite intro10;
	public Sprite intro11;
	public Sprite intro12;

	/*public AudioClip EmLine;
	AudioSource audioSource;*/

	public float pageNum = 0;

	// Use this for initialization
	void Start () {
		//audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			pageNum++;
		}

		if (pageNum == 1) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro1){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro2;

				/*if (!audioSource.isPlaying) {
					audioSource.clip = EmLine;
					audioSource.Play ();
				} */
			}
		}

		if (pageNum == 2) {
			
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro2){
				
				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro3;
			}
		}

		if (pageNum == 3) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro3){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro4;
			}

		}

		if (pageNum == 4) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro4){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro5;
			}

		}

		if (pageNum == 5) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro5){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro6;
			}

		}

		if (pageNum == 6) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro6){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro7;
			}
		
		}

		if (pageNum == 7) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro7){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro8;
			}
		
		}

		if (pageNum == 8) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro8){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro9;
			}
		
		}

		if (pageNum == 9) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro9){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro10;
			}
		
		}

		if (pageNum == 10) {
		
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro10){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro11;
			}

		}

		if (pageNum == 11) {

			if(this.gameObject.GetComponent<SpriteRenderer>().sprite == intro11){

				this.gameObject.GetComponent<SpriteRenderer>().sprite = intro12;
			}

		}

		if (pageNum >= 12) {
			SceneManager.LoadScene (2);
		
		}

	}
}
