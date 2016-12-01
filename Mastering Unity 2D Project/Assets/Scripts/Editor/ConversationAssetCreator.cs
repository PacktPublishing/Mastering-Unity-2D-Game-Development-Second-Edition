using UnityEditor;
using UnityEngine;

public class ConversationAssetCreator : MonoBehaviour {

    [MenuItem("Assets/Create/Conversation")]
    public static void CreateAsset()
    {
        CustomAssetUtility.CreateAsset<Conversation>();
    }
}
