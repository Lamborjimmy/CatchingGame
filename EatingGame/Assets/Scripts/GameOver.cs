using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1f;
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
