using UnityEngine;
using System.Collections;

public class lazerMove : MonoBehaviour {
	GameObject caz;
	float cazY;
	float speed = .1f;
	float dist = 50;
	float i = 0;
	GameObject lazer;
	Vector3 loc;
	Quaternion quat = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		this.i = 0;
		caz = GameObject.Find ("Caz");
		cazY = caz.transform.localScale.x;
		Physics2D.IgnoreLayerCollision(13,9,true);
		//Physics2D.IgnoreLayerCollision(13,12,true);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (cazY * speed, 0, 0);
		if (i > dist) {
			loc = new Vector3(-100,-100, -1);
			lazer = GameObject.FindGameObjectWithTag("cazLazer");
			Instantiate(lazer, loc , quat);
			Destroy(gameObject);
		}
		i++;
	}
}
