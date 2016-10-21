using UnityEngine;
using UnityEditor;

public class InventoryItemAssetCreator : MonoBehaviour {

    [MenuItem("Assets/Create/Inventory Item")]
    public static void CreateAsset()
    {
        CustomAssetUtility.CreateAsset<InventoryItem>();
    }
}
