using UnityEngine;
using System.Collections;

public class damageHandler : MonoBehaviour {
	heartsHandler hh;
	public int damage = 1;
	// Use this for initialization
	void Start () {
		hh = GameObject.Find("hearts").GetComponent<heartsHandler>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name.Equals ("Caz") ){
			hh.TakeDamage(damage);
		}
		if(other.gameObject.name.Equals ("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == false) {
			hh.TakeDamage(damage);
		}
	}
}
