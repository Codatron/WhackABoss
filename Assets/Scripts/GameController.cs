using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float timeRemaining;
    public bool isGameOver = false;
    public bool isPaused = false;
     
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (timeRemaining > 0.0f)
        {
            timeRemaining -= Time.deltaTime;
        }

        if (isPaused)
        {
            Time.timeScale = 0.0f;
            Debug.Log("Game is paused!");
        }
        else 
        {
            Time.timeScale = 1.0f;
        }
        
        if (timeRemaining <= 0.0f)
        {
            isGameOver = true;
            Time.timeScale = 0.0f;
            Debug.Log("Time's Up!");
        }
    }
}
