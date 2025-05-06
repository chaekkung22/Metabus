using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Instance { get { return gameManager; } }

    bool isGameOver = false;

    private int currentScore = 0;
    private int bestScore = 0;

    [SerializeField] FlappyGameUIManager uiManager;

    private void Awake()
    {
        gameManager = this;
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (isGameOver && Input.anyKeyDown)
        {
            isGameOver = false;
            uiManager.Restart();
        }
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        uiManager.GameStart();
        uiManager.UpdateScore(0);
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        uiManager.UpdateBestScore(bestScore);
    }

    public void GameOver()
    {
        isGameOver = true;
        uiManager.GameOver();
    }


    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        if (currentScore >= bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.Save();
            uiManager.UpdateBestScore(currentScore);
        }
    }
}
