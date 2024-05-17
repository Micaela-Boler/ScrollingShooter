using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicarPowerUp :jugadorYEnemigos
{
    [SerializeField] GameObject arma1;
    [SerializeField] GameObject arma2;

    [SerializeField] float duracionPowerUp;

    //[SerializeField] ParticleSystem particulas;
    //[SerializeField] AudioSource audio;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            InvokeRepeating("empezarAdisparar", 0, 0.5f);


            //audio.Play();
            // particulas.Play();
            Destroy(other.gameObject);
        }
    }

 
    void empezarAdisparar()
    {
        StartCoroutine("PowerUpActivado");
    }
 


    IEnumerator PowerUpActivado()
    {
        Disparar(arma1.transform, transform.right);
        Disparar(arma2.transform, transform.right);

        yield return new WaitForSeconds(duracionPowerUp);

        CancelInvoke("empezarAdisparar");
        //particulas.Stop();
    }
}
