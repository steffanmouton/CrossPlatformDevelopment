using System.Collections;
using System.Collections.Generic;
using Resources.Items;
using UnityEngine;

public class LootTableBehaviour : MonoBehaviour {

	public InventoryScriptable lootTable;
	public GameObject ItemPrefab;
	public List<ItemScriptable> RolledLoot;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RollLoot()
	{
		foreach (var item in lootTable.Items)
		{
			var i = Instantiate(ItemPrefab);			
			i.transform.position = transform.position + Vector3.up;
			i.transform.localScale *= 2;
			i.GetComponent<ItemBehaviour>().Item = item;
			i.GetComponent<SpriteRenderer>().sprite = item.Display;
			i.GetComponent<Rigidbody>().AddForce(Random.onUnitSphere.x * 100, 0, Random.onUnitSphere.z * 100);
			RolledLoot.Add(item);
		}
	}
}
