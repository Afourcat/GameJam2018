using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Button HOST_btn;

    private void Start()
    {
        if (HOST_btn != null) {
            HOST_btn.Select();
            Debug.Log("Selected Button");
        } else {
            Debug.Log("Selected Button wa NULL");
        }
    }

    public void HostGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
