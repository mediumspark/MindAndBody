#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DeckManager))]
public class DeckManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("To Deck")) DeckManager.instance.AddToDeck(); 
        if(GUILayout.Button("To Mind")) DeckManager.instance.CommitToMind();  
        if(GUILayout.Button("To Body")) DeckManager.instance.CommitToBody();
    }
}

#endif