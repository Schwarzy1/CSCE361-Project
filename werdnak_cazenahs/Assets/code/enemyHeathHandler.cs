using UnityEngine;
using System.Collections;

public class enemyHeathHandler : MonoBehaviour {

	public int health = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.name.Equals("Werd") && other.gameObject.GetComponent<werdnakMove>().attacking == true){
			health -= 2;
		}else if (other.gameObject.tag.Equals("cazLazer")){
			health -= 1;
		}
		if(health <= 0){
			Destroy(gameObject);
		}
	}

}
