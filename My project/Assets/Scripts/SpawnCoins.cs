using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] Vector2 range1;
     [SerializeField] GameObject coins;

     void Start()
    {
        StartCoroutine(SpawnerCoins());
    }
    IEnumerator SpawnerCoins()
    {
        yield return new WaitForSeconds(3.1f);
         GameObject Newcoin = Instantiate(coins);
        Vector2 pos1 = transform.position + new Vector3(Random.Range(-range1.x, range1.x), 0);
        Instantiate(coins, pos1, Quaternion.identity);
        Repeat();
    }
    // Start is called before the first frame update
    

    void Repeat()
    {
        StartCoroutine(SpawnerCoins());
    }
}
