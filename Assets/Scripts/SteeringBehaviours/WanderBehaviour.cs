using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBehaviour : MonoBehaviour
{
	[Header("Wander Circle Attributes")]
	[SerializeField] private Vector3 wanderCircleCenter;
	[SerializeField] private floatVariable wanderCircleDistance;
	[SerializeField] private Vector3 displacement;
	
	[Header("Agent References")]
	[SerializeField] private AgentBehaviour ab;
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var randomUnitSphere = Random.insideUnitSphere;
		wanderCircleCenter = ab.velocity.normalized * wanderCircleDistance.Value;
		displacement = new Vector3(randomUnitSphere.x, randomUnitSphere.y,0);
		
		var wanderForce = wanderCircleCenter + displacement;
		ab.transform.LookAt(ab.velocity, Vector3.back);
		ab.AddForce(wanderForce);
	}
}
