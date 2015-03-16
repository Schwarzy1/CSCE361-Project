using UnityEngine;
using System.Collections;

public class roomHandler : MonoBehaviour {
	GameObject[] gos;
	float currentRoomX;
	float currentRoomY;
	GameObject caz;
	GameObject werd;
	cameraHandler camHand;
	float z = -3;
	// Use this for initialization
	void Start () {
		camHand = GameObject.Find("Main Camera").GetComponent<cameraHandler>();
		currentRoomX = 0;
		currentRoomY = 0;
		caz = GameObject.Find ("Caz");
		werd = GameObject.Find ("Werd");
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void UnloadAssets(string assets){
		gos = GameObject.FindGameObjectsWithTag(assets);
		foreach (GameObject go in gos) {
			go.SetActive(false);
		}
	}
	void LoadAssets(string assets){
		gos = GameObject.FindGameObjectsWithTag(assets);
		foreach (GameObject go in gos) {
			go.SetActive(true);
		}
	}

	
	
	public void MoveUp(){
		currentRoomY += 7.2f;
		caz.transform.position = new Vector3 (currentRoomX+1, currentRoomY-2.5f, z);
		werd.transform.position = new Vector3 (currentRoomX-1, currentRoomY-2.5f, z);
		camHand.MoveUp ();
	}
	public void MoveDown(){
		currentRoomY -= 7.2f;
		caz.transform.position = new Vector3 (currentRoomX+1, currentRoomY+2.5f, z);
		werd.transform.position = new Vector3 (currentRoomX-1, currentRoomY+2.5f, z);
		camHand.MoveDown ();
	}
	public void MoveLeft(){
		currentRoomX += 12.8f;
		caz.transform.position = new Vector3 (currentRoomX-5, currentRoomY+1, z);
		werd.transform.position = new Vector3 (currentRoomX-5, currentRoomY-1, z);
		camHand.MoveLeft ();
	}
	public void MoveRight(){
		currentRoomX -= 12.8f;
		caz.transform.position = new Vector3 (currentRoomX+5, currentRoomY+1, z);
		werd.transform.position = new Vector3 (currentRoomX+5, currentRoomY-1, z);
		camHand.MoveRight ();
	}

}
