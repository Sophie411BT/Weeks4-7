using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Spawn_Button : MonoBehaviour
{
    //create prefab variable as game object so that the real prefab can be assigned to it in unity
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void spawn so that it can be assigned to the spawn button 
   public void spawn()
    {
        //tell the code to acually get the prefab using instantiate
        Instantiate(prefab);
    }
}


