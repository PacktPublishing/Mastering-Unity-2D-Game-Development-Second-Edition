using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RandomBattle : MonoBehaviour {

public int battleProbability;
int encounterChance=100;

public int secondsBetweenBattles;

public string battleSceneName;
	
	void OnTriggerEnter2D(Collider2D col){
		if(!GameState.justExitedBattle){
			encounterChance=Random.Range(1,100);
			if(encounterChance>battleProbability){
				StartCoroutine(RecalculateChance());
			}
		}else{
			StartCoroutine(RecalculateChance());
			GameState.justExitedBattle=false;
		}

	}

	IEnumerator RecalculateChance(){
  		while (encounterChance>battleProbability){
			yield return new WaitForSeconds(secondsBetweenBattles);
			GameState.saveLastPosition=true;
			encounterChance=Random.Range(1,100);
  		}
  	}

	void OnTriggerStay2D(Collider2D col){
		if(encounterChance<=battleProbability){
			Debug.Log("Battle");
			SceneManager.LoadScene(battleSceneName);
		}
  	}

  	void OnTriggerExit2D(Collider2D col){
  		encounterChance=100;
		StopCoroutine(RecalculateChance());
  	}

}
