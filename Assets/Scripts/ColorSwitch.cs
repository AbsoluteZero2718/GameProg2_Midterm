using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    public Color[] Colors = {Color.red, Color.green, Color.blue};
    public Renderer rend;

    public int index = 0, enemyCount = 0;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    public void OnMouseDown()
    {
        if (index < Colors.Length - 1)
        {
            index++;
        } 
        else
        {
            index = 0;
        }
        rend.material.color = Colors[index];
    }


}
