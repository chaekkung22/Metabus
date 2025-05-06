using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Instance {  get { return gameManager; } }

    public bool isGameStart = false;

    private int currentScore = 0;
    private int bestScore = 0;

   [SerializeField] FlappyGameUIManager uiManager;

    private void Awake()
    {
        gameManager = this;
    }



    void GameStart()
    {
        isGameStart = true;
        uiManager.GameStart();
        uiManager.UpdateScore(0);
    }

    void GameOver()
    {
        uiManager.GameOver();
    }


    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }
}
