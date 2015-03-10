using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
		Application.LoadLevel("scene_one");
	}
	public void Exit()
	{
		Application.Quit ();
	}
	public void Credits()
	{
	}
	public void LevelSelect()
	{
	}
	public void Options()
	{
	}
}
