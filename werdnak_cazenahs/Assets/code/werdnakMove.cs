using UnityEngine;
using System.Collections;

public class werdnakMove : MonoBehaviour {
	float speed = .08f;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		animator.SetFloat("Speed", 0);
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0,speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0,(-1)*speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate((-1)*speed,0,0);
			transform.localScale = (new Vector3(-1,1,1));
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(speed,0,0);
			transform.localScale = (new Vector3(1,1,1));
			animator.SetFloat("Speed", 1);
		}
		animator.SetBool("Attacking", false);
		if(Input.GetKeyDown(KeyCode.Space)){
			animator.SetBool("Attacking", true);
		}
	}
}
