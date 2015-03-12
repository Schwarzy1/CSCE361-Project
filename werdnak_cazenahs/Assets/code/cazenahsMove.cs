using UnityEngine;
using System.Collections;

public class cazenahsMove : MonoBehaviour {
	float speed = .1f;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		animator.SetFloat("Speed", 0);
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0,speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0,(-1)*speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate((-1)*speed,0,0);
			transform.localScale = (new Vector3(-1,1,1));
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(speed,0,0);
			transform.localScale = (new Vector3(1,1,1));
			animator.SetFloat("Speed", 1);
		}
		//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
	}
}