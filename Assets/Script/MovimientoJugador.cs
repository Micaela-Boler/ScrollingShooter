using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    float horizontal;
    float vertical;
    public int velocidad;

    Vector2 movimiento;


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movimiento = new Vector2(horizontal, vertical);
        movimiento = movimiento.normalized;

        transform.Translate(movimiento * Time.deltaTime * velocidad);
    }
}
