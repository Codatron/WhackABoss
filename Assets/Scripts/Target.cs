using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points;

    private ScoreController scoreController;
    private GameController gameController;
    private BoxCollider2D boxCol;

    // Start is called before the first frame update
    void Start()
    {
        boxCol = GetComponent<BoxCollider2D>();

        scoreController = FindObjectOfType<ScoreController>();
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.isPaused || gameController.isGameOver)
        {
            boxCol.enabled = false;
        }
        else
        {
            boxCol.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        scoreController.AddScore(points);
    }
}
