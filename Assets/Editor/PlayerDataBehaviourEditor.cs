using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEditor;
using UnityEngine;

// As per the assignment, this is an Editor script that shows how to create custom editor functionality
// without breaking the build via the use of placing the file within an 'Editor' folder. Unity knows
// to keep this in a separate project assembly.
[CustomEditor(typeof(PlayerDataBehaviour))]
public class PlayerDataBehaviourEditor : Editor
{
	public override void OnInspectorGUI()
	{
		// Draws the standard UI
		base.OnInspectorGUI();
		
		// Adds a button below the standard UI. It merely prints to the console
		if (GUILayout.Button("Click to Debug"))
		{
			Debug.Log("This Player Button works.");
		}
	}
}
