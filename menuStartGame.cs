﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuStartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("tutorial");
    }

}
