using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public bool isExitWin = false;

    public void exitWindow()
    {
        GameObject.Find("AlchemyWindow").gameObject.SetActive(false);
        isExitWin = true;
    }

    public void exitGame()
    {
        SceneManager.LoadScene("Title");
    }

    public void goNextLevel()
    {
        if (GameManager.instance.stageLevel == 1)
        {
            SceneManager.LoadScene("Level2");
        }
        else if (GameManager.instance.stageLevel == 2)
        {
            SceneManager.LoadScene("Level3");
        }
        return;
    }

    public void gameStart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void endGame()
    {
        Application.Quit();
    }
}
