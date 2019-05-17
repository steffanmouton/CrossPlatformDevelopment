using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehaviour : MonoBehaviour {
	[SerializeField] private AgentBehaviour _agentBehaviour;
	[SerializeField] private float fleeSpeed = 5.0f;
	[SerializeField] private float MAX_SPEED = 1.0f;
	[SerializeField] private float safeDistance = 10.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var distance = _agentBehaviour.TargetTransform.position - transform.position;
		var direction = distance.normalized;
		var force = direction * fleeSpeed;
		
		if (force.magnitude > MAX_SPEED)
		{
			force = force.normalized * MAX_SPEED;
		}
		_agentBehaviour.transform.LookAt(-1 * _agentBehaviour.TargetTransform.position, Vector3.back);
		_agentBehaviour.AddForce(-force);
	}
}
