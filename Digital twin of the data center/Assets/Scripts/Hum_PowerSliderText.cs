using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hum_PowerSliderText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextSlider = null;


    public void Hum_PowerSliderChange(float value)
    {
        float localValue = value;
        string HumText;
        HumText = localValue.ToString("0.0") + "%";
        TextSlider.text = HumText;
    }
}
