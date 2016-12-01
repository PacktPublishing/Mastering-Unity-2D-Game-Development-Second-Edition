using UnityEditor;
using UnityEngine;

public class MyEditorWindow : EditorWindow
{
    string windowName = "My Editor Window";
    bool groupEnabled;
    bool DisplayToggle = true;
    float Offset = 1.23f;

    void OnEnable()
    {
        //Event / delegate registration, usually put in the OnEnable or other function
        EditorApplication.hierarchyWindowChanged += HierarchyWindowChanged;
    }

    //call back function for when event occurs
    void HierarchyWindowChanged()
    {
        //Scan hierarchy for new items
        //If found add something to the editor window
    }

    void OnDestroy()
    {
        //Dont forget to unregister the delegate when it goes out of scope or is not needed
        EditorApplication.hierarchyWindowChanged -= HierarchyWindowChanged;
    }


    [MenuItem("Window/My Editor Window")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindowWithRect(typeof(MyEditorWindow), new Rect(0, 0, 400, 150));
    }

    void OnGUI()
    {
        // Your custom Editor Window GUI code
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        windowName = EditorGUILayout.TextField("Window Name", windowName);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        DisplayToggle = EditorGUILayout.Toggle("Display Toggle", DisplayToggle);
        Offset = EditorGUILayout.Slider("Offset Slider", Offset, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }

} 

