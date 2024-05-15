using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float horizontal;
    public int velocidad;

    Vector2 movimiento;


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        movimiento = new Vector2(horizontal, 0);
        transform.Translate(movimiento * Time.deltaTime * velocidad);
    }
}
