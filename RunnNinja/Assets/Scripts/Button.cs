using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Animator controller;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Obstactes.health = 3;
        Time.timeScale = 1;
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
        Obstactes.health = 3;
        Time.timeScale = 1;
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("Loading");
        Time.timeScale = 1;
    }
}
