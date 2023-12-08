using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForTextScore : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] Text scoreText;
     [SerializeField] Text HighText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + ScoreLast.Coins.ToString();
        HighText.text = "High Score: " + ScoreLast.HighCoins.ToString();
    }
}
