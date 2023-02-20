using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class escenaBoton : MonoBehaviour
{
    public void otroLado(string donde)
    {
        SceneManager.LoadScene(donde);
    }

    public void Salir()
    {
        Debug.Log("Estas saliendo del juego, good bye");
        Application.Quit();
    }
}
