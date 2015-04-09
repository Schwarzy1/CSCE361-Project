using UnityEngine;
using System.Collections;

public class PauseUIManager : MonoBehaviour {

	// Use this for initialization
	GameObject canvas;
	public static bool paused=false;
	void Start(){
		paused = false;
		canvas = GameObject.Find ("Canvas");
		canvas.SetActive (false);
	}
	
	// Update is called once per frame

	void FixedUpdate(){
		if (Input.GetKey (KeyCode.P)) {
			//Pause Menu stuff
			
			canvas.SetActive (true);
			paused = true;
			
		} 
		
	}
}
