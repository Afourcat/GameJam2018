using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    private static string[] stringId = { "Jar", "Plant", "Stone", "Eye" };

    private static string[] stringColor = { "Red", "Blue", "Green", "Yellow" };
    
    public GameObject inventory_object;

    private InventoryManager inventory;

    private void Start() {
        inventory = inventory_object.GetComponent<InventoryManager>();
    }

    void Update () {
        RaycastHit hit = new RaycastHit();
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));

        if (Physics.Raycast(ray, out hit, 5)) {
            if (hit.collider.CompareTag("PlaceHolder")) {
                if (Input.GetButtonDown("X Button"))
                {
                    if (inventory.items[(int) buttonId.X] == null) {
                        inventory.AddItem(Instantiate(hit.collider.gameObject), buttonId.X);
                        if (hit.collider.GetComponentInChildren<PlaceHolderManager>().nbRessources == 1)
                        {
                            Destroy(hit.collider.transform.parent.gameObject);
                        }
                        else
                        {
                            hit.collider.GetComponent<PlaceHolderManager>().nbRessources--;
                        }
                        inventory.items[(int) buttonId.X].SetActive(false);
                    }
                } else if (Input.GetButtonDown("Y Button"))
                {
                    if (inventory.items[(int) buttonId.Y] == null) {
                        inventory.AddItem(Instantiate(hit.collider.gameObject), buttonId.Y);
                        if (hit.collider.GetComponent<PlaceHolderManager>().nbRessources == 1)
                        {
                            Destroy(hit.collider.transform.parent.gameObject);
                        }
                        else
                        {
                            hit.collider.GetComponent<PlaceHolderManager>().nbRessources--;
                        }
                        inventory.items[(int) buttonId.Y].SetActive(false);
                    } 
                } else if (Input.GetButtonDown("B Button"))
                {
                    if (inventory.items[(int) buttonId.B] == null) {
                        inventory.AddItem(Instantiate(hit.collider.gameObject), buttonId.B);
                        if (hit.collider.GetComponent<PlaceHolderManager>().nbRessources == 1)
                        {
                            Destroy(hit.collider.transform.parent.gameObject);
                        }
                        else
                        {
                            hit.collider.GetComponent<PlaceHolderManager>().nbRessources--;
                        }
                        inventory.items[(int) buttonId.B].SetActive(false);
                    }
                } else if (Input.GetButtonDown("A Button"))
                {
                    if (inventory.items[(int) buttonId.A] == null) {
                        inventory.AddItem(Instantiate(hit.collider.gameObject), buttonId.A);
                        if (hit.collider.GetComponent<PlaceHolderManager>().nbRessources == 1)
                        {
                            Destroy(hit.collider.transform.parent.gameObject);
                        }
                        else
                        {
                            hit.collider.GetComponent<PlaceHolderManager>().nbRessources--;
                        }
                        inventory.items[(int) buttonId.A].SetActive(false);
                    }
                }
            }
            else if (hit.collider.CompareTag("Table"))
            {
                Debug.Log("test");
                if (Input.GetButtonDown("X Button"))
                {
                    if (inventory.items[(int) buttonId.X] != null)
                    {
                        var ressource = inventory.items[(int) buttonId.X];
                        var id = ressource.GetComponent<ResourceManager>().id;
                        var color = ressource.GetComponent<ResourceManager>().color;
                        var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                        var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 7), Quaternion.identity);
                        lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                        Destroy(inventory.items[(int) buttonId.X]);
                        GameObject.FindGameObjectWithTag("X").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                    }
                } else if (Input.GetButtonDown("Y Button"))
                {
                    if (inventory.items[(int) buttonId.Y] != null) {
                        var ressource = inventory.items[(int) buttonId.Y];
                        var id = ressource.GetComponent<ResourceManager>().id;
                        var color = ressource.GetComponent<ResourceManager>().color;
                        var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                        var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 7), Quaternion.identity);
                        lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                        Destroy(inventory.items[(int) buttonId.Y]);
                        GameObject.FindGameObjectWithTag("Y").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                    } 
                } else if (Input.GetButtonDown("B Button"))
                {
                    if (inventory.items[(int) buttonId.B] != null) {
                        var ressource = inventory.items[(int) buttonId.B];
                        var id = ressource.GetComponent<ResourceManager>().id;
                        var color = ressource.GetComponent<ResourceManager>().color;
                        var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                        var lacpy = PhotonNetwork.Instantiate(cpy.name, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 7), Quaternion.identity, 0);
                        lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                        Destroy(inventory.items[(int) buttonId.B]);
                        GameObject.FindGameObjectWithTag("B").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                    }
                } else if (Input.GetButtonDown("A Button"))
                {
                    if (inventory.items[(int) buttonId.A] != null) {
                        var ressource = inventory.items[(int) buttonId.A];
                        var id = ressource.GetComponent<ResourceManager>().id;
                        var color = ressource.GetComponent<ResourceManager>().color;
                        var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                        var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 7), Quaternion.identity);
                        lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                        Destroy(inventory.items[(int) buttonId.A]);
                        GameObject.FindGameObjectWithTag("A").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                    }
                }
            }
        }
        else
        {
            if (Input.GetButtonDown("X Button"))
            {
                if (inventory.items[(int) buttonId.X] != null) {
                    var ressource = inventory.items[(int) buttonId.X];
                    var id = ressource.GetComponent<ResourceManager>().id;
                    var color = ressource.GetComponent<ResourceManager>().color;
                    var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                    var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
                    lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                    Destroy(lacpy, 5);
                    Destroy(inventory.items[(int) buttonId.X]);
                    GameObject.FindGameObjectWithTag("X").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                }
            } else if (Input.GetButtonDown("Y Button"))
            {
                if (inventory.items[(int) buttonId.Y] != null) {
                    var ressource = inventory.items[(int) buttonId.Y];
                    var id = ressource.GetComponent<ResourceManager>().id;
                    var color = ressource.GetComponent<ResourceManager>().color;
                    var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                    var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
                    lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                    Destroy(inventory.items[(int) buttonId.Y]);
                    
                    Destroy(lacpy, 5);
                    GameObject.FindGameObjectWithTag("Y").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                } 
            } else if (Input.GetButtonDown("B Button"))
            {
                if (inventory.items[(int) buttonId.B] != null) {
                    var ressource = inventory.items[(int) buttonId.B];
                    var id = ressource.GetComponent<ResourceManager>().id;
                    var color = ressource.GetComponent<ResourceManager>().color;
                    var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                    var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
                    lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                    Destroy(inventory.items[(int) buttonId.B]);
                    
                    Destroy(lacpy, 5);
                    GameObject.FindGameObjectWithTag("B").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                }
            } else if (Input.GetButtonDown("A Button"))
            {
                if (inventory.items[(int) buttonId.A] != null) {
                    var ressource = inventory.items[(int) buttonId.A];
                    var id = ressource.GetComponent<ResourceManager>().id;
                    var color = ressource.GetComponent<ResourceManager>().color;
                    var cpy = Resources.Load<GameObject>("Resources/" + stringId[(int) id] + "_" + stringColor[(int) color]);
                    var lacpy = Instantiate(cpy, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
                    lacpy.GetComponentInChildren<PlaceHolderManager>().nbRessources = 1;
                    Destroy(inventory.items[(int) buttonId.A]);
                    
                    Destroy(lacpy, 5);
                    GameObject.FindGameObjectWithTag("A").GetComponent<Image>().color = new Color(255, 255, 255, 0);
                }
            }
        }
	}
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Book"))
            other.GetComponentInChildren<BookScript>().IsActive = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Book"))
            other.GetComponentInChildren<BookScript>().IsActive = false;
    }
}
