using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class muter : MonoBehaviour
{
    //public AudioListener myAudioListener;
    //public Button muteButton;

    void Start()
    {
        //myAudioListener = GetComponent<AudioListener>();
        
        
    }


    void onMouseDown()
    {
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
            
            AudioListener.volume = 0.0f;
        //}
    }
}
