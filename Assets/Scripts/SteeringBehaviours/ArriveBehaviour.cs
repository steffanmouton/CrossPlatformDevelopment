using System;
using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

public class ArriveBehaviour : MonoBehaviour
{
	[SerializeField] private AgentBehaviour ab;

	[SerializeField] private floatVariable slowingRadius;

	[SerializeField] private floatVariable MAX_VELOCITY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var desiredVelocity = ab.TargetTransform.position - transform.position;
		var distance = desiredVelocity.magnitude;
		
		if (distance < slowingRadius.Value)
		{
			desiredVelocity = desiredVelocity.normalized * MAX_VELOCITY.Value * (distance / slowingRadius.Value);
		}
		else
		{
			desiredVelocity = desiredVelocity.normalized * MAX_VELOCITY.Value;
		}
		
		ab.AddForce(desiredVelocity - ab.velocity);
	}
}
