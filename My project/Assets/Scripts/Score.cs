using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
     public float speed;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }
}
