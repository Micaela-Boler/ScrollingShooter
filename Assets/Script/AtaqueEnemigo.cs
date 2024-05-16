using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AtaqueEnemigo : jugadorYEnemigos
{
    [SerializeField] Transform spawnMisil;
    [SerializeField] float cooldownDeDisparo;


    //Disparar
    void Start()
    {
        InvokeRepeating("DisparoEnemigo", 1, cooldownDeDisparo);
    }


    private void DisparoEnemigo()
    {
        Disparar(spawnMisil, transform.up);

        animator.SetBool("SaludBaja", false);
    }



    //Recibir daño
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BalaJugador") || collision.gameObject.CompareTag("Jugador"))
        {
            RecibirDaño();
            animator.SetBool("SaludBaja", true);

            if (vida <= 0)
                Destroy(gameObject);
        }
    }
}
