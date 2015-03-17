using UnityEngine;
using System.Collections;

public class lazerMove : MonoBehaviour {

	float direction;
	GameObject caz;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(13,1,true);
		Physics2D.IgnoreLayerCollision(13,8,true);
		Physics2D.IgnoreLayerCollision(13,9,true);
		Physics2D.IgnoreLayerCollision(13,10,true);
		Physics2D.IgnoreLayerCollision(13,11,true);
		Physics2D.IgnoreLayerCollision(13,13,true);
		Physics2D.IgnoreLayerCollision(13,14,true);
		caz = GameObject.Find ("Caz");
		direction = caz.GetComponent<cazenahsMove> ().transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == -1f) {
			transform.Translate (-0.1f, 0, 0);
		} else if (direction == 1f) {
			transform.Translate (0.1f, 0, 0);
		} 
		if (Vector3.Distance (transform.position, caz.transform.position) >= 3.2f && Vector3.Distance (transform.position, caz.transform.position) < 20) {
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
