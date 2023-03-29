using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MC : MonoBehaviour
{
    string gen;
    int nivel;
    int newNivel;

    public GameObject iniciar;
    public GameObject continuar;
    GameObject selectedObject; // personaje seleccionado
    public GameObject object1;
    public GameObject object2;

    //public string NewNivelP = "NivelNuevo";

    private void Awake()
    {
        LoadData();
    }
    public void LoadData()
    {
        gen = PlayerPrefs.GetString("prefsGen");
        nivel = PlayerPrefs.GetInt("nivelPlayer");
    }

    //public void SaveData()
    //{
    //    PlayerPrefs.SetInt("nivelPlayer", newNivel);
    //}

    //Cargar el genero del personaje segun el genero desde la Base de Datos
    public void verificar()
    {
        if (gen == "nino" || gen == "nina")
        {
            if (gen == "nino")
            {
                selectedObject = object1;
                SaveSelectedObject();
            }
            else if (gen == "nina")
            {
                selectedObject = object2;
                SaveSelectedObject();
            }
            iniciar.gameObject.SetActive(false);
            continuar.gameObject.SetActive(true);
        }
        else
        {
            iniciar.gameObject.SetActive(true);
            continuar.gameObject.SetActive(false);
        }
    }

    //Cargar el nivel del jugador desde la base de datos

    public void CargarNivel()
    {
        switch (nivel)
        {
            case 1:
                //nivel = 1;
                //SaveData();
                SceneManager.LoadScene("GameScene");
                break;
            case 2:
                //nivel = 2;
                //SaveData();
                SceneManager.LoadScene("Nivel2");
                break;
            case 3:
                //nivel = 3;
                //SaveData();
                SceneManager.LoadScene("Nivel3");
                break;
            case 4:
                //nivel = 4;
                //SaveData();
                SceneManager.LoadScene("Nivel4");
                break;
            case 5:
                //nivel = 5;
                //SaveData();
                SceneManager.LoadScene("Nivel5");
                break;
        }
        
    }

    //public void verificarNivel()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        verificar();
    }

    public void SaveSelectedObject()
    {
        PlayerPrefs.SetString("SelectedObject", selectedObject.name);
        Debug.Log("Personaje" + selectedObject);
    }
}
