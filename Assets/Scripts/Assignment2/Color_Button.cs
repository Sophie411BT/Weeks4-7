using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale_Button : MonoBehaviour
{
     public GameObject prefab;
    public SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Color()
    {
        spriterenderer.color = Random.ColorHSV();


    }
}
