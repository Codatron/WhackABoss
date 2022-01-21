using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject targetObj; // can be used as a prefab

    private GameController gameController;
    private float timer;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();

        timer = Random.Range(1.5f, 2.25f);
    }

    void Update()
    {
        if (gameController.isPaused || gameController.isGameOver)
        {
            return;
        }
        else
        {
            RandomSpawnTimer();
        }
    }

    public void RandomSpawnTimer()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            Instantiate(targetObj, new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 4.5f)), Quaternion.identity);
            float timeBtwSpawns = Random.Range(0.0f, 3.0f);
            timer = timeBtwSpawns;
            Debug.Log(timeBtwSpawns);
        }
    }
}
