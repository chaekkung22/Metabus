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
    [SerializeField] TextMeshProUGUI gameOverUIScoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] TextMeshProUGUI gameOverUIBestScoreText;
    [SerializeField] TextMeshProUGUI SucessOrFailed;


    public void GameStart()
    {
        gameStartUI.SetActive(false);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        IsMissionSucess();
    }
    public void Restart()
    {
        SceneManager.LoadScene("FlappyPlaneScene");
    }
    public void GameQuit()
    {
        Time.timeScale = 1.0f;
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
        gameOverUIScoreText.text = score.ToString();
    }

    public void UpdateBestScore(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
        gameOverUIBestScoreText.text = bestScore.ToString();
    }

    public void IsMissionSucess()
    {
        if (GameManager.Instance.isMissionSucess)
            SucessOrFailed.text = "Mission Sucess!";
        else SucessOrFailed.text = "Mission Failed..";
    }




}
