using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public class Inventory : MonoBehaviour
{
    
    public List<GameObject> items = new List<GameObject>();

   
    public void AddItem(GameObject item)
    {
        items.Add(item);
        Debug.Log("Item added to inventory: " + item.name);
    }

    
}
