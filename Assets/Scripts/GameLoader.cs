using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public bool in_game = false;

    public GameObject grimmoire;

	// Use this for initialization
	void Start () {
        in_game = true;
        GameObject book = Instantiate(grimmoire, new Vector3(0, 0, 1), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
