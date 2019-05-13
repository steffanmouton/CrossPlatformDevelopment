using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBehaviour : MonoBehaviour
{
	[SerializeField] private Transform targetTransform;
	[SerializeField] private GameObject targetGameObject;
	[SerializeField] private Vector3 velocity;

	public Transform TargetTransform
	{
		get { return targetTransform; }
	}

	// Use this for initialization
	void Start () {
		
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
		transform.position += velocity * Time.deltaTime;
	}

	public void AddForce(Vector3 force)
	{
		velocity += force;
	}
}
