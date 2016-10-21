using UnityEngine;
using System.Collections;

public class Sorting : MonoBehaviour {

	public Transform player;

	// Update is called once per frame
	void Update () {
		if(transform.position.y>=player.transform.position.y){
			GetComponent<SpriteRenderer>().sortingOrder=(player.GetComponent<SpriteRenderer>().sortingOrder)-1;
			GetComponents<BoxCollider2D>()[1].enabled=false;
			GetComponents<BoxCollider2D>()[2].enabled=true;
		}

		if(transform.position.y<player.transform.position.y){
			GetComponent<SpriteRenderer>().sortingOrder=(player.GetComponent<SpriteRenderer>().sortingOrder)+1;
			GetComponents<BoxCollider2D>()[1].enabled=true;
			GetComponents<BoxCollider2D>()[2].enabled=false;
		}
	}
}
