using UnityEngine;
using System.Collections;

public class damageHandler : MonoBehaviour {
	heartsHandler hh;
	public int damage = 1;
	public float coolDown;
	// Use this for initialization
	void Start () {
		hh = GameObject.Find("hearts").GetComponent<heartsHandler>();
		coolDown = 0;
	}
	
	// Update is called once per frame
	void Update () {
		coolDown--;
	}

	void OnCollisionStay2D(Collision2D other){
		if (coolDown <= 0) {
			if (other.gameObject.name.Equals ("Caz")) {
				hh.TakeDamage (damage);
			}
			if (other.gameObject.name.Equals ("Werd") && other.gameObject.GetComponent<werdnakMove> ().attacking == false) {
				hh.TakeDamage (damage);
			}
			coolDown = 60;
		} 
	}
	void OnCollisionExit2D(Collision2D other){
		coolDown = 0;
	}

}
