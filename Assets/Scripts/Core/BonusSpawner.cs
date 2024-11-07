using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{

    public GameObject[] Bonus;
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
        MoveAndDestroyBonus(); 
    }

    void Spawn()
    {
        float X = Random.Range(minX,maxX);
        float Y = Random.Range(minY,maxY);

        Instantiate(Bonus[Random.Range(0, Bonus.Length)], transform.position + new Vector3(X,Y,0), transform.rotation);

    }

    void MoveAndDestroyBonus()
    {
        foreach (GameObject bonus in GameObject.FindGameObjectsWithTag("Bonus"))
        {
            bonus.transform.Translate(Vector3.down * Time.deltaTime * 5);
        }
    }
}