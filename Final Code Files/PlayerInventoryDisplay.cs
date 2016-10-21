using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour{

public Button invPrefab;

    void Start() {

        foreach (var item in GameState.currentPlayer.Inventory)
        {
        	Button inventoryChild = (Button) Instantiate(invPrefab,Vector3.zero, Quaternion.identity);
        	inventoryChild.transform.parent=transform;
        	inventoryChild.GetComponent<Image>().sprite=item.itemImage;
        }
    }

}

