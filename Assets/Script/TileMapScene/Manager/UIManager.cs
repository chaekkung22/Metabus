using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]GameObject choiceGame;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowChoiceGame()
    {
        choiceGame.SetActive(true);
    }

    public void CloseChoiceGame()
    {
        choiceGame.SetActive(false);
    }


    public void ChangeToFlappyPlaneScene()
    {
        SceneManager.LoadScene("FlappyPlaneScene");
    }

    public void ChangeToTheStackScene()
    {
        SceneManager.LoadScene("TheStackScene");
    }
}
