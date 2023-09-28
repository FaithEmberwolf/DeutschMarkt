using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int totalscanned;
    public int totalBagged; 
    public void Update()
    {
        if (totalscanned == 6)
        {

        }
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("Game_Over");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
