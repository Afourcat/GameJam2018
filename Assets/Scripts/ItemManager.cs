using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	public static GameObject createItem(GameObject resource, Vector3 pos)
    {
        GameObject gobj = GameObject.Find("Item");
        GameObject obj = Instantiate(gobj, pos, Quaternion.identity);
        obj.GetComponent<ItemScript>().Resource = resource;
        return obj;
    }
}
