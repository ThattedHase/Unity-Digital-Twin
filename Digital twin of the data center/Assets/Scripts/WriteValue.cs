using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WriteValue : MonoBehaviour
{
    public float val1;
    public float val2;
    public float val3;

    void Update()
    {
        string text = val1+" " + val2+" " + val3;
        Debug.Log(text);
    }
    public void WriteValue1(float val_1)
    {
        val1 = val_1;
    }
    public void WriteValue2(float val_2)
    {
        val2 = val_2;
    }
    public void WriteValue3(float val_3)
    {
        val3 = val_3;
    }
    
}
