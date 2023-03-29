using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ActualisarDatos : MonoBehaviour
{
    public Servidor servidor;
    //public GameObject imLoading;
    public PersonajeSelect _personajeSelect;
    public DBUsuario usuarioDatos;

    public string usuarioNombre;
    public TMP_Text genero;

    //public int respuesta = 1;

    public string prefsGenSelect = "Select";

    private void Awake()
    {
        LoadData();
    }
    public void Registrar()
    {
        StartCoroutine(RegistrarGen());
    }
    IEnumerator RegistrarGen()
    {

        string[] datos = new string[2];
        datos[0] = usuarioNombre;
        datos[1] = _personajeSelect.personaje;

        print(datos[0]);
        print(datos[1]);

        StartCoroutine(servidor.ConsumirServicio("actualizarDatos", datos, Intro));

        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => !servidor.ocupado);
        //imLoading.SetActive(false);
    }

    public void LoadData()
    {
        usuarioNombre = PlayerPrefs.GetString("prefsNombreJugador");
    }


    void Intro()
    {
        switch (servidor.respuesta.codigo)
        {
            case 204: // El Usuario y/o la contrase�a son incorrectos
                print(servidor.respuesta.mensaje);
                break;
            case 205: // Inicio de secion correcto
                      // SceneManager.LoadScene("Intro");
                usuarioDatos = JsonUtility.FromJson<DBUsuario>(servidor.respuesta.respuesta);
                break;
            case 402: // Faltan datos para realizar la accion solicitada
                print(servidor.respuesta.mensaje);
                break;
            case 404: // ERROR
                print("Error 404. Not Found");
                break;
            default:
                break;
        }
    }

    //public void SaveData()
    //{
    //    PlayerPrefs.SetInt("prefsGenSelect", respuesta);
    //}

    //private void OnDestroy()
    //{
        
    //}
}
