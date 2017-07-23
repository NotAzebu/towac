using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadLevel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel(string level)
    {
        //Application.LoadLevel(0);
        SceneManager.LoadScene ("menu");
    }
}
