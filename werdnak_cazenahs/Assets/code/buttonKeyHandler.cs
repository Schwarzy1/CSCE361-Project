using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonKeyHandler : MonoBehaviour {

	keyBindHandler keys;
	// Use this for initialization
	void Start () {
		keys = GameObject.Find ("KeyBindHandler").GetComponent<keyBindHandler>();
		
		GameObject WUBut = GameObject.Find("WUP");
		WUBut.GetComponentInChildren<Text>().text = "Move UP - "+ keys.werdUp.ToString();

		GameObject WDBut = GameObject.Find("WDown");
		WDBut.GetComponentInChildren<Text>().text = "Move DOWN - "+ keys.werdDown.ToString();

		GameObject WLBut = GameObject.Find("WLeft");
		WLBut.GetComponentInChildren<Text>().text = "Move LEFT - "+ keys.werdLeft.ToString();

		GameObject WRBut = GameObject.Find("WRight");
		WRBut.GetComponentInChildren<Text>().text = "Move RIGHT - "+ keys.werdRight.ToString();

		GameObject WABut = GameObject.Find("WAttack");
		WABut.GetComponentInChildren<Text>().text = "Attack - "+ keys.werdAttack.ToString();

		GameObject CUBut = GameObject.Find("CUP");
		CUBut.GetComponentInChildren<Text>().text = "Move UP - "+ keys.cazUp.ToString();

		GameObject CDBut = GameObject.Find("CDown");
		CDBut.GetComponentInChildren<Text>().text = "Move DOWN - "+ keys.cazDown.ToString();

		GameObject CLBut = GameObject.Find("CLeft");
		CLBut.GetComponentInChildren<Text>().text = "Move LEFT - "+ keys.cazLeft.ToString();

		GameObject CRBut = GameObject.Find("CRight");
		CRBut.GetComponentInChildren<Text>().text = "Move RIGHT - "+ keys.cazRight.ToString();

		GameObject CABut = GameObject.Find("CAttack");
		CABut.GetComponentInChildren<Text>().text = "Attack - "+ keys.cazAttack.ToString();

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
