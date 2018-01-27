using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighlightGraphics : MonoBehaviour
{
    public TextMeshProUGUI GRAPHIC_txt;

    public void HighlightGraphicCanvas()
    {
        var TextTempColor = GRAPHIC_txt.color;

        TextTempColor.a = 1f;
        GRAPHIC_txt.color = TextTempColor;
        Debug.Log("highlight Volume");
    }

    public void DishighlightGraphicCanvas()
    {
        var TextTempColor = GRAPHIC_txt.color;

        TextTempColor.a = 0.5f;
        GRAPHIC_txt.color = TextTempColor;
        Debug.Log("dishighlight Volume");
    }
}
