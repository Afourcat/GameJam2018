using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum buttonId
{
    X,
    Y,
    B,
    A
}

//Item.getComponent<SpriteRenderer>();
//Item.resources[Id, MeshRenderer, Color, Type];

public class InventoryManager : MonoBehaviour {

    public GameObject[] items = new GameObject[4];

    public GameObject x;
    public GameObject y;
    public GameObject b;
    public GameObject a;


    private Sprite my_sprite;

	void Start ()
    {
        for (int i = 0; i < 4; i++)
        {
            items[i] = null;
        }
    }

    public void AddItem(GameObject obj, buttonId id)
    {
        items[(int) id] = obj;
        my_sprite = Resources.Load<Sprite>("Sprites/recipe_items/" + obj.GetComponent<ResourceManager>().id + "_" + obj.GetComponent<ResourceManager>().color);

        for (int i = 0; i < 4; i++)
        {
            if (i == (int) id)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (y == (int) id)
                    {
                        if (i == (int) buttonId.X)
                        {
                            GameObject.FindGameObjectWithTag("X").GetComponent<Image>().sprite = my_sprite;
                            GameObject.FindGameObjectWithTag("X").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                        }
                        if (i == (int) buttonId.Y)
                        {
                            GameObject.FindGameObjectWithTag("Y").GetComponent<Image>().sprite = my_sprite;
                            GameObject.FindGameObjectWithTag("Y").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                        
                        }
                        if (i == (int) buttonId.B)
                        {
                            GameObject.FindGameObjectWithTag("B").GetComponent<Image>().sprite = my_sprite;
                            GameObject.FindGameObjectWithTag("B").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                        
                        }
                        if (i == (int) buttonId.A)
                        {
                            GameObject.FindGameObjectWithTag("A").GetComponent<Image>().sprite = my_sprite;
                            GameObject.FindGameObjectWithTag("A").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                        
                        }
                    }
                }
            }
        }
    }
}
