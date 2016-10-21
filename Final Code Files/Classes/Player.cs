using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : Entity{
	public List<InventoryItem> Inventory = new List<InventoryItem>();
  	public string[] skills;
  	public int money;

	public void AddinventoryItem(InventoryItem item){
  		Inventory.Add(item);
  	}

}
