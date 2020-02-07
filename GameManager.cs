using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public bool gameOver;
    public bool gameStarted;

    public Text tapToStart;

    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)) && !gameStarted)
        {
            gameStarted = true;
            tapToStart.gameObject.SetActive(false);
        }
        
        if (gameOver) 
        {
            gameOverPanel.gameObject.SetActive(true);
            ScoreController.instance.SetDeathScreenScores();
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(1);
    }
}
