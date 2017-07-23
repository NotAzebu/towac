using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        Destroy(gameObject, 1);
    }
}
