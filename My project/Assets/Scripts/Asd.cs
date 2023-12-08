using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asd : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    // Start is called before the first frame update
   

    // Update is called once per frame
   
         public float speed;
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
       Vector2 movement = new Vector2(moveHorizontal, 0.0f  );
        //transform.Translate(movement * speed * Time.deltaTime);

        if (moveHorizontal < 0 )
        {
            if (transform.position.x > leftBorder.transform.position.x)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        }
         else if (moveHorizontal > 0)
        {
            if (transform.position.x < rightBorder.transform.position.x)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
        
        
    }
}
