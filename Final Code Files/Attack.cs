using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attack : MonoBehaviour {

	public bool attackSelected=false;
	public int hitAmount=0;
	public Button smack;
	public Button wack;
	public Button kick;
	public Button chop;

	public void Smack(){
		hitAmount=5;
		AttackTheEnemy();
		HighlightTheButton();
	}

	public void Wack(){
		hitAmount=10;
		AttackTheEnemy();
		HighlightTheButton();
	}

	public void Kick(){
		hitAmount=15;
		AttackTheEnemy();
		HighlightTheButton();
	}

	public void Chop(){
		hitAmount=20;
		AttackTheEnemy();
		HighlightTheButton();
	}

	public void AttackTheEnemy(){
		attackSelected=true;

	}

	void HighlightTheButton(){
		if(hitAmount==5){
			smack.GetComponent<Outline>().enabled=true;
		}else{
			smack.GetComponent<Outline>().enabled=false;
		}

		if(hitAmount==10){
			wack.GetComponent<Outline>().enabled=true;
		}else{
			wack.GetComponent<Outline>().enabled=false;
		}

		if(hitAmount==15){
			kick.GetComponent<Outline>().enabled=true;
		}else{
			kick.GetComponent<Outline>().enabled=false;
		}

		if(hitAmount==20){
			chop.GetComponent<Outline>().enabled=true;
		}else{
			chop.GetComponent<Outline>().enabled=false;
		}

	}

}
