using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario_Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.W))
       {
        transform.Translate(0, speed, 0);
       }
       if(Input.GetKey(KeyCode.S))
       {
        transform.Translate(0, -speed, 0);
       } 
       if(Input.GetKey(KeyCode.A))
       {
        transform.Translate(-speed, 0, 0);
        FlipSprite(true);
       } 
       
       if(Input.GetKey(KeyCode.D))
       {
        transform.Translate(speed, 0, 0);
        FlipSprite(false);
       }  
    }

    void FlipSprite(bool isLeft)
    {
        Vector3 scale = transform.localScale;

        if (isLeft)
        {
            scale.x = -Mathf.Abs(scale.x);
        }
        else
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;
    }
}
