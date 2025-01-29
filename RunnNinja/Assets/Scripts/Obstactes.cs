using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstactes : MonoBehaviour
{
    public static int health = 3;
    public TextMeshProUGUI healthPoint, endText;
    public GameObject endPanel;
    public bool gameStart = true;
    public bool gameEnd = false;
    public Button button;
    public Rigidbody2D obstacleRb;
    void Update()
    {
        healthPoint.text = " " + health.ToString();
        if (health <= 0 && gameStart && !gameEnd)
        {
            gameEnd = true;
            health = 0;
            endText.text = "Game Over!";
            endPanel.SetActive(true);
            Debug.Log("gamefin");
            Time.timeScale = 0;
        }
        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            gameEnd = false;
            Debug.Log("gamestart");
            obstacleRb.constraints = RigidbodyConstraints2D.FreezePositionX;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.01f, 10f);
        }
    }
    


    private void OnCollisionEnter2D(Collision2D contact)
    {
        float xPos = Random.Range(-2f, 2f);
        float yPos = Random.Range(7f, 15f);
        if (contact.gameObject.CompareTag("cSprite"))
        {
            transform.position = new Vector2(xPos, yPos);
        }
        else if (contact.gameObject.CompareTag("Player"))
        {
            transform.position=new Vector2(xPos, yPos);
            health--;
        }
    }
}
