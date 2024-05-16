using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject obstaculoRandom;
    [SerializeField] GameObject[] obstaculos;
    int numeroRandom;

    [SerializeField] float tiempoDeSpawn = 4;
    [SerializeField] float repeticion = 5;



    void Start()
    {
        InvokeRepeating("SpawnEnemy", tiempoDeSpawn, repeticion);
    }


    void SpawnEnemy()
    {
        numeroRandom = Random.Range(0, obstaculos.Length);
        obstaculoRandom = obstaculos[numeroRandom];

        Instantiate(obstaculoRandom, transform.position, obstaculoRandom.transform.rotation);
    }
}
