using UnityEngine;
using System.Collections;

public class keyHandler : MonoBehaviour {

	GameObject keyUI;
	// Use this for initialization
	void Start () {
		keyUI = GameObject.Find("keyUI");
	}

	void OnCollisionEnter2D(Collision2D other){
		if(keyUI.transform.position.x == 100){
			keyUI.transform.position = new Vector3(5,-3.2f,-1);
			Destroy (gameObject);
		}
	}

}
