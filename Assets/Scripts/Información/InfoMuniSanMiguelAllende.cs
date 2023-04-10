using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoMuniSanMiguelAllende : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Metodo que se encarga de llamar despues de cierto tiempo 
        Invoke("WaitToEnd", 40);
    }

    // Update is called once per frame
    void Update()
    {
        //Preguntar si se preciona la tecla de escape y mandara a la escena principal
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Nivel2Reto2");
        }

    }

    //Creaci�n de metodo para despues de ciertos segundos pasemos al MainMenu
    public void WaitToEnd()
    {
        SceneManager.LoadScene("Nivel2Reto2");

    }
}
