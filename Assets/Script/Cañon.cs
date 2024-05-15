using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Cañon : Armas
{

    [Header("SPAWN DE BALAS")]

    [SerializeField] GameObject spawnSecundario;
    [SerializeField] GameObject spawnSecundarioA;
    [SerializeField] Transform spawnPrincipal;
    [SerializeField] bool disparoCooldown;
    //private bool powerUpActivado;

    [Header("CAMARA")]
    [SerializeField] Camera cam;


    private void Start()
    {
        disparoCooldown = true;
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0) && disparoCooldown == true)
            StartCoroutine(DispararCooldown(spawnPrincipal));

        
        //if (powerUpActivado == true) 
        //{
        //    spawnSecundario.SetActive(true);
        //    spawnSecundarioA.SetActive(true);

        //    InvokeRepeating("DisparaCooldown", 1, 1);
        //}
        //else
        //{
        //    spawnSecundario.SetActive(false);
        //    spawnSecundarioA.SetActive(false);
        //}

    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("PowerUp"))
    //    {
    //        powerUpActivado = true;

    //        StartCoroutine(PowerUp());

    //        Destroy(other.gameObject);
    //    }
    //}

    //IEnumerator PowerUp()
    //{
    //    yield return new WaitForSeconds(5);
    //    powerUpActivado = true;
    //}

    IEnumerator DispararCooldown(Transform spawn)
    {
        Disparar(spawn);
        disparoCooldown = false;

        yield return new WaitForSeconds(0.5f);

        disparoCooldown = true;
    }
}


