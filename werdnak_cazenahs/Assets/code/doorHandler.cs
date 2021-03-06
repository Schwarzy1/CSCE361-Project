﻿using UnityEngine;
using System.Collections;

public class doorHandler : MonoBehaviour {
	public int doorSide;
	public bool open = true;
	public bool isBossDoor = false;
	GameObject keyUI;
	Animator animator;
	roomHandler roomHand;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		roomHand = GameObject.Find("roomHandler").GetComponent<roomHandler>();
		doorSide = (int) transform.eulerAngles.z;
		animator.SetBool ("Open", open);
		keyUI = GameObject.Find("keyUI");
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "Caz" || other.gameObject.name == "Werd"){
			if (isBossDoor == true && keyUI.transform.position.x == 5 && open == false) {
				OpenDoor();
				keyUI.transform.position = new Vector3(100,100,100);
			}
			if (open == true) {
				if(doorSide == 0){
					roomHand.MoveLeft();
				}else if(doorSide == 90){
					roomHand.MoveUp();
				}else if(doorSide < 190&& doorSide>170){
					roomHand.MoveRight();
				}else if(doorSide == 270){
					roomHand.MoveDown();
				}
			}
		}
	}

	public void OpenDoor(){
		open = true;
		animator.SetBool ("Open", open);
	}
	public void CloseDoor(){
		open = false;
		animator.SetBool ("Open", open);
	}

}
