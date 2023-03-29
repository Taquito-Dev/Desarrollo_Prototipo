using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PersonajeSelect : MonoBehaviour
{
    public GameObject object1; // personaje 1
    public GameObject object2; // personaje 2
    public GameObject selectedObject; // personaje seleccionado
    public Button button1; // botón para seleccionar objeto 1
    public Button button2; // botón para seleccionar objeto 2
    public string personaje;
    public TMP_Text pj;
    public ActualisarDatos _ActualisarDatos;
    public Login _Login;

    void Start()
    {
        // desactivar ambos objetos al inicio
        object1.SetActive(true);
        object2.SetActive(true);

        // agregar un listener para el botón 1
        button1.onClick.AddListener(SelectObject1);

        // agregar un listener para el botón 2
        button2.onClick.AddListener(SelectObject2);
    }

    void SelectObject1()
    {
        personaje = "nino";
        object1.SetActive(true);
        object2.SetActive(false);
        selectedObject = object1;
        _ActualisarDatos.Registrar();
        Debug.Log("Objeto 1 Seleccionado");
        SaveSelectedObject();
        SceneManager.LoadScene("CineNiño");
    }

    void SelectObject2()
    {
        personaje = "nina";
        object1.SetActive(false);
        object2.SetActive(true);
        selectedObject = object2;
        _ActualisarDatos.Registrar();
        Debug.Log("Objeto 2 Seleccionado");
        SaveSelectedObject();
        SceneManager.LoadScene("CineNiña");
    }

    //Guardar objeto seleccionado para usarlo en otra escena
    public void SaveSelectedObject()
    {
        PlayerPrefs.SetString("SelectedObject", selectedObject.name);
        Debug.Log("Personaje"+selectedObject);
    }
}
