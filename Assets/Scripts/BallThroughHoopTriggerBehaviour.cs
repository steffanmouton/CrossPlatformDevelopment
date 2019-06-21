using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallThroughHoopTriggerBehaviour : MonoBehaviour
{
	public BasketballControllerBehaviour bbController;
	public Text scoreView;
	public GameObject scoresplosion;
	
	public void OnTriggerEnter(Collider other)
	{
		
		if (!other.gameObject.CompareTag("Ball"))
			return;

		Instantiate(scoresplosion);
		scoresplosion.transform.position = transform.position;
		bbController.Score++;
		scoreView.text = "Score: " + bbController.Score;

	}
}
