using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolderManager : MonoBehaviour {

    public GameObject resource;
	public int nbRessources;

    public GameObject createInstance() {
        return Instantiate(resource, resource.transform.position, Quaternion.identity);
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
