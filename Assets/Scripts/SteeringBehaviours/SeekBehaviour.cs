using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekBehaviour : MonoBehaviour
{
	[SerializeField] private AgentBehaviour _agentBehaviour;
	[SerializeField] private float seekSpeed = 5.0f;
	[SerializeField] private float MAX_SPEED = 1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var distance = _agentBehaviour.TargetTransform.position - transform.position;
		var direction = distance.normalized;
		var force = direction * seekSpeed;
		
		if (force.magnitude > MAX_SPEED)
		{
			force = force.normalized * MAX_SPEED;
		}
		_agentBehaviour.transform.LookAt(_agentBehaviour.TargetTransform, Vector3.back);
		_agentBehaviour.AddForce(force);
	}
}
