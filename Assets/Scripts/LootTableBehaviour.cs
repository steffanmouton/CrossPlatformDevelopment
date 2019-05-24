using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTableBehaviour : MonoBehaviour {

	public LootTableScriptable lootTable;
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
			RolledLoot.Add(item);
		}
	}
}
