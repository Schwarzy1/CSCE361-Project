using UnityEngine;
using System.Collections;

public class keyBindHandler : MonoBehaviour {

	public KeyCode werdUp = KeyCode.W;
	public KeyCode werdLeft = KeyCode.A;
	public KeyCode werdDown = KeyCode.S;
	public KeyCode werdRight = KeyCode.D;
	public KeyCode werdAttack = KeyCode.Space;
	public KeyCode pause = KeyCode.P;
	public KeyCode cazUp = KeyCode.UpArrow;
	public KeyCode cazLeft = KeyCode.LeftArrow;
	public KeyCode cazRight = KeyCode.RightArrow;
	public KeyCode cazDown = KeyCode.DownArrow;
	public KeyCode cazAttack = KeyCode.RightControl;
	
	bool changeWerdUp = false;
	bool changeWerdDown = false;
	bool changeWerdLeft = false;
	bool changeWerdRight = false;
	bool changeWerdAttack = false;
	bool changeCazUp = false;
	bool changeCazDown = false;
	bool changeCazLeft = false;
	bool changeCazRight = false;
	bool changeCazAttack = false;
	bool changePause = false;
	bool changeKey = false;

	
	public void ChangeWerdUp(){
		changeWerdUp = true;
		changeKey = true;
	}
	public void ChangeWerdDown(){
		changeWerdDown = true;
		changeKey = true;
	}
	public void ChangeWerdLeft(){
		changeWerdLeft = true;
		changeKey = true;
	}
	public void ChangeWerdRight(){
		changeWerdRight = true;
		changeKey = true;
	}
	public void ChangeWerdAttack(){
		changeWerdAttack = true;
		changeKey = true;
	}
	
	public void ChangeCazUp(){
		changeCazUp = true;
		changeKey = true;
	}
	public void ChangeCazDown(){
		changeCazDown = true;
		changeKey = true;
	}
	public void ChangeCazLeft(){
		changeCazLeft = true;
		changeKey = true;
	}
	public void ChangeCazRight(){
		changeCazRight = true;
		changeKey = true;
	}
	public void ChangeCazAttack(){
		changeCazAttack = true;
		changeKey = true;
	}

	public void ChangePause(){
		changePause = true;
		changeKey = true;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnGUI() {
		Event e = Event.current;
		if (changeKey && e.isKey) {
			if(changeWerdUp){
				werdUp = e.keyCode;
				changeWerdUp = false;
			}
			else if(changeWerdDown){
				werdDown = e.keyCode;
				changeWerdDown = false;
			}
			else if(changeWerdLeft){
				werdLeft = e.keyCode;
				changeWerdLeft = false;
			}
			else if(changeWerdRight){
				werdRight = e.keyCode;
				changeWerdRight = false;
			}
			else if(changeWerdAttack){
				werdAttack = e.keyCode;
				changeWerdAttack = false;
			}
			else if(changeCazUp){
				cazUp = e.keyCode;
				changeCazUp = false;
			}
			else if(changeCazDown){
				cazDown = e.keyCode;
				changeCazDown = false;
			}
			else if(changeCazLeft){
				cazLeft = e.keyCode;
				changeCazLeft = false;
			}
			else if(changeCazRight){
				cazRight = e.keyCode;
				changeCazRight = false;
			}
			else if(changeCazAttack){
				cazAttack = e.keyCode;
				changeCazAttack = false;
			}
			else if(changePause){
				pause = e.keyCode;
				changePause = false;
			}
			changeKey = false;
		}
	}
}
