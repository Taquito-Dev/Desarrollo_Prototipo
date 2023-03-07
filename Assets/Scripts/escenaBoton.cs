using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class escenaBoton : MonoBehaviour
{   
    saveSystem save;
    int nr=0;

    public void Awake(){
        save=FindObjectOfType<saveSystem>();
    }
    void Start(){
        save.lnv();
    }
    public void setNivel(int NivelReto){
        nr=NivelReto;
        Debug.Log(nr);
    }

    public void otroLado(string donde)
    {
        if(nr==4){
           SceneManager.LoadScene(donde); 
        }
        else{
            SceneManager.LoadScene("seleccion"); 
        }
        
    }

    public void Salir()
    {
        Debug.Log("Estas saliendo del juego, good bye");
        Application.Quit();
    }
}
