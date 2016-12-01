using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationPrompt : MonoBehaviour {

public Vector3 startingPosition;

  void OnCollisionEnter2D(Collision2D col){
	if(NavigationManager.CanNavigate(this.tag)){
  		Debug.Log("attempting to exit via "+ tag);
		NavigationManager.NavigateTo(this.tag);

		GameState.saveLastPosition=false;
		GameState.SetLastScenePosition(SceneManager.GetActiveScene().name, startingPosition);
  	}
  }
  void OnTriggerEnter2D(Collider2D col){
	if(NavigationManager.CanNavigate(this.tag)){
  		Debug.Log("attempting to exit via "+ tag);
		NavigationManager.NavigateTo(this.tag);

		GameState.saveLastPosition=false;
		GameState.SetLastScenePosition(SceneManager.GetActiveScene().name, startingPosition);
  	}
  }
}