using UnityEngine;
using System.Collections;

public class cameraHandler : MonoBehaviour {

	float up = 7.2f;
	float down = -7.2f;
	float left = 12.8f;
	float right = -12.8f;
	float x;
	float y;
	float z = -10f;
	float t = 0;
	bool moving = false;
	Vector3 targetPos;
	Vector3 currentPos;

	// Use this for initialization
	void Start () {
		x = transform.position.x;
		y = transform.position.y;
		currentPos = new Vector3 (x, y, z);
		targetPos = new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		x = transform.position.x;
		y = transform.position.y;
		if (moving == true) {
			transform.position = Vector3.Lerp(currentPos ,targetPos, t);
			t += 0.2f;
		}
		if (t >= 1.2f) {
			moving = false;
			currentPos = new Vector3(targetPos.x,targetPos.y,z);
			t = 0f;
		}
	}

	public void MoveUp(){
		targetPos = new Vector3 (x,y+up,z);
		moving = true;
	}
	public void MoveDown(){
		targetPos = new Vector3 (x,y+down,z);
		moving = true;
	}
	public void MoveLeft(){
		targetPos = new Vector3 (x+left,y,z);
		moving = true;
	}
	public void MoveRight(){
		targetPos = new Vector3 (x+right,y,z);
		moving = true;
	}
}
