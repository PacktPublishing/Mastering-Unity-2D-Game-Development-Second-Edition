using UnityEngine;
using System.Collections;

public class KeepAround : MonoBehaviour {
	
	void Update (){ 

		DontDestroyOnLoad(gameObject);

	}	
	
}