using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public string levelToLoad = "Town";
	

	public void LoadTheLevel(){
		SceneManager.LoadScene(levelToLoad);
	}
	
}