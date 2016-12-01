using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {
	public string sceneToLoadName;
	public int timeToLoad;


	void Start () {	
		Invoke("NextScene", timeToLoad);
	}
	
	void NextScene () {
		SceneManager.LoadScene(sceneToLoadName);
	}
}