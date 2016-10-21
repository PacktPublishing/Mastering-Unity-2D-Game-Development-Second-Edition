using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MapPosition : MonoBehaviour {

	void Awake(){
		var lastPosition = GameState.GetLastScenePosition(SceneManager.GetActiveScene().name);

	    if (lastPosition != Vector3.zero){
	        transform.position = lastPosition;
	    }
	}

	void OnDestroy()
	{
		if(GameState.saveLastPosition){
				GameState.SetLastScenePosition(SceneManager.GetActiveScene().name, transform.position);
		}
    	
	}


}
