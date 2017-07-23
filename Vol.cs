using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vol : MonoBehaviour
{
    public AudioListener audioListenerGoesHere; 

    void Start()
    {

    }

    public void ChangeVol(float newValue)
    {
        float newVol = AudioListener.volume;
        newVol = newValue;
        AudioListener.volume = newVol;
    }
}
