using UnityEngine;
using System.Collections;

public class audioOnClick : MonoBehaviour
{

    // Your audio clip
    public AudioClip MusicClip;

    // the component that Unity uses to play your clip
    public AudioSource MusicSource;

    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
            //MusicSource.Play();
    }
    void OnMouseDown()
    {
        MusicSource.Play();
    }
}