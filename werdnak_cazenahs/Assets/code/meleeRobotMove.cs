
using UnityEngine;

using System.Collections;

public class meleeRobotMove : MonoBehaviour {

	public float xSpeed = .01f;
	public float ySpeed = .01f;
	public float scale = 1;
	float r = 0; //used to determine a random direction choice
	float s = 0; //used to determine how many times the object will move in the random direction, this is also random
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
	float STARTX;
	float STARTY;
	float roomX;
	float roomY;
	public string roomNum = "Room 1";
	public bool advanced = false;
	public bool boss = false;
	public float radius = 1;
	public float coolDown = 0;
	GameObject caz;
	GameObject werd;
	Animator animator;
	GameObject room;
	// Use this for initialization
	public void Start () {
		STARTX = transform.position.x;
		STARTY = transform.position.y;
		//animator = GetComponent<Animator>();
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
		room = GameObject.Find (roomNum);
		roomX = room.transform.position.x;
		roomY = room.transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!PauseUIManager.paused) {
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
			if(boss){
				scale = 2;
				if(werdPosX < posX + .1f && werdPosX > posX - .1f && (werdPosY > posY + .1f || werdPosY < posY - .1f) && coolDown <= 0){
					ySpeed = .45f;
					xSpeed = .01f;
					coolDown = 50;
				}
				else if(werdPosY < posY + .1f && werdPosY > posY - .1f && (werdPosX > posX + .1f || werdPosX < posX - .1f) && coolDown <= 0){
					xSpeed = .45f;
					ySpeed = .01f;
					coolDown = 50;
				}
				else if(cazPosX < posX + .1f && cazPosX > posX - .1f && (cazPosY > posY + .1f || cazPosY < posY - .1f) && coolDown <= 0){
					ySpeed = .45f;
					xSpeed = .01f;
					coolDown = 50;
				}
				else if(cazPosY < posY + .1f && cazPosY > posY - .1f && (cazPosX > posX + .1f || cazPosX < posX - .1f) && coolDown <= 0){
					xSpeed = .45f;
					ySpeed = .01f;
					coolDown = 50;
				}
				else{
					xSpeed = .017f;
					ySpeed = .017f;
					coolDown--;
				}

			}
			else{
				xSpeed = .01f;
				ySpeed = .01f;
			}
			if(advanced){
				if(cazPosX > roomX-6 && cazPosX < roomX+6 && cazPosY > roomY-3 && cazPosY < roomY+3){
					if (cazDist < werdDist) {
						if (cazPosY > posY) {
							transform.Translate (0, ySpeed, 0);
							//animator.SetFloat("Speed", 1);
						}
						if (cazPosY < posY) {
							transform.Translate (0, (-1) * ySpeed, 0);
							//animator.SetFloat("Speed", 1);
						}
						if (cazPosX < posX) {
							transform.localScale = (new Vector3 (scale, scale, 1));
							transform.Translate ((-1) * xSpeed, 0, 0);
							//animator.SetFloat("Speed", 1);
						}
						if (cazPosX > posX) {
							transform.localScale = (new Vector3 (-scale, scale, 1));
							transform.Translate (xSpeed, 0, 0);
							//animator.SetFloat("Speed", 1);
						}
					}
					if (cazDist > werdDist) {
						if (werdPosY > posY) {
							transform.Translate (0, ySpeed, 0);
							//animator.SetFloat("Speed", 1);
						}
						if (werdPosY < posY) {
							transform.Translate (0, (-1) * ySpeed, 0);
							//animator.SetFloat("Speed", 1);
						}
						if (werdPosX < posX) {
							transform.localScale = (new Vector3 (scale, scale, 1));
							transform.Translate ((-1) * xSpeed, 0, 0);
							//animator.SetFloat("Speed", 1);
						}
						if (werdPosX > posX) {
							transform.localScale = (new Vector3 (-scale, scale, 1));
							transform.Translate (xSpeed, 0, 0);
							//animator.SetFloat("Speed", 1);
						}
					}
					//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
				}
			}
			else{
				if (cazPosX < STARTX + radius && cazPosX > STARTX - radius && cazPosY < STARTY + radius && cazPosY > STARTY - radius && cazDist < werdDist) {
					if (cazPosY > posY) {
						transform.Translate (0, ySpeed, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (cazPosY < posY) {
						transform.Translate (0, (-1) * ySpeed, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (cazPosX < posX) {
						transform.localScale = (new Vector3 (1, 1, 1));
						transform.Translate ((-1) * xSpeed, 0, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (cazPosX > posX) {
						transform.localScale = (new Vector3 (-1, 1, 1));
						transform.Translate (xSpeed, 0, 0);
						//animator.SetFloat("Speed", 1);
					}
				}
				if (werdPosX < STARTX + radius && werdPosX > STARTX - radius && werdPosY < STARTY + radius && werdPosY > STARTY - radius && cazDist > werdDist) {
					if (werdPosY > posY) {
						transform.Translate (0, ySpeed, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (werdPosY < posY) {
						transform.Translate (0, (-1) * ySpeed, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (werdPosX < posX) {
						transform.localScale = (new Vector3 (1, 1, 1));
						transform.Translate ((-1) * xSpeed, 0, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (werdPosX > posX) {
						transform.localScale = (new Vector3 (-1, 1, 1));
						transform.Translate (xSpeed, 0, 0);
						//animator.SetFloat("Speed", 1);
					}
				} else {
					if (s <= 0) {
						r = Random.value;
					}
					if (s <= 0) {
						s = Random.value * 100;
					}
				
					//animator.SetFloat("Speed", 0);
					if (r > .20 && r < .4 && y < STARTY + radius) {
						transform.Translate (0, ySpeed, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (r >= .4 && r < .6 && y > STARTY - radius) {
						transform.Translate (0, (-1) * ySpeed, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (r >= .6 && r < .8 && x > STARTX - radius) {
						transform.localScale = (new Vector3 (1, 1, 1));
						transform.Translate ((-1) * xSpeed, 0, 0);
						//animator.SetFloat("Speed", 1);
					}
					if (r >= .8 && x < STARTX + radius) {
						transform.localScale = (new Vector3 (-1, 1, 1));
						transform.Translate (xSpeed, 0, 0);
						//animator.SetFloat("Speed", 1);
					}
				
					s--;
					//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
				}
			}
		}
	}
}
