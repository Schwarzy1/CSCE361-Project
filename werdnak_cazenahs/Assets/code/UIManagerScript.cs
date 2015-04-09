using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {
	public string lastLevel="Menus";
	GameObject canvas;
	void Start(){
		PauseUIManager.paused = false;
		canvas = GameObject.Find ("Canvas");
	}
	// Use this for initialization
	public void StartGame(){
		PauseUIManager.paused = false;
		Application.LoadLevel ("scene_one");
	}

	public void StartGame (string selectedLevel) {
		PauseUIManager.paused = false;
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
		PauseUIManager.paused = false;

		Application.LoadLevel("scene_one");

	}
	public void LevelThree(){
		PauseUIManager.paused = false;
		Application.LoadLevel ("scene_three");
	}
	public void GameOver(){
		Application.LoadLevel ("GameOver");
		lastLevel = "GameOver";
	}

	public void LevelTwo(){
		PauseUIManager.paused = false;
		Application.LoadLevel ("scene_two");
	}
	public void ResumeLevel(){
		canvas = GameObject.Find ("Canvas");
		canvas.SetActive (false);
		PauseUIManager.paused = false;
	}


}
