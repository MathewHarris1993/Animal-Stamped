using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            //destroys objects as they pass top
            Destroy(gameObject);
             
        } 
        else if(transform.position.z < lowerBound)
        {
            //destroys objects as they pass bottom
            Destroy(gameObject);
            Debug.Log("Game Over");

        }
    }
}
