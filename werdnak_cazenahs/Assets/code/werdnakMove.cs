using UnityEngine;
using System.Collections;

public class werdnakMove : MonoBehaviour {
	float speed = .1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0,speed,0);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0,(-1)*speed,0);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate((-1)*speed,0,0);
			transform.localScale = (new Vector3(-1,1,1));
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(speed,0,0);
			transform.localScale = (new Vector3(1,1,1));
		}
	}
}
