using UnityEngine;
using System.Collections;

public class switchController : MonoBehaviour {
	
	Animator animator;
	public bool switchDown = false;
	public doorHandler doorHand;
	public bool isWerds=true;
	public int cooldown= 0;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(cooldown>0)cooldown--;
	}

	void OnCollisionEnter2D(Collision2D other){
		if(isWerds && other.gameObject.name.Equals("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == true && switchDown==false){
			changeSwitch('w');
		}
		else if(isWerds && other.gameObject.name.Equals("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == true && switchDown==true){
			changeSwitch('w');
		}
	}

	public void changeSwitch(char owner){
		if (switchDown == false && owner=='w' && isWerds && cooldown<=0) {
			switchDown = true;
			doorHand.OpenDoor();
			cooldown=45;
		} else if (switchDown == true && owner=='w' && isWerds && cooldown<=0) {
			switchDown = false;
			doorHand.CloseDoor();
			cooldown=45;
		}
		else if (switchDown == false && owner=='c' && !isWerds) {
			switchDown = true;
			doorHand.OpenDoor();
		} else if (switchDown == true && owner=='c' && !isWerds) {
			switchDown = false;
			doorHand.CloseDoor();
		}

	}
	

	}
	
	

