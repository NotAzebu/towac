using UnityEngine;
using System.Collections;

public class muter : MonoBehaviour
{
    //public AudioListener myAudioListener;


    void Start()
    {
        //myAudioListener = GetComponent<AudioListener>();
        
    }


    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
            AudioListener.volume = 0.0f;
        //}
    }
}
