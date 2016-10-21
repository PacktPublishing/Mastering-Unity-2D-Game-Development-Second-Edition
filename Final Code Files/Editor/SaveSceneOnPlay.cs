using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class SaveSceneOnPlay
{

    // Static class constructor, this is initialized as soon as Unity Starts
    static SaveSceneOnPlay()
    {
        EditorApplication.playmodeStateChanged += SaveSceneIfPlaying;
    }

    //Handler to save the scene and associated assets when user hits play button
    static void SaveSceneIfPlaying()
    {
        if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
        {

            Debug.Log("Automaticly saving scene (" + EditorApplication.currentScene + ") before entering play mode ");

            EditorApplication.SaveAssets();
            EditorApplication.SaveScene();
        }
    }

    //Dispose method that will need calling by the project to clean up when the editor is closed.
    //Needs to be called from any other traditional editor scripts OnDestroy() method.
    //(optional but recommended)
    static void Dispose()
    {
        EditorApplication.playmodeStateChanged -= SaveSceneIfPlaying;
    }
}