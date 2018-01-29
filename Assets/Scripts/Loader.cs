using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    private GameObject[] resources;

    private void Start()
    {
        resources = new GameObject[4];

        resources[0] = ResourceManager.createResource(resourceId.EYE, resourceColor.BLUE, new Vector3(10, 10, 1));
        resources[1] = ResourceManager.createResource(resourceId.JAR, resourceColor.BLUE, new Vector3(5, 10, 1));
        resources[2] = ResourceManager.createResource(resourceId.PLANT, resourceColor.BLUE, new Vector3(10, 5, 1));
        resources[3] = ResourceManager.createResource(resourceId.STONE, resourceColor.BLUE, new Vector3(5, 5, 1));


    }
}
