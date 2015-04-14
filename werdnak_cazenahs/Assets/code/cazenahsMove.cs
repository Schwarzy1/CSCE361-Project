using UnityEngine;
using System.Collections;

public class cazenahsMove : MonoBehaviour {
	float speed = .1f;
	Animator animator;
	public bool lockMove = false;
	public int coolDownWait = 0;
	public bool powerUp = false;
	public bool dubPowerUp=false;
	public keyBindHandler keyBindScript;
	GameObject lazer;
	GameObject canvas;
	Vector3 loc;
	Quaternion quat = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		keyBindScript = GameObject.Find ("keyBindHandler").GetComponent<keyBindHandler>();
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!PauseUIManager.paused) {

			if (lockMove == false) {
				Move ();
				Attack ();
			}
			if (Input.GetKey (KeyCode.U)) {
				powerUp = true;
			}
			if(Input.GetKey (KeyCode.O)){
				dubPowerUp=true;
			}
			//GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 1, 1);
		}
		}



	void Attack(){
		if (Input.GetKey (keyBindScript.cazAttack) && coolDownWait <= 0) {
			loc = new Vector3(transform.position.x, transform.position.y-0.1f, transform.position.z);
			lazer = GameObject.Find("lazer_blue");
			Instantiate(lazer, loc , quat);
			coolDownWait = 30;
		}if (coolDownWait > 0) {
			coolDownWait--;
		}
	}

	void Move(){
		animator.SetFloat("Speed", 0);
		if(Input.GetKey(keyBindScript.cazUp)){
			transform.Translate(0,speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(keyBindScript.cazDown)){
			transform.Translate(0,(-1)*speed,0);
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(keyBindScript.cazLeft)){
			transform.Translate((-1)*speed,0,0);
			transform.localScale = (new Vector3(-1,1,1));
			animator.SetFloat("Speed", 1);
		}
		if(Input.GetKey(keyBindScript.cazRight)){
			transform.Translate(speed,0,0);
			transform.localScale = (new Vector3(1,1,1));
			animator.SetFloat("Speed", 1);
		}
	}


}