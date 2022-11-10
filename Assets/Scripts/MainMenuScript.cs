using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void MainMenuGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame ()
    {
        Debug.Log("EXIT GAME");
        Application.Quit();
    }
}
