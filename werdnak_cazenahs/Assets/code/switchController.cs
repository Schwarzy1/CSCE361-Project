using UnityEngine;
using System.Collections;

public class switchController : MonoBehaviour {
	
	Animator animator;
	public doorHandler doorHand;
	public bool isWerds=true;
	public int cooldown= 0;
	public GameObject pit;

	public bool isPairedtoDoor=true;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldown > 0) {
			cooldown--;
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(isWerds && other.gameObject.name.Equals("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == true){
			changeSwitch('w');
		}

	}

	public void changeSwitch(char owner){
		if (isPairedtoDoor) {
			if (doorHand.open == false && owner == 'w' && isWerds && cooldown <= 0) {
				doorHand.OpenDoor ();
				cooldown = 20;
			} else if (doorHand.open == true && owner == 'w' && isWerds && cooldown <= 0) {
				doorHand.CloseDoor ();
				cooldown = 20;
			} else if (doorHand.open == false && owner == 'c' && !isWerds) {
				doorHand.OpenDoor ();
			} else if (doorHand.open == true && owner == 'c' && !isWerds) {
				doorHand.CloseDoor ();
			}
		} else {
			if(pit.activeInHierarchy){
				pit.SetActive(false);
			}
			else{
				pit.SetActive(true);
			}
		}
	}
	

	}
	
	

