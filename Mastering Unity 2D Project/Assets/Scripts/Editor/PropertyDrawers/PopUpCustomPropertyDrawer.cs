using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(PopUpAttribute))]
public class PopUpCustomPropertyDrawer : PropertyDrawer {

    PopUpAttribute popUpAttribute { get { return ((PopUpAttribute)attribute); } }

    public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
    {
        if (prop.propertyType != SerializedPropertyType.String)
        {
            throw new UnityException("property " + prop + " must be string to use with DropdownSubtypesOf");
        }

        var popupRect = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var currentItem = prop.stringValue;
        var currentIndex = popUpAttribute.value.Length - 1;
        for (; currentIndex >= 0; currentIndex--)
        {
            if (popUpAttribute.value[currentIndex] == currentItem) break;
        }

        int selectedIndex = EditorGUI.Popup(popupRect, currentIndex, popUpAttribute.value);
        prop.stringValue = selectedIndex < 0 ? "" : popUpAttribute.value[selectedIndex];
    }
}



