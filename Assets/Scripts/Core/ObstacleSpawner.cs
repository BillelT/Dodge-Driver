using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] Obstacles;
    private GameObject Player;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    private float initialTimeBetweenSpawn = 5f;
    private float timeBetweenSpawn;
    private float spawnTime;
    private float gameStartTime;
    private float gameTimeElapsed;


    // Update is called once per frame
    void Start()
    {
        gameStartTime = Time.time; // Enregistrer le temps de démarrage de la partie
        Player = GameObject.FindGameObjectWithTag("Player");


    }
    void Update()
    {
        gameTimeElapsed = Time.time - gameStartTime;
        if(Time.time > spawnTime)
        {
            Spawn();
            if (timeBetweenSpawn > 1f) {
            timeBetweenSpawn = initialTimeBetweenSpawn - gameTimeElapsed * 0.1f ;
            } else {
                timeBetweenSpawn = 1f;
            }
            spawnTime = Time.time + timeBetweenSpawn;
        }
        MoveAndDestroyObstacles(); 
    }

    void Spawn()
    {
        float X = Random.Range(minX,maxX);
        float Y = Random.Range(minY,maxY);

        Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], transform.position + new Vector3(X,Y,0), transform.rotation);

    }

    void MoveAndDestroyObstacles()
    {
        foreach (GameObject obstacle in GameObject.FindGameObjectsWithTag("Obstacle"))
        {
            obstacle.transform.Translate(Vector3.down * Time.deltaTime * 5);
        }
    }
}