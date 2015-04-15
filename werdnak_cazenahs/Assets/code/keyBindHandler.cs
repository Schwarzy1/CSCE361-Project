using UnityEngine;
using UnityEngine.UI;
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
	public static bool changeKey = false;

	private static keyBindHandler _instance ;


	public void Awake(){
		
		GameObject WUBut = GameObject.Find ("WUP");
		GameObject WRBut = GameObject.Find ("WRight");
		GameObject WLBut = GameObject.Find ("WLeft");
		GameObject WABut = GameObject.Find ("WAttack");
		GameObject CUBut = GameObject.Find ("CUP");
		GameObject CDBut = GameObject.Find ("CDown");
		GameObject CLBut = GameObject.Find ("CLeft");
		GameObject CRBut = GameObject.Find ("CRight");
		GameObject CABut = GameObject.Find ("CAttack");

		if (!_instance) {
			_instance = this;
		} else {
			Destroy (this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
	}



	public void makeFalse(){
		 changeWerdUp = false;
		 changeWerdDown = false;
		 changeWerdLeft = false;
		 changeWerdRight = false;
		 changeWerdAttack = false;
		 changeCazUp = false;
		 changeCazDown = false;
		 changeCazLeft = false;
		 changeCazRight = false;
		 changeCazAttack = false;
		 changePause = false;
	}

	
	public void ChangeWerdUp(){
		makeFalse ();
		changeWerdUp = true;
		changeKey = true;
	}
	public void ChangeWerdDown(){
		makeFalse ();
		changeWerdDown = true;
		changeKey = true;
	}
	public void ChangeWerdLeft(){
		makeFalse ();
		changeWerdLeft = true;
		changeKey = true;
	}
	public void ChangeWerdRight(){
		makeFalse ();
		changeWerdRight = true;
		changeKey = true;
	}
	public void ChangeWerdAttack(){
		makeFalse ();
		changeWerdAttack = true;
		changeKey = true;
	}
	
	public void ChangeCazUp(){
		makeFalse ();
		changeCazUp = true;
		changeKey = true;
	}
	public void ChangeCazDown(){
		makeFalse ();
		changeCazDown = true;
		changeKey = true;
	}
	public void ChangeCazLeft(){
		makeFalse ();
		changeCazLeft = true;
		changeKey = true;
	}
	public void ChangeCazRight(){
		makeFalse ();
		changeCazRight = true;
		changeKey = true;
	}
	public void ChangeCazAttack(){
		makeFalse ();
		changeCazAttack = true;
		changeKey = true;
	}

	public void ChangePause(){
		makeFalse ();
		changePause = true;
		changeKey = true;
	}


	
	// Update is called once per frame
	public void OnGUI() {
		Event e = Event.current;
		if (changeKey && e.isKey) {
			if(changeWerdUp){
				werdUp = e.keyCode;
				GameObject WUBut = GameObject.Find("WUP");
				WUBut.GetComponentInChildren<Text>().text = "Move UP - "+ werdUp.ToString();
				changeWerdUp = false;
			}
			else if(changeWerdDown){

				werdDown = e.keyCode;
				GameObject WDBut = GameObject.Find("WDown");
				WDBut.GetComponentInChildren<Text>().text = "Move DOWN - "+ werdDown.ToString();

				changeWerdDown = false;
			}
			else if(changeWerdLeft){
				werdLeft = e.keyCode;
				GameObject WLBut = GameObject.Find("WLeft");
				WLBut.GetComponentInChildren<Text>().text = "Move LEFT - "+ werdLeft.ToString();
				changeWerdLeft = false;
			}
			else if(changeWerdRight){
				werdRight = e.keyCode;
				GameObject WRBut = GameObject.Find("WRight");
				WRBut.GetComponentInChildren<Text>().text = "Move RIGHT - "+ werdRight.ToString();
				changeWerdRight = false;
			}
			else if(changeWerdAttack){
				werdAttack = e.keyCode;
				GameObject WABut = GameObject.Find("WAttack");
				WABut.GetComponentInChildren<Text>().text = "Attack - "+ werdAttack.ToString();
				changeWerdAttack = false;
			}
			else if(changeCazUp){
				cazUp = e.keyCode;
				GameObject CUBut = GameObject.Find("CUP");
				CUBut.GetComponentInChildren<Text>().text = "Move UP - "+ cazUp.ToString();
				changeCazUp = false;
			}
			else if(changeCazDown){
				cazDown = e.keyCode;
				GameObject CDBut = GameObject.Find("CDown");
				CDBut.GetComponentInChildren<Text>().text = "Move DOWN - "+ cazDown.ToString();
				changeCazDown = false;
			}
			else if(changeCazLeft){
				cazLeft = e.keyCode;
				GameObject CLBut = GameObject.Find("CLeft");
				CLBut.GetComponentInChildren<Text>().text = "Move LEFT - "+ cazLeft.ToString();
				changeCazLeft = false;
			}
			else if(changeCazRight){
				cazRight = e.keyCode;
				GameObject CRBut = GameObject.Find("CRight");
				CRBut.GetComponentInChildren<Text>().text = "Move RIGHT - "+ cazRight.ToString();
				changeCazRight = false;
			}
			else if(changeCazAttack){
				cazAttack = e.keyCode;
				GameObject CABut = GameObject.Find("CAttack");
				CABut.GetComponentInChildren<Text>().text = "Attack - "+ cazAttack.ToString();
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
