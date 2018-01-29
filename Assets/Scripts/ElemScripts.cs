using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElemScripts : MonoBehaviour {

    public int[] value = new int[2];

    public Sprite spriteElem;

    public Image img;

    private static float[] pospos = {4.5f - 1, 4.5f * 0.0f - 1, 4.5f * -1f - 1, 4.5f * -2f - 1, 0.0f};

    public static int w = 0;

    void Start()
    {
        value[0] = Random.Range(0, 4);
        value[1] = Random.Range(0, 4);

        for (int i = 0; i < 4; i++)
        {
            if (i == value[0])
            {
                for (int y = 0; y < 4; y++)
                {
                    if (y == value[1] && w < 4)
                    {
                        img.sprite = Resources.Load<Sprite>("Sprites/recipe_items/" + value[0].ToString() + "_" + value[1].ToString());
                        gameObject.transform.Translate(new Vector3(0, 75 * -w, 0));
                        w = w + 1;
                    }
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
