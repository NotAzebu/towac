using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unMuter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (AudioListener.volume != 100)
        {
            AudioListener.volume = 100;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
