using UnityEngine;
using System.Collections;

public class lazerMove : MonoBehaviour {

	int direction;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(13,1,true);
		Physics2D.IgnoreLayerCollision(13,8,true);
		Physics2D.IgnoreLayerCollision(13,9,true);
		Physics2D.IgnoreLayerCollision(13,10,true);
		Physics2D.IgnoreLayerCollision(13,11,true);
		Physics2D.IgnoreLayerCollision(13,13,true);
		Physics2D.IgnoreLayerCollision(13,14,true);
		direction = GameObject.Find ("Caz").GetComponent<cazenahsMove> ().direction;
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == 1) {
			transform.Translate (0, 0.1f, 0);
		} else if (direction == 2) {
			transform.Translate (0, -0.1f, 0);
		} else if (direction == 3) {
			transform.Translate (-0.1f, 0, 0);
		} else if (direction == 4) {
			transform.Translate (0.1f, 0, 0);
		} else {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag.Equals("enemy")){
			other.gameObject.GetComponent<enemyHeathHandler>().TakeDamage(1);
		}
		Destroy(gameObject);
	}

}
