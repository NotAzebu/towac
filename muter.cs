using UnityEngine;
using System.Collections;

public class muter : MonoBehaviour
{
    public AudioListener myAudioListener;


    void Start()
    {
        myAudioListener = Camera.main.GetComponent<AudioListener>();
        
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myAudioListener.volume = 0.0f;
        }
    }
}
