using UnityEngine;
using System.Collections;

public class keyHandler : MonoBehaviour {

	GameObject keyUI;
	// Use this for initialization
	void Start () {
		keyUI = GameObject.Find("keyUI");
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name.Equals ("Caz") ){
			if(keyUI.transform.position.x == 100){
				keyUI.transform.position = new Vector3(5,-3.2f,-1);
				Destroy (gameObject);
			}
		}
		if(other.gameObject.name.Equals ("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == false) {
			if(keyUI.transform.position.x == 100){
				keyUI.transform.position = new Vector3(5,-3.2f,-1);
				Destroy (gameObject);
			}
		}

	}

}
