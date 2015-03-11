using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
		Application.LoadLevel("scene_one");
	}

	public void CharSelect(){
		Application.LoadLevel ("CharacterSelect");
	}

	public void Exit()
	{
		Application.Quit ();
	}
	public void Credits(){
		Application.LoadLevel ("Credits");
	}
	public void LevelSelect(){
		Application.LoadLevel ("LevelSelect");
	}
	public void Options(){
		Application.LoadLevel ("Options");
	}

	public void Back(){
	
		Application.LoadLevel ("Menus");
	
	}
}
