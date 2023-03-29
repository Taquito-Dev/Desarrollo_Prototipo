using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GuardarNIvel : MonoBehaviour
{
    public Servidor servidor;

    string usuarioNombre;
    string nivel;

    private void Awake()
    {
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        LoadData();
    }

    public void LoadData()
    {
        usuarioNombre = PlayerPrefs.GetString("prefsNombreJugador");
        nivel = PlayerPrefs.GetString("prefsNivel");
    }

    public void SaveNivel()
    {
        StartCoroutine(GuardarNivelP());
    }


    IEnumerator GuardarNivelP()
    {

        string[] datos = new string[2];
        datos[0] = usuarioNombre;
        datos[1] = nivel;

        print(datos[0]);
        print(datos[1]);

        StartCoroutine(servidor.ConsumirServicio("guardarNivel", datos, Intro));

        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => !servidor.ocupado);
        //imLoading.SetActive(false);
    }

    private void OnDestroy()
    {
        
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
                //usuarioDatos = JsonUtility.FromJson<DBUsuario>(servidor.respuesta.respuesta);
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
}
