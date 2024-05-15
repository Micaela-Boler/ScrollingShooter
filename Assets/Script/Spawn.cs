using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstaculoRandom;
    public GameObject[] obstaculos;
    public Vector2 posicionSpawn;

    int numeroRandom;
    public float tiempoDeSpawn = 4;
    public float repeticion = 5;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", tiempoDeSpawn, repeticion);
    }


    void SpawnEnemy()
    {
        numeroRandom = Random.Range(0, obstaculos.Length);
        obstaculoRandom = obstaculos[numeroRandom];

        Instantiate(obstaculoRandom, posicionSpawn, obstaculoRandom.transform.rotation);
    }
}
