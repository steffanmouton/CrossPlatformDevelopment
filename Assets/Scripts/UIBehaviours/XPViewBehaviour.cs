using System;
using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class XPViewBehaviour : MonoBehaviour
{
	// References to the Text box values that show up on the Canvas in Unity
	public Text xpView;
	public Text levelView;
	
	// Reference to a global ScriptableObject so that the UI can read the data without interacting
	// with the player class directly
	public PlayerDataVariable pdRef;

	// Unity Event, called every frame.
	private void Update()
	{
		// Sets the two text box values to the player's current XP and level, as held by the
		// Player Data Variable reference
		xpView.text = "XP: " + pdRef.xpRef.Value;
		levelView.text = "Level: " + pdRef.levelRef.Value;
	}

}

// As per the assignment, this is an Editor script that shows how to create custom editor functionality
// without breaking the build via the use of Pre-processing Directives
#if UNITY_EDITOR
[CustomEditor(typeof(XPViewBehaviour))]
public class XPViewBehaviourEditor : Editor
{
	public override void OnInspectorGUI()
	{
		// Draws the standard UI
		base.OnInspectorGUI();
		
		// Adds a button below the standard UI. It merely prints to the console
		if (GUILayout.Button("Click to Debug"))
		{
			Debug.Log("This XPView Button works.");
		}
	}
}
#endif