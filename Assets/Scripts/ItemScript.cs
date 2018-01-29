using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {

    private GameObject resource;

    public GameObject Resource
    {
        get
        {
            return resource;
        }

        set
        {
            resource = value;
        }
    }

    private void Start()
    {
        resource = null;
    }
}
