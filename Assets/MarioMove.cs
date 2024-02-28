using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
       {
        transform.Translate(0, speed, 0);
       }
       if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
       {
        transform.Translate(0, -speed, 0);
       } 
       if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
       {
        transform.Translate(-speed, 0, 0);
       } 
       if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
       {
        transform.Translate(speed, 0, 0);
       }  
    }
}
