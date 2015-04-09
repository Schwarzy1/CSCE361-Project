using UnityEngine;
using System.Collections;

public class archeryRobotAttack : MonoBehaviour {
	GameObject werd;
	GameObject caz;
	float cazPosX;
	float cazPosY;
	float cazDist;
	float werdPosX;
	float werdPosY;
	float werdDist;
	Quaternion quat = new Quaternion(0,0,0,0);
	float posX;
	float posY;
	public int coolDownWait = 0;
	public float radius = 5;
	GameObject lazer;
	Vector3 loc;
	// Use this for initialization
	void Start () {
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
	}
	
	// Update is called once per frame
	void Update () {
		if (!PauseUIManager.paused) {
			posX = transform.position.x;
			posY = transform.position.y;
			cazPosX = caz.transform.position.x;
			cazPosY = caz.transform.position.y;
			cazDist = Vector3.Distance (transform.position, caz.transform.position);
			werdPosX = werd.transform.position.x;
			werdPosY = werd.transform.position.y;
			werdDist = Vector3.Distance (transform.position, werd.transform.position);

			if (cazPosX < posX + radius && cazPosX > posX - radius && cazPosY < posY + radius && cazPosY > posY - radius && cazDist < werdDist) {
				if (cazPosX < posX) {
					transform.localScale = (new Vector3 (1, 1, 1));
				} else if (cazPosX > posX) {
					transform.localScale = (new Vector3 (-1, 1, 1));
				}
				if (coolDownWait <= 0) {
					loc = new Vector3 (transform.position.x, transform.position.y - 0.3f, transform.position.z - 0.5f);
					lazer = GameObject.Find ("lazer_green");
					Instantiate (lazer, loc, quat);
					coolDownWait = 30;
				}
				if (coolDownWait > 0) {
					coolDownWait--;
				}
			}
			if (werdPosX < posX + radius && werdPosX > posX - radius && werdPosY < posY + radius && werdPosY > posY - radius && cazDist > werdDist) {
				if (werdPosX < posX) {
					transform.localScale = (new Vector3 (1, 1, 1));
				} else if (werdPosX > posX) {
					transform.localScale = (new Vector3 (-1, 1, 1));
				}
				if (coolDownWait <= 0) {
					loc = new Vector3 (transform.position.x, transform.position.y - 0.3f, transform.position.z - 0.5f);
					lazer = GameObject.Find ("lazer_green");
					Instantiate (lazer, loc, quat);
					coolDownWait = 30;
				}
				if (coolDownWait > 0) {
					coolDownWait--;
				}
			}
			/*
		if (coolDownWait <= 0) {
			loc = new Vector3(transform.position.x+1, transform.position.y-0.1f, transform.position.z);
			lazer = GameObject.Find("lazer_green");
			Instantiate(lazer, loc , quat);
			coolDownWait = 30;
		}
		if (coolDownWait > 0) {
			coolDownWait--;
		}
		*/

		}
	}
}
