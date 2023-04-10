using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoMuniLeon : MonoBehaviour
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
            SceneManager.LoadScene("Nivel5Reto2");
        }

    }

    //Creación de metodo para despues de ciertos segundos pasemos al MainMenu
    public void WaitToEnd()
    {
        SceneManager.LoadScene("Nivel5Reto2");

    }
}
