using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public string selectedObjectName;

    //Utiliza el objeto seleccionado para enviar a las cinemáticas finales de MenteFactura
    public void GoToCineMentefactura()
    {
        string selectedObjectName = PlayerPrefs.GetString("SelectedObject");

        if (selectedObjectName == "Masculino")
        {
            Debug.Log("Ir a CineMentefacturaNiño");
            SceneManager.LoadScene("CineMentefacturaNiño");
        }
        else if(selectedObjectName == "Femenino")
        {
            Debug.Log("Ir a CineMentefacturaNiña");
            SceneManager.LoadScene("CineMentefacturaNiña");
        }
        else{
            Debug.Log("No funciona manito");
        }
    }
}
