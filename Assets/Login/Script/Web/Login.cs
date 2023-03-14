using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public Servidor servidor; 
    public TMP_InputField usuario;
    public TMP_InputField contrasena;
    public GameObject imLoading;
    public DBUsuario usuarioDatos;

    //public TextMeshProUGUI usuarioNombre;

    public void IniciarSesion()
    {
        StartCoroutine(Iniciar());
        
    }

    IEnumerator Iniciar()
    {
        imLoading.SetActive(true);
        string[] datos = new string[2];
        datos[0] = usuario.text;
        datos[1] = contrasena.text;
        StartCoroutine(servidor.ConsumirServicio("login", datos, Intro));

        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => !servidor.ocupado);
        imLoading.SetActive(false);
    }

    void Intro()
    {
        switch (servidor.respuesta.codigo)
        {
            case 204: // El Usuario y/o la contrasena son incorrectos
                print(servidor.respuesta.mensaje);
                break;
            case 205: // Inicio de secion correcto
                      //
                      SceneManager.LoadScene("Main_Menu");
                usuarioDatos = JsonUtility.FromJson<DBUsuario>(servidor.respuesta.respuesta);
                //usuarioNombre.text = usuarioDatos.usuario;
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
