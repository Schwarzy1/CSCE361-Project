using UnityEngine;
using System.Collections;

public class PauseUIManager : MonoBehaviour {

	// Use this for initialization
	GameObject canvas;
	public static bool paused=false;
	public int cooldown=0;
	void Start(){
		paused = false;
		canvas = GameObject.Find ("Canvas");
		canvas.SetActive (false);
	}
	
	// Update is called once per frame

	void FixedUpdate(){
		if (Input.GetKey (KeyCode.P)&& cooldown<=0&& paused==false) {
			//Pause Menu stuff
			canvas.SetActive (true);
			paused = true;
			cooldown=30;
		} 
		if(Input.GetKey (KeyCode.P)&& cooldown<=0&& paused==true){
			canvas.SetActive (false);
			paused = false;
			cooldown=30;
		}
		cooldown--;
		
	}
}
