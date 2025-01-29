using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearth : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D contact)
    {
        float xPos = Random.Range(-2f, 2f);
        float yPos = Random.Range(70f, 150f);
        if (contact.gameObject.CompareTag("Player"))
        {
            transform.position = new Vector2(xPos, yPos);
            Obstactes.health++;
        }
        else if (contact.gameObject.CompareTag("cSprite"))
        {
            transform.position = new Vector2(xPos, yPos);
            
        }
    }
}
