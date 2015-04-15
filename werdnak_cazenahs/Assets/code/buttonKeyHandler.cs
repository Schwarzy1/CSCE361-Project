using UnityEngine;
using System.Collections;

public class buttonKeyHandler : MonoBehaviour {

	public keyBindHandler keys;
	// Use this for initialization
	void Start () {
		keys = GameObject.Find ("keyBindHandler").GetComponent<keyBindHandler>();
	}

	
	public void ButtonChangeWerdUp(){
		keys.ChangeWerdUp ();
	}
	public void ButtonChangeWerdDown(){
		keys.ChangeWerdDown ();
	}
	public void ButtonChangeWerdLeft(){
		keys.ChangeWerdLeft ();
	}
	public void ButtonChangeWerdRight(){
		keys.ChangeWerdRight ();
	}
	public void ButtonChangeWerdAttack(){
		keys.ChangeWerdAttack ();
	}
	
	
	public void ButtonChangeCazUp(){
		keys.ChangeCazUp ();
	}
	public void ButtonChangeCazDown(){
		keys.ChangeCazDown ();
	}
	public void ButtonChangeCazLeft(){
		keys.ChangeCazLeft ();
	}
	public void ButtonChangeCazRight(){
		keys.ChangeCazRight ();
	}
	public void ButtonChangeCazAttack(){
		keys.ChangeCazAttack ();
	}
	
	public void ButtonChangePause(){
		keys.ChangePause ();
	}
	

}
