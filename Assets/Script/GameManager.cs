using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("VIDA")]
    [SerializeField] List<GameObject> vidas = new List<GameObject>();



    //Vida
    public void CambiarCorazon(int indice)
    {
        GameObject imagenCorazon = vidas[indice];
        imagenCorazon.SetActive(false);
    }


    //Cambiar escena
    public void CambiarEscena(int escena)
    {
        SceneManager.LoadScene(escena);
    }

}
