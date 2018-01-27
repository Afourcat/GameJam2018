using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighlightFullScreen : MonoBehaviour {

    public TextMeshProUGUI FULL_SCREEN_txt;

    public void HighlightFullScreenCanvas()
    {
        var TextTempColor = FULL_SCREEN_txt.color;

        TextTempColor.a = 1f;
        FULL_SCREEN_txt.color = TextTempColor;
        Debug.Log("highlight Volume");
    }

    public void DishighlightFullScreenCanvas()
    {
        var TextTempColor = FULL_SCREEN_txt.color;

        TextTempColor.a = 0.5f;
        FULL_SCREEN_txt.color = TextTempColor;
        Debug.Log("dishighlight Volume");
    }
}
