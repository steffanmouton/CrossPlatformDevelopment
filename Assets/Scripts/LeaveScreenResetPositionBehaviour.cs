using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveScreenResetPositionBehaviour : MonoBehaviour
{
	[SerializeField] private AgentBehaviour ab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (
			transform.position.x > 188 || transform.position.x < -188 ||
			transform.position.y > 100 || transform.position.y < -100)
		{
			transform.position = ab.spawnPosition;
		}
	}
}
