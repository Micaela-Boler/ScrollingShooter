using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Armas
{
    [SerializeField] Transform spawnMisil;


    void Update()
    {
        tiempoDeDisparo();
    }


    IEnumerator tiempoDeDisparo()
    {
        Disparar(spawnMisil);
        yield return new WaitForSeconds(1.5f);
    }
}
