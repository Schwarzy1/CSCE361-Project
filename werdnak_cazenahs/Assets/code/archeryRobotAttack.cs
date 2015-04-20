using UnityEngine;
using System.Collections;

public class archeryRobotAttack : MonoBehaviour {
	GameObject werd;
	GameObject caz;
	float cazPosX;
	float scale = 1;
	float lazerScaleX = 1;
	float lazerScaleY = 1;
	float cazPosY;
	float cazDist;
	float werdPosX;
	float werdPosY;
	float werdDist;
	float randX;
	float randY;
	public float coolDownMove = 100;
	enemyLazerMove elm;
	Quaternion quat = new Quaternion(0,0,0,0);
	float posX;
	float posY;
	public bool boss = false;
	public int coolDownWait = 0;
	public float radius = 5;
	float roomX;
	float roomY;
	public string roomNum = "Room 1";
	GameObject lazer;
	GameObject room;
	Vector3 loc;
	// Use this for initialization
	void Start () {
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
		room = GameObject.Find (roomNum);
		roomX = room.transform.position.x;
		roomY = room.transform.position.y;
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
			if(boss){
				scale = 2;
				lazerScaleX = 2;
				lazerScaleY = 5;
			}
			if(boss && coolDownMove <= 0){

				randX = Random.Range(roomX-5.5f, roomX+5.5f);
				randY = Random.Range(roomY-2.5f, roomY+2.5f);
				transform.position = (new Vector3(randX, randY, -1));
				coolDownMove = 100;
			}
			else if(boss && coolDownMove > 0){
				scale = 2;
				coolDownMove--;
			}
			if(cazPosX > roomX-6 && cazPosX < roomX+6 && cazPosY > roomY-3 && cazPosY < roomY+3){
				if (cazPosX < posX + radius && cazPosX > posX - radius && cazPosY < posY + radius && cazPosY > posY - radius && cazDist < werdDist) {
					if (cazPosX < posX) {
						transform.localScale = (new Vector3 (scale, scale, 1));
					} else if (cazPosX > posX) {
						transform.localScale = (new Vector3 (-scale, scale, 1));
					}
					if (coolDownWait <= 0) {
						loc = new Vector3 (transform.position.x, transform.position.y - 0.3f, transform.position.z - 0.5f);
						lazer = GameObject.Find ("lazer_green");
						Instantiate (lazer, loc, quat);
						elm = lazer.GetComponent<enemyLazerMove>();
						elm.distance = radius;
						elm.transform.localScale = (new Vector3 (lazerScaleX, lazerScaleY, 1));
						coolDownWait = 40;
					}
					if(boss && (coolDownWait == 35 || coolDownWait == 30)){
						
						loc = new Vector3 (transform.position.x, transform.position.y - 0.3f, transform.position.z - 0.5f);
						lazer = GameObject.Find ("lazer_green");
						Instantiate (lazer, loc, quat);
						elm = lazer.GetComponent<enemyLazerMove>();
						elm.distance = radius;
						elm.transform.localScale = (new Vector3 (lazerScaleX, lazerScaleY, 1));
						
					}
					if (coolDownWait > 0) {
						coolDownWait--;
					}
				}
				if (werdPosX < posX + radius && werdPosX > posX - radius && werdPosY < posY + radius && werdPosY > posY - radius && cazDist > werdDist) {
					if (werdPosX < posX) {
						transform.localScale = (new Vector3 (scale, scale, 1));
					} else if (werdPosX > posX) {
						transform.localScale = (new Vector3 (-scale, scale, 1));
					}
					if (coolDownWait <= 0) {
						loc = new Vector3 (transform.position.x, transform.position.y - 0.3f, transform.position.z - 0.5f);
						lazer = GameObject.Find ("lazer_green");
						Instantiate (lazer, loc, quat);
						elm = lazer.GetComponent<enemyLazerMove>();
						elm.distance = radius;
						elm.transform.localScale = (new Vector3 (lazerScaleX, lazerScaleY, 1));

						coolDownWait = 40;
					}
					if(boss && (coolDownWait == 35 || coolDownWait == 30)){
						
						loc = new Vector3 (transform.position.x, transform.position.y - 0.3f, transform.position.z - 0.5f);
						lazer = GameObject.Find ("lazer_green");
						Instantiate (lazer, loc, quat);
						elm = lazer.GetComponent<enemyLazerMove>();
						elm.distance = radius;
						elm.transform.localScale = (new Vector3 (lazerScaleX, lazerScaleY, 1));
						
					}

					if (coolDownWait > 0) {
						coolDownWait--;
					}
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
