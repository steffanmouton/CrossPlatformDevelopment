﻿using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class PlayerCollidesWithItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!other.gameObject.CompareTag("Item"))
			return;
		
		GetComponent<PlayerBehaviour>().Inventory.AddToItems(
			other.gameObject.GetComponent<ItemBehaviour>().Item
			);
		
		Destroy(other.gameObject);
	}
}
