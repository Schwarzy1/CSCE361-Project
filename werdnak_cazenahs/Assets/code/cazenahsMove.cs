﻿using UnityEngine;
using System.Collections;

public class cazenahsMove : MonoBehaviour {
	float speed = .1f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0,speed,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0,(-1)*speed,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate((-1)*speed,0,0);
			transform.localScale = (new Vector3(-1,1,1));
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(speed,0,0);
			transform.localScale = (new Vector3(1,1,1));
		}
		//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
	}
}