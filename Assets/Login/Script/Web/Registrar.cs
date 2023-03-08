using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Registrar : MonoBehaviour
{
    public Servidor servidor;
    public TMP_InputField regUsuario;
    public TMP_InputField regContrasena;
    public TMP_InputField regContrasena2;
    public GameObject imLoading;
    public DBUsuario usuarioDatos;

    public void RegistrarUsuario()
    {
        StartCoroutine(Iniciar());
    }

    IEnumerator Iniciar()
    {
        imLoading.SetActive(true);
        string[] datos = new string[3];
        datos[0] = regUsuario.text;
        datos[1] = regContrasena.text;
        datos[2] = regContrasena2.text;

        if (datos[0] == "" || datos[1] == "" || datos[2] == "" || datos[1] != datos[2])
        {
            Intro();
            print("Campos vacios");
        }
        else
        {
            StartCoroutine(servidor.ConsumirServicio("registrarUsuario", datos, Intro));

            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => !servidor.ocupado);
            imLoading.SetActive(false);
            
        }

        
    }

    void Intro()
    {
        switch (servidor.respuesta.codigo)
        {
            case 204: // El Usuario y/o la contraseña son incorrectos
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
}
