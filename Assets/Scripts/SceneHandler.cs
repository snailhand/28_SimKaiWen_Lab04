using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public static void WinGame()
    {
        SceneManager.LoadScene("GameWinScene");
    }
    public static void LoseGame()
    {
        SceneManager.LoadScene("GameLoseScene");
    }
    public static void NextLevel()
    {
        SceneManager.LoadScene("GamePlay_Level_2");
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
