using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] float tiempoVivo = 0f;
    [SerializeField] float tiempoMaximo = 10f;


    void Update()
    {
        transform.position -= new Vector3(velocidad * Time.deltaTime, 0, 0);

        tiempoVivo += Time.deltaTime;

        if (tiempoMaximo <= tiempoVivo)
            Destroy(this.gameObject);
    }
}
