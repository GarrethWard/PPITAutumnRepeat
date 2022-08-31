using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Wave1");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
