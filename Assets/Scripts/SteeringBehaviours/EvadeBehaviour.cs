using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvadeBehaviour : MonoBehaviour {
	[SerializeField] private AgentBehaviour ab;

	[SerializeField] private floatVariable MAX_SPEED;

	[SerializeField] private float seekSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		var distance = ab.TargetTransform.position - transform.position;
		var T = distance.magnitude / MAX_SPEED.Value;
		var futurePosition = ab.TargetTransform.position + ab.TargetObjectBhv.moveVector * T;

		distance = futurePosition - transform.position;
		var direction = distance.normalized;
		var force = direction * seekSpeed;

		if (force.magnitude > MAX_SPEED.Value)
		{
			force = force.normalized * MAX_SPEED.Value;
		}

		ab.transform.LookAt(futurePosition, Vector3.back);
		ab.AddForce(force * -1);
	}
}
