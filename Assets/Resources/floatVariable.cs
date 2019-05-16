using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/float")]
public class floatVariable : ScriptableObject
{

	[SerializeField] private float value;
	// Use this for initialization
	public float Value
	{
		get { return value; }
		set { this.value = value; }
	}
}
