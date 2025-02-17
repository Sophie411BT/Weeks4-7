using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fluff_Movement : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use Vector3 to find the position. Vector 3 means ut has 3 positions (x, y and z)
        Vector3 pos = transform.position;
        //make the position += the speed
        pos.x += speed * Time.deltaTime; //Delta time allows us to see exactly how many times the script is updateing. it makes frame rate and speed more consistant 
        //use Vector2 (only has x and y positions) and set it = to Screenpoint
        Vector2 screenpos = Camera.main.WorldToScreenPoint(pos);

        //if the position of the object on screen is less than 0 or the object is greater than the width of the screen, switch directions
        if (screenpos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        if (screenpos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        //always remember to set transform position = to pos for new position
        transform.position = pos;
    }
}
