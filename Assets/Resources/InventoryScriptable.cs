using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryScriptable : ScriptableObject
{
	public List<ItemScriptable> Items;

	public void AddToItems(ItemScriptable item)
	{
		Items.Add(item);
	}

	public void RemoveFromItems(ItemScriptable item)
	{
		Items.Remove(item);
	}
	
}
