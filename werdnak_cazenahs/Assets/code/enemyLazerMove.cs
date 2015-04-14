using UnityEngine;
using System.Collections;

public class enemyLazerMove : MonoBehaviour {

	float direction;
	GameObject robot;
	heartsHandler hh;
	GameObject werd;
	GameObject caz;
	public float distance = 3.2f;
	float cazPosX;
	float cazDist;
	float werdPosX;
	float werdDist;
	float posX;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(17,1,true);
		Physics2D.IgnoreLayerCollision(17,9,true);
		Physics2D.IgnoreLayerCollision(17,10,true);
		Physics2D.IgnoreLayerCollision(17,13,true);
		Physics2D.IgnoreLayerCollision(17,14,true);
		Physics2D.IgnoreLayerCollision(17,15,true);
		Physics2D.IgnoreLayerCollision(17,16,true);
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
		pos = transform.position;
		posX = transform.position.x;
		cazPosX = caz.transform.position.x;
		cazDist = Vector3.Distance (transform.position, caz.transform.position);
		werdPosX = werd.transform.position.x;
		werdDist = Vector3.Distance (transform.position, werd.transform.position);
		hh = GameObject.Find("hearts").GetComponent<heartsHandler>();
		if (cazDist < werdDist) {
			if (cazPosX < posX) {
				direction = -0.1f;
			} else if (cazPosX > posX) {
				direction = 0.1f;
			}
			
		}if (cazDist > werdDist) {
			if (werdPosX < posX) {
				direction = -0.1f;
			} else if (werdPosX > posX) {
				direction = 0.1f;
			}

		}

	}
	
	// Update is called once per frame
	void Update () {
		if (!PauseUIManager.paused) {
			if (!(-9900 > posX && posX > -10100)) {
				transform.Translate (direction, 0, 0);
			
				if (Vector3.Distance (transform.position, pos) >= distance) {
					Destroy (gameObject);
				}
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name.Equals("Werd") || other.gameObject.name.Equals("Caz")){
			hh.TakeDamage(1);
		}
		Destroy(gameObject);
	}

	
}
