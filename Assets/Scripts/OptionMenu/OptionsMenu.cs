using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public Image Fill;
    public TextMeshProUGUI VOLUME_txt;
    public TextMeshProUGUI FULL_SCREEN_txt;
    public TextMeshProUGUI GRAPHIC_txt;
    public Toggle ToggleFullScreen;
    public Button BACK_btn;
    public Button OPTION_btn;
    public GameObject OptionMenu;
    public GameObject MainMenu;
    public AudioMixer MainMusicMixer;
    public TMP_Dropdown Dropdown_res;

    Resolution[] resolutions;

    private void Start()
    {
        if (BACK_btn != null) {
            BACK_btn.Select();
            Debug.Log("Selected Button");
        }
        else {
            Debug.Log("Selected Button wa NULL");
        }

        resolutions = Screen.resolutions;
        Dropdown_res.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        int toAdd = resolutions.Length / 6;
        for (int i = 0; i < resolutions.Length; i += toAdd)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        Dropdown_res.AddOptions(options);
        Dropdown_res.value = currentResolutionIndex;
        Dropdown_res.RefreshShownValue();

        ToggleFullScreen.isOn = Screen.fullScreen;
    }

    private void VerifyBackKey()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            var TextTempColor = GRAPHIC_txt.color;

            TextTempColor.a = 0.5f;
            GRAPHIC_txt.color = TextTempColor;
            VOLUME_txt.color = TextTempColor;
            FULL_SCREEN_txt.color = TextTempColor;
            Fill.color = TextTempColor;

            OptionMenu.SetActive(false);
            MainMenu.SetActive(true);
            OPTION_btn.Select();
        }
    }

    private void Update()
    {
        VerifyBackKey();
    }

    public void SetVolume(float sliderVolume)
    {
        MainMusicMixer.SetFloat("MainMusicMixer", sliderVolume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
