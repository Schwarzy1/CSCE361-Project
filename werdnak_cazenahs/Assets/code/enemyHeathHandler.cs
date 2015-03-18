﻿using UnityEngine;
using System.Collections;

public class enemyHeathHandler : MonoBehaviour {

	public int health = 3;
	public bool isBoss=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.name.Equals("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == true){
			TakeDamage(2);
		}
	}

	public void TakeDamage(int damage){
		print ("HIT!");
		health -= damage;
		if(health <= 0){
			Destroy(gameObject);
			if(isBoss){
				int wait=1000;
				while(wait>0){
					wait--;
				}
				Application.LoadLevel("LevelOneComplete");
			}
		}
	}

}
