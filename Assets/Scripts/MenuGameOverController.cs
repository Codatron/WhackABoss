using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuGameOverController : MonoBehaviour
{
    public Canvas canvasGameOver;
    public Canvas canvasPause;

    private GameController gameController;
   
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        canvasGameOver.enabled = false;
        canvasPause.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.isGameOver)
        {
            canvasGameOver.enabled = true;
        }

        if (gameController.isPaused)
        {
            canvasPause.enabled = true;
        }
    }

    public void Pause()
    {
        gameController.isPaused = true;
        canvasPause.enabled = true;
    }

    public void Resume()
    {
        gameController.isPaused = false;
        canvasPause.enabled = false;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
