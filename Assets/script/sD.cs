using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sD : MonoBehaviour
{
    public Servidor servidor;
    public GameObject usuarioNombre;

    public TMP_InputField Usuario;
    public TMP_InputField contadorPlanos;
    public GameObject imLoading;
    public DBUsuario usuarioDatos;
    public colocarPlano _colocarPlano;

    public void registrarDatosUsuarios()
    {
        StartCoroutine(Iniciar());
    }

    IEnumerator Iniciar()
    {
        contadorPlanos.text = _colocarPlano.contadorPlanos.ToString();
        imLoading.SetActive(true);
        string[] datos = new string[2];
        datos[0] = Usuario.text;
        datos[1] = contadorPlanos.text;


        StartCoroutine(servidor.ConsumirServicio("registrarDatosUsuarios", datos, Intro));

        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => !servidor.ocupado);
        imLoading.SetActive(false);

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
