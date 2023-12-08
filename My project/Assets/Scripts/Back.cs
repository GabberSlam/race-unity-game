using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public float speed;
    public GameObject bottomBG;
    public float backLength;
    public int backsCount;
    public Vector2 direction;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < bottomBG.transform.position.y)
        {
            direction.Set(transform.position.x,
                transform.position.y + backLength * backsCount);
            transform.position = direction;
        }
    }
}
