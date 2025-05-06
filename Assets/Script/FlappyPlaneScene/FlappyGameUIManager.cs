using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyGameUIManager : MonoBehaviour
{
    [SerializeField] GameObject gameStartUI;
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject howToPlayUI;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;

    public void GameStart()
    {
        gameStartUI.SetActive(false);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void GameQuit()
    {
        SceneManager.LoadScene("TileMapScene");
    }

    public void ShowHowToPlay()
    {
        gameStartUI.SetActive(false);
        howToPlayUI.SetActive(true);
    }

    public void CloseHowToPlay()
    {
        howToPlayUI.SetActive(false);
        gameStartUI.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void UpdateBestScore(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }




}
