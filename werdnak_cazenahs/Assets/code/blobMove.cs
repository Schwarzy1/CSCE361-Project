using UnityEngine;
using System.Collections;

public class blobMove : MonoBehaviour {
	float speed = .01f;
	float r = 0; //used to determine a random direction choice
	float s = 0; //used to determine how many times the object will move in the random direction, this is also random
	float x;
	float y;
	float radius = 1;
	float STARTX;
	float STARTY;
	public bool hasDoor=false;

	bool adjacent = false;
	 public doorHandler doorhand;
	Animator animator;



	float cazPosX;
	float cazPosY;
	float cazDist;
	float werdPosX;
	float werdPosY;
	float werdDist;
	float posX;
	float posY;


	GameObject caz;
	GameObject werd;

	// Use this for initialization
	public void Start () {
		STARTX = transform.position.x;
		STARTY = transform.position.y;
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
		animator = GetComponent<Animator>();


	}
		public void OnDestroy(){
	
		if (hasDoor) {
			doorhand.OpenDoor ();

		}

	}
	
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!PauseUIManager.paused) {
			if (adjacent == false) {
				Move ();
			} else {
				AdjacentMove ();
			}
			//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name.Equals ("Caz") | other.gameObject.name.Equals ("Werd") ){
			adjacent = true;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.name.Equals ("Caz") | other.gameObject.name.Equals ("Werd") ){
			adjacent = false;
		}
	}

	void Move(){

		x = transform.position.x;
		y = transform.position.y;
		
		if (s <= 0) {
			r = Random.value;
		}
		if (s <= 0) {
			s = Random.value * 100;
		}
		
		animator.SetFloat ("Speed", 0);
		if (r > .20 && r < .4 && y < STARTY + radius) {
			transform.Translate (0, speed, 0);
			animator.SetFloat ("Speed", 1);
		}
		if (r >= .4 && r < .6 && y > STARTY - radius) {
			transform.Translate (0, (-1) * speed, 0);
			animator.SetFloat ("Speed", 1);
		}
		if (r >= .6 && r < .8 && x > STARTX - radius) {
			transform.localScale = (new Vector3 (1, 1, 1));
			transform.Translate ((-1) * speed, 0, 0);
			animator.SetFloat ("Speed", 1);
		}
		if (r >= .8 && x < STARTX + radius) {
			transform.localScale = (new Vector3 (-1, 1, 1));
			transform.Translate (speed, 0, 0);
			animator.SetFloat ("Speed", 1);
		}
		
		
		s--;
	}

	void AdjacentMove(){

		x = transform.position.x;
		y = transform.position.y;
		cazPosX = caz.transform.position.x;
		cazPosY = caz.transform.position.y;
		cazDist = Vector3.Distance (transform.position, caz.transform.position);
		werdPosX = werd.transform.position.x;
		werdPosY = werd.transform.position.y;
		werdDist = Vector3.Distance (transform.position, werd.transform.position);
		posX = transform.position.x;
		posY = transform.position.y;

		if (cazDist < werdDist) {
			if (cazPosY > posY) {
				transform.Translate (0, speed, 0);
				animator.SetFloat("Speed", 1);
			}
			if (cazPosY < posY) {
				transform.Translate (0, (-1) * speed, 0);
				animator.SetFloat("Speed", 1);
			}
			if (cazPosX < posX) {
				transform.localScale = (new Vector3 (1, 1, 1));
				transform.Translate ((-1) * speed, 0, 0);
				animator.SetFloat("Speed", 1);
			}
			if (cazPosX > posX) {
				transform.localScale = (new Vector3 (-1, 1, 1));
				transform.Translate (speed, 0, 0);
				animator.SetFloat("Speed", 1);
			}
		}
		if (cazDist > werdDist) {
			if (werdPosY > posY) {
				transform.Translate (0, speed, 0);
				animator.SetFloat("Speed", 1);
			}
			if (werdPosY < posY) {
				transform.Translate (0, (-1) * speed, 0);
				animator.SetFloat("Speed", 1);
			}
			if (werdPosX < posX) {
				transform.localScale = (new Vector3 (1, 1, 1));
				transform.Translate ((-1) * speed, 0, 0);
				animator.SetFloat("Speed", 1);
			}
			if (werdPosX > posX) {
				transform.localScale = (new Vector3 (-1, 1, 1));
				transform.Translate (speed, 0, 0);
				animator.SetFloat("Speed", 1);
			}
		}
	}

}
