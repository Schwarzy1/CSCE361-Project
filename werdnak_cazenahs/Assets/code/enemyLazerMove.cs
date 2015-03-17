using UnityEngine;
using System.Collections;

public class enemyLazerMove : MonoBehaviour {

	float direction;
	GameObject robot;
	float distance;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(13,1,true);
		Physics2D.IgnoreLayerCollision(13,8,true);
		Physics2D.IgnoreLayerCollision(13,9,true);
		Physics2D.IgnoreLayerCollision(13,10,true);
		Physics2D.IgnoreLayerCollision(13,11,true);
		Physics2D.IgnoreLayerCollision(13,13,true);
		Physics2D.IgnoreLayerCollision(13,14,true);
		robot = GameObject.Find ("archeryRobot");
		direction = 1f;
		distance = 3.2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == -1f) {
			transform.Translate (-0.1f, 0, 0);
		} else if (direction == 1f) {
			transform.Translate (0.1f, 0, 0);
		} 
		if (Vector3.Distance (transform.position, robot.transform.position) >= distance && Vector3.Distance (transform.position, robot.transform.position) < 20) {
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name.Equals("Werd") | other.gameObject.name.Equals("Caz")){
			other.gameObject.GetComponent<heartsHandler>().TakeDamage(1);
		}
		Destroy(gameObject);
	}
}
