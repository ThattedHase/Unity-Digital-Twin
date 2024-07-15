using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TempSliderText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextSlider = null;


    public void TempSliderChange(float value)
    {
        string tempText;
        float localValue = value;
        if (localValue > 0)
        {
            tempText = "+" + localValue.ToString("0.0");
        }
        else
        {
            tempText = localValue.ToString("0.0");
        }

        TextSlider.text = tempText;
    }
}
