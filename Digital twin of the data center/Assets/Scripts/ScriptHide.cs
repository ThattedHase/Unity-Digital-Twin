using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptHide : MonoBehaviour
{
    [SerializeField] private GameObject panel;


    public void hidePanel(bool toogle)
    {
        if (toogle == true)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
