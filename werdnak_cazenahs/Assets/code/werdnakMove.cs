using UnityEngine;
using System.Collections;

public class werdnakMove : MonoBehaviour {
	float speed = .08f;
	Animator animator;
	public bool powerup = true;
	public bool attacking = false;
	public int attackCoolDown;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

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
		if(Input.GetKeyDown(KeyCode.Space)){
			//speed = .12f;
			Physics2D.IgnoreLayerCollision(8,9,true);
			attacking = true;
			animator.SetBool("Attacking", true);
			attackCoolDown = 20;
		}
		if (attackCoolDown < 0) {
			//speed = 0.08f;
			animator.SetBool ("Attacking", false);
			attacking = false;
			Physics2D.IgnoreLayerCollision (8, 9, false);
		} else {
			attackCoolDown--;
		}
	}
}