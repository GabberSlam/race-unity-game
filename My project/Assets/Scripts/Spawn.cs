using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public Transform transform;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;

    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(1.5f);
        Vector2 pos = transform.position + new Vector3(Random.Range(-range.x, range.x), 0);
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }


    void Repeat()
    {
        StartCoroutine(Spawner());
    }
}
