using UnityEngine;
using System.Collections;

public class blobMove : MonoBehaviour {
	float speed = .01f;
	float r = 0;
	float s = 0;
	int i;
	//Animator animator;
	// Use this for initialization
	void Start () {
		//animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x = transform.position.x;
		float y = transform.position.y;
		if (s <= 0) {
			r = Random.value;
		}
		if (s <= 0) {
			s = Random.value * 100;
		}
		//animator.SetFloat("Speed", 0);
		if(r <= .25 && y < 0){
			transform.Translate(0,speed,0);

			//animator.SetFloat("Speed", 1);
		}
		if(r > .25 && r < .5 && y > -2){
			transform.Translate(0,(-1)*speed,0);

			//animator.SetFloat("Speed", 1);
		}
		if(r >= .5 && r < .75 && x > -4){
			transform.localScale = (new Vector3(-1,1,1));
			transform.Translate((-1)*speed,0,0);

			//animator.SetFloat("Speed", 1);
		}
		if(r >= .75 && x < -2){
			transform.localScale = (new Vector3(1,1,1));
			transform.Translate(speed,0,0);

			//animator.SetFloat("Speed", 1);
		}
		s--;


		//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
	}
}
