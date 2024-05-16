using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class jugadorYEnemigos : MonoBehaviour
{
    [Header("DISPARAR")]

    [SerializeField] Bala bulletPrefab;


    [Header("RECIBIR DA�O")]

    [SerializeField] protected int vida;

    [SerializeField] protected int da�o;


    [Header("ANIMACION")]

    [SerializeField] protected Animator animator;



    protected virtual void Disparar(Transform spawn, Vector2 direccion)
    {
        Bala projectile = Instantiate(bulletPrefab, spawn.position, transform.rotation);
        projectile.LaunchBullet(direccion);
    }

    
    protected virtual void RecibirDa�o()
    {
        vida -= da�o;
    }
    
}
