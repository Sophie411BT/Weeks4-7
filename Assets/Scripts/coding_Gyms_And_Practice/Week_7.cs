using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Week_7 : MonoBehaviour
{
    public float speed;
    public float velocity = 5f;
    public SpriteRenderer spriterenderer;
    public GameObject prefab;
    public Boolean dies;


    // Start is called before the first frame update
    void Start()
    {
       dies = false;
    }

     

// Update is called once per frame
void Update()
    {

        if (transform.position.y <= -2.5)
        {
            dies = true;
        }
        if (transform.position.y >= -3.5)
        {
            dies = false;
        }


        if (dies == true)
        {
            spriterenderer.color = Color.red;
            speed = 0;
            velocity = 0;
        }

        //in order to get the transform position value, use Vector2, to get it in a variable form.
        Vector2 pos = transform.position;

        //use Input,Getaxis to allow the x and y values to be modified when keys are pressed.
        //left and right arrow keys move the character from side to side
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //up and down arrow keys make the character move up and down
        pos.y += Input.GetAxis("Vertical") * speed * velocity * Time.deltaTime;
        // set transform position equel to pos variable
        transform.position = pos;


       
    }

    
}

