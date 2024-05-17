using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AtaqueEnemigo : jugadorYEnemigos
{
    [Header("DISPARO")]
    [SerializeField] Transform spawnMisil;
    [SerializeField] float cooldownDeDisparo;
    [SerializeField] float empezarADisparar = 1;

    [Header("RECIBIR DAÑO")]
    [SerializeField] float tiempoParaDestruirse = 0;
    [SerializeField] ParticleSystem particulas;
    [SerializeField] AudioSource audio;



    //Disparar
    void Start()
    {
        InvokeRepeating("DisparoEnemigo", empezarADisparar, cooldownDeDisparo);
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
            particulas.Play();
            animator.SetBool("SaludBaja", true);


            if (vida <= 0)
            {
                audio.Play();
                Destroy(gameObject, tiempoParaDestruirse);
            }
        }
    }
}
