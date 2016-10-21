using UnityEditor;
using UnityEngine;
public class MyMenu
{
    // Add a menu item named MenuItem1 to a Menu option called MenuName in the menu bar.

    [MenuItem("MenuName/MenuItem1")]
    static void EnableMyAwesomeFeature()
    {
        Debug.Log("I am a leaf on the wind. Watch how I soar.");
    }

    // Add a menu item named MenuItem2 to a Menu option called MenuName in the menu bar.
    // Using a validator to enable it.

    [MenuItem("MenuName/MenuItem1", true)]
    static bool CheckifaGameObjectisselected()
    {
        // Return false if no transform is selected.
        return Selection.activeTransform != null;
    }

    [MenuItem("MenuName/MenuItem2 %g")]
    static void EnableMyOtherAwesomeFeature()
    {
        Debug.Log("Find my key and wind the prize - g");
    }

    [MenuItem("CONTEXT/Transform/Move to Center")]
    static void MoveToCenter(MenuCommand command)
    {
        Transform transform = (Transform)command.context;
        transform.position = Vector3.zero;
        Debug.Log("Moved obejct to " + transform.position + " from a Context Menu.");
    }

}

