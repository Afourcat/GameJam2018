using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum resourceId
{
    JAR,
    PLANT,
    STONE,
    EYE
}

public enum resourceColor
{
    RED,
    BLUE,
    GREEN,
    YELLOW
}

public class ResourceManager : MonoBehaviour {

    private static string[] stringId = { "Jar", "Plant", "Stone", "Eye" };

    private static string[] stringColor = { "Red", "Blue", "Green", "Yellow" };

    public resourceId id;

    public resourceColor color;

    public string spritePath;

    public static GameObject createResource(resourceId id, resourceColor color, Vector3 pos)
    {
        GameObject obj = null;

        for (int i = 0; i < stringId.Length; i++)
            for (int y = 0; y < stringColor.Length; y++)
                if (i == (int)id && y == (int)color) {
                    GameObject prefab = Resources.Load<GameObject>("Resources/" + stringId[i] + "_" + stringColor[y]);
                    obj = Instantiate(prefab, pos, Quaternion.identity);
                    //obj.transform.position = pos;
                    ResourceManager self = obj.AddComponent<ResourceManager>();
                    //sr.sprite = Resources.Load <Sprite>("Visual/" + stringId[i] + "_" + stringColor[y]);
                    self.id = id;
                    self.color = color;
                    self.spritePath = "Visual/" + stringId[i] + "_" + stringColor[y];

                    return obj;
                }
        return obj;
    } 

    void Start () {
	}
	
}
