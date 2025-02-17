using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6_CodingGymBarrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set the transform position direction to face the mouse
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // In 2D you only want your object position - your current position(transform position)
        Vector2 direction = mouse - transform.position;

        //The rotation direction up will cause the green arrow to point at the mouse and forward will cause the blue arrow to point at the mouse
        //When working in 2D only use Up or Right
        transform.up = direction;
    }
}
