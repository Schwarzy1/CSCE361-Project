using UnityEngine;
using System.Collections;

public class enemyLazerMove : MonoBehaviour {

	float direction;
	GameObject robot;
	heartsHandler hh;
	float distance;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(17,1,true);
		Physics2D.IgnoreLayerCollision(17,9,true);
		Physics2D.IgnoreLayerCollision(17,10,true);
		Physics2D.IgnoreLayerCollision(17,13,true);
		Physics2D.IgnoreLayerCollision(17,14,true);
		Physics2D.IgnoreLayerCollision(17,15,true);
		Physics2D.IgnoreLayerCollision(17,16,true);
		robot = GameObject.Find ("arecheryRobot");
		hh = GameObject.Find("hearts").GetComponent<heartsHandler>();
		direction = robot.GetComponent<archeryRobotAttack> ().transform.localScale.x;
		distance = 3.2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == 1f) {
			transform.Translate (-0.1f, 0, 0);
		} else if (direction == -1f) {
			transform.Translate (0.1f, 0, 0);
		} 
		if (Vector3.Distance (transform.position, robot.transform.position) >= distance && Vector3.Distance (transform.position, robot.transform.position) < 20) {
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name.Equals("Werd") || other.gameObject.name.Equals("Caz")){
			hh.TakeDamage(1);
		}
		Destroy(gameObject);
	}
}
