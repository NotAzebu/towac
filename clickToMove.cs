using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        transform.Translate(-0.5f, 1, Time.deltaTime);
    }
}
