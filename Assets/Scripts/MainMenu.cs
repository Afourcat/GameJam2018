using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public GameObject host;


    private void Start()
    {
        
    }

    public void HostGame()
    {
        //HOST GAME
    }

    public void JoinGame()
    {
        //JOIN GAME
    }

    public void QuitGame()
    {
        Debug.Log("Leaved by menu.");
        Application.Quit();
    }
}
