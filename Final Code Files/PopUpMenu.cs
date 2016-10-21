using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour {
	public CanvasGroup popUp;

	void Awake(){
		popUp=GetComponent<CanvasGroup>();
	}
	
	// Use this for initialization
	public void EnableTheMenu () {
	
		popUp.alpha=1;
		popUp.interactable=true;
		popUp.blocksRaycasts=true;
		
	}
	
	public void DisableTheMenu () {
		popUp.alpha=0;
		popUp.interactable=false;
		popUp.blocksRaycasts=false;
	}
	
}