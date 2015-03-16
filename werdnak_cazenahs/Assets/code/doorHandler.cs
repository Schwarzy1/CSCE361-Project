using UnityEngine;
using System.Collections;

public class doorHandler : MonoBehaviour {
	public int doorSide;
	public bool open = true;
	Animator animator;
	roomHandler roomHand;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		roomHand = GameObject.Find("roomHandler").GetComponent<roomHandler>();
		doorSide = (int) transform.eulerAngles.z;
		animator.SetBool ("Open", open);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (open == true && (other.gameObject.name == "Caz" || other.gameObject.name == "Werd")) {

			if(doorSide == 0){
				roomHand.MoveLeft();
			}else if(doorSide == 90){
				roomHand.MoveUp();
			}else if(doorSide == 180){
				roomHand.MoveRight();
			}else if(doorSide == 270){
				roomHand.MoveDown();
			}
		}
	}

	public void OpenDoor(){
		open = true;
		animator.SetBool ("Open", open);
	}
	public void CloseDoor(){
		open = false;
		animator.SetBool ("Open", open);
	}

}
