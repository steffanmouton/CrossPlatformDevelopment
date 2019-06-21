using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketballControllerBehaviour : MonoBehaviour
{

	public GameObject bball;

	public Vector3 shootForce;
	public int Score;
	public Text scoreView;
	// Use this for initialization
	void Start ()
	{
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			ShootIt();
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			ShootIt();
		}
	}

	public void ShootIt()
	{
		var ballInstance = Instantiate(bball);
		var ballRB = ballInstance.GetComponent<Rigidbody>();
		
		ballInstance.transform.position = transform.position + Vector3.forward * 10;
		ballRB.AddForce(shootForce);
	}
}
