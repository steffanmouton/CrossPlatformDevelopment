using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBehaviour : MonoBehaviour
{
	[SerializeField] private Transform targetTransform;
	[SerializeField] private InputBehaviour targetObjectBhv;
	[SerializeField] public Vector3 velocity;
	[SerializeField] private floatVariable MAX_SPEED;
	

	public Vector3 spawnPosition;

	public Transform TargetTransform
	{
		get { return targetTransform; }
	}
	
	public InputBehaviour TargetObjectBhv
	{
		get { return targetObjectBhv; }
	}

	// Use this for initialization
	void Start ()
	{
		spawnPosition = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
/// <summary>
/// debug.drawlines in update
/// </summary>
	private void LateUpdate()
	{
		if (velocity.magnitude > MAX_SPEED.Value)
		{
			velocity = velocity.normalized * MAX_SPEED.Value;
		}
		transform.position += velocity * Time.deltaTime;
		
	}

	public void AddForce(Vector3 force)
	{
		velocity += force;
	}
}
