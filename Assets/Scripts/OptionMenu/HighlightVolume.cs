using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighlightVolume : MonoBehaviour {

    public Image Fill;
    public TextMeshProUGUI VOLUME_txt;

    public void HighlightVolumeCanvas()
    {
        var FillTempColor = Fill.color;
        var TextTempColor = VOLUME_txt.color;

        FillTempColor.a = 1f;
        TextTempColor.a = 1f;
        Fill.color = FillTempColor;
        VOLUME_txt.color = TextTempColor;
        Debug.Log("highlight Volume");
    }

    public void DishighlightVolumeCanvas()
    {
        var FillTempColor = Fill.color;
        var TextTempColor = VOLUME_txt.color;

        FillTempColor.a = 0.5f;
        TextTempColor.a = 0.5f;
        Fill.color = FillTempColor;
        VOLUME_txt.color = TextTempColor;
        Debug.Log("dishighlight Volume");
    }
}
