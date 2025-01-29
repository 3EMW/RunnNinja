using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Golden : MonoBehaviour
{
    private static int score,highScore;
    public TextMeshProUGUI scoreText, HighscoreText;
    void Start()
    {
        score = 0;
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highScore = PlayerPrefs.GetInt("Highscore");
            HighscoreText.text = "HighScore :" + highScore.ToString();
        }
    }

    void Update()
    {
        scoreText.text ="Your Score:" +score.ToString();
        
    }
    private void OnCollisionEnter2D(Collision2D contact)
    {
        float xPos = Random.Range(-2f, 2f);
        float yPos = Random.Range(15f, 30f);
        if (contact.gameObject.CompareTag("Player"))
        {
            transform.position = new Vector2(xPos, yPos);
            score += Random.Range(5, 15);
            if (score > highScore)
            {
                highScore = score;
                HighscoreText.text = "Highscore:" + highScore.ToString();
                PlayerPrefs.SetInt("Highscore", highScore);
            }
            else
            {
                //highScore = 0;
            }
        }
        else if (contact.gameObject.CompareTag("cSprite"))
        {
            transform.position = new Vector2(xPos, yPos);
            score--;
        }
    }
}
