using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour {

    public GameObject recipePrefab;

    private RecipeScript recipe;

    public GameObject elemPrefab;

    public List<GameObject> recipes;

    private Transform trans;

    private bool isActive;

    public int cursor;

    public bool isTLeftActive;

    public bool isTRightActive;

    private float oldTrigger;

    public bool IsActive
    {
        get
        {
            return isActive;
        }

        set
        {
            isActive = value;
        }
    }

    // Use this for initialization
    void Start () {
        cursor = 0;
        isActive = false;
        isTRightActive = false;
        isTRightActive = false;
        generate_recipes();
        trans = this.transform;
	}
    
    private void generate_recipes()
    {
        GameObject current_recipe = null;

        for (int i = 0; i < 14; i++)
        { 
            current_recipe = Instantiate<GameObject>(recipePrefab, new Vector3(-325, 230, 0), Quaternion.identity);
            current_recipe.GetComponent<RecipeScript>().my_init((potionId) i, elemPrefab);
            current_recipe.transform.SetParent(gameObject.transform, false);
            current_recipe.SetActive(false);
            recipes.Add(current_recipe);
        }
    }
    
	void Update () {
		if (isActive)
        {
            if (recipes.Count == 0) {
                return;
            }
            recipes[cursor].SetActive(true);

            if (isTLeftActive == true && Input.GetAxis("Trigger left") == 0)
                isTLeftActive = false;
            if (isTRightActive == true && Input.GetAxis("Trigger right") == 0)
                isTRightActive = false;
            if (Input.GetAxis("Trigger left") == 1) {
                if (!isTLeftActive) {
                    recipes[cursor].SetActive(false);
                    cursor = (cursor > 0) ? cursor - 1 : recipes.Count - 1;
                    isTLeftActive = true;
                }
                recipes[cursor].SetActive(true);
            } else if (Input.GetAxis("Trigger right") == 1) {
                if (!isTRightActive) {
                    recipes[cursor].SetActive(false);
                    cursor = (cursor < recipes.Count - 1) ? cursor + 1 : 0;
                    isTRightActive = true;
                }
                recipes[cursor].SetActive(true);
            }
        } else {
            foreach (GameObject item in recipes)
            {
                item.SetActive(false);
            }
        }
        
	}
}
