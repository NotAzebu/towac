﻿using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        transform.Translate(0,500,0);
    }
}




