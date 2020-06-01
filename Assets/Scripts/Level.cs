using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Level : MonoBehaviour
{

    [SerializeField] float gameOverDelay = 1;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndGameOver());
    }

    public void QuitGame()
    {
        Application.Quit();
    }



    private IEnumerator WaitAndGameOver()
    {
        yield return new WaitForSeconds(gameOverDelay);
        SceneManager.LoadScene("Game Over");
    }
}
