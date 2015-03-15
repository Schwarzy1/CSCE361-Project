using UnityEngine;
using System.Collections;

public class doorHandler : MonoBehaviour {
	public int doorSide;
	bool open = true;
	public roomHandler roomHand;
	// Use this for initialization
	void Start () {
		doorSide = (int) transform.eulerAngles.z;
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

}
