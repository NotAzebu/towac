using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeSlider : MonoBehaviour {

    public AudioListener myAudioListener;

    public float VolumeSliderValue = 1f;

   

    // Use this for initialization
    void Start () {

        //VolumeSliderValue = GameObject.Find("Slider1").GetComponent<Slider>().value;

    }
	
	// Update is called once per frame
	void Update () {

        
        {

            AudioListener.volume = VolumeSliderValue;
        }
    }
}
