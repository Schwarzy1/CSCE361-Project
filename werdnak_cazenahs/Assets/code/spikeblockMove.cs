using UnityEngine;
using System.Collections;

public class spikeblockMove : MonoBehaviour {
	public bool direction = true;
	public float distance = 30;
	float speed = .01f;
	float i = 0;
	float a = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!UIManagerScript.paused) {
			if (i > distance) {
				a = -1;
			}
			if (i < -1 * distance) {
				a = 1;
			}
			if (direction == true) {
				transform.Translate (0, a * speed, 0);
			}
			if (direction == false) {
				transform.Translate (a * speed, 0, 0);
			}
			i += a;
		}
	}
}
