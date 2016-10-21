using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour {

    public Image PurchaseItemDisplay;
    public ShopSlot[] ItemSlots;
    public InventoryItem[] ShopItems;
    private static ShopSlot SelectedShopSlot;

    private int nextSlotIndex = 0;
    public Text shopKeeperText;
    public Vector3 storeFrontPosition;

    GameObject soundEffectsSource;
    public AudioClip buySound;

    void Awake(){
    	soundEffectsSource=GameObject.FindGameObjectWithTag("Sound");
    }

	// Use this for initialization
	void Start () {
        if (ItemSlots.Length > 0 && ShopItems.Length > 0)
        {
            for (int i = 0; i < ShopItems.Length; i++)
			{
                if (nextSlotIndex > ItemSlots.Length) break;
                ItemSlots[nextSlotIndex].AddShopItem(ShopItems[i]);
                ItemSlots[nextSlotIndex].Manager = this;
                nextSlotIndex++;
			}
        }
	}

   public void SetShopSelectedItem(ShopSlot slot)
    {
        SelectedShopSlot = slot;
        PurchaseItemDisplay.sprite = slot.Item.itemImage;
        shopKeeperText.text=" ";
    }


    public static void PurchaseSelectedItem()
    {
        SelectedShopSlot.PurchaseItem();
    }

	public void ConfirmPurchase(){
    	PurchaseSelectedItem();

    	shopKeeperText.text="Thanks!";

		if(soundEffectsSource!=null){
			soundEffectsSource.GetComponent<AudioSource>().PlayOneShot(buySound);
		}
			
															
    }

    public void LeaveTheShop(){
		NavigationManager.NavigateTo("Town");
    }
}