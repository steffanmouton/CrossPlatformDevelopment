using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBehaviour : MonoBehaviour {
	
	public GameObject Deathsplosion;
	private void OnTriggerEnter(Collider other)
	{
		if (!other.CompareTag("Player"))
			return;

		var loot = GetComponent<LootTableBehaviour>();
		loot.RollLoot();
		
		var exp = Instantiate(Deathsplosion);
		exp.transform.position = transform.position + Vector3.up;
		var ps = exp.GetComponent<ParticleSystem>().main.duration;
		Destroy(exp, ps);
		Destroy(gameObject);
	}
}