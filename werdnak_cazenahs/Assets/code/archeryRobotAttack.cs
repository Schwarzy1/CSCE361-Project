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
	float posX;
	float posY;
	public int coolDownWait = 0;
	public float radius = 5;
	GameObject lazer;
	Vector3 loc;
	Quaternion quat = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
		posX = transform.position.x;
		posY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		cazPosX = caz.transform.position.x;
		cazPosY = caz.transform.position.y;
		cazDist = cazPosX * cazPosY;
		werdPosX = werd.transform.position.x;
		werdPosY = werd.transform.position.y;
		werdDist = werdPosX * werdPosY;

		if (cazPosX < posX + radius && cazPosX > posX - radius && cazPosY < posY + radius && cazPosY > posY - radius && cazDist < werdDist) {
			if (coolDownWait <= 0) {
				loc = new Vector3(transform.position.x+1, transform.position.y-0.1f, transform.position.z);
				lazer = GameObject.Find("lazer_green");
				Instantiate(lazer, loc , quat);
				coolDownWait = 30;
			}

			if (coolDownWait > 0) {
				coolDownWait--;
			}

		}
		if (werdPosX < posX + radius && werdPosX > posX - radius && werdPosY < posY + radius && werdPosY > posY - radius && cazDist > werdDist) {
			if (coolDownWait <= 0) {
				loc = new Vector3(transform.position.x+1, transform.position.y-0.1f, transform.position.z);
				lazer = GameObject.Find("lazer_green");
				Instantiate(lazer, loc , quat);
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
