using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    float offsetX = 21.16f;
    public float posicionFondo;
    public float velocidadFondo;


    void Update()
    {
        transform.position -= new Vector3(velocidadFondo * Time.deltaTime, 0, 0);

        if (transform.position.x <= -offsetX)
            transform.position = new Vector3(posicionFondo, transform.position.y, 0);
    }
}
