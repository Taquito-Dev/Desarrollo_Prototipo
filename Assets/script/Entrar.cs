using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrar : MonoBehaviour
{

    public GameObject canvas;
    public GameObject Texto;
    private bool lugar;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && lugar == true)
        {
            canvas.SetActive(true);
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