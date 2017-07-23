using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTrollBrowser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()

    {
        Application.OpenURL("http://www.youtube.com/watch?v=gkTb9GP9lVI&t=0m26s");
    }
}
