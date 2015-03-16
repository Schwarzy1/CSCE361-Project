using UnityEngine;
using System.Collections;

public class heartsHandler : MonoBehaviour {

	int health = 6;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.X)){
			TakeDamage(1);
		}
	}

	void TakeDamage(int damage){
		health -= damage;
		if(health >= 6){
			health = 6;
		}else if(health <= 0){
			health = 0;
		}
		animator.SetInteger("health", health);
	}

}
