using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Canvas canvasMenu;
    public Canvas canvasSettings;

    void Start()
    {
        canvasSettings.enabled = false;
    }

    public void NewGame()
    {
        canvasSettings.enabled = true;
        canvasMenu.enabled = false;
    }

    public void LoadGame()
    {
        // Loads progress from a previous game
    }

    public void HighScore()
    {
        // Loads HIgh Score screen
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
