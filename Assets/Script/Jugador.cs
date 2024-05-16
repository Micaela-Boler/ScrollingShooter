using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Jugador : jugadorYEnemigos
{

    [Header("SPAWN DE BALAS")]

    [SerializeField] GameObject spawnSecundario;

    [SerializeField] GameObject spawnSecundarioA;

    [SerializeField] bool disparoCooldown;

    [SerializeField] float segundosParaDisparar;

    [SerializeField] Transform spawnPrincipal;


    [Header("VIDA")]

    public GameManager gameManager;



    //Atacar
    private void Start()
    {
        disparoCooldown = true;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && disparoCooldown == true)
            StartCoroutine(DispararCooldown(spawnPrincipal));
    }


    IEnumerator DispararCooldown(Transform spawn)
    {
        Disparar(spawn, transform.right);
        disparoCooldown = false;

        yield return new WaitForSeconds(segundosParaDisparar);

        disparoCooldown = true;
    }



    //Recibir daño
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BalaEnemiga") || collision.gameObject.CompareTag("Obstaculo"))
        {
            RecibirDaño();
            gameManager.CambiarCorazon(vida);


            switch (vida)
            { 
                case 1:
                    animator.SetTrigger("SaludBaja");
                    break;

                case 0:
                    gameManager.CambiarEscena(0);
                    break;

            }
        }
    }
}


