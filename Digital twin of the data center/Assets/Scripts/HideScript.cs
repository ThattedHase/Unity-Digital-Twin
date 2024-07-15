using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    [SerializeField] private GameObject floor;

    public void hide(bool toogle)
    {
        if (toogle == true)
        {
            floor.SetActive(false);
        }
        else
        {
            floor.SetActive(true);
        }
    }
}
