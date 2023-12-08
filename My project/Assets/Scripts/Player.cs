using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject leftBorder;
    public GameObject rightBorder;
    public int score;
    


    [SerializeField] Text scoreText;

    int highScore;
    int highScoreForLast;
    [SerializeField] Text highText;


    void Start()
    {
       

    }

    void Update()
    {
        

        if (Input.GetKey(KeyCode.A) )
        {
            if (transform.position.x > leftBorder.transform.position.x)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < rightBorder.transform.position.x)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
        

        scoreText.text="Score: " + score.ToString();
        HighScore();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag!="Coin")
        {
            SceneManager.LoadScene(1);
            Destroy(gameObject);
        }
        else
        {
           Destroy(collision.gameObject);
            score++;
            highScore = score;
            
            
        }
        
        
    }

    private void OnDestroy()
    {
        ScoreLast.Coins = score;
        ScoreLast.HighCoins = PlayerPrefs.GetInt("score");
    }

    public void HighScore()
    {
        if(PlayerPrefs.GetInt("score")<=highScore)
        {
            PlayerPrefs.SetInt("score", highScore);
             highScoreForLast=highScore;
        }
        highText.text ="High Score: " + PlayerPrefs.GetInt("score").ToString();
    }

}
    
