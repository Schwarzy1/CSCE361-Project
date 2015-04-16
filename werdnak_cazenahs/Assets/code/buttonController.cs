using UnityEngine;
using System.Collections;

public class buttonController : MonoBehaviour {
	
	Animator animator;
	public bool buttonDown = false;
	public doorHandler doorHand;
	public bool isPairedtoDoor=false;
	public GameObject pits;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(){
		buttonDown = true;
		animator.SetBool ("ButtonDown", buttonDown);
		if (isPairedtoDoor) {
			doorHand.OpenDoor ();
		} else {
			pits.SetActive(false);
		}
	}
	void OnTriggerExit2D(){
		buttonDown = false;
		animator.SetBool ("ButtonDown", buttonDown);
		if (isPairedtoDoor) {
			doorHand.CloseDoor ();
		} else {
			pits.SetActive(true);
		}
	}

}
