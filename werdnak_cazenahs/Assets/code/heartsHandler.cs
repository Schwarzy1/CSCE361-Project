using UnityEngine;
using System.Collections;

public class heartsHandler : MonoBehaviour {
	public int konami = 0;
	bool godmode = false;
	public int health = 6;
	SpriteRenderer sprite;
	GameObject[] players;
	GameObject goldHearts;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		players = GameObject.FindGameObjectsWithTag ("Players");
		goldHearts = GameObject.Find ("goldHearts");

	}
	
	// Update is called once per frame
	void Update () {
		if((konami == 0 || konami == 1) && (Input.GetKeyDown(KeyCode.UpArrow))){
			konami++;
		}else if((konami == 2 || konami == 3) && (Input.GetKeyDown(KeyCode.DownArrow))){
			konami++;
		}else if((konami == 4 || konami == 6) && (Input.GetKeyDown(KeyCode.LeftArrow))){
			konami++;
		}else if((konami == 5 || konami == 7) && (Input.GetKeyDown( KeyCode.RightArrow))){
			konami++;
		}else if((konami == 8) && (Input.GetKeyDown( KeyCode.B))){
			konami++;
		}else if((konami == 9) && (Input.GetKeyDown( KeyCode.A))){
			konami++;
		}else if((konami == 10) && (Input.GetKeyDown( KeyCode.Return))){
			konami = 0;
			if(godmode == false){
				godmode = true;
				animator.SetInteger("health", 6);
				health = 6;
				for(int i = 0; i < 15; i++){
					players[i].GetComponent<SpriteRenderer>().material.color = new Color(1, 0.92f, 0.016f, 1);
				}
				goldHearts.transform.position = new Vector3 (-4.41f,-3.19f,-2);
			}else{
				godmode = false;
				for(int i = 0; i < 15; i++){
					players[i].GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, 1);
				}
				goldHearts.transform.position = new Vector3 (-1000,-1000,-1);
			}
		}else if(Input.anyKeyDown){
			konami = 0;
		}
	}

	public void TakeDamage(int damage){
		if(godmode == false){
			health -= damage;

			if(health <= 0){
				health = 0;
				Application.LoadLevel ("GameOver");
			}
			animator.SetInteger("health", health);
		}
	}

}
