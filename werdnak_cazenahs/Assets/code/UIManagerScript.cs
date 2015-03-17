using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {
	public string lastLevel="Menus";


	// Use this for initialization
	public void StartGame(){
		Application.LoadLevel ("scene_one");
	}

	public void StartGame (string selectedLevel) {
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

		StartGame ("scene_one");

	}
	public void GameOver(){
		Application.LoadLevel ("GameOver");
		lastLevel = "GameOver";
	}

	public void LevelTwo(){
		Application.LoadLevel ("scene_two");
	}

}
