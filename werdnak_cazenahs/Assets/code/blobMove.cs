using UnityEngine;
using System.Collections;

public class blobMove : MonoBehaviour {
	float speed = .01f;
	float r = 0;
	float s = 0;
	float x;
	float y;
	int i;
	float STARTX;
	float STARTY;
	Animator animator;
	// Use this for initialization
	public void Start () {
		STARTX = transform.position.x;
		STARTY = transform.position.y;
		animator = GetComponent<Animator>();
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
		if(r > .20 && r < .4 && y < STARTY + 1){
			transform.Translate(0,speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(r >= .4 && r < .6 && y > STARTY - 1){
			transform.Translate(0,(-1)*speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(r >= .6 && r < .8 && x > STARTX - 1){
			transform.localScale = (new Vector3(1,1,1));
			transform.Translate((-1)*speed,0,0);
			animator.SetFloat("Speed", 1);
		}
		if(r >= .8 && x < STARTX + 1){
			transform.localScale = (new Vector3(-1,1,1));
			transform.Translate(speed,0,0);
			animator.SetFloat("Speed", 1);
		}

		s--;
		//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
	}
	

}
