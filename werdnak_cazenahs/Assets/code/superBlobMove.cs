using UnityEngine;
using System.Collections;

public class superBlobMove : MonoBehaviour {

	float speed = .01f;
	float x;
	float y;
	float cazPosX;
	float cazPosY;
	float cazDist;
	float werdPosX;
	float werdPosY;
	float werdDist;
	float posX;
	float posY;
	GameObject caz;
	GameObject werd;
	Animator animator;
	// Use this for initialization
	public void Start () {
		animator = GetComponent<Animator>();
		transform.localScale = new Vector3(2.5f, 2.5f, 1);
		animator.transform.localScale = new Vector3(2.5f, 2.5f, 1);
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!PauseUIManager.paused) {
			transform.localScale.Set (2.5f, 2.5f, 1);
			animator.transform.localScale.Set (2.5f, 2.5f, 1);
			x = transform.position.x;
			y = transform.position.y;
			cazPosX = caz.transform.position.x;
			cazPosY = caz.transform.position.y;
			cazDist = Vector3.Distance (transform.position, caz.transform.position);
			werdPosX = werd.transform.position.x;
			werdPosY = werd.transform.position.y;
			werdDist = Vector3.Distance (transform.position, werd.transform.position);
			posX = transform.position.x;
			posY = transform.position.y;
		
		
			if (cazDist < werdDist) {
				if (cazPosY > posY) {
					transform.Translate (0, speed, 0);
					animator.SetFloat ("Speed", 1);
				}
				if (cazPosY < posY) {
					transform.Translate (0, (-1) * speed, 0);
					animator.SetFloat ("Speed", 1);
				}
				if (cazPosX < posX) {
					transform.localScale = (new Vector3 (2.5f, 2.5f, 1));
					transform.Translate ((-1) * speed, 0, 0);
					animator.SetFloat ("Speed", 1);
				}
				if (cazPosX > posX) {
					transform.localScale = (new Vector3 (-2.5f, 2.5f, 1));
					transform.Translate (speed, 0, 0);
					animator.SetFloat ("Speed", 1);
				}
			}
			if (cazDist > werdDist) {
				if (werdPosY > posY) {
					transform.Translate (0, speed, 0);
					animator.SetFloat ("Speed", 1);
				}
				if (werdPosY < posY) {
					transform.Translate (0, (-1) * speed, 0);
					animator.SetFloat ("Speed", 1);
				}
				if (werdPosX < posX) {
					transform.localScale = (new Vector3 (2.5f, 2.5f, 1));
					transform.Translate ((-1) * speed, 0, 0);
					animator.SetFloat ("Speed", 1);
				}
				if (werdPosX > posX) {
					transform.localScale = (new Vector3 (-2.5f, 2.5f, 1));
					transform.Translate (speed, 0, 0);
					animator.SetFloat ("Speed", 1);
				}
			}
			//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
		}
	}
}
