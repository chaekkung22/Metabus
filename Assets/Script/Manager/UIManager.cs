using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{  
    public void ChangeToFlappyPlaneScene()
    {
        SceneManager.LoadScene("FlappyPlaneScene");
    }

    public void ChangeToTheStackScene()
    {
        SceneManager.LoadScene("TheStackScene");
    }
}
