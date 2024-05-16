using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] List<GameObject> vidas = new List<GameObject>();

    [SerializeField] TextMeshProUGUI texto;
    int puntos;



    public void CambiarCorazon(int indice)
    {
        GameObject imagenCorazon = vidas[indice];
        imagenCorazon.SetActive(false);
    }


    public void ActualizarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
        texto.text = puntos.ToString();
    }


    public void CambiarEscena(int escena)
    {
        SceneManager.LoadScene(escena);
    }


    // SI MATAMOS 10 ENEMIGOS APARECE EL JEFE
    // O PODEMOS HACER UN TIMER PARA QUE APAREZCA

    // IF (EL OBJETO"JEFE" ES NULO) GANAR LA PARTIDA
}
