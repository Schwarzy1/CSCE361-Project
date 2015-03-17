using UnityEngine;
using System.Collections;

public class keyHandler : MonoBehaviour {

	GameObject keyUI;
	// Use this for initialization
	void Start () {
		keyUI = GameObject.Find("keyUI");
	}

	void OnCollisionEnter2D(Collision2D other){
		if(keyUI.activeSelf == false){
			keyUI.SetActive(true);
			Destroy (gameObject);
		}
	}

}
