using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public static ScoreController instance;

    public Text scoreText;
   // public Text hiScoreText;

    public Text deathScoreText;
    public Text deathHighScoreText;

    public float scoreCount;
    public float hiScoreCount;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.instance.gameStarted && !GameManager.instance.gameOver)
        {
            scoreCount += Time.deltaTime;
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }
        scoreText.text = scoreCount.ToString("F2");

    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }

    public void SetHighScore()
    {
        //hiScoreText.text = "High Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScore"));
    }

    public void SetDeathScreenScores()
    {
        deathScoreText.text = scoreCount.ToString("F2");
        deathHighScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString("F2");

    }


    // Update is called once per frame
}
