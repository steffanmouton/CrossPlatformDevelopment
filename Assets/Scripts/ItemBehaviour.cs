using System.Collections;
using System.Collections.Generic;
using Resources.Items;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public ItemScriptable Item;

    private void Start()
    {
        tag = "Item";
    }
}