using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    //public GameObject[] sprites;
    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    private SpriteRenderer spriteRenderer;



    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    void OnMouseDown()
    {
        if (spriteRenderer.sprite == sprite1)

            ChangeTheSprite(); // call method to change sprite  

        else if (spriteRenderer.sprite == sprite2)

            ChangeTheSprite2();

        else if (spriteRenderer.sprite == sprite3)

            ChangeTheSprite3();

        else if (spriteRenderer.sprite == sprite4)

            ChangeTheSprite4();
    }

    void ChangeTheSprite()
    {
        if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite2;
        }
        //if (spriteRenderer.sprite == sprite2)
        //{
        //    spriteRenderer.sprite = sprite3;
        //}
        //    if (spriteRenderer.sprite == sprite3)
        //{
        //    spriteRenderer.sprite = sprite4;
        //}
    }
    void ChangeTheSprite2()
    {
        if (spriteRenderer.sprite == sprite2)
        {
            spriteRenderer.sprite = sprite3;
        }
    }
    void ChangeTheSprite3()
    {
        if (spriteRenderer.sprite == sprite3)
        {
            spriteRenderer.sprite = sprite4;
        }
    }
    void ChangeTheSprite4()
    {
        if (spriteRenderer.sprite == sprite4)
        {
            spriteRenderer.sprite = sprite5;
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex -9);
        }
    }

}
