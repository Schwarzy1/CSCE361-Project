﻿using UnityEngine;
using System.Collections;

public class werdnakMove : MonoBehaviour {
	float speed = .08f;
	Animator animator;
	int direction = 0;
	public bool powerup = false;
	public bool secondPower=false;
	public bool lockMove = false;
	public bool attacking = false;
	public int attackCoolDown = 0;
	keyBindHandler keyBindScript;
	// Use this for initialization
	void Start () {
		keyBindScript = GameObject.Find ("KeyBindHandler").GetComponent<keyBindHandler>();
		animator = GetComponent<Animator>();
		//alows sword to pass through objects marked as wall and pit
		Physics2D.IgnoreLayerCollision(10,9,true);
		Physics2D.IgnoreLayerCollision(10,12,true);
		Physics2D.IgnoreLayerCollision (10, 18, true);
		Physics2D.IgnoreLayerCollision (10, 14, true);
	}

	void FixedUpdate () {
		if (!PauseUIManager.paused) {
			if (lockMove == false) {
				if (powerup == true) {
					if(secondPower==true){
						DoublejumpAttack();

					}
					else{
					jumpAttack ();
					}
				} else {
					basicAttack ();
					move ();
				}
			}
			if (Input.GetKey (KeyCode.I)) {
				powerup = true;
			}
		}
	}

	void basicAttack(){
		if(Input.GetKeyDown(keyBindScript.werdAttack)){
			speed = .09f;
			attacking = true;
			animator.SetBool("Attacking", true);
			attackCoolDown = 20;
		}
		if (attackCoolDown <= 0) {
			speed = 0.08f;
			animator.SetBool ("Attacking", false);
			attacking = false;
		} else {
			attackCoolDown--;
		}
	}
	void DoublejumpAttack(){
		if(Input.GetKeyDown(keyBindScript.werdAttack) && attacking == false){
			speed = .15f;
			Physics2D.IgnoreLayerCollision(8,9,true);
			Physics2D.IgnoreLayerCollision(8,18,true);
			attacking = true;
			animator.SetBool("Attacking", true);
			attackCoolDown = 20;
		}
		if (attackCoolDown <= 0) {
			speed = 0.08f;
			animator.SetBool ("Attacking", false);
			attacking = false;
			Physics2D.IgnoreLayerCollision (8, 9, false);
			Physics2D.IgnoreLayerCollision (8, 18, false);
			move ();
			
		} else {
			attackCoolDown--;
		}
		if(attacking == true){
			if(direction == 1){
				transform.Translate(0,speed,0);
			}if(direction == 2){
				transform.Translate(0,(-1)*speed,0);
			}if(direction == 3){
				transform.Translate((-1)*speed,0,0);
			}if(direction == 4){
				transform.Translate(speed,0,0);
			}
		}
	}

	void jumpAttack(){
		if(Input.GetKeyDown(keyBindScript.werdAttack) && attacking == false){
			speed = .12f;
			Physics2D.IgnoreLayerCollision(8,9,true);
			attacking = true;
			animator.SetBool("Attacking", true);
			attackCoolDown = 20;
		}
		if (attackCoolDown <= 0) {
			speed = 0.08f;
			animator.SetBool ("Attacking", false);
			attacking = false;
			Physics2D.IgnoreLayerCollision (8, 9, false);
			move ();
			
		} else {
			attackCoolDown--;
		}
		if(attacking == true){
			if(direction == 1){
				transform.Translate(0,speed,0);
			}if(direction == 2){
				transform.Translate(0,(-1)*speed,0);
			}if(direction == 3){
				transform.Translate((-1)*speed,0,0);
			}if(direction == 4){
				transform.Translate(speed,0,0);
			}
		}
	}

	void move(){
		animator.SetFloat("Speed", 0);
		direction = 0;
		if(Input.GetKey(keyBindScript.werdUp)){
			transform.Translate(0,speed,0);
			animator.SetFloat("Speed", 1);
			direction = 1;
		}
		if(Input.GetKey(keyBindScript.werdDown)){
			transform.Translate(0,(-1)*speed,0);
			animator.SetFloat("Speed", 1);
			direction = 2;
		}
		if(Input.GetKey(keyBindScript.werdLeft)){
			transform.Translate((-1)*speed,0,0);
			transform.localScale = (new Vector3(-1,1,1));
			animator.SetFloat("Speed", 1);
			direction = 3;
		}
		if(Input.GetKey(keyBindScript.werdRight)){
			transform.Translate(speed,0,0);
			transform.localScale = (new Vector3(1,1,1));
			animator.SetFloat("Speed", 1);
			direction = 4;
		}

	}

}