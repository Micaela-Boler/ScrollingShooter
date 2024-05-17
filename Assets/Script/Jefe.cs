using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jefe : jugadorYEnemigos
{
    public AtaqueEnemigo ataqueEnemigo;


    void Update()
    {
        if (ataqueEnemigo.vida <= 0)
            SceneManager.LoadScene(1);
    }
}
