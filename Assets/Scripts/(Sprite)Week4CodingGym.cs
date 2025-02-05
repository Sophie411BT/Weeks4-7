using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4CodingGym : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //in order to get the transform position value, use Vector2, to get it in a variable form.
        Vector2 pos = transform.position;

        //use Input,Getaxis to allow the x and y values to be modified when keys are pressed.
        //left and right arrow keys move the character from side to side
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //up and down arrow keys make the character move up and down
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // set transform position equel to pos variable
        transform.position = pos;
    }
}
