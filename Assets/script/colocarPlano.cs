using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class colocarPlano : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject PR;
    public Transform pos;
    public GameObject plataforma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Plano":
                PR = GameObject.FindGameObjectWithTag("Plano");
                ActivarCanvas();
                other.transform.position = new Vector3(0.8f, 1.315f, -8.42f);
                PR.GetComponent<Renderer>().enabled = false;
                other.tag = other.tag = "Plano2";
                break;

            case "Plano2":
                PR = GameObject.FindGameObjectWithTag("Plano2");
                PR.GetComponent<Renderer>().enabled = true;
                other.tag = other.tag = "Plano3";
                plataforma.gameObject.SetActive(false);
                print("Hola");
                break;
        }
       
    }
    public void ActivarCanvas()
    {
        Canvas.gameObject.SetActive(true);
    }
    public void DesactivarCanvas()
    {
        Canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
