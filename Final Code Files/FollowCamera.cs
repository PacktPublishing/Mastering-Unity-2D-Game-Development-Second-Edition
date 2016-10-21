using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	// Distance in the x axis the player can move before the camera follows.
    public float xOffset = 0f;
    // Distance in the y axis the player can move before the camera follows.
    public float yOffset = 0f;
   
    // Reference to the player's transform.
    public Transform player;


 
	void LateUpdate() {
		this.transform.position = new Vector3(player.transform.position.x + xOffset, this.transform.position.y + yOffset, -10);
	}

}
