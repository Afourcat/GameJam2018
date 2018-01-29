using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum potionId
{
    AMNESIA,
    AMOUR,
    ANTIDOTE,
    AVERSION,
    EUPHORIE,
    EXPLOSIVE,
    MENINGE,
    MORT_VIVANT,
    OCULUS,
    PAIX,
    REVITALISANTE,
    VIE,
    VERITE
}

public class RecipeScript : MonoBehaviour
{

    static public string[] loadName = {"amnesia", "amour", "antidote", "aversion", "euphorie", "explosive",
       "meninge", "malediction", "mort_vivant", "oculus", "paix", "revitalisante", "vie", "verite"};

    private string name;

    public GameObject elemPrefab;

    private potionId id;

    public List<GameObject> elems;

    public Image img;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    private void Start()
    {
        generateElem();
    }

    public void my_init(potionId id, GameObject elemPrefab)
    {
        this.id = id;
        this.elemPrefab = elemPrefab;

        for (int i = 0; i < loadName.Length; i++)
        {
            if (i == (int) id)
            {
                img.sprite = Resources.Load<Sprite>("Sprites/potions/potion_" + loadName[i]);
                this.Name = loadName[i];
            }
        }
        generateElem();
    }

    private void generateElem()
    {
        GameObject elem = null;

        ElemScripts.w = 0;
        for (int i = 0; i < Random.Range(2, 4) - 1; i++)
        {
            elem = Instantiate<GameObject>(elemPrefab);
            elem.transform.SetParent(gameObject.transform, false);
            elems.Add(elem);
        }
    }
}

