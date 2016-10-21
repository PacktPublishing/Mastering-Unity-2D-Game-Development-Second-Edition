using UnityEngine;
using UnityEngine.UI;

public class ShopSlot : MonoBehaviour
{
    public InventoryItem Item;
    public ShopManager Manager;
    Image image;
    Text name;
    public CanvasGroup buyButton;

    public void ItemSelected()
    {
        if (Item != null)
        {
            Manager.SetShopSelectedItem(this);

			if(buyButton.alpha==0){
	        	buyButton.alpha=1;
	        	buyButton.interactable=true;
	        	buyButton.blocksRaycasts=true;
        	}
        }
    }

    public void AddShopItem(InventoryItem item)
    {
		image =transform.GetChild(0).GetComponent<Image>();
        image.sprite = item.itemImage;
        Item = item;

        name=transform.GetChild(1).GetComponent<Text>();
        name.text=item.itemName;

    }

    public void PurchaseItem()
    {
        GameState.currentPlayer.AddinventoryItem(Item);
    }

}
