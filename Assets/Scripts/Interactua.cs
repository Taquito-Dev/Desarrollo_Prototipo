using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactua : MonoBehaviour
{
    public int numeroEscena;
    public GameObject Texto;
    private bool lugar;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && lugar == true)
        {
            SceneManager.LoadScene(numeroEscena);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Texto.SetActive(true);
            lugar = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
         if(other.tag == "Player")
        {
            Texto.SetActive(false);
            lugar = false;
        }
    }
}
