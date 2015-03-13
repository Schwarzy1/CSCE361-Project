using UnityEngine;
using System.Collections;

public class CharSelectMangerScript : MonoBehaviour {
	public bool isWerdRed=true;

	// Use this for initialization
	void Start () {
		//GameObject.Find("caz_b_highlight").transform.position.Set((float)225.16,(float)-32.82, 5);
		//GameObject.Find ("werd_r_highlight").transform.position.Set((float)216.25,(float)-32.32,5);
		//GameObject.Find("caz_r_highlight").transform.position.Set((float)225.16,(float)-32.82, -5);
		//GameObject.Find ("werd_b_highlight").transform.position.Set((float)216.25,(float)-32.32,-5);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown(KeyCode.A) && !isWerdRed) {
			GameObject.Find("caz_b_highlight").transform.Translate(0,0, -5);
			GameObject.Find ("werd_r_highlight").transform.localPosition.Set(0,0,-5);
			GameObject.Find("caz_r_highlight").transform.localPosition.Set(0,0, 5);
			GameObject.Find ("werd_b_highlight").transform.localPosition.Set(0,0,5);
			isWerdRed=false;
		}
		if (Input.GetKeyDown(KeyCode.B) && isWerdRed) {
			GameObject.Find("caz_b_highlight").transform.position.Set((float)225.16,(float)-32.82, -5);
			GameObject.Find ("werd_r_highlight").transform.position.Set((float)216.25,(float)-32.32,-5);
			GameObject.Find("caz_r_highlight").transform.position.Set((float)225.16,(float)-32.82, 5);
			GameObject.Find ("werd_b_highlight").transform.position.Set((float)216.25,(float)-32.32,5);
			isWerdRed=true;

		}
	}
}
