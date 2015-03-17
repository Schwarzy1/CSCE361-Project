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
	bool isOne=false;
	 public doorHandler doorhand;
	Animator animator;
	// Use this for initialization
	public void Start () {
		STARTX = transform.position.x;
		STARTY = transform.position.y;
		animator = GetComponent<Animator>();
		if(this.name==("blob 1")){
			this.
			isOne=true;
		}

	}
		public void OnDestroy(){
	
		if (isOne) {
			doorhand.OpenDoor ();

		}
	}
	
	
	// Update is called once per frame
	void FixedUpdate () {
		x = transform.position.x;
		y = transform.position.y;

		if (s <= 0) {
			r = Random.value;
		}
		if (s <= 0) {
			s = Random.value * 100;
		}

		animator.SetFloat("Speed", 0);
		if(r > .20 && r < .4 && y < STARTY + radius){
			transform.Translate(0,speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(r >= .4 && r < .6 && y > STARTY - radius){
			transform.Translate(0,(-1)*speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(r >= .6 && r < .8 && x > STARTX - radius){
			transform.localScale = (new Vector3(1,1,1));
			transform.Translate((-1)*speed,0,0);
			animator.SetFloat("Speed", 1);
		}
		if(r >= .8 && x < STARTX + radius){
			transform.localScale = (new Vector3(-1,1,1));
			transform.Translate(speed,0,0);
			animator.SetFloat("Speed", 1);
		}

		s--;
		//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);

	}

	

}
