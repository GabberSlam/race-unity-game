using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bottomBorder;

     public int speed;

    void Update()
    {
        
       
         transform.Translate(Vector2.down * speed * Time.deltaTime);

         if (transform.position.y < bottomBorder.transform.position.y)
         {
            Destroy(gameObject);
         }

    }

    
}
