using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    AudioSource masterVolume;

    public Button BACK_btn;

    private void Start()
    {
        if (BACK_btn != null) {
            BACK_btn.Select();
            Debug.Log("Selected Button");
        }
        else {
            Debug.Log("Selected Button wa NULL");
        }
    }

    public void SetVolume(float sliderVolume)
    {
        masterVolume.volume = sliderVolume;
        Debug.Log(sliderVolume);
    }
}
