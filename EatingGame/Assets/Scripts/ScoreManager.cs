using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public int score = 0;
    public int highscore = 0;
    public GameObject loseMenu;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
    public void MinusScore()
    {
        score--;
        scoreText.text = score.ToString();
        if (score < 0)
        {
            Time.timeScale = 0f;
            loseMenu.SetActive(true);
        }
    }
}
