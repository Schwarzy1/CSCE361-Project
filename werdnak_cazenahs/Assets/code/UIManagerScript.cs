using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {
	public string lastLevel="Menus";
	GameObject canvas;
	void Start(){
		paused = false;
		canvas = GameObject.Find ("Canvas");
		canvas.SetActive (false);
	}
	// Use this for initialization
	public void StartGame(){
		paused = false;
		Application.LoadLevel ("scene_one");
	}

	public void StartGame (string selectedLevel) {
		paused = false;
		Application.LoadLevel(selectedLevel);
	}


	public void CharSelect(){
		Application.LoadLevel ("CharacterSelect");
		lastLevel = "CharacterSelect";
	}

	public void Exit()
	{
		Application.Quit ();
	}
	public void Credits(){
		Application.LoadLevel ("Credits");
		lastLevel = "Credits";
	}

	public void LevelSelect(){
		Application.LoadLevel ("LevelSelect");
		lastLevel= "LevelSelect";
	}
	public void Options(){
		Application.LoadLevel ("Options");
		lastLevel = "Options";
	}

	public void Back(){
	
		Application.LoadLevel ("Menus");
	
	}

	public void BackLevelSel(){
		Application.LoadLevel ("CharacterSelect");
	}
	public void LevelOne(){
		paused = false;

		Application.LoadLevel("scene_one");

	}
	public void LevelThree(){
		paused = false;
		Application.LoadLevel ("scene_three");
	}
	public void GameOver(){
		Application.LoadLevel ("GameOver");
		lastLevel = "GameOver";
	}

	public void LevelTwo(){
		paused = false;
		Application.LoadLevel ("scene_two");
	}
	public void ResumeLevel(){
		canvas = GameObject.Find ("Canvas");
		canvas.SetActive (false);
		paused = false;
	}
	public static bool paused=false;
	void FixedUpdate(){
		if (Input.GetKey (KeyCode.P)) {
			//Pause Menu stuff

			canvas.SetActive (true);
			paused = true;
			
		} 

	}

}
