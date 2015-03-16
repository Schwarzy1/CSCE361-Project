
using UnityEngine;

using System.Collections;

public class meleeRobotMove : MonoBehaviour {

	float speed = .01f;
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
	public float radius = 1;
	GameObject caz;
	GameObject werd;
	Animator animator;
	// Use this for initialization
	public void Start () {
		STARTX = transform.position.x;
		STARTY = transform.position.y;
		//animator = GetComponent<Animator>();
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		x = transform.position.x;
		y = transform.position.y;
		cazPosX = caz.transform.position.x;
		cazPosY = caz.transform.position.y;
		cazDist = cazPosX * cazPosY;
		werdPosX = werd.transform.position.x;
		werdPosY = werd.transform.position.y;
		werdDist = werdPosX * werdPosY;
		posX = transform.position.x;
		posY = transform.position.y;


		if (cazPosX < STARTX + radius && cazPosX > STARTX - radius && cazPosY < STARTY + radius && cazPosY > STARTY - radius && cazDist < werdDist) {
			if(cazPosY > posY){
				transform.Translate(0,speed,0);
				//animator.SetFloat("Speed", 1);
			}
			if(cazPosY < posY){
				transform.Translate(0,(-1)*speed,0);
				//animator.SetFloat("Speed", 1);
			}
			if(cazPosX < posX){
				transform.localScale = (new Vector3(1,1,1));
				transform.Translate((-1)*speed,0,0);
				//animator.SetFloat("Speed", 1);
			}
			if(cazPosX > posX){
				transform.localScale = (new Vector3(-1,1,1));
				transform.Translate(speed,0,0);
				//animator.SetFloat("Speed", 1);
			}
		}
		if (werdPosX < STARTX + radius && werdPosX > STARTX - radius && werdPosY < STARTY + radius && werdPosY > STARTY - radius && cazDist > werdDist) {
			if(werdPosY > posY){
				transform.Translate(0,speed,0);
				//animator.SetFloat("Speed", 1);
			}
			if(werdPosY < posY){
				transform.Translate(0,(-1)*speed,0);
				//animator.SetFloat("Speed", 1);
			}
			if(werdPosX < posX){
				transform.localScale = (new Vector3(1,1,1));
				transform.Translate((-1)*speed,0,0);
				//animator.SetFloat("Speed", 1);
			}
			if(werdPosX > posX){
				transform.localScale = (new Vector3(-1,1,1));
				transform.Translate(speed,0,0);
				//animator.SetFloat("Speed", 1);
			}
		}



		else{
			if (s <= 0) {
				r = Random.value;
			}
			if (s <= 0) {
				s = Random.value * 100;
			}
			
			//animator.SetFloat("Speed", 0);
			if(r > .20 && r < .4 && y < STARTY + radius){
				transform.Translate(0,speed,0);
				//animator.SetFloat("Speed", 1);
			}
			if(r >= .4 && r < .6 && y > STARTY - radius){
				transform.Translate(0,(-1)*speed,0);
				//animator.SetFloat("Speed", 1);
			}
			if(r >= .6 && r < .8 && x > STARTX - radius){
				transform.localScale = (new Vector3(1,1,1));
				transform.Translate((-1)*speed,0,0);
				//animator.SetFloat("Speed", 1);
			}
			if(r >= .8 && x < STARTX + radius){
				transform.localScale = (new Vector3(-1,1,1));
				transform.Translate(speed,0,0);
				//animator.SetFloat("Speed", 1);
			}
			
			s--;
			//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
		}
	}
}
