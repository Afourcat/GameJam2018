using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject player;


    void Start ()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
	}
	
    void Update ()
    {
        if (player.transform.position.z > -90 && player.transform.position.z < 2)
            transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
	}
}
