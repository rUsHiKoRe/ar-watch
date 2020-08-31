﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class color_sel : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1colorselect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
        else if (buttonName == "blue button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#103890", out myColor);
            band1.color = myColor;

        }

    }
    public void w2colorselect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;

        }
        else if (buttonName == "red button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;

        }
    }
    public void w3colorselect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#464646", out myColor);
            band3.color = myColor;

        }
        else if (buttonName == "red button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out myColor);
            band3.color = myColor;

        }
        
    }

}
